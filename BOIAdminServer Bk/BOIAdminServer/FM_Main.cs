using GetOnline.Functions;
using DevComponents.DotNetBar.Metro;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace GetOnline
{
    public partial class FM_Main : MetroForm
    {
        public delegate void CallBackLog(String txt, Byte Type);
        public delegate void CallBackEditListBox();

        System.Timers.Timer tm_updateInfo;

        public DataTable onlineList
        {
            set
            {
                grid_OnlineList.DataSource = value;
            }
        }

        Functions.GetOnline main;
        public FM_Main()
        {
            InitializeComponent();
        }

        private void FM_Main_Load(object sender, EventArgs e)
        {
            try
            {
                Log.Start(lb_Log, web_longLog, grid_OnlineList, radial_Onlinecount, true);
                Config.Load();
                //LoadValues();
                //cb_MySQL.Checked = Config.UseMySQL;
                Log.WriteInfo("Config loaded!");
                MySQL.Start();
                main = new Functions.GetOnline();
                main.Start(this);
                this.tm_updateInfo = new System.Timers.Timer(Config.Timer);
                this.tm_updateInfo.Elapsed += _updateInfo;
                this.tm_updateInfo.Start();

            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Initialization", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void _updateInfo(object sender, System.Timers.ElapsedEventArgs e)
        {
            lb_Realm1.Text = "Realm 1:"+MySQL._Query(string.Format("select count(*) from `{0}`.`{1}` where `Online` = 1 and `Realm` = {2} ", Config.MyDatabase, Config.MyTable, 1), null);
            lb_Realm2.Text = "Realm 2:" + MySQL._Query(string.Format("select count(*) from `{0}`.`{1}` where `Online` = 1 and `Realm` = {2} ", Config.MyDatabase, Config.MyTable, 2), null);
            lb_Realm3.Text = "Realm 3:" + MySQL._Query(string.Format("select count(*) from `{0}`.`{1}` where `Online` = 1 and `Realm` = {2} ", Config.MyDatabase, Config.MyTable, 3), null);
            lb_Realm4.Text = "Realm 4:" + MySQL._Query(string.Format("select count(*) from `{0}`.`{1}` where `Online` = 1 and `Realm` = {2} ", Config.MyDatabase, Config.MyTable, 4), null);
            lb_Realm5.Text = "Realm 5:" + MySQL._Query(string.Format("select count(*) from `{0}`.`{1}` where `Online` = 1 and `Realm` = {2} ", Config.MyDatabase, Config.MyTable, 5), null);
            lb_Realm6.Text = "Realm 6:" + MySQL._Query(string.Format("select count(*) from `{0}`.`{1}` where `Online` = 1 and `Realm` = {2} ", Config.MyDatabase, Config.MyTable, 6), null);
            lb_Realm7.Text = "Realm 7:" + MySQL._Query(string.Format("select count(*) from `{0}`.`{1}` where `Online` = 1 and `Realm` = {2} ", Config.MyDatabase, Config.MyTable, 7), null);
            lb_Realm8.Text = "Realm 8:" + MySQL._Query(string.Format("select count(*) from `{0}`.`{1}` where `Online` = 1 and `Realm` = {2} ", Config.MyDatabase, Config.MyTable, 8), null);
            lb_TotalOn.Text = "Total On:" + MySQL._Query(string.Format("select count(*) from `{0}`.`{1}` where `Online` = 1 ", Config.MyDatabase, Config.MyTable), null);
        }

        private void checkBoxX1_CheckedChanged(object sender, EventArgs e)
        {
            //gp_MySQLCfg.Visible = cb_MySQL.Checked;
        }



        private void switchButton1_ValueChanged(object sender, EventArgs e)
        {
            this.web_longLog.Visible = switchButton1.Value;
            this.lb_Log.Visible = !switchButton1.Value;
            if (switchButton1.Value)
            {
                Size sz = this.Size;

                sz.Width += 309;
                this.Size = sz;
                this.MinimumSize = new Size(921, 308);
                this.MaximumSize = new Size(1300, 1024);
                //this.gp_config.Location = new Point(328, 14);
                this.web_longLog.Size = new Size(315, this.Size.Height - 80);
                this.web_longLog.Location = new Point(588, 14);
                this.web_longLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top
                | System.Windows.Forms.AnchorStyles.Bottom)
                | System.Windows.Forms.AnchorStyles.Left)
                | System.Windows.Forms.AnchorStyles.Right)));


            }
            else
            {
                Size sz;
                sz = this.MaximumSize;
                sz.Height = 308;
                this.MinimumSize = new Size(598, 308);
                this.MaximumSize = new Size(598, 1024);
                sz = this.Size;
                sz.Width -= 309;
                this.Size = sz;
                //this.gp_config.Location = new Point(328, 14);
                //this.web_longLog.Anchor = gp_config.Anchor;
            }
        }

        private void pic_donate_Click(object sender, EventArgs e)
        {
            Process.Start("https://goo.gl/lxBzmv");
        }


        private void radialMenu1_ItemClick_1(object sender, EventArgs e)
        {
            try
            {
                var menu = ((DevComponents.DotNetBar.RadialMenuItem)sender);
                if (menu == this.radial_Config)
                {
                    FM_Config cfg = new FM_Config();
                    menu.AutoCollapseOnClick = false;
                    cfg.ShowDialog(this);
                    //menu.AutoCollapseOnClick = true;
                    return;
                }
                else if (menu == this.radial_StartNow)
                {

                    if (!this.radial_StartNow.Checked)
                    {
                        this.radial_StartNow.Image = global::GetOnline.Properties.Resources.Stop;
                        this.radial_StartNow.Checked = true;
                        this.radial_StartNow.Text = "Stop Now";
                        Config.Trigger = true;
                    }
                    else
                    {
                        this.radial_StartNow.Image = global::GetOnline.Properties.Resources.Start;
                        this.radial_StartNow.Checked = false;
                        this.radial_StartNow.Text = "Start Now";
                        Config.Trigger = false;
                    }

                }
                else if (menu == this.radial_donate)
                {
                    Process.Start("https://goo.gl/lxBzmv");
                }
                else if (menu == radial_functions_ClearTable)
                {
                    grid_OnlineList.DataSource = null;
                    MySQL._Query(string.Format("TRUNCATE `{0}`.`{1}`;", Config.MyDatabase, Config.MyTable));
                    Log.WriteInfo(string.Format("Table {0} Cleaned!!", Config.MyTable));
                }
                else if (menu == radial_functions_FixDB)
                {
                    MySQL._fixDB();
                    Log.WriteInfo(string.Format("Table {0}.{1} Recreated", Config.MyDatabase, Config.MyTable));
                }
            }
            catch
            {

            }

        }

        private void reflectionLabel1_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("skype:ADM_Necros?chat");
            }
            catch { MessageBox.Show("feel free to contact me via skype or email\nSkype:ADM_Necros\nemail:necrostudo@gmail.com"); }
            
        }

        private void btn_ReloadOnline_Click(object sender, EventArgs e)
        {
            DataTable result = MySQL._Query(string.Format("select `UserID` as `ID`, `CharName` as `Character`, `Realm`, `IP` as `LastIP` from `{0}`.`{1}` where `Online` = 1", Config.MyDatabase, Config.MyTable));

            Log.updateGrid(result);

            grid_OnlineList.ColumnHeadersHeight = 4;
        }
    }
}
