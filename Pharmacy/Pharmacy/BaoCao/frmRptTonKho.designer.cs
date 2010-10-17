namespace Pharmacy.BaoCao
{
    partial class frmTonKho
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
            this.txtNam = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.txtThang = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.cmbKho = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cmdTheKho = new DevComponents.DotNetBar.ButtonX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.panelTheKho.SuspendLayout();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 92);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.SelectionFormula = "";
            this.crystalReportViewer1.Size = new System.Drawing.Size(992, 654);
            this.crystalReportViewer1.TabIndex = 73;
            this.crystalReportViewer1.ViewTimeSelectionFormula = "";
            // 
            // panelTheKho
            // 
            this.panelTheKho.BackColor = System.Drawing.Color.Transparent;
            this.panelTheKho.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelTheKho.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.panelTheKho.Controls.Add(this.txtNam);
            this.panelTheKho.Controls.Add(this.labelX1);
            this.panelTheKho.Controls.Add(this.txtThang);
            this.panelTheKho.Controls.Add(this.cmbKho);
            this.panelTheKho.Controls.Add(this.cmdTheKho);
            this.panelTheKho.Controls.Add(this.labelX3);
            this.panelTheKho.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTheKho.Location = new System.Drawing.Point(0, 32);
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
            // txtNam
            // 
            // 
            // 
            // 
            this.txtNam.Border.Class = "TextBoxBorder";
            this.txtNam.Location = new System.Drawing.Point(546, 4);
            this.txtNam.Name = "txtNam";
            this.txtNam.Size = new System.Drawing.Size(69, 24);
            this.txtNam.TabIndex = 79;
            // 
            // labelX1
            // 
            this.labelX1.Location = new System.Drawing.Point(507, 3);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(43, 25);
            this.labelX1.TabIndex = 78;
            this.labelX1.Text = "Năm:";
            // 
            // txtThang
            // 
            // 
            // 
            // 
            this.txtThang.Border.Class = "TextBoxBorder";
            this.txtThang.Location = new System.Drawing.Point(417, 4);
            this.txtThang.Name = "txtThang";
            this.txtThang.Size = new System.Drawing.Size(69, 24);
            this.txtThang.TabIndex = 77;
            // 
            // cmbKho
            // 
            this.cmbKho.DisplayMember = "Text";
            this.cmbKho.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbKho.FormattingEnabled = true;
            this.cmbKho.ItemHeight = 18;
            this.cmbKho.Location = new System.Drawing.Point(48, -1);
            this.cmbKho.Name = "cmbKho";
            this.cmbKho.Size = new System.Drawing.Size(103, 24);
            this.cmbKho.TabIndex = 75;
            this.cmbKho.Visible = false;
            // 
            // cmdTheKho
            // 
            this.cmdTheKho.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.cmdTheKho.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.cmdTheKho.Location = new System.Drawing.Point(630, 4);
            this.cmdTheKho.Name = "cmdTheKho";
            this.cmdTheKho.Size = new System.Drawing.Size(66, 27);
            this.cmdTheKho.TabIndex = 72;
            this.cmdTheKho.Text = "Báo cáo";
            this.cmdTheKho.Click += new System.EventHandler(this.cmdTheKho_Click);
            // 
            // labelX3
            // 
            this.labelX3.Location = new System.Drawing.Point(370, 4);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(52, 25);
            this.labelX3.TabIndex = 60;
            this.labelX3.Text = "Tháng:";
            // 
            // frmTonKho
            // 
            this.ClientSize = new System.Drawing.Size(992, 746);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.panelTheKho);
            this.Name = "frmTonKho";
            this.Text = "Report KH";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Controls.SetChildIndex(this.panelTheKho, 0);
            this.Controls.SetChildIndex(this.crystalReportViewer1, 0);
            this.panelTheKho.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private DevComponents.DotNetBar.Controls.GroupPanel panelTheKho;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbKho;
        private DevComponents.DotNetBar.ButtonX cmdTheKho;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.Controls.TextBoxX txtNam;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtThang;
    }
}
