namespace Pharmacy.QuanLy
{
    partial class frmNCC
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
            this.lvNCC = new DevComponents.DotNetBar.Controls.ListViewEx();
            this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader9 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader10 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader11 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader12 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader13 = new System.Windows.Forms.ColumnHeader();
            this.groupPanel2 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.txtMST = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.txtDiaChi = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtDienThoai = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.txtMa = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.cmdNhomNCC = new DevComponents.DotNetBar.ButtonX();
            this.panel5 = new System.Windows.Forms.Panel();
            this.cmdSua = new DevComponents.DotNetBar.ButtonX();
            this.cmdXoa = new DevComponents.DotNetBar.ButtonX();
            this.cmdThem = new DevComponents.DotNetBar.ButtonX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.cmb_NhomNCC = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboItem3 = new DevComponents.Editors.ComboItem();
            this.comboItem4 = new DevComponents.Editors.ComboItem();
            this.labelX23 = new DevComponents.DotNetBar.LabelX();
            this.labelX25 = new DevComponents.DotNetBar.LabelX();
            this.txtTen = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX26 = new DevComponents.DotNetBar.LabelX();
            this.cmb_QG = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboItem1 = new DevComponents.Editors.ComboItem();
            this.comboItem2 = new DevComponents.Editors.ComboItem();
            this.groupPanel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvNCC
            // 
            this.lvNCC.Anchor = System.Windows.Forms.AnchorStyles.Top;
            // 
            // 
            // 
            this.lvNCC.Border.Class = "ListViewBorder";
            this.lvNCC.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12,
            this.columnHeader13});
            this.lvNCC.FullRowSelect = true;
            this.lvNCC.GridLines = true;
            this.lvNCC.Location = new System.Drawing.Point(33, 245);
            this.lvNCC.Name = "lvNCC";
            this.lvNCC.Size = new System.Drawing.Size(740, 161);
            this.lvNCC.TabIndex = 72;
            this.lvNCC.UseCompatibleStateImageBehavior = false;
            this.lvNCC.View = System.Windows.Forms.View.Details;
            this.lvNCC.SelectedIndexChanged += new System.EventHandler(this.lvNCC_SelectedIndexChanged);
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "STT";
            this.columnHeader7.Width = 50;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Code";
            this.columnHeader2.Width = 62;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Tên";
            this.columnHeader3.Width = 194;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Nhóm";
            this.columnHeader9.Width = 98;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Quốc gia";
            this.columnHeader10.Width = 81;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Địa chỉ";
            this.columnHeader11.Width = 74;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Điện thoại";
            this.columnHeader12.Width = 80;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "MST";
            this.columnHeader13.Width = 93;
            // 
            // groupPanel2
            // 
            this.groupPanel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupPanel2.BackColor = System.Drawing.Color.Transparent;
            this.groupPanel2.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel2.Controls.Add(this.txtMST);
            this.groupPanel2.Controls.Add(this.labelX1);
            this.groupPanel2.Controls.Add(this.txtDiaChi);
            this.groupPanel2.Controls.Add(this.txtDienThoai);
            this.groupPanel2.Controls.Add(this.labelX4);
            this.groupPanel2.Controls.Add(this.txtMa);
            this.groupPanel2.Controls.Add(this.labelX3);
            this.groupPanel2.Controls.Add(this.cmdNhomNCC);
            this.groupPanel2.Controls.Add(this.panel5);
            this.groupPanel2.Controls.Add(this.labelX2);
            this.groupPanel2.Controls.Add(this.cmb_NhomNCC);
            this.groupPanel2.Controls.Add(this.labelX23);
            this.groupPanel2.Controls.Add(this.labelX25);
            this.groupPanel2.Controls.Add(this.txtTen);
            this.groupPanel2.Controls.Add(this.labelX26);
            this.groupPanel2.Controls.Add(this.cmb_QG);
            this.groupPanel2.Location = new System.Drawing.Point(33, 38);
            this.groupPanel2.Name = "groupPanel2";
            this.groupPanel2.Size = new System.Drawing.Size(740, 201);
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
            this.groupPanel2.TabIndex = 0;
            this.groupPanel2.Text = "THÔNG TIN THUỐC";
            // 
            // txtMST
            // 
            // 
            // 
            // 
            this.txtMST.Border.Class = "TextBoxBorder";
            this.txtMST.FocusHighlightEnabled = true;
            this.txtMST.Location = new System.Drawing.Point(106, 111);
            this.txtMST.Name = "txtMST";
            this.txtMST.Size = new System.Drawing.Size(193, 24);
            this.txtMST.TabIndex = 3;
            // 
            // labelX1
            // 
            this.labelX1.Location = new System.Drawing.Point(21, 110);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(70, 25);
            this.labelX1.TabIndex = 81;
            this.labelX1.Text = "Mã Thuế:";
            // 
            // txtDiaChi
            // 
            // 
            // 
            // 
            this.txtDiaChi.Border.Class = "TextBoxBorder";
            this.txtDiaChi.FocusHighlightEnabled = true;
            this.txtDiaChi.Location = new System.Drawing.Point(466, 45);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(193, 24);
            this.txtDiaChi.TabIndex = 5;
            // 
            // txtDienThoai
            // 
            // 
            // 
            // 
            this.txtDienThoai.Border.Class = "TextBoxBorder";
            this.txtDienThoai.FocusHighlightEnabled = true;
            this.txtDienThoai.Location = new System.Drawing.Point(466, 10);
            this.txtDienThoai.Name = "txtDienThoai";
            this.txtDienThoai.Size = new System.Drawing.Size(193, 24);
            this.txtDienThoai.TabIndex = 4;
            // 
            // labelX4
            // 
            this.labelX4.Location = new System.Drawing.Point(373, 10);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(77, 25);
            this.labelX4.TabIndex = 77;
            this.labelX4.Text = "Điện thoại:";
            // 
            // txtMa
            // 
            // 
            // 
            // 
            this.txtMa.Border.Class = "TextBoxBorder";
            this.txtMa.FocusHighlightEnabled = true;
            this.txtMa.Location = new System.Drawing.Point(106, 14);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(193, 24);
            this.txtMa.TabIndex = 0;
            // 
            // labelX3
            // 
            this.labelX3.Location = new System.Drawing.Point(21, 12);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(70, 25);
            this.labelX3.TabIndex = 76;
            this.labelX3.Text = "Mã NCC:";
            // 
            // cmdNhomNCC
            // 
            this.cmdNhomNCC.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.cmdNhomNCC.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.cmdNhomNCC.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdNhomNCC.Location = new System.Drawing.Point(274, 80);
            this.cmdNhomNCC.Name = "cmdNhomNCC";
            this.cmdNhomNCC.Size = new System.Drawing.Size(25, 25);
            this.cmdNhomNCC.TabIndex = 74;
            this.cmdNhomNCC.Text = "+";
            this.cmdNhomNCC.Click += new System.EventHandler(this.cmdNhomNCC_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.SteelBlue;
            this.panel5.Controls.Add(this.cmdSua);
            this.panel5.Controls.Add(this.cmdXoa);
            this.panel5.Controls.Add(this.cmdThem);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 146);
            this.panel5.Margin = new System.Windows.Forms.Padding(0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(734, 30);
            this.panel5.TabIndex = 7;
            // 
            // cmdSua
            // 
            this.cmdSua.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.cmdSua.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.cmdSua.Location = new System.Drawing.Point(323, 2);
            this.cmdSua.Margin = new System.Windows.Forms.Padding(0);
            this.cmdSua.Name = "cmdSua";
            this.cmdSua.Size = new System.Drawing.Size(70, 27);
            this.cmdSua.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2010;
            this.cmdSua.TabIndex = 1;
            this.cmdSua.Text = "Sửa";
            this.cmdSua.Click += new System.EventHandler(this.cmdSua_Click);
            // 
            // cmdXoa
            // 
            this.cmdXoa.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.cmdXoa.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.cmdXoa.Location = new System.Drawing.Point(405, 2);
            this.cmdXoa.Margin = new System.Windows.Forms.Padding(0);
            this.cmdXoa.Name = "cmdXoa";
            this.cmdXoa.Size = new System.Drawing.Size(70, 27);
            this.cmdXoa.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2010;
            this.cmdXoa.TabIndex = 2;
            this.cmdXoa.Text = "Xóa";
            this.cmdXoa.Click += new System.EventHandler(this.cmdXoa_Click);
            // 
            // cmdThem
            // 
            this.cmdThem.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.cmdThem.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.cmdThem.Location = new System.Drawing.Point(240, 2);
            this.cmdThem.Margin = new System.Windows.Forms.Padding(0);
            this.cmdThem.Name = "cmdThem";
            this.cmdThem.Size = new System.Drawing.Size(70, 27);
            this.cmdThem.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2010;
            this.cmdThem.TabIndex = 0;
            this.cmdThem.Text = "Thêm";
            this.cmdThem.Click += new System.EventHandler(this.cmdThem_Click);
            // 
            // labelX2
            // 
            this.labelX2.Location = new System.Drawing.Point(21, 78);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(83, 25);
            this.labelX2.TabIndex = 72;
            this.labelX2.Text = "Nhóm NCC:";
            // 
            // cmb_NhomNCC
            // 
            this.cmb_NhomNCC.DisplayMember = "Text";
            this.cmb_NhomNCC.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_NhomNCC.FocusHighlightEnabled = true;
            this.cmb_NhomNCC.FormattingEnabled = true;
            this.cmb_NhomNCC.ItemHeight = 18;
            this.cmb_NhomNCC.Items.AddRange(new object[] {
            this.comboItem3,
            this.comboItem4});
            this.cmb_NhomNCC.Location = new System.Drawing.Point(106, 80);
            this.cmb_NhomNCC.Name = "cmb_NhomNCC";
            this.cmb_NhomNCC.Size = new System.Drawing.Size(167, 24);
            this.cmb_NhomNCC.TabIndex = 2;
            // 
            // comboItem3
            // 
            this.comboItem3.Text = "Nhập hàng";
            // 
            // comboItem4
            // 
            this.comboItem4.Text = "Trả hàng";
            // 
            // labelX23
            // 
            this.labelX23.Location = new System.Drawing.Point(371, 81);
            this.labelX23.Name = "labelX23";
            this.labelX23.Size = new System.Drawing.Size(93, 25);
            this.labelX23.TabIndex = 58;
            this.labelX23.Text = "Quốc gia:";
            // 
            // labelX25
            // 
            this.labelX25.Location = new System.Drawing.Point(373, 42);
            this.labelX25.Name = "labelX25";
            this.labelX25.Size = new System.Drawing.Size(73, 25);
            this.labelX25.TabIndex = 59;
            this.labelX25.Text = "Địa chỉ:";
            // 
            // txtTen
            // 
            // 
            // 
            // 
            this.txtTen.Border.Class = "TextBoxBorder";
            this.txtTen.FocusHighlightEnabled = true;
            this.txtTen.Location = new System.Drawing.Point(106, 45);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(193, 24);
            this.txtTen.TabIndex = 1;
            // 
            // labelX26
            // 
            this.labelX26.Location = new System.Drawing.Point(21, 43);
            this.labelX26.Name = "labelX26";
            this.labelX26.Size = new System.Drawing.Size(70, 25);
            this.labelX26.TabIndex = 60;
            this.labelX26.Text = "Tên NCC:";
            // 
            // cmb_QG
            // 
            this.cmb_QG.DisplayMember = "Text";
            this.cmb_QG.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_QG.FocusHighlightEnabled = true;
            this.cmb_QG.FormattingEnabled = true;
            this.cmb_QG.ItemHeight = 18;
            this.cmb_QG.Items.AddRange(new object[] {
            this.comboItem1,
            this.comboItem2});
            this.cmb_QG.Location = new System.Drawing.Point(466, 80);
            this.cmb_QG.Name = "cmb_QG";
            this.cmb_QG.Size = new System.Drawing.Size(193, 24);
            this.cmb_QG.TabIndex = 6;
            // 
            // comboItem1
            // 
            this.comboItem1.Text = "Nhập hàng";
            // 
            // comboItem2
            // 
            this.comboItem2.Text = "Trả hàng";
            // 
            // frmNCC
            // 
            this.ClientSize = new System.Drawing.Size(792, 466);
            this.Controls.Add(this.groupPanel2);
            this.Controls.Add(this.lvNCC);
            this.Name = "frmNCC";
            this.Text = "Quản lý nhà cung cấp";
            this.Load += new System.EventHandler(this.frmNCC_Load);
            this.Controls.SetChildIndex(this.lvNCC, 0);
            this.Controls.SetChildIndex(this.groupPanel2, 0);
            this.groupPanel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.ListViewEx lvNCC;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel2;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.Controls.TextBoxX txtMa;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.ButtonX cmdNhomNCC;
        private System.Windows.Forms.Panel panel5;
        private DevComponents.DotNetBar.ButtonX cmdSua;
        private DevComponents.DotNetBar.ButtonX cmdXoa;
        private DevComponents.DotNetBar.ButtonX cmdThem;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmb_NhomNCC;
        private DevComponents.Editors.ComboItem comboItem3;
        private DevComponents.Editors.ComboItem comboItem4;
        private DevComponents.DotNetBar.LabelX labelX23;
        private DevComponents.DotNetBar.LabelX labelX25;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTen;
        private DevComponents.DotNetBar.LabelX labelX26;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmb_QG;
        private DevComponents.Editors.ComboItem comboItem1;
        private DevComponents.Editors.ComboItem comboItem2;
        private DevComponents.DotNetBar.Controls.TextBoxX txtDiaChi;
        private DevComponents.DotNetBar.Controls.TextBoxX txtDienThoai;
        private DevComponents.DotNetBar.Controls.TextBoxX txtMST;
        private DevComponents.DotNetBar.LabelX labelX1;

    }
}