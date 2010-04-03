namespace Pharmacy.HeThong
{
    partial class frmBk_Restore
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
            this.txtUser = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.cmbNameSer = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX26 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.txtPass = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtDB = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.cmdback = new DevComponents.DotNetBar.ButtonX();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtUser
            // 
            // 
            // 
            // 
            this.txtUser.Border.Class = "TextBoxBorder";
            this.txtUser.Location = new System.Drawing.Point(123, 75);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(191, 24);
            this.txtUser.TabIndex = 61;
            this.txtUser.Text = "sa";
            // 
            // cmbNameSer
            // 
            this.cmbNameSer.DisplayMember = "Text";
            this.cmbNameSer.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbNameSer.FormattingEnabled = true;
            this.cmbNameSer.ItemHeight = 18;
            this.cmbNameSer.Location = new System.Drawing.Point(122, 45);
            this.cmbNameSer.Name = "cmbNameSer";
            this.cmbNameSer.Size = new System.Drawing.Size(192, 24);
            this.cmbNameSer.TabIndex = 62;
            // 
            // labelX26
            // 
            this.labelX26.Location = new System.Drawing.Point(23, 44);
            this.labelX26.Name = "labelX26";
            this.labelX26.Size = new System.Drawing.Size(81, 25);
            this.labelX26.TabIndex = 63;
            this.labelX26.Text = "Tên Server:";
            // 
            // labelX1
            // 
            this.labelX1.Location = new System.Drawing.Point(23, 74);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(81, 25);
            this.labelX1.TabIndex = 64;
            this.labelX1.Text = "User:";
            // 
            // labelX2
            // 
            this.labelX2.Location = new System.Drawing.Point(23, 106);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(81, 25);
            this.labelX2.TabIndex = 65;
            this.labelX2.Text = "Pass:";
            // 
            // labelX3
            // 
            this.labelX3.Location = new System.Drawing.Point(23, 138);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(102, 25);
            this.labelX3.TabIndex = 66;
            this.labelX3.Text = "Tên Database:";
            // 
            // txtPass
            // 
            // 
            // 
            // 
            this.txtPass.Border.Class = "TextBoxBorder";
            this.txtPass.Location = new System.Drawing.Point(123, 107);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(191, 24);
            this.txtPass.TabIndex = 67;
            this.txtPass.Text = "123456";
            // 
            // txtDB
            // 
            // 
            // 
            // 
            this.txtDB.Border.Class = "TextBoxBorder";
            this.txtDB.Location = new System.Drawing.Point(123, 138);
            this.txtDB.Name = "txtDB";
            this.txtDB.Size = new System.Drawing.Size(191, 24);
            this.txtDB.TabIndex = 68;
            this.txtDB.Text = "Pharmacy";
            // 
            // cmdback
            // 
            this.cmdback.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.cmdback.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.cmdback.Location = new System.Drawing.Point(67, 2);
            this.cmdback.Margin = new System.Windows.Forms.Padding(0);
            this.cmdback.Name = "cmdback";
            this.cmdback.Size = new System.Drawing.Size(76, 25);
            this.cmdback.TabIndex = 69;
            this.cmdback.Text = "Backup";
            this.cmdback.Click += new System.EventHandler(this.cmdback_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.buttonX1.Location = new System.Drawing.Point(169, 2);
            this.buttonX1.Margin = new System.Windows.Forms.Padding(0);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(76, 25);
            this.buttonX1.TabIndex = 70;
            this.buttonX1.Text = "Restore";
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.SteelBlue;
            this.panel5.Controls.Add(this.cmdback);
            this.panel5.Controls.Add(this.buttonX1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 183);
            this.panel5.Margin = new System.Windows.Forms.Padding(0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(340, 29);
            this.panel5.TabIndex = 71;
            // 
            // frmBk_Restore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 212);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.txtDB);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.cmbNameSer);
            this.Controls.Add(this.labelX26);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(348, 246);
            this.MinimumSize = new System.Drawing.Size(348, 246);
            this.Name = "frmBk_Restore";
            this.Text = "frmBk_Restore";
            this.Load += new System.EventHandler(this.frmBk_Restore_Load);
            this.Controls.SetChildIndex(this.labelX26, 0);
            this.Controls.SetChildIndex(this.cmbNameSer, 0);
            this.Controls.SetChildIndex(this.txtUser, 0);
            this.Controls.SetChildIndex(this.labelX1, 0);
            this.Controls.SetChildIndex(this.labelX2, 0);
            this.Controls.SetChildIndex(this.labelX3, 0);
            this.Controls.SetChildIndex(this.txtPass, 0);
            this.Controls.SetChildIndex(this.txtDB, 0);
            this.Controls.SetChildIndex(this.panel5, 0);
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.TextBoxX txtUser;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbNameSer;
        private DevComponents.DotNetBar.LabelX labelX26;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.Controls.TextBoxX txtPass;
        private DevComponents.DotNetBar.Controls.TextBoxX txtDB;
        private DevComponents.DotNetBar.ButtonX cmdback;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private DevComponents.DotNetBar.ButtonX buttonX1;
        private System.Windows.Forms.Panel panel5;
    }
}