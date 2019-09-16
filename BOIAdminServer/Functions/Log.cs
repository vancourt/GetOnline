using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetOnline.Functions
{
    class Log
    {
        private static DevComponents.DotNetBar.LabelX lbLog;
        private static Boolean SaveLog;
        private static DevComponents.DotNetBar.Controls.DataGridViewX grid_online;
        private static System.Windows.Forms.WebBrowser webLongLob;
        private static StringBuilder HtmlMainContent = new StringBuilder();
        private static StringBuilder javascript = new StringBuilder();
        private static StringBuilder style = new StringBuilder();
        public static void Start(DevComponents.DotNetBar.LabelX lbLog, System.Windows.Forms.WebBrowser txtBox, DevComponents.DotNetBar.Controls.DataGridViewX grid, bool SaveLog)
        {
            Log.lbLog = lbLog;
            Log.SaveLog = SaveLog;
            Log.webLongLob = txtBox;
            Log.grid_online = grid;
            Log.HtmlMainContent.AppendLine("<!DOCTYPE html>");
            Log.HtmlMainContent.AppendLine("<html xmlns=\"http://www.w3.org/1999/xhtml\" lang=\"en-us\">");
            Log.HtmlMainContent.AppendLine("<head>");
            Log.HtmlMainContent.AppendLine("<style>");
            Log.HtmlMainContent.AppendLine("{0}");//style
            Log.HtmlMainContent.AppendLine("</style>");
            Log.HtmlMainContent.AppendLine("</head>");
            Log.HtmlMainContent.AppendLine(string.Format("\t<body style='{0}'>", "background-color:#211d1d;font-size:15px;padding:0px; margin:0px;"));
            //Log.HtmlMainContent.AppendLine("\t<div id='content'>");
            Log.HtmlMainContent.AppendLine("\t<ul id='list' style='list-style:none;  width: 100%; height:100%;padding:0px; margin:0px;overflow: hidden;'>");
            Log.HtmlMainContent.AppendLine("\t</ul>");
            //Log.HtmlMainContent.AppendLine("\t</div>");
            Log.HtmlMainContent.AppendLine("{1}"); //jagascript 
            Log.HtmlMainContent.AppendLine("\t</body>");
            Log.HtmlMainContent.AppendLine("</html>");

            Log.javascript.AppendLine("\t<script>");
            Log.javascript.AppendLine("\tfunction newline(text,style){");
            Log.javascript.AppendLine("\t\t\tvar ul = document.getElementById('list');");
            Log.javascript.AppendLine("\t\t\tvar li = document.createElement('li');");
            Log.javascript.AppendLine("\t\t\tli.className = style;");
            Log.javascript.AppendLine("\t\t\tli.innerHTML = text;");
            Log.javascript.AppendLine("\t\t\tul.appendChild(li);");
            Log.javascript.AppendLine("\t\t\twindow.scrollTo(0,document.body.scrollHeight);");
            Log.javascript.AppendLine("\t}");
            Log.javascript.AppendLine("\t</script>");

            Log.style.AppendLine("li.info {color: #9aff00;}");
            Log.style.AppendLine("li.warning {color: #ffff00;}");
            Log.style.AppendLine("li.error {color: #ff0000;}");

            StringBuilder logbox2 = new StringBuilder(webLongLob.DocumentText);
            logbox2.AppendFormat(HtmlMainContent.ToString(), style.ToString(), javascript.ToString());
            webLongLob.DocumentText = logbox2.ToString();
            //webLongLob.Dock = System.Windows.Forms.DockStyle.Right;
            //Log.txtLog = txtBox;
        }

        public static void updateGrid(DataTable result)
        {

            try
            {
                if (result.Rows.Count <=0)
                    Log.grid_online.DataSource = null;
                else if (result != Log.grid_online.DataSource)
                {

                    Log.grid_online.DataSource = result;
                }
            }
            catch (Exception e) { Log.WriteError(e.Message); }
        }

        public static void Clear()
        {
            webLongLob.Refresh();
            StringBuilder logbox2 = new StringBuilder(webLongLob.DocumentText);
            logbox2.AppendFormat(HtmlMainContent.ToString(), style.ToString(), javascript.ToString());
            webLongLob.DocumentText = logbox2.ToString();
        }

        public static void WriteError(String Text)
        {
            try
            {
                Log.lbLog.ForeColor = Color.Red;
                Log.lbLog.Text = Text;
                Log.lbLog.Image = global::GetOnline.Properties.Resources.Error;
                Log._WriteHtml(Text, "error");
                if (SaveLog) _WriteLog(Text, 3);
            }
            catch { }


        }

        public static void WriteWarning(String Text)
        {
            try
            {
                Log.lbLog.ForeColor = Color.Red;
                Log.lbLog.Text = Text;
                Log.lbLog.Image = global::GetOnline.Properties.Resources.Warning;
                Log._WriteHtml(Text, "warning");
                if (SaveLog) _WriteLog(Text, 2);
            }
            catch { }

        }

        public static void WriteInfo(String Text)
        {
            try
            {
                Log.lbLog.ForeColor = Color.DarkGreen;
                Log.lbLog.Text = Text;
                Log.lbLog.Image = global::GetOnline.Properties.Resources.Exclamation;
                Log._WriteHtml(Text, "info");
                if (SaveLog) _WriteLog(Text, 1);
            }
            catch { }


        }

        internal static void _WriteHtml(String Text, String Class)
        {
            try
            {
                if (webLongLob.Document != null)
                {
                    Object[] objArray = new Object[2];
                    objArray[0] = (Object)"<font color=white>[" + DateTime.Now.ToShortTimeString() + "]</font> " + Text;
                    objArray[1] = (Object)Class;
                    webLongLob.Document.InvokeScript("newline", objArray);
                }
            }
            catch
            {

            }




        }

        private static void _WriteLog(String Log, int Section)
        {
            switch (Section)
            {
                case 1:
                    __Writing(Log, "Info.log");
                    break;
                case 2:
                    __Writing(Log, "Warning.log");
                    break;
                case 3:
                    __Writing(Log, "Error.log");
                    break;
                default:
                    break;
            }
        }
        private static void __Writing(String Log, String Output)
        {
            String log = String.Format("[{0}]{1}" + Environment.NewLine, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), Log);
            String LogDir = "Logs\\" + DateTime.Now.ToString("dd-MM-yyy");
            String LogFileDir = LogDir + "\\" + Output;
            try
            {
                Directory.CreateDirectory(LogDir);

                if (!File.Exists(LogFileDir))
                    File.WriteAllText(LogFileDir, log);
                else
                    File.AppendAllText(LogFileDir, log);
            }
            catch { }
        }
    }
}
