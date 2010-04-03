namespace Pharmacy.ThuChi
{
    partial class frmCongNo
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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cmdTim = new DevComponents.DotNetBar.ButtonX();
            this.txtMaKH = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.rdTenKH = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.cmbKH = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.rdMaKH = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.txtDiaChi = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.grbHD = new System.Windows.Forms.GroupBox();
            this.cmdin = new DevComponents.DotNetBar.ButtonX();
            this.lvHD = new DevComponents.DotNetBar.Controls.ListViewEx();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.Ma = new System.Windows.Forms.ColumnHeader();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.txtDT = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.groupBox4.SuspendLayout();
            this.grbHD.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cmdTim);
            this.groupBox4.Controls.Add(this.txtMaKH);
            this.groupBox4.Controls.Add(this.rdTenKH);
            this.groupBox4.Controls.Add(this.cmbKH);
            this.groupBox4.Controls.Add(this.rdMaKH);
            this.groupBox4.ForeColor = System.Drawing.Color.Red;
            this.groupBox4.Location = new System.Drawing.Point(0, 41);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(483, 88);
            this.groupBox4.TabIndex = 80;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Tìm Theo";
            // 
            // cmdTim
            // 
            this.cmdTim.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.cmdTim.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.cmdTim.Location = new System.Drawing.Point(421, 35);
            this.cmdTim.Margin = new System.Windows.Forms.Padding(0);
            this.cmdTim.Name = "cmdTim";
            this.cmdTim.Size = new System.Drawing.Size(59, 27);
            this.cmdTim.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2010;
            this.cmdTim.TabIndex = 83;
            this.cmdTim.Text = "Tìm";
            this.cmdTim.Click += new System.EventHandler(this.cmdTim_Click);
            // 
            // txtMaKH
            // 
            // 
            // 
            // 
            this.txtMaKH.Border.Class = "TextBoxBorder";
            this.txtMaKH.Enabled = false;
            this.txtMaKH.Location = new System.Drawing.Point(143, 20);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(265, 24);
            this.txtMaKH.TabIndex = 80;
            // 
            // rdTenKH
            // 
            this.rdTenKH.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton;
            this.rdTenKH.Checked = true;
            this.rdTenKH.CheckState = System.Windows.Forms.CheckState.Checked;
            this.rdTenKH.CheckValue = "Y";
            this.rdTenKH.Location = new System.Drawing.Point(6, 54);
            this.rdTenKH.Name = "rdTenKH";
            this.rdTenKH.Size = new System.Drawing.Size(134, 23);
            this.rdTenKH.TabIndex = 75;
            this.rdTenKH.Text = "Tên Khách hàng:";
            this.rdTenKH.CheckedChanged += new System.EventHandler(this.rdTenKH_CheckedChanged);
            // 
            // cmbKH
            // 
            this.cmbKH.DisplayMember = "Text";
            this.cmbKH.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbKH.FormattingEnabled = true;
            this.cmbKH.ItemHeight = 18;
            this.cmbKH.Location = new System.Drawing.Point(143, 54);
            this.cmbKH.Name = "cmbKH";
            this.cmbKH.Size = new System.Drawing.Size(265, 24);
            this.cmbKH.TabIndex = 79;
            this.cmbKH.SelectedIndexChanged += new System.EventHandler(this.cmbKH_SelectedIndexChanged);
            // 
            // rdMaKH
            // 
            this.rdMaKH.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton;
            this.rdMaKH.Location = new System.Drawing.Point(6, 19);
            this.rdMaKH.Name = "rdMaKH";
            this.rdMaKH.Size = new System.Drawing.Size(134, 23);
            this.rdMaKH.TabIndex = 76;
            this.rdMaKH.Text = "Mã khách hàng:";
            this.rdMaKH.CheckedChanged += new System.EventHandler(this.rdMaKH_CheckedChanged);
            // 
            // txtDiaChi
            // 
            // 
            // 
            // 
            this.txtDiaChi.Border.Class = "TextBoxBorder";
            this.txtDiaChi.Location = new System.Drawing.Point(66, 19);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(309, 25);
            this.txtDiaChi.TabIndex = 78;
            // 
            // grbHD
            // 
            this.grbHD.Controls.Add(this.cmdin);
            this.grbHD.Controls.Add(this.lvHD);
            this.grbHD.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.grbHD.Location = new System.Drawing.Point(2, 147);
            this.grbHD.Name = "grbHD";
            this.grbHD.Size = new System.Drawing.Size(882, 240);
            this.grbHD.TabIndex = 81;
            this.grbHD.TabStop = false;
            this.grbHD.Text = "Danh sách Hóa Đơn Nợ";
            // 
            // cmdin
            // 
            this.cmdin.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.cmdin.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.cmdin.Location = new System.Drawing.Point(12, 210);
            this.cmdin.Margin = new System.Windows.Forms.Padding(0);
            this.cmdin.Name = "cmdin";
            this.cmdin.Size = new System.Drawing.Size(59, 27);
            this.cmdin.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2010;
            this.cmdin.TabIndex = 84;
            this.cmdin.Text = "In";
            this.cmdin.Click += new System.EventHandler(this.cmdin_Click_1);
            // 
            // lvHD
            // 
            // 
            // 
            // 
            this.lvHD.Border.Class = "ListViewBorder";
            this.lvHD.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader6,
            this.Ma});
            this.lvHD.Font = new System.Drawing.Font("Tahoma", 11F);
            this.lvHD.FullRowSelect = true;
            this.lvHD.GridLines = true;
            this.lvHD.Location = new System.Drawing.Point(12, 23);
            this.lvHD.Name = "lvHD";
            this.lvHD.Size = new System.Drawing.Size(864, 182);
            this.lvHD.TabIndex = 43;
            this.lvHD.UseCompatibleStateImageBehavior = false;
            this.lvHD.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "STT";
            this.columnHeader5.Width = 50;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Số HĐ";
            this.columnHeader1.Width = 65;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Ngày lập";
            this.columnHeader2.Width = 98;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Tổng tiền";
            this.columnHeader3.Width = 143;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Nợ";
            this.columnHeader4.Width = 138;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Số ngày nợ";
            this.columnHeader6.Width = 98;
            // 
            // Ma
            // 
            this.Ma.Text = "Ma";
            this.Ma.Width = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelX2);
            this.groupBox1.Controls.Add(this.txtDT);
            this.groupBox1.Controls.Add(this.labelX1);
            this.groupBox1.Controls.Add(this.txtDiaChi);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(503, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(381, 88);
            this.groupBox1.TabIndex = 82;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin khách hàng:";
            // 
            // labelX2
            // 
            this.labelX2.Location = new System.Drawing.Point(6, 54);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(54, 25);
            this.labelX2.TabIndex = 85;
            this.labelX2.Text = "Tel:";
            // 
            // txtDT
            // 
            // 
            // 
            // 
            this.txtDT.Border.Class = "TextBoxBorder";
            this.txtDT.Location = new System.Drawing.Point(66, 55);
            this.txtDT.Name = "txtDT";
            this.txtDT.Size = new System.Drawing.Size(309, 25);
            this.txtDT.TabIndex = 79;
            // 
            // labelX1
            // 
            this.labelX1.Location = new System.Drawing.Point(6, 17);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(54, 25);
            this.labelX1.TabIndex = 84;
            this.labelX1.Text = "Địa chỉ:";
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // frmCongNo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 408);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grbHD);
            this.Controls.Add(this.groupBox4);
            this.Name = "frmCongNo";
            this.Text = "frmCongNo";
            this.Load += new System.EventHandler(this.frmCongNo_Load);
            this.Controls.SetChildIndex(this.groupBox4, 0);
            this.Controls.SetChildIndex(this.grbHD, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.groupBox4.ResumeLayout(false);
            this.grbHD.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private DevComponents.DotNetBar.Controls.CheckBoxX rdTenKH;
        private DevComponents.DotNetBar.Controls.CheckBoxX rdMaKH;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbKH;
        private DevComponents.DotNetBar.Controls.TextBoxX txtDiaChi;
        private System.Windows.Forms.GroupBox grbHD;
        private DevComponents.DotNetBar.Controls.ListViewEx lvHD;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader Ma;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtMaKH;
        private DevComponents.DotNetBar.Controls.TextBoxX txtDT;
        private DevComponents.DotNetBar.ButtonX cmdTim;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private DevComponents.DotNetBar.ButtonX cmdin;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}