using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
namespace Pharmacy.TRIAL.TrialMaker.SoftwareLocker
{
    public partial class frmDialog : BASIC.frmChild
    {
        private string _Pass;

        public frmDialog(string BaseString,
            string Password,int DaysToEnd,int Runed, string info)
        {
            InitializeComponent();
            sebBaseString.Text = BaseString;
            _Pass = Password;
            lblDays.Text = DaysToEnd.ToString() + " Ngày";
            lblTimes.Text = Runed.ToString() + " Lần";
            lblText.Text = info;
            if (DaysToEnd <= 0 || Runed <= 0)
            {
                lblDays.Text = "Hết hạn dùng thử";
                lblTimes.Text = "Hết hạn dùng thử";
                btnTrial.Enabled = false;
            }

            sebPassword.Select();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (_Pass == sebPassword.Text)
            {
                MessageBox.Show("Đăng ký bản quyền thành công", "Thông Báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
            }
            else
                MessageBox.Show("Đăng ký bản quyền không thành công", "Thông Báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        private void btnTrial_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Retry;
        }

        private void frmDialog_Load(object sender, EventArgs e)
        {
        }
    }
}