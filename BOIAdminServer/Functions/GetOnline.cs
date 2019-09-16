using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using static GetOnline.FM_Main;

namespace GetOnline.Functions
{
    class GetOnline
    {
        internal Timer TimerCheck;
        internal long FileSize;
        internal int FileLines;
        Boolean FirstRun;
        FM_Main mainform;
        public void Start(FM_Main form)
        {
            this.mainform = form;
            string[] read = _readfile();
            this.FileSize = new FileInfo(Config.ManagePathLog).Length;
            this.FileLines = read.Length;

            this.TimerCheck = new Timer(Config.Timer);
            this.TimerCheck.Elapsed += _Checker;
            this.TimerCheck.Start();
            //Log.WriteInfo("TimerStarted");

        }

        private void _Checker(object sender, ElapsedEventArgs e)
        {

            if (!Config.Trigger) return;

            long size = new FileInfo(Config.ManagePathLog).Length;

            if (this.FileSize == size && FirstRun) return;


            string[] read = _readfile();
            //string[] read = File.ReadAllLines(Config.ManagePathLog);
            if (!FirstRun)
            {
                FirstRun = true;
                System.Threading.Thread loading = new System.Threading.Thread(() => InitLoad( read));
                
                loading.Start();
                
            }
            string[] read2 = read.Reverse().Where(a => a.Length > 0).Take(read.Length - this.FileLines).ToArray();

            foreach (string log in read2)
                this._AnalizeLog(log);

            //LogText(string.Format("Total:{0}, read:{1}, lines:{2}, read:{3}", (read.Length - this.FileLines), read.Length, this.FileLines, read2.Length), 1);

            this.FileLines = read.Length;
            this.FileSize = size;
        }

        private void InitLoad(string[] read)
        {
            foreach (string log in read)
            {
                System.Threading.Thread.Sleep(25);
                this._AnalizeLog(log,false);
            }
            updateList();


        }

        private string[] _readfile()
        {
            //FileStream open;

            using (FileStream open = File.Open(Config.ManagePathLog, FileMode.Open, FileAccess.Read, FileShare.Write))
            {
                StreamReader reader;
                reader = new StreamReader(open);

                return reader.ReadToEnd().Split('\n');

            }



        }

