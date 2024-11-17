namespace TRIP_APP
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            Utilities.BunifuPages.BunifuAnimatorNS.Animation animation1 = new Utilities.BunifuPages.BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.navBar = new System.Windows.Forms.Panel();
            this.btnMinimize = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnExit = new Guna.UI2.WinForms.Guna2CircleButton();
            this.Multipage = new Bunifu.UI.WinForms.BunifuPages();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.circleBar = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.gunaElipsePanel1 = new Guna.UI.WinForms.GunaElipsePanel();
            this.LoadTripProgressBar = new Guna.UI2.WinForms.Guna2ProgressIndicator();
            this.dgvTrip = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnSelectTrip = new Guna.UI2.WinForms.Guna2Button();
            this.DownPanel = new Guna.UI.WinForms.GunaElipsePanel();
            this.txtAddTrip = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnNewTrip = new Guna.UI.WinForms.GunaElipsePanel();
            this.lblNewTrip = new Guna.UI.WinForms.GunaLabel();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.gunaElipsePanel2 = new Guna.UI.WinForms.GunaElipsePanel();
            this.dgvParticipants = new Guna.UI2.WinForms.Guna2DataGridView();
            this.gunaElipsePanel3 = new Guna.UI.WinForms.GunaElipsePanel();
            this.btnStartTrip = new Guna.UI.WinForms.GunaElipsePanel();
            this.progressBar = new Guna.UI2.WinForms.Guna2ProgressIndicator();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.btnAddPeople = new Guna.UI2.WinForms.Guna2Button();
            this.txtAddPeople = new Guna.UI2.WinForms.Guna2TextBox();
            this.timerLoading = new System.Windows.Forms.Timer(this.components);
            this.timerStartTrip = new System.Windows.Forms.Timer(this.components);
            this.timerLoadTrip = new System.Windows.Forms.Timer(this.components);
            this.navBar.SuspendLayout();
            this.Multipage.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.gunaElipsePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrip)).BeginInit();
            this.DownPanel.SuspendLayout();
            this.btnNewTrip.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.gunaElipsePanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParticipants)).BeginInit();
            this.gunaElipsePanel3.SuspendLayout();
            this.btnStartTrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // navBar
            // 
            this.navBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(105)))));
            this.navBar.Controls.Add(this.btnMinimize);
            this.navBar.Controls.Add(this.btnExit);
            this.navBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.navBar.Location = new System.Drawing.Point(0, 0);
            this.navBar.Name = "navBar";
            this.navBar.Size = new System.Drawing.Size(391, 39);
            this.navBar.TabIndex = 2;
            this.navBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.navBar_MouseDown);
            this.navBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.navBar_MouseMove);
            this.navBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.navBar_MouseUp);
            // 
            // btnMinimize
            // 
            this.btnMinimize.CheckedState.Parent = this.btnMinimize;
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimize.CustomImages.Parent = this.btnMinimize;
            this.btnMinimize.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnMinimize.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnMinimize.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.HoverState.FillColor = System.Drawing.Color.Cyan;
            this.btnMinimize.HoverState.Parent = this.btnMinimize;
            this.btnMinimize.Location = new System.Drawing.Point(333, 10);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnMinimize.ShadowDecoration.Parent = this.btnMinimize;
            this.btnMinimize.Size = new System.Drawing.Size(20, 20);
            this.btnMinimize.TabIndex = 3;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnExit
            // 
            this.btnExit.CheckedState.Parent = this.btnExit;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.CustomImages.Parent = this.btnExit;
            this.btnExit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.HoverState.FillColor = System.Drawing.Color.Red;
            this.btnExit.HoverState.Parent = this.btnExit;
            this.btnExit.Location = new System.Drawing.Point(359, 10);
            this.btnExit.Name = "btnExit";
            this.btnExit.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnExit.ShadowDecoration.Parent = this.btnExit;
            this.btnExit.Size = new System.Drawing.Size(20, 20);
            this.btnExit.TabIndex = 3;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Multipage
            // 
            this.Multipage.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.Multipage.AllowTransitions = true;
            this.Multipage.Controls.Add(this.tabPage1);
            this.Multipage.Controls.Add(this.tabPage2);
            this.Multipage.Controls.Add(this.tabPage3);
            this.Multipage.Location = new System.Drawing.Point(0, 45);
            this.Multipage.Multiline = true;
            this.Multipage.Name = "Multipage";
            this.Multipage.Page = this.tabPage3;
            this.Multipage.PageIndex = 2;
            this.Multipage.PageName = "tabPage3";
            this.Multipage.PageTitle = "tabPage3";
            this.Multipage.SelectedIndex = 0;
            this.Multipage.Size = new System.Drawing.Size(391, 580);
            this.Multipage.TabIndex = 3;
            animation1.AnimateOnlyDifferences = false;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.Multipage.Transition = animation1;
            this.Multipage.TransitionType = Utilities.BunifuPages.BunifuAnimatorNS.AnimationType.Custom;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.circleBar);
            this.tabPage1.Location = new System.Drawing.Point(4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(383, 554);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(74, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(236, 65);
            this.label3.TabIndex = 32;
            this.label3.Text = "TRIP APP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.label2.Location = new System.Drawing.Point(8, 517);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 30);
            this.label2.TabIndex = 31;
            this.label2.Text = "NEXUS ANAS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(8, 487);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 30);
            this.label1.TabIndex = 30;
            this.label1.Text = "Powered By:";
            // 
            // circleBar
            // 
            this.circleBar.Animated = true;
            this.circleBar.AnimationSpeed = 0.8F;
            this.circleBar.FillOffset = 5;
            this.circleBar.FillThickness = 14;
            this.circleBar.Location = new System.Drawing.Point(116, 309);
            this.circleBar.Name = "circleBar";
            this.circleBar.ProgressColor = System.Drawing.Color.Cyan;
            this.circleBar.ProgressColor2 = System.Drawing.Color.SlateBlue;
            this.circleBar.ProgressEndCap = System.Drawing.Drawing2D.LineCap.Round;
            this.circleBar.ProgressOffset = 4;
            this.circleBar.ProgressStartCap = System.Drawing.Drawing2D.LineCap.Round;
            this.circleBar.ProgressThickness = 15;
            this.circleBar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.circleBar.ShadowDecoration.Parent = this.circleBar;
            this.circleBar.Size = new System.Drawing.Size(150, 150);
            this.circleBar.TabIndex = 28;
            this.circleBar.Value = 30;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.tabPage2.Controls.Add(this.gunaElipsePanel1);
            this.tabPage2.Controls.Add(this.DownPanel);
            this.tabPage2.Location = new System.Drawing.Point(4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(383, 554);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            // 
            // gunaElipsePanel1
            // 
            this.gunaElipsePanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaElipsePanel1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(54)))), ((int)(((byte)(78)))));
            this.gunaElipsePanel1.Controls.Add(this.LoadTripProgressBar);
            this.gunaElipsePanel1.Controls.Add(this.dgvTrip);
            this.gunaElipsePanel1.Controls.Add(this.btnSelectTrip);
            this.gunaElipsePanel1.Location = new System.Drawing.Point(21, 215);
            this.gunaElipsePanel1.Name = "gunaElipsePanel1";
            this.gunaElipsePanel1.Size = new System.Drawing.Size(340, 326);
            this.gunaElipsePanel1.TabIndex = 39;
            // 
            // LoadTripProgressBar
            // 
            this.LoadTripProgressBar.CircleSize = 0.8F;
            this.LoadTripProgressBar.Location = new System.Drawing.Point(277, 11);
            this.LoadTripProgressBar.Name = "LoadTripProgressBar";
            this.LoadTripProgressBar.ProgressColor = System.Drawing.Color.MediumSpringGreen;
            this.LoadTripProgressBar.Size = new System.Drawing.Size(49, 49);
            this.LoadTripProgressBar.TabIndex = 27;
            // 
            // dgvTrip
            // 
            this.dgvTrip.AllowUserToAddRows = false;
            this.dgvTrip.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvTrip.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTrip.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTrip.BackgroundColor = System.Drawing.Color.White;
            this.dgvTrip.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTrip.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvTrip.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTrip.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTrip.ColumnHeadersHeight = 4;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTrip.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTrip.EnableHeadersVisualStyles = false;
            this.dgvTrip.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvTrip.Location = new System.Drawing.Point(13, 68);
            this.dgvTrip.Name = "dgvTrip";
            this.dgvTrip.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTrip.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvTrip.RowHeadersVisible = false;
            this.dgvTrip.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTrip.Size = new System.Drawing.Size(313, 245);
            this.dgvTrip.TabIndex = 2;
            this.dgvTrip.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dgvTrip.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvTrip.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvTrip.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvTrip.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvTrip.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvTrip.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvTrip.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvTrip.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvTrip.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvTrip.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvTrip.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvTrip.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvTrip.ThemeStyle.HeaderStyle.Height = 4;
            this.dgvTrip.ThemeStyle.ReadOnly = true;
            this.dgvTrip.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvTrip.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvTrip.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvTrip.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvTrip.ThemeStyle.RowsStyle.Height = 22;
            this.dgvTrip.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvTrip.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvTrip.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTrip_CellClick);
            // 
            // btnSelectTrip
            // 
            this.btnSelectTrip.Animated = true;
            this.btnSelectTrip.BackColor = System.Drawing.Color.Transparent;
            this.btnSelectTrip.BorderColor = System.Drawing.Color.SpringGreen;
            this.btnSelectTrip.BorderRadius = 12;
            this.btnSelectTrip.BorderThickness = 2;
            this.btnSelectTrip.CheckedState.Parent = this.btnSelectTrip;
            this.btnSelectTrip.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSelectTrip.CustomImages.Parent = this.btnSelectTrip;
            this.btnSelectTrip.FillColor = System.Drawing.Color.Transparent;
            this.btnSelectTrip.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectTrip.ForeColor = System.Drawing.Color.White;
            this.btnSelectTrip.HoverState.Parent = this.btnSelectTrip;
            this.btnSelectTrip.Location = new System.Drawing.Point(13, 13);
            this.btnSelectTrip.Name = "btnSelectTrip";
            this.btnSelectTrip.ShadowDecoration.BorderRadius = 12;
            this.btnSelectTrip.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.btnSelectTrip.ShadowDecoration.Depth = 50;
            this.btnSelectTrip.ShadowDecoration.Enabled = true;
            this.btnSelectTrip.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnSelectTrip.ShadowDecoration.Parent = this.btnSelectTrip;
            this.btnSelectTrip.Size = new System.Drawing.Size(258, 45);
            this.btnSelectTrip.TabIndex = 21;
            this.btnSelectTrip.Text = "Select Trip";
            this.btnSelectTrip.Click += new System.EventHandler(this.btnSelectTrip_Click);
            // 
            // DownPanel
            // 
            this.DownPanel.BackColor = System.Drawing.Color.Transparent;
            this.DownPanel.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(54)))), ((int)(((byte)(78)))));
            this.DownPanel.Controls.Add(this.txtAddTrip);
            this.DownPanel.Controls.Add(this.btnNewTrip);
            this.DownPanel.Location = new System.Drawing.Point(21, 13);
            this.DownPanel.Name = "DownPanel";
            this.DownPanel.Size = new System.Drawing.Size(340, 160);
            this.DownPanel.TabIndex = 10;
            // 
            // txtAddTrip
            // 
            this.txtAddTrip.Animated = true;
            this.txtAddTrip.BorderColor = System.Drawing.Color.MediumSpringGreen;
            this.txtAddTrip.BorderRadius = 10;
            this.txtAddTrip.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAddTrip.DefaultText = "";
            this.txtAddTrip.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAddTrip.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAddTrip.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAddTrip.DisabledState.Parent = this.txtAddTrip;
            this.txtAddTrip.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAddTrip.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.txtAddTrip.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtAddTrip.FocusedState.Parent = this.txtAddTrip;
            this.txtAddTrip.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddTrip.ForeColor = System.Drawing.Color.White;
            this.txtAddTrip.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAddTrip.HoverState.Parent = this.txtAddTrip;
            this.txtAddTrip.Location = new System.Drawing.Point(13, 11);
            this.txtAddTrip.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAddTrip.Name = "txtAddTrip";
            this.txtAddTrip.PasswordChar = '\0';
            this.txtAddTrip.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtAddTrip.PlaceholderText = "Type trip name";
            this.txtAddTrip.SelectedText = "";
            this.txtAddTrip.ShadowDecoration.Parent = this.txtAddTrip;
            this.txtAddTrip.Size = new System.Drawing.Size(313, 30);
            this.txtAddTrip.TabIndex = 37;
            this.txtAddTrip.TextOffset = new System.Drawing.Point(2, 0);
            // 
            // btnNewTrip
            // 
            this.btnNewTrip.BackColor = System.Drawing.Color.Transparent;
            this.btnNewTrip.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.btnNewTrip.Controls.Add(this.lblNewTrip);
            this.btnNewTrip.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewTrip.Location = new System.Drawing.Point(13, 49);
            this.btnNewTrip.Name = "btnNewTrip";
            this.btnNewTrip.Size = new System.Drawing.Size(313, 99);
            this.btnNewTrip.TabIndex = 9;
            this.btnNewTrip.Click += new System.EventHandler(this.btnNewTrip_Click);
            this.btnNewTrip.MouseEnter += new System.EventHandler(this.btnNewTrip_MouseEnter);
            this.btnNewTrip.MouseLeave += new System.EventHandler(this.btnNewTrip_MouseLeave);
            // 
            // lblNewTrip
            // 
            this.lblNewTrip.AutoSize = true;
            this.lblNewTrip.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewTrip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblNewTrip.Location = new System.Drawing.Point(19, 30);
            this.lblNewTrip.Name = "lblNewTrip";
            this.lblNewTrip.Size = new System.Drawing.Size(158, 36);
            this.lblNewTrip.TabIndex = 6;
            this.lblNewTrip.Text = "New Trip +";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.tabPage3.Controls.Add(this.gunaElipsePanel2);
            this.tabPage3.Controls.Add(this.gunaElipsePanel3);
            this.tabPage3.Location = new System.Drawing.Point(4, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(383, 554);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            // 
            // gunaElipsePanel2
            // 
            this.gunaElipsePanel2.BackColor = System.Drawing.Color.Transparent;
            this.gunaElipsePanel2.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(54)))), ((int)(((byte)(78)))));
            this.gunaElipsePanel2.Controls.Add(this.dgvParticipants);
            this.gunaElipsePanel2.Location = new System.Drawing.Point(21, 215);
            this.gunaElipsePanel2.Name = "gunaElipsePanel2";
            this.gunaElipsePanel2.Size = new System.Drawing.Size(340, 326);
            this.gunaElipsePanel2.TabIndex = 41;
            // 
            // dgvParticipants
            // 
            this.dgvParticipants.AllowUserToAddRows = false;
            this.dgvParticipants.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            this.dgvParticipants.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvParticipants.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvParticipants.BackgroundColor = System.Drawing.Color.White;
            this.dgvParticipants.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvParticipants.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvParticipants.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvParticipants.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvParticipants.ColumnHeadersHeight = 4;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvParticipants.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvParticipants.EnableHeadersVisualStyles = false;
            this.dgvParticipants.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvParticipants.Location = new System.Drawing.Point(13, 13);
            this.dgvParticipants.Name = "dgvParticipants";
            this.dgvParticipants.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvParticipants.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvParticipants.RowHeadersVisible = false;
            this.dgvParticipants.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvParticipants.Size = new System.Drawing.Size(313, 300);
            this.dgvParticipants.TabIndex = 2;
            this.dgvParticipants.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dgvParticipants.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvParticipants.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvParticipants.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvParticipants.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvParticipants.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvParticipants.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvParticipants.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvParticipants.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvParticipants.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvParticipants.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvParticipants.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvParticipants.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvParticipants.ThemeStyle.HeaderStyle.Height = 4;
            this.dgvParticipants.ThemeStyle.ReadOnly = true;
            this.dgvParticipants.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvParticipants.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvParticipants.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvParticipants.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvParticipants.ThemeStyle.RowsStyle.Height = 22;
            this.dgvParticipants.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvParticipants.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // gunaElipsePanel3
            // 
            this.gunaElipsePanel3.BackColor = System.Drawing.Color.Transparent;
            this.gunaElipsePanel3.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(54)))), ((int)(((byte)(78)))));
            this.gunaElipsePanel3.Controls.Add(this.btnStartTrip);
            this.gunaElipsePanel3.Controls.Add(this.btnAddPeople);
            this.gunaElipsePanel3.Controls.Add(this.txtAddPeople);
            this.gunaElipsePanel3.Location = new System.Drawing.Point(21, 13);
            this.gunaElipsePanel3.Name = "gunaElipsePanel3";
            this.gunaElipsePanel3.Size = new System.Drawing.Size(340, 160);
            this.gunaElipsePanel3.TabIndex = 40;
            // 
            // btnStartTrip
            // 
            this.btnStartTrip.BackColor = System.Drawing.Color.Transparent;
            this.btnStartTrip.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.btnStartTrip.Controls.Add(this.progressBar);
            this.btnStartTrip.Controls.Add(this.gunaLabel1);
            this.btnStartTrip.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStartTrip.Location = new System.Drawing.Point(13, 49);
            this.btnStartTrip.Name = "btnStartTrip";
            this.btnStartTrip.Size = new System.Drawing.Size(313, 99);
            this.btnStartTrip.TabIndex = 9;
            this.btnStartTrip.Click += new System.EventHandler(this.btnStartTrip_Click);
            this.btnStartTrip.Paint += new System.Windows.Forms.PaintEventHandler(this.btnStartTrip_Paint);
            this.btnStartTrip.MouseEnter += new System.EventHandler(this.btnStartTrip_MouseEnter);
            this.btnStartTrip.MouseLeave += new System.EventHandler(this.btnStartTrip_MouseLeave);
            // 
            // progressBar
            // 
            this.progressBar.CircleSize = 0.8F;
            this.progressBar.Location = new System.Drawing.Point(208, 6);
            this.progressBar.Name = "progressBar";
            this.progressBar.ProgressColor = System.Drawing.Color.MediumSpringGreen;
            this.progressBar.Size = new System.Drawing.Size(86, 86);
            this.progressBar.TabIndex = 26;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gunaLabel1.Location = new System.Drawing.Point(19, 30);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(131, 36);
            this.gunaLabel1.TabIndex = 6;
            this.gunaLabel1.Text = "Start Trip";
            // 
            // btnAddPeople
            // 
            this.btnAddPeople.Animated = true;
            this.btnAddPeople.BackColor = System.Drawing.Color.Transparent;
            this.btnAddPeople.BorderRadius = 5;
            this.btnAddPeople.CheckedState.Parent = this.btnAddPeople;
            this.btnAddPeople.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddPeople.CustomImages.Parent = this.btnAddPeople;
            this.btnAddPeople.FillColor = System.Drawing.Color.Cyan;
            this.btnAddPeople.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPeople.ForeColor = System.Drawing.Color.Black;
            this.btnAddPeople.HoverState.Parent = this.btnAddPeople;
            this.btnAddPeople.Location = new System.Drawing.Point(290, 12);
            this.btnAddPeople.Name = "btnAddPeople";
            this.btnAddPeople.ShadowDecoration.Parent = this.btnAddPeople;
            this.btnAddPeople.Size = new System.Drawing.Size(36, 30);
            this.btnAddPeople.TabIndex = 37;
            this.btnAddPeople.Text = "+";
            this.btnAddPeople.Click += new System.EventHandler(this.btnAddPeople_Click);
            // 
            // txtAddPeople
            // 
            this.txtAddPeople.Animated = true;
            this.txtAddPeople.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.txtAddPeople.BorderRadius = 10;
            this.txtAddPeople.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAddPeople.DefaultText = "";
            this.txtAddPeople.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAddPeople.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAddPeople.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAddPeople.DisabledState.Parent = this.txtAddPeople;
            this.txtAddPeople.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAddPeople.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.txtAddPeople.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtAddPeople.FocusedState.Parent = this.txtAddPeople;
            this.txtAddPeople.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddPeople.ForeColor = System.Drawing.Color.White;
            this.txtAddPeople.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAddPeople.HoverState.Parent = this.txtAddPeople;
            this.txtAddPeople.Location = new System.Drawing.Point(13, 12);
            this.txtAddPeople.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAddPeople.Name = "txtAddPeople";
            this.txtAddPeople.PasswordChar = '\0';
            this.txtAddPeople.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtAddPeople.PlaceholderText = "Add new people";
            this.txtAddPeople.SelectedText = "";
            this.txtAddPeople.ShadowDecoration.Parent = this.txtAddPeople;
            this.txtAddPeople.Size = new System.Drawing.Size(262, 30);
            this.txtAddPeople.TabIndex = 36;
            this.txtAddPeople.TextOffset = new System.Drawing.Point(2, 0);
            // 
            // timerLoading
            // 
            this.timerLoading.Interval = 1000;
            this.timerLoading.Tick += new System.EventHandler(this.timerLoading_Tick);
            // 
            // timerStartTrip
            // 
            this.timerStartTrip.Interval = 1000;
            this.timerStartTrip.Tick += new System.EventHandler(this.timerStartTrip_Tick);
            // 
            // timerLoadTrip
            // 
            this.timerLoadTrip.Interval = 1000;
            this.timerLoadTrip.Tick += new System.EventHandler(this.timerLoadTrip_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(391, 613);
            this.Controls.Add(this.Multipage);
            this.Controls.Add(this.navBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.navBar.ResumeLayout(false);
            this.Multipage.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.gunaElipsePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrip)).EndInit();
            this.DownPanel.ResumeLayout(false);
            this.btnNewTrip.ResumeLayout(false);
            this.btnNewTrip.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.gunaElipsePanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvParticipants)).EndInit();
            this.gunaElipsePanel3.ResumeLayout(false);
            this.btnStartTrip.ResumeLayout(false);
            this.btnStartTrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel navBar;
        private Guna.UI2.WinForms.Guna2CircleButton btnMinimize;
        private Guna.UI2.WinForms.Guna2CircleButton btnExit;
        private Bunifu.UI.WinForms.BunifuPages Multipage;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2CircleProgressBar circleBar;
        private System.Windows.Forms.TabPage tabPage2;
        private Guna.UI.WinForms.GunaElipsePanel gunaElipsePanel1;
        private Guna.UI2.WinForms.Guna2DataGridView dgvTrip;
        private Guna.UI2.WinForms.Guna2Button btnSelectTrip;
        private Guna.UI.WinForms.GunaElipsePanel DownPanel;
        private Guna.UI2.WinForms.Guna2TextBox txtAddTrip;
        private Guna.UI.WinForms.GunaElipsePanel btnNewTrip;
        private Guna.UI.WinForms.GunaLabel lblNewTrip;
        private System.Windows.Forms.TabPage tabPage3;
        private Guna.UI2.WinForms.Guna2Button btnAddPeople;
        private Guna.UI2.WinForms.Guna2TextBox txtAddPeople;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timerLoading;
        private System.Windows.Forms.Timer timerStartTrip;
        private System.Windows.Forms.Timer timerLoadTrip;
        private Guna.UI.WinForms.GunaElipsePanel gunaElipsePanel3;
        private Guna.UI.WinForms.GunaElipsePanel btnStartTrip;
        private Guna.UI2.WinForms.Guna2ProgressIndicator progressBar;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaElipsePanel gunaElipsePanel2;
        private Guna.UI2.WinForms.Guna2DataGridView dgvParticipants;
        private Guna.UI2.WinForms.Guna2ProgressIndicator LoadTripProgressBar;
    }
}

