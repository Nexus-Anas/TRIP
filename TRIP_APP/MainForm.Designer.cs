namespace TRIP_APP
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.navBar = new System.Windows.Forms.Panel();
            this.btnMinimize = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnExit = new Guna.UI2.WinForms.Guna2CircleButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Indicator2 = new System.Windows.Forms.Panel();
            this.btnSummary = new Guna.UI2.WinForms.Guna2Button();
            this.Indicator = new System.Windows.Forms.Panel();
            this.btnNewActivity = new Guna.UI2.WinForms.Guna2Button();
            this.btnDashboard = new Guna.UI2.WinForms.Guna2Button();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.MultiPage = new Bunifu.UI.WinForms.BunifuPages();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.gunaElipsePanel1 = new Guna.UI.WinForms.GunaElipsePanel();
            this.label3 = new System.Windows.Forms.Label();
            this.lblRegion = new System.Windows.Forms.Label();
            this.panelDuration = new Guna.UI.WinForms.GunaElipsePanel();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvParticipants = new Guna.UI2.WinForms.Guna2DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panelCreateActivity = new Guna.UI.WinForms.GunaElipsePanel();
            this.comboParticipants = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnCreate = new Guna.UI2.WinForms.Guna2Button();
            this.txtActivityName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panelPerformActivity = new Guna.UI.WinForms.GunaElipsePanel();
            this.btnEndActivity = new Guna.UI2.WinForms.Guna2Button();
            this.comboDebtors = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtAmount = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnPay = new Guna.UI2.WinForms.Guna2Button();
            this.dgvDebtorsActivity = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.lblPersonInCharge = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnNewTrip = new Guna.UI2.WinForms.Guna2Button();
            this.lblSummary = new System.Windows.Forms.Label();
            this.btnFinishTrip = new Guna.UI2.WinForms.Guna2Button();
            this.debtorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.debtorNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.debtorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.navBar.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelHeader.SuspendLayout();
            this.MultiPage.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.gunaElipsePanel1.SuspendLayout();
            this.panelDuration.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParticipants)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.panelCreateActivity.SuspendLayout();
            this.panelPerformActivity.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDebtorsActivity)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.debtorsBindingSource)).BeginInit();
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
            this.navBar.Size = new System.Drawing.Size(1089, 39);
            this.navBar.TabIndex = 1;
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
            this.btnMinimize.Location = new System.Drawing.Point(1031, 10);
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
            this.btnExit.Location = new System.Drawing.Point(1057, 10);
            this.btnExit.Name = "btnExit";
            this.btnExit.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnExit.ShadowDecoration.Parent = this.btnExit;
            this.btnExit.Size = new System.Drawing.Size(20, 20);
            this.btnExit.TabIndex = 3;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.panel2.Controls.Add(this.Indicator2);
            this.panel2.Controls.Add(this.btnSummary);
            this.panel2.Controls.Add(this.Indicator);
            this.panel2.Controls.Add(this.btnNewActivity);
            this.panel2.Controls.Add(this.btnDashboard);
            this.panel2.Controls.Add(this.panelHeader);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 39);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(182, 580);
            this.panel2.TabIndex = 2;
            // 
            // Indicator2
            // 
            this.Indicator2.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.Indicator2.Location = new System.Drawing.Point(0, 235);
            this.Indicator2.Name = "Indicator2";
            this.Indicator2.Size = new System.Drawing.Size(10, 55);
            this.Indicator2.TabIndex = 4;
            this.Indicator2.Visible = false;
            // 
            // btnSummary
            // 
            this.btnSummary.CheckedState.Parent = this.btnSummary;
            this.btnSummary.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSummary.CustomImages.Parent = this.btnSummary;
            this.btnSummary.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSummary.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.btnSummary.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSummary.ForeColor = System.Drawing.Color.White;
            this.btnSummary.HoverState.Parent = this.btnSummary;
            this.btnSummary.Location = new System.Drawing.Point(0, 235);
            this.btnSummary.Name = "btnSummary";
            this.btnSummary.ShadowDecoration.Parent = this.btnSummary;
            this.btnSummary.Size = new System.Drawing.Size(182, 55);
            this.btnSummary.TabIndex = 4;
            this.btnSummary.Text = "Summary";
            this.btnSummary.Click += new System.EventHandler(this.btnSummary_Click);
            // 
            // Indicator
            // 
            this.Indicator.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.Indicator.Location = new System.Drawing.Point(0, 125);
            this.Indicator.Name = "Indicator";
            this.Indicator.Size = new System.Drawing.Size(10, 55);
            this.Indicator.TabIndex = 3;
            // 
            // btnNewActivity
            // 
            this.btnNewActivity.CheckedState.Parent = this.btnNewActivity;
            this.btnNewActivity.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewActivity.CustomImages.Parent = this.btnNewActivity;
            this.btnNewActivity.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNewActivity.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.btnNewActivity.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewActivity.ForeColor = System.Drawing.Color.White;
            this.btnNewActivity.HoverState.Parent = this.btnNewActivity;
            this.btnNewActivity.Location = new System.Drawing.Point(0, 180);
            this.btnNewActivity.Name = "btnNewActivity";
            this.btnNewActivity.ShadowDecoration.Parent = this.btnNewActivity;
            this.btnNewActivity.Size = new System.Drawing.Size(182, 55);
            this.btnNewActivity.TabIndex = 2;
            this.btnNewActivity.Text = "New Activity";
            this.btnNewActivity.Click += new System.EventHandler(this.btnNewActivity_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.CheckedState.Parent = this.btnDashboard;
            this.btnDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDashboard.CustomImages.Parent = this.btnDashboard;
            this.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDashboard.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.btnDashboard.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.HoverState.Parent = this.btnDashboard;
            this.btnDashboard.Location = new System.Drawing.Point(0, 125);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.ShadowDecoration.Parent = this.btnDashboard;
            this.btnDashboard.Size = new System.Drawing.Size(182, 55);
            this.btnDashboard.TabIndex = 1;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(65)))));
            this.panelHeader.Controls.Add(this.label2);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(182, 125);
            this.panelHeader.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.label2.Location = new System.Drawing.Point(38, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 64);
            this.label2.TabIndex = 30;
            this.label2.Text = "NEXUS\r\nANAS";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // MultiPage
            // 
            this.MultiPage.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.MultiPage.AllowTransitions = true;
            this.MultiPage.Controls.Add(this.tabPage1);
            this.MultiPage.Controls.Add(this.tabPage2);
            this.MultiPage.Controls.Add(this.tabPage3);
            this.MultiPage.Location = new System.Drawing.Point(181, 39);
            this.MultiPage.Multiline = true;
            this.MultiPage.Name = "MultiPage";
            this.MultiPage.Page = this.tabPage2;
            this.MultiPage.PageIndex = 1;
            this.MultiPage.PageName = "tabPage2";
            this.MultiPage.PageTitle = "tabPage2";
            this.MultiPage.SelectedIndex = 0;
            this.MultiPage.Size = new System.Drawing.Size(908, 588);
            this.MultiPage.TabIndex = 39;
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
            this.MultiPage.Transition = animation1;
            this.MultiPage.TransitionType = Utilities.BunifuPages.BunifuAnimatorNS.AnimationType.Custom;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.tabPage1.Controls.Add(this.gunaElipsePanel1);
            this.tabPage1.Controls.Add(this.panelDuration);
            this.tabPage1.Location = new System.Drawing.Point(4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(900, 562);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            // 
            // gunaElipsePanel1
            // 
            this.gunaElipsePanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaElipsePanel1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(54)))), ((int)(((byte)(78)))));
            this.gunaElipsePanel1.Controls.Add(this.label3);
            this.gunaElipsePanel1.Controls.Add(this.lblRegion);
            this.gunaElipsePanel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.gunaElipsePanel1.Location = new System.Drawing.Point(262, 28);
            this.gunaElipsePanel1.Name = "gunaElipsePanel1";
            this.gunaElipsePanel1.Size = new System.Drawing.Size(370, 62);
            this.gunaElipsePanel1.TabIndex = 38;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(74, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 37);
            this.label3.TabIndex = 32;
            this.label3.Text = "Region";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblRegion
            // 
            this.lblRegion.AutoSize = true;
            this.lblRegion.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegion.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.lblRegion.Location = new System.Drawing.Point(187, 10);
            this.lblRegion.Name = "lblRegion";
            this.lblRegion.Size = new System.Drawing.Size(107, 37);
            this.lblRegion.TabIndex = 31;
            this.lblRegion.Text = "Region";
            this.lblRegion.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panelDuration
            // 
            this.panelDuration.BackColor = System.Drawing.Color.Transparent;
            this.panelDuration.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(54)))), ((int)(((byte)(78)))));
            this.panelDuration.Controls.Add(this.label1);
            this.panelDuration.Controls.Add(this.dgvParticipants);
            this.panelDuration.Cursor = System.Windows.Forms.Cursors.Default;
            this.panelDuration.Location = new System.Drawing.Point(262, 144);
            this.panelDuration.Name = "panelDuration";
            this.panelDuration.Size = new System.Drawing.Size(370, 402);
            this.panelDuration.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(99, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 37);
            this.label1.TabIndex = 33;
            this.label1.Text = "Participants";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dgvParticipants
            // 
            this.dgvParticipants.AllowUserToAddRows = false;
            this.dgvParticipants.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvParticipants.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvParticipants.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvParticipants.BackgroundColor = System.Drawing.Color.White;
            this.dgvParticipants.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvParticipants.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvParticipants.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvParticipants.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvParticipants.ColumnHeadersHeight = 21;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvParticipants.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvParticipants.EnableHeadersVisualStyles = false;
            this.dgvParticipants.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvParticipants.Location = new System.Drawing.Point(10, 53);
            this.dgvParticipants.Name = "dgvParticipants";
            this.dgvParticipants.ReadOnly = true;
            this.dgvParticipants.RowHeadersVisible = false;
            this.dgvParticipants.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvParticipants.Size = new System.Drawing.Size(351, 339);
            this.dgvParticipants.TabIndex = 37;
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
            this.dgvParticipants.ThemeStyle.HeaderStyle.Height = 21;
            this.dgvParticipants.ThemeStyle.ReadOnly = true;
            this.dgvParticipants.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvParticipants.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvParticipants.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvParticipants.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvParticipants.ThemeStyle.RowsStyle.Height = 22;
            this.dgvParticipants.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvParticipants.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.tabPage2.Controls.Add(this.panelCreateActivity);
            this.tabPage2.Controls.Add(this.panelPerformActivity);
            this.tabPage2.Location = new System.Drawing.Point(4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(900, 562);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            // 
            // panelCreateActivity
            // 
            this.panelCreateActivity.BackColor = System.Drawing.Color.Transparent;
            this.panelCreateActivity.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(54)))), ((int)(((byte)(78)))));
            this.panelCreateActivity.Controls.Add(this.comboParticipants);
            this.panelCreateActivity.Controls.Add(this.btnCreate);
            this.panelCreateActivity.Controls.Add(this.txtActivityName);
            this.panelCreateActivity.Controls.Add(this.label5);
            this.panelCreateActivity.Controls.Add(this.label4);
            this.panelCreateActivity.Cursor = System.Windows.Forms.Cursors.Default;
            this.panelCreateActivity.Location = new System.Drawing.Point(25, 18);
            this.panelCreateActivity.Name = "panelCreateActivity";
            this.panelCreateActivity.Size = new System.Drawing.Size(837, 140);
            this.panelCreateActivity.TabIndex = 43;
            // 
            // comboParticipants
            // 
            this.comboParticipants.BackColor = System.Drawing.Color.Transparent;
            this.comboParticipants.BorderRadius = 15;
            this.comboParticipants.BorderThickness = 2;
            this.comboParticipants.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboParticipants.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboParticipants.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.comboParticipants.FocusedColor = System.Drawing.Color.Empty;
            this.comboParticipants.FocusedState.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.comboParticipants.FocusedState.Parent = this.comboParticipants;
            this.comboParticipants.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboParticipants.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.comboParticipants.FormattingEnabled = true;
            this.comboParticipants.HoverState.Parent = this.comboParticipants;
            this.comboParticipants.ItemHeight = 30;
            this.comboParticipants.ItemsAppearance.Parent = this.comboParticipants;
            this.comboParticipants.Location = new System.Drawing.Point(594, 11);
            this.comboParticipants.Name = "comboParticipants";
            this.comboParticipants.ShadowDecoration.Parent = this.comboParticipants;
            this.comboParticipants.Size = new System.Drawing.Size(217, 36);
            this.comboParticipants.TabIndex = 42;
            this.comboParticipants.TextOffset = new System.Drawing.Point(2, 0);
            // 
            // btnCreate
            // 
            this.btnCreate.BorderRadius = 5;
            this.btnCreate.CheckedState.Parent = this.btnCreate;
            this.btnCreate.CustomImages.Parent = this.btnCreate;
            this.btnCreate.FillColor = System.Drawing.Color.MediumSeaGreen;
            this.btnCreate.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.ForeColor = System.Drawing.Color.White;
            this.btnCreate.HoverState.Parent = this.btnCreate;
            this.btnCreate.Location = new System.Drawing.Point(675, 92);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.ShadowDecoration.Parent = this.btnCreate;
            this.btnCreate.Size = new System.Drawing.Size(136, 35);
            this.btnCreate.TabIndex = 41;
            this.btnCreate.Text = "Create";
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // txtActivityName
            // 
            this.txtActivityName.Animated = true;
            this.txtActivityName.BorderColor = System.Drawing.Color.MediumSpringGreen;
            this.txtActivityName.BorderRadius = 10;
            this.txtActivityName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtActivityName.DefaultText = "";
            this.txtActivityName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtActivityName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtActivityName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtActivityName.DisabledState.Parent = this.txtActivityName;
            this.txtActivityName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtActivityName.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.txtActivityName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtActivityName.FocusedState.Parent = this.txtActivityName;
            this.txtActivityName.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtActivityName.ForeColor = System.Drawing.Color.White;
            this.txtActivityName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtActivityName.HoverState.Parent = this.txtActivityName;
            this.txtActivityName.Location = new System.Drawing.Point(119, 13);
            this.txtActivityName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtActivityName.Name = "txtActivityName";
            this.txtActivityName.PasswordChar = '\0';
            this.txtActivityName.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtActivityName.PlaceholderText = "Type activity name";
            this.txtActivityName.SelectedText = "";
            this.txtActivityName.ShadowDecoration.Parent = this.txtActivityName;
            this.txtActivityName.Size = new System.Drawing.Size(200, 30);
            this.txtActivityName.TabIndex = 38;
            this.txtActivityName.TextOffset = new System.Drawing.Point(2, 0);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gainsboro;
            this.label5.Location = new System.Drawing.Point(383, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(205, 32);
            this.label5.TabIndex = 30;
            this.label5.Text = "Person in charge";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gainsboro;
            this.label4.Location = new System.Drawing.Point(11, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 32);
            this.label4.TabIndex = 30;
            this.label4.Text = "Activity";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panelPerformActivity
            // 
            this.panelPerformActivity.BackColor = System.Drawing.Color.Transparent;
            this.panelPerformActivity.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(54)))), ((int)(((byte)(78)))));
            this.panelPerformActivity.Controls.Add(this.btnEndActivity);
            this.panelPerformActivity.Controls.Add(this.comboDebtors);
            this.panelPerformActivity.Controls.Add(this.txtAmount);
            this.panelPerformActivity.Controls.Add(this.btnPay);
            this.panelPerformActivity.Controls.Add(this.dgvDebtorsActivity);
            this.panelPerformActivity.Controls.Add(this.label8);
            this.panelPerformActivity.Controls.Add(this.lblPersonInCharge);
            this.panelPerformActivity.Cursor = System.Windows.Forms.Cursors.Default;
            this.panelPerformActivity.Location = new System.Drawing.Point(25, 188);
            this.panelPerformActivity.Name = "panelPerformActivity";
            this.panelPerformActivity.Size = new System.Drawing.Size(841, 368);
            this.panelPerformActivity.TabIndex = 40;
            this.panelPerformActivity.Visible = false;
            // 
            // btnEndActivity
            // 
            this.btnEndActivity.BorderRadius = 5;
            this.btnEndActivity.CheckedState.Parent = this.btnEndActivity;
            this.btnEndActivity.CustomImages.Parent = this.btnEndActivity;
            this.btnEndActivity.FillColor = System.Drawing.Color.MediumSeaGreen;
            this.btnEndActivity.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEndActivity.ForeColor = System.Drawing.Color.White;
            this.btnEndActivity.HoverState.Parent = this.btnEndActivity;
            this.btnEndActivity.Location = new System.Drawing.Point(634, 297);
            this.btnEndActivity.Name = "btnEndActivity";
            this.btnEndActivity.ShadowDecoration.Parent = this.btnEndActivity;
            this.btnEndActivity.Size = new System.Drawing.Size(177, 35);
            this.btnEndActivity.TabIndex = 43;
            this.btnEndActivity.Text = "Finish Activity";
            this.btnEndActivity.Click += new System.EventHandler(this.btnEndActivity_Click);
            // 
            // comboDebtors
            // 
            this.comboDebtors.BackColor = System.Drawing.Color.Transparent;
            this.comboDebtors.BorderRadius = 15;
            this.comboDebtors.BorderThickness = 2;
            this.comboDebtors.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboDebtors.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboDebtors.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.comboDebtors.FocusedColor = System.Drawing.Color.Empty;
            this.comboDebtors.FocusedState.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.comboDebtors.FocusedState.Parent = this.comboDebtors;
            this.comboDebtors.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboDebtors.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.comboDebtors.FormattingEnabled = true;
            this.comboDebtors.HoverState.Parent = this.comboDebtors;
            this.comboDebtors.ItemHeight = 30;
            this.comboDebtors.ItemsAppearance.Parent = this.comboDebtors;
            this.comboDebtors.Location = new System.Drawing.Point(17, 78);
            this.comboDebtors.Name = "comboDebtors";
            this.comboDebtors.ShadowDecoration.Parent = this.comboDebtors;
            this.comboDebtors.Size = new System.Drawing.Size(217, 36);
            this.comboDebtors.TabIndex = 43;
            this.comboDebtors.TextOffset = new System.Drawing.Point(2, 0);
            // 
            // txtAmount
            // 
            this.txtAmount.Animated = true;
            this.txtAmount.BorderColor = System.Drawing.Color.MediumSpringGreen;
            this.txtAmount.BorderRadius = 10;
            this.txtAmount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAmount.DefaultText = "";
            this.txtAmount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAmount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAmount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAmount.DisabledState.Parent = this.txtAmount;
            this.txtAmount.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAmount.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.txtAmount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtAmount.FocusedState.Parent = this.txtAmount;
            this.txtAmount.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmount.ForeColor = System.Drawing.Color.White;
            this.txtAmount.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAmount.HoverState.Parent = this.txtAmount;
            this.txtAmount.Location = new System.Drawing.Point(246, 78);
            this.txtAmount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.PasswordChar = '\0';
            this.txtAmount.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtAmount.PlaceholderText = "enter amount to pay";
            this.txtAmount.SelectedText = "";
            this.txtAmount.ShadowDecoration.Parent = this.txtAmount;
            this.txtAmount.Size = new System.Drawing.Size(150, 36);
            this.txtAmount.TabIndex = 42;
            this.txtAmount.TextOffset = new System.Drawing.Point(2, 0);
            // 
            // btnPay
            // 
            this.btnPay.BorderRadius = 5;
            this.btnPay.CheckedState.Parent = this.btnPay;
            this.btnPay.CustomImages.Parent = this.btnPay;
            this.btnPay.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnPay.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPay.ForeColor = System.Drawing.Color.White;
            this.btnPay.HoverState.Parent = this.btnPay;
            this.btnPay.Location = new System.Drawing.Point(408, 78);
            this.btnPay.Name = "btnPay";
            this.btnPay.ShadowDecoration.Parent = this.btnPay;
            this.btnPay.Size = new System.Drawing.Size(150, 36);
            this.btnPay.TabIndex = 42;
            this.btnPay.Text = "Pay";
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // dgvDebtorsActivity
            // 
            this.dgvDebtorsActivity.AllowUserToAddRows = false;
            this.dgvDebtorsActivity.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgvDebtorsActivity.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDebtorsActivity.AutoGenerateColumns = false;
            this.dgvDebtorsActivity.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDebtorsActivity.BackgroundColor = System.Drawing.Color.White;
            this.dgvDebtorsActivity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDebtorsActivity.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDebtorsActivity.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDebtorsActivity.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvDebtorsActivity.ColumnHeadersHeight = 21;
            this.dgvDebtorsActivity.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.debtorDataGridViewTextBoxColumn,
            this.debtorNameDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn});
            this.dgvDebtorsActivity.DataSource = this.debtorsBindingSource;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDebtorsActivity.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvDebtorsActivity.EnableHeadersVisualStyles = false;
            this.dgvDebtorsActivity.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDebtorsActivity.Location = new System.Drawing.Point(17, 137);
            this.dgvDebtorsActivity.Name = "dgvDebtorsActivity";
            this.dgvDebtorsActivity.ReadOnly = true;
            this.dgvDebtorsActivity.RowHeadersVisible = false;
            this.dgvDebtorsActivity.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDebtorsActivity.Size = new System.Drawing.Size(541, 195);
            this.dgvDebtorsActivity.TabIndex = 40;
            this.dgvDebtorsActivity.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dgvDebtorsActivity.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvDebtorsActivity.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvDebtorsActivity.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvDebtorsActivity.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvDebtorsActivity.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvDebtorsActivity.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvDebtorsActivity.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDebtorsActivity.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvDebtorsActivity.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvDebtorsActivity.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvDebtorsActivity.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvDebtorsActivity.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvDebtorsActivity.ThemeStyle.HeaderStyle.Height = 21;
            this.dgvDebtorsActivity.ThemeStyle.ReadOnly = true;
            this.dgvDebtorsActivity.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvDebtorsActivity.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDebtorsActivity.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvDebtorsActivity.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvDebtorsActivity.ThemeStyle.RowsStyle.Height = 22;
            this.dgvDebtorsActivity.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDebtorsActivity.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label8.Location = new System.Drawing.Point(10, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(229, 37);
            this.label8.TabIndex = 32;
            this.label8.Text = "Person in charge";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblPersonInCharge
            // 
            this.lblPersonInCharge.AutoSize = true;
            this.lblPersonInCharge.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersonInCharge.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.lblPersonInCharge.Location = new System.Drawing.Point(245, 16);
            this.lblPersonInCharge.Name = "lblPersonInCharge";
            this.lblPersonInCharge.Size = new System.Drawing.Size(104, 37);
            this.lblPersonInCharge.TabIndex = 31;
            this.lblPersonInCharge.Text = "Person";
            this.lblPersonInCharge.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.tabPage3.Controls.Add(this.btnNewTrip);
            this.tabPage3.Controls.Add(this.lblSummary);
            this.tabPage3.Controls.Add(this.btnFinishTrip);
            this.tabPage3.Location = new System.Drawing.Point(4, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(900, 562);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            // 
            // btnNewTrip
            // 
            this.btnNewTrip.BorderRadius = 5;
            this.btnNewTrip.CheckedState.Parent = this.btnNewTrip;
            this.btnNewTrip.CustomImages.Parent = this.btnNewTrip;
            this.btnNewTrip.FillColor = System.Drawing.Color.DarkOrange;
            this.btnNewTrip.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewTrip.ForeColor = System.Drawing.Color.White;
            this.btnNewTrip.HoverState.Parent = this.btnNewTrip;
            this.btnNewTrip.Location = new System.Drawing.Point(730, 28);
            this.btnNewTrip.Name = "btnNewTrip";
            this.btnNewTrip.ShadowDecoration.Parent = this.btnNewTrip;
            this.btnNewTrip.Size = new System.Drawing.Size(136, 35);
            this.btnNewTrip.TabIndex = 44;
            this.btnNewTrip.Text = "New Trip";
            this.btnNewTrip.Visible = false;
            this.btnNewTrip.Click += new System.EventHandler(this.btnNewTrip_Click);
            // 
            // lblSummary
            // 
            this.lblSummary.AutoSize = true;
            this.lblSummary.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSummary.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblSummary.Location = new System.Drawing.Point(16, 92);
            this.lblSummary.Name = "lblSummary";
            this.lblSummary.Size = new System.Drawing.Size(0, 21);
            this.lblSummary.TabIndex = 43;
            this.lblSummary.Visible = false;
            // 
            // btnFinishTrip
            // 
            this.btnFinishTrip.BorderRadius = 5;
            this.btnFinishTrip.CheckedState.Parent = this.btnFinishTrip;
            this.btnFinishTrip.CustomImages.Parent = this.btnFinishTrip;
            this.btnFinishTrip.FillColor = System.Drawing.Color.MediumSeaGreen;
            this.btnFinishTrip.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinishTrip.ForeColor = System.Drawing.Color.White;
            this.btnFinishTrip.HoverState.Parent = this.btnFinishTrip;
            this.btnFinishTrip.Location = new System.Drawing.Point(379, 28);
            this.btnFinishTrip.Name = "btnFinishTrip";
            this.btnFinishTrip.ShadowDecoration.Parent = this.btnFinishTrip;
            this.btnFinishTrip.Size = new System.Drawing.Size(136, 35);
            this.btnFinishTrip.TabIndex = 42;
            this.btnFinishTrip.Text = "Finish Trip";
            this.btnFinishTrip.Click += new System.EventHandler(this.btnFinishTrip_Click);
            // 
            // debtorDataGridViewTextBoxColumn
            // 
            this.debtorDataGridViewTextBoxColumn.DataPropertyName = "Debtor";
            this.debtorDataGridViewTextBoxColumn.HeaderText = "Debtor";
            this.debtorDataGridViewTextBoxColumn.Name = "debtorDataGridViewTextBoxColumn";
            this.debtorDataGridViewTextBoxColumn.ReadOnly = true;
            this.debtorDataGridViewTextBoxColumn.Visible = false;
            // 
            // debtorNameDataGridViewTextBoxColumn
            // 
            this.debtorNameDataGridViewTextBoxColumn.DataPropertyName = "DebtorName";
            this.debtorNameDataGridViewTextBoxColumn.HeaderText = "Debtor";
            this.debtorNameDataGridViewTextBoxColumn.Name = "debtorNameDataGridViewTextBoxColumn";
            this.debtorNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "Amount";
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            this.amountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // debtorsBindingSource
            // 
            this.debtorsBindingSource.DataSource = typeof(TRIP_APP.Models.Debtors);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 619);
            this.Controls.Add(this.MultiPage);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.navBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.navBar.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.MultiPage.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.gunaElipsePanel1.ResumeLayout(false);
            this.gunaElipsePanel1.PerformLayout();
            this.panelDuration.ResumeLayout(false);
            this.panelDuration.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParticipants)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.panelCreateActivity.ResumeLayout(false);
            this.panelCreateActivity.PerformLayout();
            this.panelPerformActivity.ResumeLayout(false);
            this.panelPerformActivity.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDebtorsActivity)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.debtorsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.UI.WinForms.BunifuPages MultiPage;
        private System.Windows.Forms.TabPage tabPage1;
        private Guna.UI.WinForms.GunaElipsePanel gunaElipsePanel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblRegion;
        private Guna.UI.WinForms.GunaElipsePanel panelDuration;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DataGridView dgvParticipants;
        private System.Windows.Forms.TabPage tabPage2;
        private Guna.UI.WinForms.GunaElipsePanel panelCreateActivity;
        private Guna.UI2.WinForms.Guna2ComboBox comboParticipants;
        private Guna.UI2.WinForms.Guna2Button btnCreate;
        private Guna.UI2.WinForms.Guna2TextBox txtActivityName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private Guna.UI.WinForms.GunaElipsePanel panelPerformActivity;
        private Guna.UI2.WinForms.Guna2Button btnEndActivity;
        private Guna.UI2.WinForms.Guna2ComboBox comboDebtors;
        private Guna.UI2.WinForms.Guna2TextBox txtAmount;
        private Guna.UI2.WinForms.Guna2Button btnPay;
        private Guna.UI2.WinForms.Guna2DataGridView dgvDebtorsActivity;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblPersonInCharge;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel Indicator;
        private Guna.UI2.WinForms.Guna2Button btnNewActivity;
        private Guna.UI2.WinForms.Guna2Button btnDashboard;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel navBar;
        private Guna.UI2.WinForms.Guna2CircleButton btnMinimize;
        private Guna.UI2.WinForms.Guna2CircleButton btnExit;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label lblSummary;
        private Guna.UI2.WinForms.Guna2Button btnFinishTrip;
        private Guna.UI2.WinForms.Guna2Button btnSummary;
        private Guna.UI2.WinForms.Guna2Button btnNewTrip;
        private System.Windows.Forms.Panel Indicator2;
        private System.Windows.Forms.BindingSource debtorsBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn debtorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn debtorNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
    }
}