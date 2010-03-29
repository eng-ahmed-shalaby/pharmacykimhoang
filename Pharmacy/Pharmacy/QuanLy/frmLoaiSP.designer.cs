namespace Pharmacy.QuanLy
{
    partial class frmLoaiSP
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
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.txt_mota = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.panel5 = new System.Windows.Forms.Panel();
            this.buttonX6 = new DevComponents.DotNetBar.ButtonX();
            this.buttonX4 = new DevComponents.DotNetBar.ButtonX();
            this.buttonX5 = new DevComponents.DotNetBar.ButtonX();
            this.txt_tenloai = new DevComponents.DotNetBar.Controls.TextBoxX();
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
            this.groupPanel1.Location = new System.Drawing.Point(12, 205);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(484, 217);
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
            this.groupPanel1.Text = "DANH SÁCH LOẠI SẢN PHẨM";
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
            this.lvhanghoa.Size = new System.Drawing.Size(459, 177);
            this.lvhanghoa.TabIndex = 71;
            this.lvhanghoa.UseCompatibleStateImageBehavior = false;
            this.lvhanghoa.View = System.Windows.Forms.View.Details;
            this.lvhanghoa.SelectedIndexChanged += new System.EventHandler(this.lvhanghoa_SelectedIndexChanged);
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "STT";
            this.columnHeader7.Width = 54;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên Loại";
            this.columnHeader2.Width = 203;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Mô Tả";
            this.columnHeader4.Width = 196;
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
            this.groupPanel2.Controls.Add(this.labelX1);
            this.groupPanel2.Controls.Add(this.txt_mota);
            this.groupPanel2.Controls.Add(this.panel5);
            this.groupPanel2.Controls.Add(this.txt_tenloai);
            this.groupPanel2.Controls.Add(this.labelX26);
            this.groupPanel2.Location = new System.Drawing.Point(59, 41);
            this.groupPanel2.Name = "groupPanel2";
            this.groupPanel2.Size = new System.Drawing.Size(388, 158);
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
            this.groupPanel2.Text = "THÔNG TIN LOẠI SẢN PHẨM";
            // 
            // labelX1
            // 
            this.labelX1.Location = new System.Drawing.Point(3, 56);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(97, 25);
            this.labelX1.TabIndex = 72;
            this.labelX1.Text = "Mô Tả:";
            // 
            // txt_mota
            // 
            // 
            // 
            // 
            this.txt_mota.Border.Class = "TextBoxBorder";
            this.txt_mota.Location = new System.Drawing.Point(106, 44);
            this.txt_mota.Multiline = true;
            this.txt_mota.Name = "txt_mota";
            this.txt_mota.Size = new System.Drawing.Size(193, 47);
            this.txt_mota.TabIndex = 71;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.SteelBlue;
            this.panel5.Controls.Add(this.buttonX6);
            this.panel5.Controls.Add(this.buttonX4);
            this.panel5.Controls.Add(this.buttonX5);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 103);
            this.panel5.Margin = new System.Windows.Forms.Padding(0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(382, 30);
            this.panel5.TabIndex = 70;
            // 
            // buttonX6
            // 
            this.buttonX6.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX6.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.buttonX6.Location = new System.Drawing.Point(158, 2);
            this.buttonX6.Margin = new System.Windows.Forms.Padding(0);
            this.buttonX6.Name = "buttonX6";
            this.buttonX6.Size = new System.Drawing.Size(70, 27);
            this.buttonX6.TabIndex = 54;
            this.buttonX6.Text = "Sửa";
            this.buttonX6.Click += new System.EventHandler(this.buttonX6_Click);
            // 
            // buttonX4
            // 
            this.buttonX4.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX4.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.buttonX4.Enabled = false;
            this.buttonX4.Location = new System.Drawing.Point(241, 2);
            this.buttonX4.Margin = new System.Windows.Forms.Padding(0);
            this.buttonX4.Name = "buttonX4";
            this.buttonX4.Size = new System.Drawing.Size(70, 27);
            this.buttonX4.TabIndex = 53;
            this.buttonX4.Text = "Xóa";
            this.buttonX4.Click += new System.EventHandler(this.buttonX4_Click);
            // 
            // buttonX5
            // 
            this.buttonX5.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX5.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.buttonX5.Location = new System.Drawing.Point(76, 2);
            this.buttonX5.Margin = new System.Windows.Forms.Padding(0);
            this.buttonX5.Name = "buttonX5";
            this.buttonX5.Size = new System.Drawing.Size(70, 27);
            this.buttonX5.TabIndex = 28;
            this.buttonX5.Text = "Thêm";
            this.buttonX5.Click += new System.EventHandler(this.buttonX5_Click);
            // 
            // txt_tenloai
            // 
            // 
            // 
            // 
            this.txt_tenloai.Border.Class = "TextBoxBorder";
            this.txt_tenloai.Location = new System.Drawing.Point(106, 16);
            this.txt_tenloai.Name = "txt_tenloai";
            this.txt_tenloai.Size = new System.Drawing.Size(193, 24);
            this.txt_tenloai.TabIndex = 0;
            // 
            // labelX26
            // 
            this.labelX26.Location = new System.Drawing.Point(3, 12);
            this.labelX26.Name = "labelX26";
            this.labelX26.Size = new System.Drawing.Size(97, 25);
            this.labelX26.TabIndex = 60;
            this.labelX26.Text = "Tên Loại:";
            // 
            // frmLoaiSP
            // 
            this.ClientSize = new System.Drawing.Size(519, 448);
            this.Controls.Add(this.groupPanel1);
            this.Controls.Add(this.groupPanel2);
            this.Name = "frmLoaiSP";
            this.Load += new System.EventHandler(this.frmLoaiSP_Load);
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
        private DevComponents.DotNetBar.Controls.TextBoxX txt_mota;
        private System.Windows.Forms.Panel panel5;
        private DevComponents.DotNetBar.ButtonX buttonX6;
        private DevComponents.DotNetBar.ButtonX buttonX4;
        private DevComponents.DotNetBar.ButtonX buttonX5;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_tenloai;
        private DevComponents.DotNetBar.LabelX labelX26;
    }
}
