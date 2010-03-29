using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace Pharmacy
{
    public partial class frmLogin : BASIC.frmChild
    {
        BLL.TLogin tLogin = new BLL.TLogin();
        int maTDV;
        string tenDN;
        public frmLogin()
        {
            InitializeComponent();
        }
        public void Inti() {
            SetTitle("ĐĂNG NHẬP");

        }
        public void refesh() {
            txtPass.Text = "";
            txtUser.Text = "";
        }
        private void frmLogin_Load(object sender, EventArgs e)
        {
            Inti();
        }
        public void CheckLogin() {
            try
            {
                DataTable dt = tLogin.CheckMatKhau(txtUser.Text.Trim(), txtPass.Text.Trim());
                if (dt.Rows.Count > 0)
                {
                    refesh();
                    maTDV = int.Parse(dt.Rows[0]["MA"].ToString());
                    tenDN = dt.Rows[0]["TEN"].ToString();
                    this.Hide();
                    frmMain frm = new frmMain();
                    frm.Show(this, maTDV, tenDN);
                    frm.FormClosed += new FormClosedEventHandler(frm_FormClosed);

                }
                else MessageBox.Show("Thông tin đăng nhập không hợp lệ!");
            }
            catch (Exception ex)
            {
                TLog.WriteErr("frmDangNhap_CheckLogin", ex.Message + "|" + ex.StackTrace);
            }
        }

        void frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            refesh();
            this.Show(); 
            
        }
    
        private void cmdDn_Click(object sender, EventArgs e)
        {
            CheckLogin();
        }

        private void cmdTHoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                CheckLogin();
        }

       
    }
}