namespace Pharmacy.BaoCao
{
    partial class frmRptKH
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
            this.panelTheKho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dkpTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dpkfrom)).BeginInit();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 95);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.SelectionFormula = "";
            this.crystalReportViewer1.Size = new System.Drawing.Size(992, 651);
            this.crystalReportViewer1.TabIndex = 73;
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
            this.panelTheKho.Location = new System.Drawing.Point(0, 35);
            this.panelTheKho.Name = "panelTheKho";
            this.panelTheKho.Size = new System.Drawing.Size(992, 60);
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
            this.panelTheKho.TabIndex = 74;
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
            this.dkpTo.Location = new System.Drawing.Point(683, 8);
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
            this.dkpTo.Size = new System.Drawing.Size(96, 22);
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
            this.dpkfrom.Location = new System.Drawing.Point(518, 8);
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
            this.dpkfrom.Size = new System.Drawing.Size(96, 22);
            this.dpkfrom.TabIndex = 77;
            // 
            // labelX5
            // 
            this.labelX5.Location = new System.Drawing.Point(312, 9);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(33, 25);
            this.labelX5.TabIndex = 76;
            this.labelX5.Text = "Kho:";
            // 
            // cmbKho
            // 
            this.cmbKho.DisplayMember = "Text";
            this.cmbKho.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbKho.FormattingEnabled = true;
            this.cmbKho.ItemHeight = 16;
            this.cmbKho.Location = new System.Drawing.Point(351, 9);
            this.cmbKho.Name = "cmbKho";
            this.cmbKho.Size = new System.Drawing.Size(103, 22);
            this.cmbKho.TabIndex = 75;
            // 
            // labelX4
            // 
            this.labelX4.Location = new System.Drawing.Point(30, 5);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(92, 25);
            this.labelX4.TabIndex = 74;
            this.labelX4.Text = "Khách hàng:";
            // 
            // cmbTenThuoc
            // 
            this.cmbTenThuoc.DisplayMember = "Text";
            this.cmbTenThuoc.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbTenThuoc.FormattingEnabled = true;
            this.cmbTenThuoc.ItemHeight = 16;
            this.cmbTenThuoc.Location = new System.Drawing.Point(128, 8);
            this.cmbTenThuoc.Name = "cmbTenThuoc";
            this.cmbTenThuoc.Size = new System.Drawing.Size(165, 22);
            this.cmbTenThuoc.TabIndex = 73;
            // 
            // cmdTheKho
            // 
            this.cmdTheKho.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.cmdTheKho.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.cmdTheKho.Location = new System.Drawing.Point(795, 7);
            this.cmdTheKho.Name = "cmdTheKho";
            this.cmdTheKho.Size = new System.Drawing.Size(75, 23);
            this.cmdTheKho.TabIndex = 72;
            this.cmdTheKho.Text = "Báo cáo";
            // 
            // labelX2
            // 
            this.labelX2.Location = new System.Drawing.Point(620, 9);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(57, 25);
            this.labelX2.TabIndex = 70;
            this.labelX2.Text = "đến ngày:";
            // 
            // labelX3
            // 
            this.labelX3.Location = new System.Drawing.Point(460, 9);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(52, 25);
            this.labelX3.TabIndex = 60;
            this.labelX3.Text = "Từ ngày:";
            // 
            // frmRptKH
            // 
            this.ClientSize = new System.Drawing.Size(992, 746);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.panelTheKho);
            this.Name = "frmRptKH";
            this.Text = "Report KH";
            this.Controls.SetChildIndex(this.panelTheKho, 0);
            this.Controls.SetChildIndex(this.crystalReportViewer1, 0);
            this.panelTheKho.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dkpTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dpkfrom)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private DevComponents.DotNetBar.Controls.GroupPanel panelTheKho;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dkpTo;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dpkfrom;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbKho;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbTenThuoc;
        private DevComponents.DotNetBar.ButtonX cmdTheKho;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX3;
    }
}
