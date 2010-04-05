
namespace Pharmacy.TRIAL.TrialMaker.SoftwareLocker
{
    partial class frmDialog
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
            this.btnOK = new DevComponents.DotNetBar.ButtonX();
            this.btnTrial = new System.Windows.Forms.Button();
            this.grbRegister = new System.Windows.Forms.GroupBox();
            this.lblText = new System.Windows.Forms.Label();
            this.lblSerial = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.lblCallPhone = new System.Windows.Forms.Label();
            this.sebBaseString = new Pharmacy.TRIAL.SerialBoxControls.SerialBox();
            this.sebPassword = new Pharmacy.TRIAL.SerialBoxControls.SerialBox();
            this.lblComment = new System.Windows.Forms.Label();
            this.lblDaysToEnd = new System.Windows.Forms.Label();
            this.lblDays = new System.Windows.Forms.Label();
            this.lblRunTimesLeft = new System.Windows.Forms.Label();
            this.lblTimes = new System.Windows.Forms.Label();
            this.grbTrialRunning = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grbRegister.SuspendLayout();
            this.grbTrialRunning.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnOK.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.btnOK.Location = new System.Drawing.Point(113, 174);
            this.btnOK.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(87, 28);
            this.btnOK.TabIndex = 5;
            this.btnOK.Text = "Đồ&ng ý";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnTrial
            // 
            this.btnTrial.Location = new System.Drawing.Point(285, 32);
            this.btnTrial.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTrial.Name = "btnTrial";
            this.btnTrial.Size = new System.Drawing.Size(73, 28);
            this.btnTrial.TabIndex = 2;
            this.btnTrial.Text = "Dùng thử";
            this.btnTrial.UseVisualStyleBackColor = true;
            this.btnTrial.Click += new System.EventHandler(this.btnTrial_Click);
            // 
            // grbRegister
            // 
            this.grbRegister.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grbRegister.Controls.Add(this.lblText);
            this.grbRegister.Controls.Add(this.lblSerial);
            this.grbRegister.Controls.Add(this.lblID);
            this.grbRegister.Controls.Add(this.lblCallPhone);
            this.grbRegister.Controls.Add(this.sebBaseString);
            this.grbRegister.Controls.Add(this.btnOK);
            this.grbRegister.Controls.Add(this.sebPassword);
            this.grbRegister.Location = new System.Drawing.Point(14, 66);
            this.grbRegister.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbRegister.Name = "grbRegister";
            this.grbRegister.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbRegister.Size = new System.Drawing.Size(397, 281);
            this.grbRegister.TabIndex = 1;
            this.grbRegister.TabStop = false;
            this.grbRegister.Text = "Đăng ký";
            // 
            // lblText
            // 
            this.lblText.ForeColor = System.Drawing.Color.Red;
            this.lblText.Location = new System.Drawing.Point(10, 206);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(345, 67);
            this.lblText.TabIndex = 6;
            // 
            // lblSerial
            // 
            this.lblSerial.AutoSize = true;
            this.lblSerial.Location = new System.Drawing.Point(10, 118);
            this.lblSerial.Name = "lblSerial";
            this.lblSerial.Size = new System.Drawing.Size(146, 16);
            this.lblSerial.TabIndex = 3;
            this.lblSerial.Text = "Mã kích hoạt ứng dụng:";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(10, 69);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(89, 16);
            this.lblID.TabIndex = 1;
            this.lblID.Text = "Mã ứng dụng:";
            // 
            // lblCallPhone
            // 
            this.lblCallPhone.AutoSize = true;
            this.lblCallPhone.Location = new System.Drawing.Point(7, 17);
            this.lblCallPhone.Name = "lblCallPhone";
            this.lblCallPhone.Size = new System.Drawing.Size(333, 48);
            this.lblCallPhone.TabIndex = 0;
            this.lblCallPhone.Text = "Gọi điện hoặc gởi mail và cung cấp \'Mã ứng dụng\r\ncủa chương trình trên máy bạn.\r\n" +
                "Bạn sẽ được cấp một dãy số để kích hoạt chương trình";
            // 
            // sebBaseString
            // 
            this.sebBaseString.CaptleLettersOnly = true;
            this.sebBaseString.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F);
            this.sebBaseString.Location = new System.Drawing.Point(14, 91);
            this.sebBaseString.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.sebBaseString.Name = "sebBaseString";
            this.sebBaseString.ReadOnly = true;
            this.sebBaseString.Size = new System.Drawing.Size(342, 22);
            this.sebBaseString.TabIndex = 2;
            // 
            // sebPassword
            // 
            this.sebPassword.CaptleLettersOnly = true;
            this.sebPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F);
            this.sebPassword.Location = new System.Drawing.Point(14, 144);
            this.sebPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.sebPassword.Name = "sebPassword";
            this.sebPassword.Size = new System.Drawing.Size(342, 22);
            this.sebPassword.TabIndex = 4;
            // 
            // lblComment
            // 
            this.lblComment.Location = new System.Drawing.Point(0, 9);
            this.lblComment.Name = "lblComment";
            this.lblComment.Size = new System.Drawing.Size(425, 20);
            this.lblComment.TabIndex = 0;
            this.lblComment.Text = "BẢN QUỀN THUỘC VỀ:";
            // 
            // lblDaysToEnd
            // 
            this.lblDaysToEnd.AutoSize = true;
            this.lblDaysToEnd.Location = new System.Drawing.Point(10, 27);
            this.lblDaysToEnd.Name = "lblDaysToEnd";
            this.lblDaysToEnd.Size = new System.Drawing.Size(116, 16);
            this.lblDaysToEnd.TabIndex = 3;
            this.lblDaysToEnd.Text = "Số ngày dùng thử:";
            // 
            // lblDays
            // 
            this.lblDays.AutoSize = true;
            this.lblDays.ForeColor = System.Drawing.Color.Red;
            this.lblDays.Location = new System.Drawing.Point(154, 27);
            this.lblDays.Name = "lblDays";
            this.lblDays.Size = new System.Drawing.Size(46, 16);
            this.lblDays.TabIndex = 4;
            this.lblDays.Text = "[Ngày]";
            // 
            // lblRunTimesLeft
            // 
            this.lblRunTimesLeft.AutoSize = true;
            this.lblRunTimesLeft.Location = new System.Drawing.Point(10, 59);
            this.lblRunTimesLeft.Name = "lblRunTimesLeft";
            this.lblRunTimesLeft.Size = new System.Drawing.Size(81, 16);
            this.lblRunTimesLeft.TabIndex = 5;
            this.lblRunTimesLeft.Text = "Sồ lần chạy:";
            // 
            // lblTimes
            // 
            this.lblTimes.AutoSize = true;
            this.lblTimes.ForeColor = System.Drawing.Color.Red;
            this.lblTimes.Location = new System.Drawing.Point(154, 59);
            this.lblTimes.Name = "lblTimes";
            this.lblTimes.Size = new System.Drawing.Size(37, 16);
            this.lblTimes.TabIndex = 6;
            this.lblTimes.Text = "[Lần]";
            // 
            // grbTrialRunning
            // 
            this.grbTrialRunning.Controls.Add(this.lblDaysToEnd);
            this.grbTrialRunning.Controls.Add(this.lblRunTimesLeft);
            this.grbTrialRunning.Controls.Add(this.lblDays);
            this.grbTrialRunning.Controls.Add(this.lblTimes);
            this.grbTrialRunning.Controls.Add(this.btnTrial);
            this.grbTrialRunning.Location = new System.Drawing.Point(14, 363);
            this.grbTrialRunning.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbTrialRunning.Name = "grbTrialRunning";
            this.grbTrialRunning.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbTrialRunning.Size = new System.Drawing.Size(370, 91);
            this.grbTrialRunning.TabIndex = 8;
            this.grbTrialRunning.TabStop = false;
            this.grbTrialRunning.Text = "Dùng thử";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Gainsboro;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(-3, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(429, 27);
            this.label1.TabIndex = 10;
            this.label1.Text = "CTY THIẾT KẾ-QUẢNG CÁO KIM HOÀNG";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmDialog
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(425, 364);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblComment);
            this.Controls.Add(this.grbRegister);
            this.Controls.Add(this.grbTrialRunning);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(431, 396);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(431, 396);
            this.Name = "frmDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng ký bản quyền phần mềm";
            this.Load += new System.EventHandler(this.frmDialog_Load);
            this.Controls.SetChildIndex(this.grbTrialRunning, 0);
            this.Controls.SetChildIndex(this.grbRegister, 0);
            this.Controls.SetChildIndex(this.lblComment, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.grbRegister.ResumeLayout(false);
            this.grbRegister.PerformLayout();
            this.grbTrialRunning.ResumeLayout(false);
            this.grbTrialRunning.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private SerialBoxControls.SerialBox sebBaseString;
        private SerialBoxControls.SerialBox sebPassword;
        private DevComponents.DotNetBar.ButtonX btnOK;
        private System.Windows.Forms.Button btnTrial;
        private System.Windows.Forms.GroupBox grbRegister;
        private System.Windows.Forms.Label lblCallPhone;
        private System.Windows.Forms.Label lblComment;
        private System.Windows.Forms.Label lblSerial;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblDaysToEnd;
        private System.Windows.Forms.Label lblDays;
        private System.Windows.Forms.Label lblRunTimesLeft;
        private System.Windows.Forms.Label lblTimes;
        private System.Windows.Forms.GroupBox grbTrialRunning;
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.Label label1;

    }
}