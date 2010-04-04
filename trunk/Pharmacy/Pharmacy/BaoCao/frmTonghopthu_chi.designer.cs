namespace Pharmacy.BaoCao
{
    partial class frmTonghopthu_chi
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
            this.panelNhapXuat = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.rdKH = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.rdKhac = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.cmdShow = new DevComponents.DotNetBar.ButtonX();
            this.txtNam = new DevComponents.Editors.IntegerInput();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.txtThang = new DevComponents.Editors.IntegerInput();
            this.labelX26 = new DevComponents.DotNetBar.LabelX();
            this.panelNhapXuat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtThang)).BeginInit();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 126);
            this.crystalReportViewer1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.SelectionFormula = "";
            this.crystalReportViewer1.Size = new System.Drawing.Size(992, 620);
            this.crystalReportViewer1.TabIndex = 74;
            this.crystalReportViewer1.ViewTimeSelectionFormula = "";
            // 
            // panelNhapXuat
            // 
            this.panelNhapXuat.BackColor = System.Drawing.Color.Transparent;
            this.panelNhapXuat.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelNhapXuat.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.panelNhapXuat.Controls.Add(this.rdKH);
            this.panelNhapXuat.Controls.Add(this.rdKhac);
            this.panelNhapXuat.Controls.Add(this.cmdShow);
            this.panelNhapXuat.Controls.Add(this.txtNam);
            this.panelNhapXuat.Controls.Add(this.labelX1);
            this.panelNhapXuat.Controls.Add(this.txtThang);
            this.panelNhapXuat.Controls.Add(this.labelX26);
            this.panelNhapXuat.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelNhapXuat.Location = new System.Drawing.Point(0, 35);
            this.panelNhapXuat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelNhapXuat.Name = "panelNhapXuat";
            this.panelNhapXuat.Size = new System.Drawing.Size(992, 91);
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
            this.panelNhapXuat.TabIndex = 73;
            this.panelNhapXuat.Text = "Thông tin";
            // 
            // rdKH
            // 
            this.rdKH.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton;
            this.rdKH.Checked = true;
            this.rdKH.CheckState = System.Windows.Forms.CheckState.Checked;
            this.rdKH.CheckValue = "Y";
            this.rdKH.Location = new System.Drawing.Point(390, 43);
            this.rdKH.Name = "rdKH";
            this.rdKH.Size = new System.Drawing.Size(71, 23);
            this.rdKH.TabIndex = 77;
            this.rdKH.Text = "Thu";
            // 
            // rdKhac
            // 
            this.rdKhac.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton;
            this.rdKhac.Location = new System.Drawing.Point(467, 43);
            this.rdKhac.Name = "rdKhac";
            this.rdKhac.Size = new System.Drawing.Size(95, 23);
            this.rdKhac.TabIndex = 78;
            this.rdKhac.Text = "Chi";
            // 
            // cmdShow
            // 
            this.cmdShow.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.cmdShow.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.cmdShow.Location = new System.Drawing.Point(583, 37);
            this.cmdShow.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmdShow.Name = "cmdShow";
            this.cmdShow.Size = new System.Drawing.Size(86, 28);
            this.cmdShow.TabIndex = 72;
            this.cmdShow.Text = "Báo cáo";
            this.cmdShow.Click += new System.EventHandler(this.cmdShow_Click);
            // 
            // txtNam
            // 
            // 
            // 
            // 
            this.txtNam.BackgroundStyle.Class = "DateTimeInputBackground";
            this.txtNam.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.txtNam.Location = new System.Drawing.Point(526, 7);
            this.txtNam.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNam.Name = "txtNam";
            this.txtNam.ShowUpDown = true;
            this.txtNam.Size = new System.Drawing.Size(64, 24);
            this.txtNam.TabIndex = 71;
            // 
            // labelX1
            // 
            this.labelX1.Location = new System.Drawing.Point(480, 6);
            this.labelX1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(46, 30);
            this.labelX1.TabIndex = 70;
            this.labelX1.Text = "Năm:";
            // 
            // txtThang
            // 
            // 
            // 
            // 
            this.txtThang.BackgroundStyle.Class = "DateTimeInputBackground";
            this.txtThang.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.txtThang.Location = new System.Drawing.Point(390, 6);
            this.txtThang.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtThang.Name = "txtThang";
            this.txtThang.ShowUpDown = true;
            this.txtThang.Size = new System.Drawing.Size(64, 24);
            this.txtThang.TabIndex = 69;
            // 
            // labelX26
            // 
            this.labelX26.Location = new System.Drawing.Point(344, 4);
            this.labelX26.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelX26.Name = "labelX26";
            this.labelX26.Size = new System.Drawing.Size(46, 30);
            this.labelX26.TabIndex = 60;
            this.labelX26.Text = "Tháng:";
            // 
            // frmTonghopthu_chi
            // 
            this.ClientSize = new System.Drawing.Size(992, 746);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.panelNhapXuat);
            this.Name = "frmTonghopthu_chi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Controls.SetChildIndex(this.panelNhapXuat, 0);
            this.Controls.SetChildIndex(this.crystalReportViewer1, 0);
            this.panelNhapXuat.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtNam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtThang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private DevComponents.DotNetBar.Controls.GroupPanel panelNhapXuat;
        private DevComponents.DotNetBar.ButtonX cmdShow;
        private DevComponents.Editors.IntegerInput txtNam;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.Editors.IntegerInput txtThang;
        private DevComponents.DotNetBar.LabelX labelX26;
        private DevComponents.DotNetBar.Controls.CheckBoxX rdKH;
        private DevComponents.DotNetBar.Controls.CheckBoxX rdKhac;
    }
}
