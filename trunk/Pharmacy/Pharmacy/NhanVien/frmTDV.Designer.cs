namespace Pharmacy.NhanVien
{
    partial class frmTDV
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
            this.lvTDV = new DevComponents.DotNetBar.Controls.ListViewEx();
            this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader9 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader10 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader11 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.groupPanel2 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.lable = new DevComponents.DotNetBar.LabelX();
            this.txtMK = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.txtTenDN = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.txtTuoi = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtdienthoai = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.cmbSua = new DevComponents.DotNetBar.ButtonX();
            this.cmdXoa = new DevComponents.DotNetBar.ButtonX();
            this.cmdThem = new DevComponents.DotNetBar.ButtonX();
            this.txt_codeTDV = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.panel5 = new System.Windows.Forms.Panel();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX27 = new DevComponents.DotNetBar.LabelX();
            this.txt_diachi = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txt_tenTDV = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX26 = new DevComponents.DotNetBar.LabelX();
            this.groupPanel1.SuspendLayout();
            this.groupPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupPanel1
            // 
            this.groupPanel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupPanel1.BackColor = System.Drawing.Color.Transparent;
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.lvTDV);
            this.groupPanel1.Location = new System.Drawing.Point(15, 260);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(877, 255);
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
            this.groupPanel1.Text = "DANH SÁCH TRÌNH DƯỢC VIÊN";
            // 
            // lvTDV
            // 
            // 
            // 
            // 
            this.lvTDV.Border.Class = "ListViewBorder";
            this.lvTDV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader2,
            this.columnHeader9,
            this.columnHeader5,
            this.columnHeader10,
            this.columnHeader3,
            this.columnHeader11,
            this.columnHeader6});
            this.lvTDV.Font = new System.Drawing.Font("Arial", 11F);
            this.lvTDV.FullRowSelect = true;
            this.lvTDV.GridLines = true;
            this.lvTDV.Location = new System.Drawing.Point(7, 3);
            this.lvTDV.Name = "lvTDV";
            this.lvTDV.Size = new System.Drawing.Size(864, 226);
            this.lvTDV.TabIndex = 71;
            this.lvTDV.UseCompatibleStateImageBehavior = false;
            this.lvTDV.View = System.Windows.Forms.View.Details;
            this.lvTDV.SelectedIndexChanged += new System.EventHandler(this.lvTDV_SelectedIndexChanged);
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "STT";
            this.columnHeader7.Width = 54;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Mã TDV";
            this.columnHeader2.Width = 80;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Tên TDV";
            this.columnHeader9.Width = 240;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Tên DN";
            this.columnHeader5.Width = 111;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Tuổi";
            this.columnHeader10.Width = 77;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Điện Thoại";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Địa chỉ";
            this.columnHeader11.Width = 200;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Ma";
            this.columnHeader6.Width = 0;
            // 
            // groupPanel2
            // 
            this.groupPanel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupPanel2.BackColor = System.Drawing.Color.Transparent;
            this.groupPanel2.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel2.Controls.Add(this.lable);
            this.groupPanel2.Controls.Add(this.txtMK);
            this.groupPanel2.Controls.Add(this.labelX2);
            this.groupPanel2.Controls.Add(this.txtTenDN);
            this.groupPanel2.Controls.Add(this.labelX6);
            this.groupPanel2.Controls.Add(this.txtTuoi);
            this.groupPanel2.Controls.Add(this.txtdienthoai);
            this.groupPanel2.Controls.Add(this.cmbSua);
            this.groupPanel2.Controls.Add(this.cmdXoa);
            this.groupPanel2.Controls.Add(this.cmdThem);
            this.groupPanel2.Controls.Add(this.txt_codeTDV);
            this.groupPanel2.Controls.Add(this.labelX3);
            this.groupPanel2.Controls.Add(this.panel5);
            this.groupPanel2.Controls.Add(this.labelX1);
            this.groupPanel2.Controls.Add(this.labelX27);
            this.groupPanel2.Controls.Add(this.txt_diachi);
            this.groupPanel2.Controls.Add(this.txt_tenTDV);
            this.groupPanel2.Controls.Add(this.labelX26);
            this.groupPanel2.Location = new System.Drawing.Point(12, 41);
            this.groupPanel2.Name = "groupPanel2";
            this.groupPanel2.Size = new System.Drawing.Size(880, 213);
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
            this.groupPanel2.Text = "THÔNG TIN TRÌNH DƯỢC VIÊN";
            // 
            // lable
            // 
            this.lable.Location = new System.Drawing.Point(21, 117);
            this.lable.Name = "lable";
            this.lable.Size = new System.Drawing.Size(71, 25);
            this.lable.TabIndex = 87;
            this.lable.Text = "Mật khẩu:";
            // 
            // txtMK
            // 
            // 
            // 
            // 
            this.txtMK.Border.Class = "TextBoxBorder";
            this.txtMK.Location = new System.Drawing.Point(106, 119);
            this.txtMK.Multiline = true;
            this.txtMK.Name = "txtMK";
            this.txtMK.PasswordChar = '*';
            this.txtMK.Size = new System.Drawing.Size(193, 24);
            this.txtMK.TabIndex = 86;
            // 
            // labelX2
            // 
            this.labelX2.Location = new System.Drawing.Point(21, 82);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(71, 25);
            this.labelX2.TabIndex = 85;
            this.labelX2.Text = "Tên ĐN:";
            // 
            // txtTenDN
            // 
            // 
            // 
            // 
            this.txtTenDN.Border.Class = "TextBoxBorder";
            this.txtTenDN.Location = new System.Drawing.Point(106, 83);
            this.txtTenDN.Multiline = true;
            this.txtTenDN.Name = "txtTenDN";
            this.txtTenDN.Size = new System.Drawing.Size(193, 24);
            this.txtTenDN.TabIndex = 84;
            // 
            // labelX6
            // 
            this.labelX6.Location = new System.Drawing.Point(356, 10);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(71, 25);
            this.labelX6.TabIndex = 83;
            this.labelX6.Text = "Tuổi:";
            // 
            // txtTuoi
            // 
            // 
            // 
            // 
            this.txtTuoi.Border.Class = "TextBoxBorder";
            this.txtTuoi.Location = new System.Drawing.Point(431, 12);
            this.txtTuoi.Multiline = true;
            this.txtTuoi.Name = "txtTuoi";
            this.txtTuoi.Size = new System.Drawing.Size(193, 24);
            this.txtTuoi.TabIndex = 82;
            // 
            // txtdienthoai
            // 
            // 
            // 
            // 
            this.txtdienthoai.Border.Class = "TextBoxBorder";
            this.txtdienthoai.Location = new System.Drawing.Point(431, 49);
            this.txtdienthoai.Name = "txtdienthoai";
            this.txtdienthoai.Size = new System.Drawing.Size(374, 24);
            this.txtdienthoai.TabIndex = 81;
            // 
            // cmbSua
            // 
            this.cmbSua.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.cmbSua.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.cmbSua.Location = new System.Drawing.Point(402, 160);
            this.cmbSua.Margin = new System.Windows.Forms.Padding(0);
            this.cmbSua.Name = "cmbSua";
            this.cmbSua.Size = new System.Drawing.Size(70, 27);
            this.cmbSua.TabIndex = 54;
            this.cmbSua.Text = "Sửa";
            this.cmbSua.Click += new System.EventHandler(this.cmbSua_Click);
            // 
            // cmdXoa
            // 
            this.cmdXoa.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.cmdXoa.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.cmdXoa.Location = new System.Drawing.Point(485, 160);
            this.cmdXoa.Margin = new System.Windows.Forms.Padding(0);
            this.cmdXoa.Name = "cmdXoa";
            this.cmdXoa.Size = new System.Drawing.Size(70, 27);
            this.cmdXoa.TabIndex = 53;
            this.cmdXoa.Text = "Xóa";
            this.cmdXoa.Click += new System.EventHandler(this.cmdXoa_Click);
            // 
            // cmdThem
            // 
            this.cmdThem.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.cmdThem.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.cmdThem.Location = new System.Drawing.Point(318, 160);
            this.cmdThem.Margin = new System.Windows.Forms.Padding(0);
            this.cmdThem.Name = "cmdThem";
            this.cmdThem.Size = new System.Drawing.Size(70, 27);
            this.cmdThem.TabIndex = 28;
            this.cmdThem.Text = "Thêm";
            this.cmdThem.Click += new System.EventHandler(this.cmdThem_Click);
            // 
            // txt_codeTDV
            // 
            // 
            // 
            // 
            this.txt_codeTDV.Border.Class = "TextBoxBorder";
            this.txt_codeTDV.Location = new System.Drawing.Point(106, 14);
            this.txt_codeTDV.Name = "txt_codeTDV";
            this.txt_codeTDV.Size = new System.Drawing.Size(193, 24);
            this.txt_codeTDV.TabIndex = 75;
            // 
            // labelX3
            // 
            this.labelX3.Location = new System.Drawing.Point(21, 10);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(70, 25);
            this.labelX3.TabIndex = 76;
            this.labelX3.Text = "Mã TDV";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.SteelBlue;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 158);
            this.panel5.Margin = new System.Windows.Forms.Padding(0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(874, 30);
            this.panel5.TabIndex = 70;
            // 
            // labelX1
            // 
            this.labelX1.Location = new System.Drawing.Point(356, 97);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(53, 25);
            this.labelX1.TabIndex = 70;
            this.labelX1.Text = "Địa chỉ:";
            // 
            // labelX27
            // 
            this.labelX27.Location = new System.Drawing.Point(356, 49);
            this.labelX27.Name = "labelX27";
            this.labelX27.Size = new System.Drawing.Size(71, 25);
            this.labelX27.TabIndex = 67;
            this.labelX27.Text = "Điện thoại:";
            // 
            // txt_diachi
            // 
            // 
            // 
            // 
            this.txt_diachi.Border.Class = "TextBoxBorder";
            this.txt_diachi.Location = new System.Drawing.Point(431, 85);
            this.txt_diachi.Multiline = true;
            this.txt_diachi.Name = "txt_diachi";
            this.txt_diachi.Size = new System.Drawing.Size(374, 57);
            this.txt_diachi.TabIndex = 54;
            // 
            // txt_tenTDV
            // 
            // 
            // 
            // 
            this.txt_tenTDV.Border.Class = "TextBoxBorder";
            this.txt_tenTDV.Location = new System.Drawing.Point(106, 48);
            this.txt_tenTDV.Name = "txt_tenTDV";
            this.txt_tenTDV.Size = new System.Drawing.Size(193, 24);
            this.txt_tenTDV.TabIndex = 0;
            // 
            // labelX26
            // 
            this.labelX26.Location = new System.Drawing.Point(21, 45);
            this.labelX26.Name = "labelX26";
            this.labelX26.Size = new System.Drawing.Size(70, 25);
            this.labelX26.TabIndex = 60;
            this.labelX26.Text = "Tên TDV:";
            // 
            // frmTDV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 544);
            this.Controls.Add(this.groupPanel1);
            this.Controls.Add(this.groupPanel2);
            this.Name = "frmTDV";
            this.Text = "Quản lý trình dược viên";
            this.Load += new System.EventHandler(this.frmTDV_Load);
            this.Controls.SetChildIndex(this.groupPanel2, 0);
            this.Controls.SetChildIndex(this.groupPanel1, 0);
            this.groupPanel1.ResumeLayout(false);
            this.groupPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.Controls.ListViewEx lvTDV;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel2;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTuoi;
        private DevComponents.DotNetBar.Controls.TextBoxX txtdienthoai;
        private DevComponents.DotNetBar.ButtonX cmbSua;
        private DevComponents.DotNetBar.ButtonX cmdXoa;
        private DevComponents.DotNetBar.ButtonX cmdThem;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_codeTDV;
        private DevComponents.DotNetBar.LabelX labelX3;
        private System.Windows.Forms.Panel panel5;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX27;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_diachi;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_tenTDV;
        private DevComponents.DotNetBar.LabelX labelX26;
        private DevComponents.DotNetBar.LabelX lable;
        private DevComponents.DotNetBar.Controls.TextBoxX txtMK;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTenDN;
        private System.Windows.Forms.ColumnHeader columnHeader6;
    }
}