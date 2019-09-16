namespace GetOnline
{
    partial class FM_Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FM_Main));
            this.switchButton1 = new DevComponents.DotNetBar.Controls.SwitchButton();
            this.web_longLog = new System.Windows.Forms.WebBrowser();
            this.grid_OnlineList = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.radialMenu1 = new DevComponents.DotNetBar.RadialMenu();
            this.radial_StartNow = new DevComponents.DotNetBar.RadialMenuItem();
            this.radial_Config = new DevComponents.DotNetBar.RadialMenuItem();
            this.radial_functions = new DevComponents.DotNetBar.RadialMenuItem();
            this.radial_functions_ClearTable = new DevComponents.DotNetBar.RadialMenuItem();
            this.radial_functions_FixDB = new DevComponents.DotNetBar.RadialMenuItem();
            this.radial_donate = new DevComponents.DotNetBar.RadialMenuItem();
            this.pic_donate = new System.Windows.Forms.PictureBox();
            this.lb_Log = new DevComponents.DotNetBar.LabelX();
            this.reflectionLabel1 = new DevComponents.DotNetBar.Controls.ReflectionLabel();
            this.btn_ReloadOnline = new DevComponents.DotNetBar.ButtonX();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.lb_TotalOn = new DevComponents.DotNetBar.LabelX();
            this.lb_Realm8 = new DevComponents.DotNetBar.LabelX();
            this.lb_Realm4 = new DevComponents.DotNetBar.LabelX();
            this.lb_Realm7 = new DevComponents.DotNetBar.LabelX();
            this.lb_Realm3 = new DevComponents.DotNetBar.LabelX();
            this.lb_Realm6 = new DevComponents.DotNetBar.LabelX();
            this.lb_Realm2 = new DevComponents.DotNetBar.LabelX();
            this.lb_Realm5 = new DevComponents.DotNetBar.LabelX();
            this.lb_Realm1 = new DevComponents.DotNetBar.LabelX();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.buttonX2 = new DevComponents.DotNetBar.ButtonX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.groupPanel2 = new DevComponents.DotNetBar.Controls.GroupPanel();
            ((System.ComponentModel.ISupportInitialize)(this.grid_OnlineList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_donate)).BeginInit();
            this.groupPanel1.SuspendLayout();
            this.groupPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // switchButton1
            // 
            this.switchButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.switchButton1.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.switchButton1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.switchButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.switchButton1.ForeColor = System.Drawing.Color.Black;
            this.switchButton1.Location = new System.Drawing.Point(496, 394);
            this.switchButton1.Name = "switchButton1";
            this.switchButton1.OffText = "Expand";
            this.switchButton1.OnText = "Collapse";
            this.switchButton1.Size = new System.Drawing.Size(86, 21);
            this.switchButton1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.switchButton1.TabIndex = 2;
            this.switchButton1.ValueChanged += new System.EventHandler(this.switchButton1_ValueChanged);
            // 
            // web_longLog
            // 
            this.web_longLog.AllowNavigation = false;
            this.web_longLog.AllowWebBrowserDrop = false;
            this.web_longLog.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.web_longLog.Location = new System.Drawing.Point(582, 14);
            this.web_longLog.MinimumSize = new System.Drawing.Size(20, 20);
            this.web_longLog.Name = "web_longLog";
            this.web_longLog.Size = new System.Drawing.Size(20, 376);
            this.web_longLog.TabIndex = 4;
            this.web_longLog.TabStop = false;
            this.web_longLog.Visible = false;
            this.web_longLog.WebBrowserShortcutsEnabled = false;
            // 
            // grid_OnlineList
            // 
            this.grid_OnlineList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.grid_OnlineList.BackgroundColor = System.Drawing.Color.White;
            this.grid_OnlineList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_OnlineList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grid_OnlineList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_OnlineList.DefaultCellStyle = dataGridViewCellStyle2;
            this.grid_OnlineList.EnableHeadersVisualStyles = false;
            this.grid_OnlineList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.grid_OnlineList.Location = new System.Drawing.Point(137, 12);
            this.grid_OnlineList.Name = "grid_OnlineList";
            this.grid_OnlineList.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_OnlineList.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grid_OnlineList.Size = new System.Drawing.Size(445, 246);
            this.grid_OnlineList.TabIndex = 5;
            // 
            // radialMenu1
            // 
            this.radialMenu1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.radialMenu1.BackButtonSymbol = "";
            this.radialMenu1.BackColor = System.Drawing.Color.Transparent;
            this.radialMenu1.Diameter = 200;
            this.radialMenu1.ForeColor = System.Drawing.Color.Black;
            this.radialMenu1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.radial_StartNow,
            this.radial_Config,
            this.radial_functions,
            this.radial_donate});
            this.radialMenu1.Location = new System.Drawing.Point(542, 360);
            this.radialMenu1.Name = "radialMenu1";
            this.radialMenu1.Size = new System.Drawing.Size(28, 28);
            this.radialMenu1.Symbol = "59627";
            this.radialMenu1.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.radialMenu1.SymbolSize = 15F;
            this.radialMenu1.TabIndex = 8;
            this.radialMenu1.ItemClick += new System.EventHandler(this.radialMenu1_ItemClick_1);
            // 
            // radial_StartNow
            // 
            this.radial_StartNow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radial_StartNow.Description = "Start Tool";
            this.radial_StartNow.Image = global::GetOnline.Properties.Resources.Start;
            this.radial_StartNow.Name = "radial_StartNow";
            this.radial_StartNow.Tag = "Start_Stop";
            this.radial_StartNow.Text = "Start Now";
            this.radial_StartNow.Tooltip = "Start the tool, make sure to have configured before using";
            // 
            // radial_Config
            // 
            this.radial_Config.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radial_Config.Image = global::GetOnline.Properties.Resources.data_configuration;
            this.radial_Config.Name = "radial_Config";
            this.radial_Config.Tag = "Show_Cfg";
            this.radial_Config.Text = "Config";
            this.radial_Config.Tooltip = "Configure MySQL Connection & ManageLog Path";
            // 
            // radial_functions
            // 
            this.radial_functions.AutoCollapseOnClick = false;
            this.radial_functions.Image = global::GetOnline.Properties.Resources.Tools;
            this.radial_functions.Name = "radial_functions";
            this.radial_functions.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.radial_functions_ClearTable,
            this.radial_functions_FixDB});
            this.radial_functions.Text = "Functions";
            this.radial_functions.Tooltip = "clear table,fix table etc...";
            // 
            // radial_functions_ClearTable
            // 
            this.radial_functions_ClearTable.Image = global::GetOnline.Properties.Resources.clear;
            this.radial_functions_ClearTable.Name = "radial_functions_ClearTable";
            this.radial_functions_ClearTable.Text = "Clear OnlineTable";
            this.radial_functions_ClearTable.Tooltip = "will delete all content from Table";
            // 
            // radial_functions_FixDB
            // 
            this.radial_functions_FixDB.Image = global::GetOnline.Properties.Resources.fixdb_fw;
            this.radial_functions_FixDB.Name = "radial_functions_FixDB";
            this.radial_functions_FixDB.Text = "Fix Table";
            this.radial_functions_FixDB.Tooltip = "Will Delete and Recreate Online_memb table";
            // 
            // radial_donate
            // 
            this.radial_donate.Image = global::GetOnline.Properties.Resources.donate;
            this.radial_donate.Name = "radial_donate";
            this.radial_donate.Tooltip = "this tool is useful? want to help me with a symbolic value?";
            // 
            // pic_donate
            // 
            this.pic_donate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pic_donate.BackColor = System.Drawing.Color.White;
            this.pic_donate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_donate.ForeColor = System.Drawing.Color.Black;
            this.pic_donate.Image = ((System.Drawing.Image)(resources.GetObject("pic_donate.Image")));
            this.pic_donate.Location = new System.Drawing.Point(138, 264);
            this.pic_donate.Name = "pic_donate";
            this.pic_donate.Size = new System.Drawing.Size(164, 68);
            this.pic_donate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_donate.TabIndex = 6;
            this.pic_donate.TabStop = false;
            this.pic_donate.Click += new System.EventHandler(this.pic_donate_Click);
            // 
            // lb_Log
            // 
            this.lb_Log.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_Log.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.lb_Log.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lb_Log.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Log.ForeColor = System.Drawing.Color.Black;
            this.lb_Log.Image = global::GetOnline.Properties.Resources.Exclamation;
            this.lb_Log.ImageTextSpacing = 5;
            this.lb_Log.Location = new System.Drawing.Point(-1, 396);
            this.lb_Log.Name = "lb_Log";
            this.lb_Log.Size = new System.Drawing.Size(426, 21);
            this.lb_Log.TabIndex = 1;
            this.lb_Log.Text = "Initializing";
            // 
            // reflectionLabel1
            // 
            this.reflectionLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.reflectionLabel1.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.reflectionLabel1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.reflectionLabel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reflectionLabel1.ForeColor = System.Drawing.Color.Black;
            this.reflectionLabel1.Location = new System.Drawing.Point(308, 264);
            this.reflectionLabel1.Name = "reflectionLabel1";
            this.reflectionLabel1.Size = new System.Drawing.Size(274, 68);
            this.reflectionLabel1.TabIndex = 9;
            this.reflectionLabel1.Text = "<b><font size=\"+6\"><i>By</i><font color=\"#B02B2C\"> Necros</font></font></b>\r\n<br>" +
    "<font size=\"+8\">Skype:<font color=\"#C0504D\">ADM_Necros</font></font></br>\r\n";
            this.reflectionLabel1.Click += new System.EventHandler(this.reflectionLabel1_Click);
            // 
            // btn_ReloadOnline
            // 
            this.btn_ReloadOnline.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_ReloadOnline.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ReloadOnline.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_ReloadOnline.Location = new System.Drawing.Point(431, 394);
            this.btn_ReloadOnline.Name = "btn_ReloadOnline";
            this.btn_ReloadOnline.Size = new System.Drawing.Size(59, 21);
            this.btn_ReloadOnline.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_ReloadOnline.TabIndex = 10;
            this.btn_ReloadOnline.Text = "Refresh";
            this.btn_ReloadOnline.Click += new System.EventHandler(this.btn_ReloadOnline_Click);
            // 
            // groupPanel1
            // 
            this.groupPanel1.BackColor = System.Drawing.Color.White;
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.lb_TotalOn);
            this.groupPanel1.Controls.Add(this.lb_Realm8);
            this.groupPanel1.Controls.Add(this.lb_Realm4);
            this.groupPanel1.Controls.Add(this.lb_Realm7);
            this.groupPanel1.Controls.Add(this.lb_Realm3);
            this.groupPanel1.Controls.Add(this.lb_Realm6);
            this.groupPanel1.Controls.Add(this.lb_Realm2);
            this.groupPanel1.Controls.Add(this.lb_Realm5);
            this.groupPanel1.Controls.Add(this.lb_Realm1);
            this.groupPanel1.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel1.Location = new System.Drawing.Point(1, 12);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(132, 198);
            // 
            // 
            // 
            this.groupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel1.Style.BackColorGradientAngle = 90;
            this.groupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderBottomWidth = 1;
            this.groupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderLeftWidth = 1;
            this.groupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderRightWidth = 1;
            this.groupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderTopWidth = 1;
            this.groupPanel1.Style.CornerDiameter = 4;
            this.groupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel1.TabIndex = 11;
            this.groupPanel1.Text = "Informations.";
            // 
            // lb_TotalOn
            // 
            this.lb_TotalOn.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lb_TotalOn.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lb_TotalOn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TotalOn.Location = new System.Drawing.Point(3, 156);
            this.lb_TotalOn.Name = "lb_TotalOn";
            this.lb_TotalOn.Size = new System.Drawing.Size(117, 24);
            this.lb_TotalOn.TabIndex = 0;
            this.lb_TotalOn.Text = "Total:";
            // 
            // lb_Realm8
            // 
            this.lb_Realm8.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lb_Realm8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lb_Realm8.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Realm8.Location = new System.Drawing.Point(3, 131);
            this.lb_Realm8.Name = "lb_Realm8";
            this.lb_Realm8.Size = new System.Drawing.Size(117, 24);
            this.lb_Realm8.TabIndex = 0;
            this.lb_Realm8.Text = "Realm 8:";
            // 
            // lb_Realm4
            // 
            this.lb_Realm4.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lb_Realm4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lb_Realm4.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Realm4.Location = new System.Drawing.Point(3, 55);
            this.lb_Realm4.Name = "lb_Realm4";
            this.lb_Realm4.Size = new System.Drawing.Size(117, 24);
            this.lb_Realm4.TabIndex = 0;
            this.lb_Realm4.Text = "Realm 4:";
            // 
            // lb_Realm7
            // 
            this.lb_Realm7.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lb_Realm7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lb_Realm7.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Realm7.Location = new System.Drawing.Point(3, 112);
            this.lb_Realm7.Name = "lb_Realm7";
            this.lb_Realm7.Size = new System.Drawing.Size(117, 24);
            this.lb_Realm7.TabIndex = 0;
            this.lb_Realm7.Text = "Realm 7:";
            // 
            // lb_Realm3
            // 
            this.lb_Realm3.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lb_Realm3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lb_Realm3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Realm3.Location = new System.Drawing.Point(3, 36);
            this.lb_Realm3.Name = "lb_Realm3";
            this.lb_Realm3.Size = new System.Drawing.Size(117, 24);
            this.lb_Realm3.TabIndex = 0;
            this.lb_Realm3.Text = "Realm 3:";
            // 
            // lb_Realm6
            // 
            this.lb_Realm6.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lb_Realm6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lb_Realm6.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Realm6.Location = new System.Drawing.Point(3, 93);
            this.lb_Realm6.Name = "lb_Realm6";
            this.lb_Realm6.Size = new System.Drawing.Size(117, 24);
            this.lb_Realm6.TabIndex = 0;
            this.lb_Realm6.Text = "Realm 6:";
            // 
            // lb_Realm2
            // 
            this.lb_Realm2.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lb_Realm2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lb_Realm2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Realm2.Location = new System.Drawing.Point(3, 17);
            this.lb_Realm2.Name = "lb_Realm2";
            this.lb_Realm2.Size = new System.Drawing.Size(117, 24);
            this.lb_Realm2.TabIndex = 0;
            this.lb_Realm2.Text = "Realm 2:";
            // 
            // lb_Realm5
            // 
            this.lb_Realm5.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lb_Realm5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lb_Realm5.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Realm5.Location = new System.Drawing.Point(3, 74);
            this.lb_Realm5.Name = "lb_Realm5";
            this.lb_Realm5.Size = new System.Drawing.Size(117, 24);
            this.lb_Realm5.TabIndex = 0;
            this.lb_Realm5.Text = "Realm 5:";
            // 
            // lb_Realm1
            // 
            this.lb_Realm1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lb_Realm1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lb_Realm1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Realm1.Location = new System.Drawing.Point(3, -1);
            this.lb_Realm1.Name = "lb_Realm1";
            this.lb_Realm1.Size = new System.Drawing.Size(117, 24);
            this.lb_Realm1.TabIndex = 0;
            this.lb_Realm1.Text = "Realm 1:";
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.Location = new System.Drawing.Point(9, 32);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(109, 23);
            this.buttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX1.TabIndex = 0;
            this.buttonX1.Text = "Ban/UnBan Account";
            // 
            // buttonX2
            // 
            this.buttonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX2.Location = new System.Drawing.Point(9, 61);
            this.buttonX2.Name = "buttonX2";
            this.buttonX2.Size = new System.Drawing.Size(109, 23);
            this.buttonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX2.TabIndex = 0;
            this.buttonX2.Text = "Add Zen";
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.FontBold = true;
            this.labelX1.ForeColor = System.Drawing.Color.Maroon;
            this.labelX1.Location = new System.Drawing.Point(5, 3);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(118, 23);
            this.labelX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Windows7;
            this.labelX1.Symbol = "";
            this.labelX1.TabIndex = 1;
            this.labelX1.Text = "Selected Account";
            // 
            // groupPanel2
            // 
            this.groupPanel2.BackColor = System.Drawing.Color.White;
            this.groupPanel2.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel2.Controls.Add(this.labelX1);
            this.groupPanel2.Controls.Add(this.buttonX2);
            this.groupPanel2.Controls.Add(this.buttonX1);
            this.groupPanel2.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel2.Enabled = false;
            this.groupPanel2.Location = new System.Drawing.Point(1, 216);
            this.groupPanel2.Name = "groupPanel2";
            this.groupPanel2.Size = new System.Drawing.Size(130, 162);
            // 
            // 
            // 
            this.groupPanel2.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel2.Style.BackColorGradientAngle = 90;
            this.groupPanel2.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel2.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderBottomWidth = 1;
            this.groupPanel2.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel2.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderLeftWidth = 1;
            this.groupPanel2.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderRightWidth = 1;
            this.groupPanel2.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderTopWidth = 1;
            this.groupPanel2.Style.CornerDiameter = 4;
            this.groupPanel2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel2.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel2.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel2.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel2.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel2.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel2.TabIndex = 12;
            this.groupPanel2.Text = "Paid Functions";
            // 
            // FM_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 416);
            this.Controls.Add(this.groupPanel2);
            this.Controls.Add(this.groupPanel1);
            this.Controls.Add(this.btn_ReloadOnline);
            this.Controls.Add(this.reflectionLabel1);
            this.Controls.Add(this.radialMenu1);
            this.Controls.Add(this.pic_donate);
            this.Controls.Add(this.grid_OnlineList);
            this.Controls.Add(this.web_longLog);
            this.Controls.Add(this.switchButton1);
            this.Controls.Add(this.lb_Log);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(598, 1024);
            this.MinimumSize = new System.Drawing.Size(598, 308);
            this.Name = "FM_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "[GetOnline] By Necros - FreeVersion";
            this.Load += new System.EventHandler(this.FM_Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_OnlineList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_donate)).EndInit();
            this.groupPanel1.ResumeLayout(false);
            this.groupPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DevComponents.DotNetBar.LabelX lb_Log;
        private DevComponents.DotNetBar.Controls.SwitchButton switchButton1;
        private System.Windows.Forms.WebBrowser web_longLog;
        private DevComponents.DotNetBar.Controls.DataGridViewX grid_OnlineList;
        private System.Windows.Forms.PictureBox pic_donate;
        private DevComponents.DotNetBar.RadialMenu radialMenu1;
        private DevComponents.DotNetBar.RadialMenuItem radial_StartNow;
        private DevComponents.DotNetBar.RadialMenuItem radial_Config;
        private DevComponents.DotNetBar.RadialMenuItem radial_functions;
        private DevComponents.DotNetBar.RadialMenuItem radial_functions_ClearTable;
        private DevComponents.DotNetBar.RadialMenuItem radial_functions_FixDB;
        private DevComponents.DotNetBar.RadialMenuItem radial_donate;
        private DevComponents.DotNetBar.Controls.ReflectionLabel reflectionLabel1;
        private DevComponents.DotNetBar.ButtonX btn_ReloadOnline;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.LabelX lb_TotalOn;
        private DevComponents.DotNetBar.LabelX lb_Realm8;
        private DevComponents.DotNetBar.LabelX lb_Realm4;
        private DevComponents.DotNetBar.LabelX lb_Realm7;
        private DevComponents.DotNetBar.LabelX lb_Realm3;
        private DevComponents.DotNetBar.LabelX lb_Realm6;
        private DevComponents.DotNetBar.LabelX lb_Realm2;
        private DevComponents.DotNetBar.LabelX lb_Realm5;
        private DevComponents.DotNetBar.LabelX lb_Realm1;
        private DevComponents.DotNetBar.ButtonX buttonX1;
        private DevComponents.DotNetBar.ButtonX buttonX2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel2;
    }
}