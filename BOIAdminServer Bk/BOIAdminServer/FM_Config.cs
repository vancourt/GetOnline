using GetOnline.Functions;
using DevComponents.DotNetBar.Metro;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GetOnline
{
    public partial class FM_Config : MetroForm
    {
        public FM_Config()
        {
            InitializeComponent();
        }
        private void FM_Config_Load(object sender, EventArgs e)
        {
            try
            {
                Config.Load();
                LoadValues();
                cb_MySQL.Checked = Config.UseMySQL;
                Log.WriteInfo("Config loaded!");
                MySQL.Start();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Initialization", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void bt_Connect_Click(object sender, EventArgs e)
        {
            try
            {

                Config.Save(txt_DatabaseMySQL.Text, "Database", "MySQL");
                Config.Save(txt_IpMySQL.Text, "IP", "MySQL");
                Config.Save(txt_PassMySQL.Text, "Password", "MySQL");
                Config.Save(txt_PortMySQL.Text, "Port", "MySQL");
                Config.Save(txt_UserMySQL.Text, "User", "MySQL");
                Config.Save(txt_TableMySQL.Text, "Table", "MySQL");

                Config.Save(txt_MsLogDir.Text, "ManageLogPath", null);
                Config.Load();
                Log.WriteWarning("Trying to connect on MySQL Host:" + Config.MyIP);
                MySQL.Start();
                MySQL.TryConnect();
                Log.WriteInfo("Connection Estabilished");
                MessageBox.Show("Connection Estabilished", "MySQL Connector", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                
            }
            catch (Exception ex)
            {
                Log.WriteError(ex.Message);
                MessageBox.Show(ex.Message, "MySQL Connector", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void textBoxX1_ButtonCustomClick(object sender, EventArgs e)
        {
            if (txt_IpMySQL.Text == string.Empty) MySQL.Start();
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                txt_MsLogDir.Text = dialog.FileName;
            }

        }
        private void LoadValues()
        {
            txt_DatabaseMySQL.Text = Config.MyDatabase;
            txt_IpMySQL.Text = Config.MyIP;
            txt_PassMySQL.Text = Config.MyPassword;
            txt_UserMySQL.Text = Config.MyUser;
            txt_PortMySQL.Text = Config.MyPort;
            txt_TableMySQL.Text = Config.MyTable;
            txt_MsLogDir.Text = Config.ManagePathLog;
        }

       
    }
}
