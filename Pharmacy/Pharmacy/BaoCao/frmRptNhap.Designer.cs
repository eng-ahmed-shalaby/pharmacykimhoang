namespace Pharmacy.BaoCao
{
    partial class frmRptNhap
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
            this.panelNhapXuat = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.dtpdengay = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.dtpTungay = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.cmdShow = new DevComponents.DotNetBar.ButtonX();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.panelTheKho = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.dkpTo = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.dpkfrom = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.cmbKho = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.cmbTenThuoc = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cmdTheKho = new DevComponents.DotNetBar.ButtonX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.panelNhapXuat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtpdengay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpTungay)).BeginInit();
            this.panelTheKho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dkpTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dpkfrom)).BeginInit();
            this.SuspendLayout();
            // 
            // panelNhapXuat
            // 
            this.panelNhapXuat.BackColor = System.Drawing.Color.Transparent;
            this.panelNhapXuat.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelNhapXuat.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.panelNhapXuat.Controls.Add(this.dtpdengay);
            this.panelNhapXuat.Controls.Add(this.dtpTungay);
            this.panelNhapXuat.Controls.Add(this.labelX6);
            this.panelNhapXuat.Controls.Add(this.labelX7);
            this.panelNhapXuat.Controls.Add(this.cmdShow);
            this.panelNhapXuat.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelNhapXuat.Location = new System.Drawing.Point(0, 32);
            this.panelNhapXuat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelNhapXuat.Name = "panelNhapXuat";
            this.panelNhapXuat.Size = new System.Drawing.Size(1019, 65);
            // 
            // 
            // 
            this.panelNhapXuat.Style.BackColor = System.Drawing.Color.Transparent;
            this.panelNhapXuat.Style.BackColor2 = System.Drawing.Color.Transparent;
            this.panelNhapXuat.Style.BackColorGradientAngle = 90;
            this.panelNhapXuat.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.panelNhapXuat.Style.BorderBottomWidth = 1;
            this.panelNhapXuat.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelNhapXuat.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.panelNhapXuat.Style.BorderLeftWidth = 1;
            this.panelNhapXuat.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.panelNhapXuat.Style.BorderRightWidth = 1;
            this.panelNhapXuat.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.panelNhapXuat.Style.BorderTopWidth = 1;
            this.panelNhapXuat.Style.CornerDiameter = 4;
            this.panelNhapXuat.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.panelNhapXuat.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.panelNhapXuat.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelNhapXuat.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            this.panelNhapXuat.TabIndex = 69;
            this.panelNhapXuat.Text = "Thông tin";
            // 
            // dtpdengay
            // 
            // 
            // 
            // 
            this.dtpdengay.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dtpdengay.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dtpdengay.ButtonDropDown.Visible = true;
            this.dtpdengay.CustomFormat = "dd/MM/yyyy";
            this.dtpdengay.Format = DevComponents.Editors.eDateTimePickerFormat.Custom;
            this.dtpdengay.Location = new System.Drawing.Point(502, 9);
            // 
            // 
            // 
            this.dtpdengay.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtpdengay.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.dtpdengay.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dtpdengay.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dtpdengay.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dtpdengay.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dtpdengay.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dtpdengay.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dtpdengay.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dtpdengay.MonthCalendar.DisplayMonth = new System.DateTime(2009, 12, 1, 0, 0, 0, 0);
            this.dtpdengay.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dtpdengay.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtpdengay.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dtpdengay.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dtpdengay.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dtpdengay.MonthCalendar.TodayButtonVisible = true;
            this.dtpdengay.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dtpdengay.Name = "dtpdengay";
            this.dtpdengay.Size = new System.Drawing.Size(106, 24);
            this.dtpdengay.TabIndex = 86;
            // 
            // dtpTungay
            // 
            // 
            // 
            // 
            this.dtpTungay.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dtpTungay.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dtpTungay.ButtonDropDown.Visible = true;
            this.dtpTungay.CustomFormat = "dd/MM/yyyy";
            this.dtpTungay.Format = DevComponents.Editors.eDateTimePickerFormat.Custom;
            this.dtpTungay.Location = new System.Drawing.Point(305, 8);
            // 
            // 
            // 
            this.dtpTungay.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtpTungay.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.dtpTungay.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dtpTungay.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dtpTungay.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dtpTungay.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dtpTungay.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dtpTungay.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dtpTungay.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dtpTungay.MonthCalendar.DisplayMonth = new System.DateTime(2009, 12, 1, 0, 0, 0, 0);
            this.dtpTungay.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dtpTungay.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtpTungay.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dtpTungay.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dtpTungay.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dtpTungay.MonthCalendar.TodayButtonVisible = true;
            this.dtpTungay.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dtpTungay.Name = "dtpTungay";
            this.dtpTungay.Size = new System.Drawing.Size(112, 24);
            this.dtpTungay.TabIndex = 85;
            // 
            // labelX6
            // 
            this.labelX6.Location = new System.Drawing.Point(435, 8);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(83, 25);
            this.labelX6.TabIndex = 84;
            this.labelX6.Text = "đến ngày:";
            // 
            // labelX7
            // 
            this.labelX7.Location = new System.Drawing.Point(243, 7);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(72, 25);
            this.labelX7.TabIndex = 83;
            this.labelX7.Text = "Từ ngày:";
            // 
            // cmdShow
            // 
            this.cmdShow.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.cmdShow.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.cmdShow.Location = new System.Drawing.Point(614, 7);
            this.cmdShow.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmdShow.Name = "cmdShow";
            this.cmdShow.Size = new System.Drawing.Size(79, 28);
            this.cmdShow.TabIndex = 72;
            this.cmdShow.Text = "&Báo cáo";
            this.cmdShow.Click += new System.EventHandler(this.cmdShow_Click);
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 162);
            this.crystalReportViewer1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.SelectionFormula = "";
            this.crystalReportViewer1.Size = new System.Drawing.Size(1019, 584);
            this.crystalReportViewer1.TabIndex = 70;
            this.crystalReportViewer1.ViewTimeSelectionFormula = "";
            // 
            // panelTheKho
            // 
            this.panelTheKho.BackColor = System.Drawing.Color.Transparent;
            this.panelTheKho.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelTheKho.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.panelTheKho.Controls.Add(this.dkpTo);
            this.panelTheKho.Controls.Add(this.dpkfrom);
            this.panelTheKho.Controls.Add(this.labelX5);
            this.panelTheKho.Controls.Add(this.cmbKho);
            this.panelTheKho.Controls.Add(this.labelX4);
            this.panelTheKho.Controls.Add(this.cmbTenThuoc);
            this.panelTheKho.Controls.Add(this.cmdTheKho);
            this.panelTheKho.Controls.Add(this.labelX2);
            this.panelTheKho.Controls.Add(this.labelX3);
            this.panelTheKho.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTheKho.Location = new System.Drawing.Point(0, 97);
            this.panelTheKho.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelTheKho.Name = "panelTheKho";
            this.panelTheKho.Size = new System.Drawing.Size(1019, 65);
            // 
            // 
            // 
            this.panelTheKho.Style.BackColor = System.Drawing.Color.Transparent;
            this.panelTheKho.Style.BackColor2 = System.Drawing.Color.Transparent;
            this.panelTheKho.Style.BackColorGradientAngle = 90;
            this.panelTheKho.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.panelTheKho.Style.BorderBottomWidth = 1;
            this.panelTheKho.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelTheKho.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.panelTheKho.Style.BorderLeftWidth = 1;
            this.panelTheKho.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.panelTheKho.Style.BorderRightWidth = 1;
            this.panelTheKho.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.panelTheKho.Style.BorderTopWidth = 1;
            this.panelTheKho.Style.CornerDiameter = 4;
            this.panelTheKho.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.panelTheKho.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.panelTheKho.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelTheKho.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            this.panelTheKho.TabIndex = 71;
            this.panelTheKho.Text = "Thông tin";
            // 
            // dkpTo
            // 
            // 
            // 
            // 
            this.dkpTo.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dkpTo.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dkpTo.ButtonDropDown.Visible = true;
            this.dkpTo.Location = new System.Drawing.Point(780, 9);
            this.dkpTo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            // 
            // 
            // 
            this.dkpTo.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dkpTo.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.dkpTo.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dkpTo.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dkpTo.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dkpTo.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dkpTo.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dkpTo.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dkpTo.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dkpTo.MonthCalendar.DisplayMonth = new System.DateTime(2009, 12, 1, 0, 0, 0, 0);
            this.dkpTo.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dkpTo.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dkpTo.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dkpTo.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dkpTo.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dkpTo.MonthCalendar.TodayButtonVisible = true;
            this.dkpTo.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dkpTo.Name = "dkpTo";
            this.dkpTo.Size = new System.Drawing.Size(110, 24);
            this.dkpTo.TabIndex = 78;
            // 
            // dpkfrom
            // 
            // 
            // 
            // 
            this.dpkfrom.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dpkfrom.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dpkfrom.ButtonDropDown.Visible = true;
            this.dpkfrom.Location = new System.Drawing.Point(567, 9);
            this.dpkfrom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            // 
            // 
            // 
            this.dpkfrom.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dpkfrom.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.dpkfrom.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dpkfrom.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dpkfrom.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dpkfrom.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dpkfrom.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dpkfrom.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dpkfrom.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dpkfrom.MonthCalendar.DisplayMonth = new System.DateTime(2009, 12, 1, 0, 0, 0, 0);
            this.dpkfrom.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dpkfrom.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dpkfrom.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dpkfrom.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dpkfrom.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dpkfrom.MonthCalendar.TodayButtonVisible = true;
            this.dpkfrom.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dpkfrom.Name = "dpkfrom";
            this.dpkfrom.Size = new System.Drawing.Size(110, 24);
            this.dpkfrom.TabIndex = 77;
            // 
            // labelX5
            // 
            this.labelX5.Location = new System.Drawing.Point(278, 7);
            this.labelX5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(38, 30);
            this.labelX5.TabIndex = 76;
            this.labelX5.Text = "Kho:";
            // 
            // cmbKho
            // 
            this.cmbKho.DisplayMember = "Text";
            this.cmbKho.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbKho.FormattingEnabled = true;
            this.cmbKho.ItemHeight = 18;
            this.cmbKho.Location = new System.Drawing.Point(321, 9);
            this.cmbKho.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbKho.Name = "cmbKho";
            this.cmbKho.Size = new System.Drawing.Size(117, 24);
            this.cmbKho.TabIndex = 75;
            // 
            // labelX4
            // 
            this.labelX4.Location = new System.Drawing.Point(3, 6);
            this.labelX4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(71, 30);
            this.labelX4.TabIndex = 74;
            this.labelX4.Text = "Hàng hóa:";
            // 
            // cmbTenThuoc
            // 
            this.cmbTenThuoc.DisplayMember = "Text";
            this.cmbTenThuoc.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbTenThuoc.FormattingEnabled = true;
            this.cmbTenThuoc.ItemHeight = 18;
            this.cmbTenThuoc.Location = new System.Drawing.Point(73, 9);
            this.cmbTenThuoc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbTenThuoc.Name = "cmbTenThuoc";
            this.cmbTenThuoc.Size = new System.Drawing.Size(188, 24);
            this.cmbTenThuoc.TabIndex = 73;
            // 
            // cmdTheKho
            // 
            this.cmdTheKho.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.cmdTheKho.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.cmdTheKho.Location = new System.Drawing.Point(896, 6);
            this.cmdTheKho.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmdTheKho.Name = "cmdTheKho";
            this.cmdTheKho.Size = new System.Drawing.Size(78, 28);
            this.cmdTheKho.TabIndex = 72;
            this.cmdTheKho.Text = "Báo cáo";
            this.cmdTheKho.Click += new System.EventHandler(this.cmdTheKho_Click);
            // 
            // labelX2
            // 
            this.labelX2.Location = new System.Drawing.Point(714, 5);
            this.labelX2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(65, 30);
            this.labelX2.TabIndex = 70;
            this.labelX2.Text = "đến ngày:";
            // 
            // labelX3
            // 
            this.labelX3.Location = new System.Drawing.Point(502, 7);
            this.labelX3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(59, 30);
            this.labelX3.TabIndex = 60;
            this.labelX3.Text = "Từ ngày:";
            // 
            // frmRptNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 746);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.panelTheKho);
            this.Controls.Add(this.panelNhapXuat);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmRptNhap";
            this.Text = "frmRptNhap";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Controls.SetChildIndex(this.panelNhapXuat, 0);
            this.Controls.SetChildIndex(this.panelTheKho, 0);
            this.Controls.SetChildIndex(this.crystalReportViewer1, 0);
            this.panelNhapXuat.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtpdengay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpTungay)).EndInit();
            this.panelTheKho.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dkpTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dpkfrom)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.GroupPanel panelNhapXuat;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private DevComponents.DotNetBar.ButtonX cmdShow;
        private DevComponents.DotNetBar.Controls.GroupPanel panelTheKho;
        private DevComponents.DotNetBar.ButtonX cmdTheKho;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbKho;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbTenThuoc;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dpkfrom;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dkpTo;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtpdengay;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtpTungay;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.LabelX labelX7;

    }
}