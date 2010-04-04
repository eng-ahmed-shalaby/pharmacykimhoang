namespace Pharmacy.QuanLy
{
    partial class frmQuyCach
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
            this.groupPanel2 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.txtSL = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.buttonX2 = new DevComponents.DotNetBar.ButtonX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.cmbdvQD = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboItem3 = new DevComponents.Editors.ComboItem();
            this.comboItem4 = new DevComponents.Editors.ComboItem();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.labelX23 = new DevComponents.DotNetBar.LabelX();
            this.cmb_dvt = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboItem1 = new DevComponents.Editors.ComboItem();
            this.comboItem2 = new DevComponents.Editors.ComboItem();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.panel5 = new System.Windows.Forms.Panel();
            this.cmbSua = new DevComponents.DotNetBar.ButtonX();
            this.cmbXoa = new DevComponents.DotNetBar.ButtonX();
            this.buttonX5 = new DevComponents.DotNetBar.ButtonX();
            this.txtten = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX26 = new DevComponents.DotNetBar.LabelX();
            this.groupPanel1.SuspendLayout();
            this.groupPanel2.SuspendLayout();
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
            this.groupPanel1.Location = new System.Drawing.Point(14, 198);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(575, 217);
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
            this.groupPanel1.TabIndex = 79;
            this.groupPanel1.Text = "DANH SÁCH NHÓM CUNG CẤP";
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
            this.columnHeader1});
            this.lvhanghoa.FullRowSelect = true;
            this.lvhanghoa.GridLines = true;
            this.lvhanghoa.Location = new System.Drawing.Point(7, 3);
            this.lvhanghoa.Name = "lvhanghoa";
            this.lvhanghoa.Size = new System.Drawing.Size(531, 177);
            this.lvhanghoa.TabIndex = 71;
            this.lvhanghoa.UseCompatibleStateImageBehavior = false;
            this.lvhanghoa.View = System.Windows.Forms.View.Details;
            this.lvhanghoa.SelectedIndexChanged += new System.EventHandler(this.lvhanghoa_SelectedIndexChanged);
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "STT";
            this.columnHeader7.Width = 55;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên QC";
            this.columnHeader2.Width = 190;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "SLĐVT";
            this.columnHeader4.Width = 150;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "manhom";
            this.columnHeader1.Width = 0;
            // 
            // groupPanel2
            // 
            this.groupPanel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupPanel2.BackColor = System.Drawing.Color.Transparent;
            this.groupPanel2.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel2.Controls.Add(this.txtSL);
            this.groupPanel2.Controls.Add(this.buttonX2);
            this.groupPanel2.Controls.Add(this.labelX2);
            this.groupPanel2.Controls.Add(this.cmbdvQD);
            this.groupPanel2.Controls.Add(this.buttonX1);
            this.groupPanel2.Controls.Add(this.labelX23);
            this.groupPanel2.Controls.Add(this.cmb_dvt);
            this.groupPanel2.Controls.Add(this.labelX1);
            this.groupPanel2.Controls.Add(this.panel5);
            this.groupPanel2.Controls.Add(this.txtten);
            this.groupPanel2.Controls.Add(this.labelX26);
            this.groupPanel2.Location = new System.Drawing.Point(14, 40);
            this.groupPanel2.Name = "groupPanel2";
            this.groupPanel2.Size = new System.Drawing.Size(578, 152);
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
            this.groupPanel2.TabIndex = 78;
            this.groupPanel2.Text = "THÔNG TIN QUY CÁCH";
            // 
            // txtSL
            // 
            // 
            // 
            // 
            this.txtSL.Border.Class = "TextBoxBorder";
            this.txtSL.Location = new System.Drawing.Point(81, 52);
            this.txtSL.Name = "txtSL";
            this.txtSL.Size = new System.Drawing.Size(134, 24);
            this.txtSL.TabIndex = 79;
            this.txtSL.TextChanged += new System.EventHandler(this.txtSL_TextChanged);
            // 
            // buttonX2
            // 
            this.buttonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.buttonX2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonX2.Location = new System.Drawing.Point(537, 17);
            this.buttonX2.Name = "buttonX2";
            this.buttonX2.Size = new System.Drawing.Size(25, 25);
            this.buttonX2.TabIndex = 78;
            this.buttonX2.Text = "+";
            // 
            // labelX2
            // 
            this.labelX2.Location = new System.Drawing.Point(250, 16);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(138, 23);
            this.labelX2.TabIndex = 76;
            this.labelX2.Text = "Đơn vị nhập quy đổi:";
            // 
            // cmbdvQD
            // 
            this.cmbdvQD.DisplayMember = "Text";
            this.cmbdvQD.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbdvQD.FormattingEnabled = true;
            this.cmbdvQD.ItemHeight = 18;
            this.cmbdvQD.Items.AddRange(new object[] {
            this.comboItem3,
            this.comboItem4});
            this.cmbdvQD.Location = new System.Drawing.Point(393, 17);
            this.cmbdvQD.Name = "cmbdvQD";
            this.cmbdvQD.Size = new System.Drawing.Size(142, 24);
            this.cmbdvQD.TabIndex = 77;
            // 
            // comboItem3
            // 
            this.comboItem3.Text = "Nhập hàng";
            // 
            // comboItem4
            // 
            this.comboItem4.Text = "Trả hàng";
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.buttonX1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonX1.Location = new System.Drawing.Point(217, 17);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(25, 25);
            this.buttonX1.TabIndex = 75;
            this.buttonX1.Text = "+";
            // 
            // labelX23
            // 
            this.labelX23.Location = new System.Drawing.Point(1, 16);
            this.labelX23.Name = "labelX23";
            this.labelX23.Size = new System.Drawing.Size(80, 23);
            this.labelX23.TabIndex = 73;
            this.labelX23.Text = "Đơn vị tính:";
            // 
            // cmb_dvt
            // 
            this.cmb_dvt.DisplayMember = "Text";
            this.cmb_dvt.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_dvt.FormattingEnabled = true;
            this.cmb_dvt.ItemHeight = 18;
            this.cmb_dvt.Items.AddRange(new object[] {
            this.comboItem1,
            this.comboItem2});
            this.cmb_dvt.Location = new System.Drawing.Point(81, 17);
            this.cmb_dvt.Name = "cmb_dvt";
            this.cmb_dvt.Size = new System.Drawing.Size(134, 24);
            this.cmb_dvt.TabIndex = 74;
            // 
            // comboItem1
            // 
            this.comboItem1.Text = "Nhập hàng";
            // 
            // comboItem2
            // 
            this.comboItem2.Text = "Trả hàng";
            // 
            // labelX1
            // 
            this.labelX1.Location = new System.Drawing.Point(2, 54);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(80, 25);
            this.labelX1.TabIndex = 72;
            this.labelX1.Text = "SLDVT:";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.SteelBlue;
            this.panel5.Controls.Add(this.cmbSua);
            this.panel5.Controls.Add(this.cmbXoa);
            this.panel5.Controls.Add(this.buttonX5);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 97);
            this.panel5.Margin = new System.Windows.Forms.Padding(0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(572, 30);
            this.panel5.TabIndex = 70;
            // 
            // cmbSua
            // 
            this.cmbSua.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.cmbSua.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.cmbSua.Location = new System.Drawing.Point(223, 2);
            this.cmbSua.Margin = new System.Windows.Forms.Padding(0);
            this.cmbSua.Name = "cmbSua";
            this.cmbSua.Size = new System.Drawing.Size(70, 27);
            this.cmbSua.TabIndex = 54;
            this.cmbSua.Text = "Sửa";
            this.cmbSua.Click += new System.EventHandler(this.cmbSua_Click);
            // 
            // cmbXoa
            // 
            this.cmbXoa.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.cmbXoa.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.cmbXoa.Location = new System.Drawing.Point(305, 2);
            this.cmbXoa.Margin = new System.Windows.Forms.Padding(0);
            this.cmbXoa.Name = "cmbXoa";
            this.cmbXoa.Size = new System.Drawing.Size(70, 27);
            this.cmbXoa.TabIndex = 53;
            this.cmbXoa.Text = "Xóa";
            this.cmbXoa.Click += new System.EventHandler(this.cmbXoa_Click);
            // 
            // buttonX5
            // 
            this.buttonX5.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX5.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.buttonX5.Location = new System.Drawing.Point(140, 2);
            this.buttonX5.Margin = new System.Windows.Forms.Padding(0);
            this.buttonX5.Name = "buttonX5";
            this.buttonX5.Size = new System.Drawing.Size(70, 27);
            this.buttonX5.TabIndex = 28;
            this.buttonX5.Text = "Thêm";
            this.buttonX5.Click += new System.EventHandler(this.buttonX5_Click);
            // 
            // txtten
            // 
            // 
            // 
            // 
            this.txtten.Border.Class = "TextBoxBorder";
            this.txtten.Enabled = false;
            this.txtten.Location = new System.Drawing.Point(393, 52);
            this.txtten.Name = "txtten";
            this.txtten.Size = new System.Drawing.Size(142, 24);
            this.txtten.TabIndex = 0;
            // 
            // labelX26
            // 
            this.labelX26.Location = new System.Drawing.Point(285, 52);
            this.labelX26.Name = "labelX26";
            this.labelX26.Size = new System.Drawing.Size(102, 25);
            this.labelX26.TabIndex = 60;
            this.labelX26.Text = "Tên Quy cách :";
            // 
            // frmQuyCach
            // 
            this.ClientSize = new System.Drawing.Size(603, 435);
            this.Controls.Add(this.groupPanel1);
            this.Controls.Add(this.groupPanel2);
            this.Name = "frmQuyCach";
            this.Load += new System.EventHandler(this.frmQuyCach_Load);
            this.Controls.SetChildIndex(this.groupPanel2, 0);
            this.Controls.SetChildIndex(this.groupPanel1, 0);
            this.groupPanel1.ResumeLayout(false);
            this.groupPanel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.Controls.ListViewEx lvhanghoa;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private System.Windows.Forms.Panel panel5;
        private DevComponents.DotNetBar.ButtonX cmbSua;
        private DevComponents.DotNetBar.ButtonX cmbXoa;
        private DevComponents.DotNetBar.ButtonX buttonX5;
        private DevComponents.DotNetBar.Controls.TextBoxX txtten;
        private DevComponents.DotNetBar.LabelX labelX26;
        private DevComponents.DotNetBar.ButtonX buttonX2;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbdvQD;
        private DevComponents.Editors.ComboItem comboItem3;
        private DevComponents.Editors.ComboItem comboItem4;
        private DevComponents.DotNetBar.ButtonX buttonX1;
        private DevComponents.DotNetBar.LabelX labelX23;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmb_dvt;
        private DevComponents.Editors.ComboItem comboItem1;
        private DevComponents.Editors.ComboItem comboItem2;
        private DevComponents.DotNetBar.Controls.TextBoxX txtSL;
    }
}
