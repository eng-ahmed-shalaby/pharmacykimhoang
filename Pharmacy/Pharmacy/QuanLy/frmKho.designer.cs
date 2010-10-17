namespace Pharmacy.QuanLy
{
    partial class frmKho
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvKho = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.Ma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIACHI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIENTHOAI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SODK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAYLAP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmdLuu = new DevComponents.DotNetBar.ButtonX();
            this.dgvCTKho = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmdLuuCT = new DevComponents.DotNetBar.ButtonX();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmdBo = new DevComponents.DotNetBar.ButtonX();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmdBoCT = new DevComponents.DotNetBar.ButtonX();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTKho)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvKho
            // 
            this.dgvKho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKho.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ma,
            this.TEN,
            this.DIACHI,
            this.DIENTHOAI,
            this.SODK,
            this.NGAYLAP});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 11F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvKho.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvKho.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvKho.Location = new System.Drawing.Point(6, 23);
            this.dgvKho.Name = "dgvKho";
            this.dgvKho.Size = new System.Drawing.Size(800, 150);
            this.dgvKho.TabIndex = 76;
            this.dgvKho.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKho_CellEnter);
            this.dgvKho.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKho_CellContentClick);
            // 
            // Ma
            // 
            this.Ma.DataPropertyName = "MaKho";
            this.Ma.HeaderText = "Ma";
            this.Ma.Name = "Ma";
            this.Ma.Visible = false;
            // 
            // TEN
            // 
            this.TEN.DataPropertyName = "TEN";
            this.TEN.HeaderText = "Tên Kho";
            this.TEN.Name = "TEN";
            this.TEN.Width = 200;
            // 
            // DIACHI
            // 
            this.DIACHI.DataPropertyName = "DIACHI";
            this.DIACHI.HeaderText = "Địa chỉ";
            this.DIACHI.Name = "DIACHI";
            this.DIACHI.Width = 200;
            // 
            // DIENTHOAI
            // 
            this.DIENTHOAI.DataPropertyName = "DIENTHOAI";
            this.DIENTHOAI.HeaderText = "Điện Thoại";
            this.DIENTHOAI.Name = "DIENTHOAI";
            this.DIENTHOAI.Width = 150;
            // 
            // SODK
            // 
            this.SODK.DataPropertyName = "SODK";
            this.SODK.HeaderText = "Số ĐK";
            this.SODK.Name = "SODK";
            // 
            // NGAYLAP
            // 
            this.NGAYLAP.DataPropertyName = "NGAYLAP";
            this.NGAYLAP.HeaderText = "Ngày";
            this.NGAYLAP.Name = "NGAYLAP";
            // 
            // cmdLuu
            // 
            this.cmdLuu.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.cmdLuu.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.cmdLuu.Location = new System.Drawing.Point(15, 179);
            this.cmdLuu.Name = "cmdLuu";
            this.cmdLuu.Size = new System.Drawing.Size(75, 23);
            this.cmdLuu.TabIndex = 78;
            this.cmdLuu.Text = "Lưu";
            this.cmdLuu.Click += new System.EventHandler(this.cmdLuu_Click);
            // 
            // dgvCTKho
            // 
            this.dgvCTKho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCTKho.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 11F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCTKho.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCTKho.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvCTKho.Location = new System.Drawing.Point(21, 23);
            this.dgvCTKho.Name = "dgvCTKho";
            this.dgvCTKho.Size = new System.Drawing.Size(150, 150);
            this.dgvCTKho.TabIndex = 79;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MAKHO";
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "KE";
            this.dataGridViewTextBoxColumn2.HeaderText = "Tên Kệ";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // cmdLuuCT
            // 
            this.cmdLuuCT.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.cmdLuuCT.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.cmdLuuCT.Location = new System.Drawing.Point(21, 179);
            this.cmdLuuCT.Name = "cmdLuuCT";
            this.cmdLuuCT.Size = new System.Drawing.Size(75, 23);
            this.cmdLuuCT.TabIndex = 80;
            this.cmdLuuCT.Text = "Lưu CT";
            this.cmdLuuCT.Click += new System.EventHandler(this.cmdLuuCT_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.cmdBo);
            this.groupBox1.Controls.Add(this.dgvKho);
            this.groupBox1.Controls.Add(this.cmdLuu);
            this.groupBox1.Location = new System.Drawing.Point(7, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(812, 218);
            this.groupBox1.TabIndex = 81;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kho";
            // 
            // cmdBo
            // 
            this.cmdBo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.cmdBo.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.cmdBo.Location = new System.Drawing.Point(111, 179);
            this.cmdBo.Name = "cmdBo";
            this.cmdBo.Size = new System.Drawing.Size(75, 23);
            this.cmdBo.TabIndex = 79;
            this.cmdBo.Text = "Bỏ";
            this.cmdBo.Click += new System.EventHandler(this.cmdBo_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmdBoCT);
            this.groupBox2.Controls.Add(this.dgvCTKho);
            this.groupBox2.Controls.Add(this.cmdLuuCT);
            this.groupBox2.Location = new System.Drawing.Point(7, 256);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 223);
            this.groupBox2.TabIndex = 82;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chi Tiết kho";
            // 
            // cmdBoCT
            // 
            this.cmdBoCT.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.cmdBoCT.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.cmdBoCT.Location = new System.Drawing.Point(111, 179);
            this.cmdBoCT.Name = "cmdBoCT";
            this.cmdBoCT.Size = new System.Drawing.Size(75, 23);
            this.cmdBoCT.TabIndex = 81;
            this.cmdBoCT.Text = "Bỏ";
            this.cmdBoCT.Click += new System.EventHandler(this.cmdBoCT_Click);
            // 
            // frmKho
            // 
            this.ClientSize = new System.Drawing.Size(822, 499);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmKho";
            this.Text = "Kho";
            this.Load += new System.EventHandler(this.frmKho_Load);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTKho)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX cmdLuu;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvKho;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvCTKho;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DevComponents.DotNetBar.ButtonX cmdLuuCT;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevComponents.DotNetBar.ButtonX cmdBo;
        private DevComponents.DotNetBar.ButtonX cmdBoCT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ma;
        private System.Windows.Forms.DataGridViewTextBoxColumn TEN;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIACHI;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIENTHOAI;
        private System.Windows.Forms.DataGridViewTextBoxColumn SODK;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYLAP;
    }
}
