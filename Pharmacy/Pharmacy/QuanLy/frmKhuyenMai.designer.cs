namespace Pharmacy.QuanLy
{
    partial class frmKhuyenMai
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
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.lvhanghoa = new DevComponents.DotNetBar.Controls.ListViewEx();
            this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader8 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.groupPanel2 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbHHKM = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.txtSLKM = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.txtDVKM = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbHH = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.txtDVTban = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX26 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.txtSLBan = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.panel5 = new System.Windows.Forms.Panel();
            this.cmdSua = new DevComponents.DotNetBar.ButtonX();
            this.cmdXoa = new DevComponents.DotNetBar.ButtonX();
            this.cmdThem = new DevComponents.DotNetBar.ButtonX();
            this.groupPanel1.SuspendLayout();
            this.groupPanel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupPanel1
            // 
            this.groupPanel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupPanel1.BackColor = System.Drawing.Color.Transparent;
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.lvhanghoa);
            this.groupPanel1.Location = new System.Drawing.Point(0, 214);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(841, 255);
            // 
            // 
            // 
            this.groupPanel1.Style.BackColor = System.Drawing.Color.Transparent;
            this.groupPanel1.Style.BackColor2 = System.Drawing.Color.Transparent;
            this.groupPanel1.Style.BackColorGradientAngle = 90;
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
            this.groupPanel1.TabIndex = 77;
            this.groupPanel1.Text = "DANH SÁCH KHUYẾN MÃI";
            // 
            // lvhanghoa
            // 
            // 
            // 
            // 
            this.lvhanghoa.Border.Class = "ListViewBorder";
            this.lvhanghoa.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader2,
            this.columnHeader4,
            this.columnHeader1,
            this.columnHeader3,
            this.columnHeader8,
            this.columnHeader5,
            this.columnHeader6});
            this.lvhanghoa.FullRowSelect = true;
            this.lvhanghoa.GridLines = true;
            this.lvhanghoa.Location = new System.Drawing.Point(3, 3);
            this.lvhanghoa.Name = "lvhanghoa";
            this.lvhanghoa.Size = new System.Drawing.Size(829, 230);
            this.lvhanghoa.TabIndex = 71;
            this.lvhanghoa.UseCompatibleStateImageBehavior = false;
            this.lvhanghoa.View = System.Windows.Forms.View.Details;
            this.lvhanghoa.SelectedIndexChanged += new System.EventHandler(this.lvhanghoa_SelectedIndexChanged);
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "STT";
            this.columnHeader7.Width = 51;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên hàng hóa";
            this.columnHeader2.Width = 133;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Đơn vị";
            this.columnHeader4.Width = 72;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "SL mua";
            this.columnHeader1.Width = 81;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Hàng khuyến mãi";
            this.columnHeader3.Width = 137;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Đơn Vị";
            this.columnHeader8.Width = 65;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "SL KM";
            this.columnHeader5.Width = 75;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Ngày KM";
            this.columnHeader6.Width = 80;
            // 
            // groupPanel2
            // 
            this.groupPanel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupPanel2.BackColor = System.Drawing.Color.Transparent;
            this.groupPanel2.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel2.Controls.Add(this.groupBox2);
            this.groupPanel2.Controls.Add(this.groupBox1);
            this.groupPanel2.Controls.Add(this.panel5);
            this.groupPanel2.Location = new System.Drawing.Point(52, 38);
            this.groupPanel2.Name = "groupPanel2";
            this.groupPanel2.Size = new System.Drawing.Size(730, 178);
            // 
            // 
            // 
            this.groupPanel2.Style.BackColor = System.Drawing.Color.Transparent;
            this.groupPanel2.Style.BackColor2 = System.Drawing.Color.Transparent;
            this.groupPanel2.Style.BackColorGradientAngle = 90;
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
            this.groupPanel2.TabIndex = 76;
            this.groupPanel2.Text = "Thông tin";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbHHKM);
            this.groupBox2.Controls.Add(this.labelX4);
            this.groupBox2.Controls.Add(this.txtSLKM);
            this.groupBox2.Controls.Add(this.labelX5);
            this.groupBox2.Controls.Add(this.labelX1);
            this.groupBox2.Controls.Add(this.txtDVKM);
            this.groupBox2.Location = new System.Drawing.Point(396, -7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(323, 105);
            this.groupBox2.TabIndex = 84;
            this.groupBox2.TabStop = false;
            // 
            // cmbHHKM
            // 
            this.cmbHHKM.DisplayMember = "Text";
            this.cmbHHKM.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbHHKM.FormattingEnabled = true;
            this.cmbHHKM.ItemHeight = 18;
            this.cmbHHKM.Location = new System.Drawing.Point(92, 10);
            this.cmbHHKM.Name = "cmbHHKM";
            this.cmbHHKM.Size = new System.Drawing.Size(225, 24);
            this.cmbHHKM.TabIndex = 83;
            this.cmbHHKM.SelectedIndexChanged += new System.EventHandler(this.cmbHHKM_SelectedIndexChanged);
            // 
            // labelX4
            // 
            this.labelX4.Location = new System.Drawing.Point(6, 38);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(62, 25);
            this.labelX4.TabIndex = 80;
            this.labelX4.Text = "DVT:";
            // 
            // txtSLKM
            // 
            // 
            // 
            // 
            this.txtSLKM.Border.Class = "TextBoxBorder";
            this.txtSLKM.Location = new System.Drawing.Point(91, 70);
            this.txtSLKM.Name = "txtSLKM";
            this.txtSLKM.Size = new System.Drawing.Size(225, 24);
            this.txtSLKM.TabIndex = 81;
            // 
            // labelX5
            // 
            this.labelX5.Location = new System.Drawing.Point(6, 11);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(83, 25);
            this.labelX5.TabIndex = 78;
            this.labelX5.Text = "Khuyến mãi:";
            // 
            // labelX1
            // 
            this.labelX1.Location = new System.Drawing.Point(6, 68);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(73, 25);
            this.labelX1.TabIndex = 82;
            this.labelX1.Text = "Số lượng:";
            // 
            // txtDVKM
            // 
            // 
            // 
            // 
            this.txtDVKM.Border.Class = "TextBoxBorder";
            this.txtDVKM.Location = new System.Drawing.Point(91, 40);
            this.txtDVKM.Name = "txtDVKM";
            this.txtDVKM.ReadOnly = true;
            this.txtDVKM.Size = new System.Drawing.Size(225, 24);
            this.txtDVKM.TabIndex = 79;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbHH);
            this.groupBox1.Controls.Add(this.txtDVTban);
            this.groupBox1.Controls.Add(this.labelX26);
            this.groupBox1.Controls.Add(this.labelX2);
            this.groupBox1.Controls.Add(this.labelX3);
            this.groupBox1.Controls.Add(this.txtSLBan);
            this.groupBox1.Location = new System.Drawing.Point(3, -8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(320, 106);
            this.groupBox1.TabIndex = 83;
            this.groupBox1.TabStop = false;
            // 
            // cmbHH
            // 
            this.cmbHH.DisplayMember = "Text";
            this.cmbHH.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbHH.FormattingEnabled = true;
            this.cmbHH.ItemHeight = 18;
            this.cmbHH.Location = new System.Drawing.Point(74, 11);
            this.cmbHH.Name = "cmbHH";
            this.cmbHH.Size = new System.Drawing.Size(215, 24);
            this.cmbHH.TabIndex = 77;
            this.cmbHH.SelectedIndexChanged += new System.EventHandler(this.cmbHH_SelectedIndexChanged);
            // 
            // txtDVTban
            // 
            // 
            // 
            // 
            this.txtDVTban.Border.Class = "TextBoxBorder";
            this.txtDVTban.Location = new System.Drawing.Point(74, 44);
            this.txtDVTban.Name = "txtDVTban";
            this.txtDVTban.ReadOnly = true;
            this.txtDVTban.Size = new System.Drawing.Size(215, 24);
            this.txtDVTban.TabIndex = 73;
            // 
            // labelX26
            // 
            this.labelX26.Location = new System.Drawing.Point(5, 8);
            this.labelX26.Name = "labelX26";
            this.labelX26.Size = new System.Drawing.Size(73, 25);
            this.labelX26.TabIndex = 60;
            this.labelX26.Text = "Tên Hàng:";
            // 
            // labelX2
            // 
            this.labelX2.Location = new System.Drawing.Point(6, 43);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(62, 25);
            this.labelX2.TabIndex = 74;
            this.labelX2.Text = "DVT:";
            // 
            // labelX3
            // 
            this.labelX3.Location = new System.Drawing.Point(4, 73);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(70, 25);
            this.labelX3.TabIndex = 76;
            this.labelX3.Text = "Số lượng:";
            // 
            // txtSLBan
            // 
            // 
            // 
            // 
            this.txtSLBan.Border.Class = "TextBoxBorder";
            this.txtSLBan.Location = new System.Drawing.Point(74, 74);
            this.txtSLBan.Name = "txtSLBan";
            this.txtSLBan.Size = new System.Drawing.Size(215, 24);
            this.txtSLBan.TabIndex = 75;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.SteelBlue;
            this.panel5.Controls.Add(this.cmdSua);
            this.panel5.Controls.Add(this.cmdXoa);
            this.panel5.Controls.Add(this.cmdThem);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 124);
            this.panel5.Margin = new System.Windows.Forms.Padding(0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(724, 29);
            this.panel5.TabIndex = 70;
            // 
            // cmdSua
            // 
            this.cmdSua.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.cmdSua.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.cmdSua.Location = new System.Drawing.Point(156, 2);
            this.cmdSua.Margin = new System.Windows.Forms.Padding(0);
            this.cmdSua.Name = "cmdSua";
            this.cmdSua.Size = new System.Drawing.Size(70, 25);
            this.cmdSua.TabIndex = 54;
            this.cmdSua.Text = "Sửa";
            // 
            // cmdXoa
            // 
            this.cmdXoa.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.cmdXoa.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.cmdXoa.Location = new System.Drawing.Point(238, 2);
            this.cmdXoa.Margin = new System.Windows.Forms.Padding(0);
            this.cmdXoa.Name = "cmdXoa";
            this.cmdXoa.Size = new System.Drawing.Size(70, 25);
            this.cmdXoa.TabIndex = 53;
            this.cmdXoa.Text = "Xóa";
            // 
            // cmdThem
            // 
            this.cmdThem.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.cmdThem.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.cmdThem.Location = new System.Drawing.Point(73, 2);
            this.cmdThem.Margin = new System.Windows.Forms.Padding(0);
            this.cmdThem.Name = "cmdThem";
            this.cmdThem.Size = new System.Drawing.Size(70, 25);
            this.cmdThem.TabIndex = 28;
            this.cmdThem.Text = "Thêm";
            this.cmdThem.Click += new System.EventHandler(this.cmdThem_Click);
            // 
            // frmKhuyenMai
            // 
            this.ClientSize = new System.Drawing.Size(841, 543);
            this.Controls.Add(this.groupPanel1);
            this.Controls.Add(this.groupPanel2);
            this.Name = "frmKhuyenMai";
            this.Text = "Khuyến mãi";
            this.Load += new System.EventHandler(this.frmKhuyenMai_Load);
            this.Controls.SetChildIndex(this.groupPanel2, 0);
            this.Controls.SetChildIndex(this.groupPanel1, 0);
            this.groupPanel1.ResumeLayout(false);
            this.groupPanel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.Controls.ListViewEx lvhanghoa;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel2;
        private System.Windows.Forms.Panel panel5;
        private DevComponents.DotNetBar.ButtonX cmdSua;
        private DevComponents.DotNetBar.ButtonX cmdXoa;
        private DevComponents.DotNetBar.ButtonX cmdThem;
        private DevComponents.DotNetBar.LabelX labelX26;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtDVTban;
        private DevComponents.DotNetBar.LabelX labelX2;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.Controls.TextBoxX txtSLBan;
        private DevComponents.DotNetBar.Controls.TextBoxX txtSLKM;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtDVKM;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX5;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbHHKM;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbHH;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader8;
    }
}
