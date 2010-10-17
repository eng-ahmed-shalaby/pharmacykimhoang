using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace Pharmacy.BaoCao
{
    public partial class frmTuyChonCN : BASIC.frmChild
    {
        public frmTuyChonCN()
        {
            InitializeComponent();
        }
        Pharmacy.BLL.TKhachHang tKH = new Pharmacy.BLL.TKhachHang();
        Pharmacy.BLL.TNhaCC tNCC = new Pharmacy.BLL.TNhaCC();
        public int flag = 0;
        public string ten = "";
        public void Show(int _flag)
        {
            flag = _flag;
            this.ShowDialog();
        }

        private void frmTuyChonCN_Load(object sender, EventArgs e)
        {
            SetTitle("TÙY CHỌN");
            ShowComboBox(flag);
            cmbChon.Enabled = false;

        }
        public void ShowComboBox(int _flag)
        {
            DataTable dt = new DataTable();
            if (flag == 0)
            {
                dt = tKH.GetKhachHang_All();
                cmbChon.DataSource = dt;
                cmbChon.DisplayMember = "TEN";
                cmbChon.ValueMember = "CODEKH";
            }
            else
            {
                dt = tNCC.GetNCC();
                cmbChon.DataSource = dt;
                cmbChon.DisplayMember = "TEN";
                cmbChon.ValueMember = "CODENCC";
            }
        }
        private void frmDY_Click(object sender, EventArgs e)
        {
          
            if (chkAll.Checked == true)
            {
                ten = "";
            }
            else
            {
                ten = cmbChon.SelectedValue.ToString() + "   " + cmbChon.Text;
            }
            this.Tag = ten;
            this.Close();
        }

        private void chkAll_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAll.Checked == true)
            { cmbChon.Enabled = false; }
            else { cmbChon.Enabled = true; }
        }

        private void chkOne_CheckedChanged(object sender, EventArgs e)
        {
            if (chkOne.Checked == true)
            {
                cmbChon.Enabled = true;
            }
            else { cmbChon.Enabled = false; }
        }
    }
}
