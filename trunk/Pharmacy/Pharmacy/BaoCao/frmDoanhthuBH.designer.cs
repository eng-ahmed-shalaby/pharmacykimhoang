namespace Pharmacy.BaoCao
{
    partial class frmDoanhthuBH
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
            this.panelTheKho = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.dkpTo = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.dpkfrom = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.cmdShow = new DevComponents.DotNetBar.ButtonX();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.panelTheKho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dkpTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dpkfrom)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTheKho
            // 
            this.panelTheKho.BackColor = System.Drawing.Color.Transparent;
            this.panelTheKho.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelTheKho.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.panelTheKho.Controls.Add(this.dkpTo);
            this.panelTheKho.Controls.Add(this.dpkfrom);
            this.panelTheKho.Controls.Add(this.labelX2);
            this.panelTheKho.Controls.Add(this.labelX3);
            this.panelTheKho.Controls.Add(this.cmdShow);
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
            this.panelTheKho.TabIndex = 77;
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
            this.dkpTo.CustomFormat = "dd/MM/yyyy";
            this.dkpTo.Format = DevComponents.Editors.eDateTimePickerFormat.Custom;
            this.dkpTo.Location = new System.Drawing.Point(473, 5);
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
            this.dkpTo.Size = new System.Drawing.Size(96, 24);
            this.dkpTo.TabIndex = 82;
            // 
            // dpkfrom
            // 
            // 
            // 
            // 
            this.dpkfrom.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dpkfrom.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dpkfrom.ButtonDropDown.Visible = true;
            this.dpkfrom.CustomFormat = "dd/MM/yyyy";
            this.dpkfrom.Format = DevComponents.Editors.eDateTimePickerFormat.Custom;
            this.dpkfrom.Location = new System.Drawing.Point(288, 7);
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
            this.dpkfrom.Size = new System.Drawing.Size(96, 24);
            this.dpkfrom.TabIndex = 81;
            // 
            // labelX2
            // 
            this.labelX2.Location = new System.Drawing.Point(405, 4);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(68, 25);
            this.labelX2.TabIndex = 80;
            this.labelX2.Text = "đến ngày:";
            // 
            // labelX3
            // 
            this.labelX3.Location = new System.Drawing.Point(219, 6);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(63, 25);
            this.labelX3.TabIndex = 79;
            this.labelX3.Text = "Từ ngày:";
            // 
            // cmdShow
            // 
            this.cmdShow.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.cmdShow.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.cmdShow.Location = new System.Drawing.Point(575, 5);
            this.cmdShow.Name = "cmdShow";
            this.cmdShow.Size = new System.Drawing.Size(75, 23);
            this.cmdShow.TabIndex = 77;
            this.cmdShow.Text = "Báo cáo";
            this.cmdShow.Click += new System.EventHandler(this.cmdShow_Click);
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
            this.crystalReportViewer1.TabIndex = 78;
            this.crystalReportViewer1.ViewTimeSelectionFormula = "";
            // 
            // frmDoanhthuBH
            // 
            this.ClientSize = new System.Drawing.Size(992, 746);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.panelTheKho);
            this.Name = "frmDoanhthuBH";
            this.Text = "Doanh Thu Ban Hang";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Controls.SetChildIndex(this.panelTheKho, 0);
            this.Controls.SetChildIndex(this.crystalReportViewer1, 0);
            this.panelTheKho.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dkpTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dpkfrom)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.GroupPanel panelTheKho;
        private DevComponents.DotNetBar.ButtonX cmdShow;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dkpTo;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dpkfrom;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX3;

    }
}