        private void _AnalizeLog(String Line,bool UpdateGrid = true)
        {
            //LogText(Line, 1);
            if (Line.Contains("New Account["))
            {
                string AccountID = Line.Substring(Line.IndexOf("[")).Split('[')[1].Split(']')[0];
                string AccountName = MySQL._Query(string.Format("Select `name` from `shengui`.`users` where `ID` = '{0}'", AccountID), string.Empty);
                this.LogText(string.Format("Account {0} [{1}] at Selection of Characters", AccountName, AccountID), 2);
                return;

            }
            if (Line.Contains("Account[") && Line.Contains("Char[") && Line.Contains("Line["))
            {
                string AccountID = Line.Substring(Line.IndexOf("Account[")).Split('[')[1].Split(']')[0];
                string RoleID = Line.Substring(Line.IndexOf("Char[")).Split('[')[1].Split(']')[0];
                string Realm = Line.Substring(Line.IndexOf("Line[")).Split('[')[1].Split(']')[0];

                string IP = MySQL._Query(string.Format("(select CAST((Concat(SUBSTRING_INDEX(SUBSTRING_INDEX(INET_NTOA(lastip), '.', 4), '.', -1),'.',SUBSTRING_INDEX(SUBSTRING_INDEX(INET_NTOA(lastip), '.', 3), '.', -1),'.',SUBSTRING_INDEX(SUBSTRING_INDEX(INET_NTOA(lastip), '.', 2), '.', -1),'.',SUBSTRING_INDEX(SUBSTRING_INDEX(INET_NTOA(lastip), '.', 1), '.', -1))) AS CHAR(10000) CHARACTER SET utf8) from shengui.basetab_sg where `AccountID` = '{0}' and `RoleID` = '{1}' limit 1)", AccountID, RoleID), string.Empty);
                string AccountName = MySQL._Query(string.Format("Select `name` from `shengui`.`users` where `ID` = '{0}'", AccountID), string.Empty);
                string RoleName = MySQL._Query(string.Format("Select `name` from `shengui`.`basetab_sg` where `AccountID` = '{0}' and `RoleID` = '{1}'", AccountID, RoleID), string.Empty);
                LogText(string.Format("Role: {0} [{1}], Account: {2} [{3}], Realm: {4}, IP: {5}", RoleName, RoleID, AccountName, AccountID, Realm, IP == "0.0.0.0" ? "First Login" : IP), 1);

                if (MySQL._Query(string.Format("select count(*) from `{0}`.`{1}` where UserID = '{2}' and CharName = '{3}'", Config.MyDatabase, Config.MyTable, AccountID, RoleName), 0) > 0)
                    MySQL._Query(string.Format("update {0}.{1} set `Online` = 1, Realm = '{2}', IP = '{3}' where UserID = '{4}' and CharName = '{5}'", Config.MyDatabase, Config.MyTable, Realm, IP, AccountID, RoleName));
                else
                    MySQL._Query(string.Format("insert into {0}.{1} (`UserID`, `CharName`, `Realm`, `IP`, `Online`) Values ('{2}', '{3}', '{4}', '{5}', '1')", Config.MyDatabase, Config.MyTable, AccountID, RoleName, Realm, IP));
                if (UpdateGrid) updateList();
                return;
            }
            if (Line.Contains("MSG_DMM_NOTIFY_SAVE_ROLE"))
            {
                string AccountID = Line.Substring(Line.IndexOf("MSG_DMM_NOTIFY_SAVE_ROLE ")).Split()[1];
                string AccountName = MySQL._Query(string.Format("Select `name` from `shengui`.`users` where `ID` = '{0}'", AccountID), string.Empty);
                LogText(string.Format("Account: {0} [{1}] Logged out", AccountName, AccountID), 3);

                MySQL._Query(string.Format("update {0}.{1} set `Online` = 0 where UserID = '{2}' ", Config.MyDatabase, Config.MyTable, AccountID));
                if (UpdateGrid) updateList();
                return;
            }
            if (Line.Contains("Save Completed"))
            {
                string AccountID = Line.Substring(Line.IndexOf("Account[")).Split('[')[1].Split(']')[0];
                string RoleID = Line.Substring(Line.IndexOf("Char[")).Split('[')[1].Split(']')[0];

                string AccountName = MySQL._Query(string.Format("Select `name` from `shengui`.`users` where `ID` = '{0}'", AccountID), string.Empty);
                string RoleName = MySQL._Query(string.Format("Select `name` from `shengui`.`basetab_sg` where `AccountID` = '{0}' and `RoleID` = '{1}'", AccountID, RoleID), string.Empty);

                LogText(string.Format("Account: {0} [{1}] - Role:{2}[{3}] Logged out", AccountName, AccountID, RoleName, RoleID), 3);

                MySQL._Query(string.Format("update {0}.{1} set `Online` = 0 where UserID = '{2}' ", Config.MyDatabase, Config.MyTable, AccountID));
                if (UpdateGrid) updateList();
                return;
            }
            if (Line.Contains("Account[") && Line.Contains("Char[") && Line.Contains("Logout"))
            {
                string AccountID = Line.Substring(Line.IndexOf("Account[")).Split('[')[1].Split(']')[0];
                string RoleID = Line.Substring(Line.IndexOf("Char[")).Split('[')[1].Split(']')[0];

                string AccountName = MySQL._Query(string.Format("Select `name` from `shengui`.`users` where `ID` = '{0}'", AccountID), string.Empty);
                string RoleName = MySQL._Query(string.Format("Select `name` from `shengui`.`basetab_sg` where `AccountID` = '{0}' and `RoleID` = '{1}'", AccountID, RoleID), string.Empty);

                MySQL._Query(string.Format("update {0}.{1} set `Online` = 0 where UserID = '{2}' ", Config.MyDatabase, Config.MyTable, AccountID));
                if (UpdateGrid) updateList();
                return;
            }
            if (Line.Contains("KickAccout id: "))
            {
                string AccountID = Line.Substring(Line.IndexOf("KickAccout id: ")).Split(' ')[2];

                string AccountName = MySQL._Query(string.Format("Select `name` from `shengui`.`users` where `ID` = '{0}'", AccountID), string.Empty);
                LogText(string.Format("Account: {0} [{1}] Kicked from the server", AccountName, AccountID), 3);

                MySQL._Query(string.Format("update `{0}`.`{1}` set Online = 0 where UserID = '{2}' ", Config.MyDatabase, Config.MyTable, AccountID));
                if(UpdateGrid) updateList();
                return;
            }
            
        }

        private void updateList()
        {
            return;
            DataTable result = MySQL._Query(string.Format("select `UserID` as `ID`, `CharName` as `Character`, `Realm`, `IP` as `LastIP` from `{0}`.`{1}` where `Online` = 1", Config.MyDatabase, Config.MyTable));
            CallBackEditListBox callback = new CallBackEditListBox(updateList);
            if (this.mainform.InvokeRequired)
            {
                this.mainform.Invoke(callback);

            }
            Log.updateGrid(result);
        }

        /// <summary>
        /// 1 = Info<para/>
        /// 2 = Warning<para/>
        /// 3 = Error<para/>
        /// </summary>
        /// <param name="Text"></param>
        /// <param name="Type"></param>
        private void LogText(string Text, Byte Type)
        {
            CallBackLog callback = new CallBackLog(LogText);
            switch (Type)
            {
                case 1:
                    if (this.mainform.InvokeRequired)
                    {
                        this.mainform.Invoke(callback, new object[] { Text, Type });
                    }
                    Log.WriteInfo(Text);
                    break;
                case 2:
                    if (this.mainform.InvokeRequired)
                    {
                        this.mainform.Invoke(callback, new object[] { Text, Type });
                    }
                    Log.WriteWarning(Text);
                    break;
                case 3:
                    if (this.mainform.InvokeRequired)
                    {
                        this.mainform.Invoke(callback, new object[] { Text, Type });
                    }
                    Log.WriteError(Text);
                    break;
                default:
                    break;
            }

        }

    }
}
