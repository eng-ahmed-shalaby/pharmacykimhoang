namespace Pharmacy.BaoCao
{
    partial class frmTuyChonCN
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
            this.chkAll = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.chkOne = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.frmDY = new DevComponents.DotNetBar.ButtonX();
            this.cmbChon = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.SuspendLayout();
            // 
            // chkAll
            // 
            this.chkAll.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton;
            this.chkAll.Checked = true;
            this.chkAll.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAll.CheckValue = "Y";
            this.chkAll.Location = new System.Drawing.Point(21, 38);
            this.chkAll.Name = "chkAll";
            this.chkAll.Size = new System.Drawing.Size(78, 23);
            this.chkAll.TabIndex = 1;
            this.chkAll.Text = "Tất cả";
            this.chkAll.CheckedChanged += new System.EventHandler(this.chkAll_CheckedChanged);
            // 
            // chkOne
            // 
            this.chkOne.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton;
            this.chkOne.Location = new System.Drawing.Point(21, 80);
            this.chkOne.Name = "chkOne";
            this.chkOne.Size = new System.Drawing.Size(78, 23);
            this.chkOne.TabIndex = 2;
            this.chkOne.Text = "Chọn";
            this.chkOne.CheckedChanged += new System.EventHandler(this.chkOne_CheckedChanged);
            // 
            // frmDY
            // 
            this.frmDY.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.frmDY.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.frmDY.Location = new System.Drawing.Point(93, 109);
            this.frmDY.Name = "frmDY";
            this.frmDY.Size = new System.Drawing.Size(75, 23);
            this.frmDY.TabIndex = 3;
            this.frmDY.Text = "Đồng ý";
            this.frmDY.Click += new System.EventHandler(this.frmDY_Click);
            // 
            // cmbChon
            // 
            this.cmbChon.DisplayMember = "Text";
            this.cmbChon.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbChon.FormattingEnabled = true;
            this.cmbChon.ItemHeight = 18;
            this.cmbChon.Location = new System.Drawing.Point(93, 79);
            this.cmbChon.Name = "cmbChon";
            this.cmbChon.Size = new System.Drawing.Size(207, 24);
            this.cmbChon.TabIndex = 4;
            // 
            // frmTuyChonCN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 186);
            this.Controls.Add(this.cmbChon);
            this.Controls.Add(this.frmDY);
            this.Controls.Add(this.chkOne);
            this.Controls.Add(this.chkAll);
            this.Name = "frmTuyChonCN";
            this.Text = "Tùy chọn";
            this.Load += new System.EventHandler(this.frmTuyChonCN_Load);
            this.Controls.SetChildIndex(this.chkAll, 0);
            this.Controls.SetChildIndex(this.chkOne, 0);
            this.Controls.SetChildIndex(this.frmDY, 0);
            this.Controls.SetChildIndex(this.cmbChon, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.CheckBoxX chkAll;
        private DevComponents.DotNetBar.Controls.CheckBoxX chkOne;
        private DevComponents.DotNetBar.ButtonX frmDY;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbChon;
    }
}