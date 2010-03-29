using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Pharmacy.BaoCao
{
    public partial class frmRptNhap : BASIC.frmChild
    {
        BLL.TNhap tNhap = new BLL.TNhap();
        Pharmacy.BLL.THangHoa tHH = new Pharmacy.BLL.THangHoa();
        Pharmacy.BLL.TKho tKho = new Pharmacy.BLL.TKho();
        BLL.TXuat tXuat = new BLL.TXuat();
        BLL.TTheokho tTheKho = new BLL.TTheokho();
        int fg = 0;
        public frmRptNhap()
        {
            InitializeComponent();
            ShowHH();
            ShowKho();
            dtpTungay.Value = DateTime.Now;
            dtpdengay.Value = DateTime.Now;
        }
        public void ShowHH()
        {
            DataTable dt = tHH.GetHangHoa_ALL();
            cmbTenThuoc.DisplayMember = "TENHANGHOA";
            cmbTenThuoc.ValueMember = "MA";
            cmbTenThuoc.DataSource = dt;
        }
        public void ShowKho()
        {
            DataTable data = tKho.GetKho(0);
            cmbKho.DisplayMember = "TEN";
            cmbKho.ValueMember = "MAKHO";
            cmbKho.DataSource = data;

        }
        public void ShowRPT(int flag)
        {
            fg = flag;
            if (fg == 0)
            {
                SetTitle("BÁO CÁO NHẬP");
                panelNhapXuat.Visible = true;
                panelTheKho.Visible = false;
            }
            else if (fg == 1)
            {
                SetTitle("BÁO CÁO XUÂT");
                panelNhapXuat.Visible = true;
                panelTheKho.Visible = false;
            }
            else
            {
                SetTitle("THẺ KHO");
                panelNhapXuat.Visible = false;
                panelTheKho.Visible = true;
            }
            this.Show();

        }
        private void ShowNhap(DateTime tu, DateTime den)
        {
            DataTable dt = tNhap.SetData(tu, den);
            RPT.rptNhap rpt = new RPT.rptNhap();
            rpt.SetDataSource(dt);
            crystalReportViewer1.ReportSource = rpt;
            crystalReportViewer1.Refresh();
            dt.Clear();
        }
        private void ShowXuat(DateTime tu, DateTime den)
        {
            DataTable dt = tXuat.SetData(tu, den);
            RPT.rptXuat rpt = new RPT.rptXuat();
            rpt.SetDataSource(dt);
            crystalReportViewer1.ReportSource = rpt;
            crystalReportViewer1.Refresh();
            dt.Clear();
        }

        private void ShowTheKho(int maHH, int maKho, DateTime from, DateTime to)
        {
            DataTable dt = tTheKho.SetData(maHH, maKho, from, to);
            RPT.rptTheKho rpt = new RPT.rptTheKho();
            rpt.SetDataSource(dt);
            crystalReportViewer1.ReportSource = rpt;
            crystalReportViewer1.Refresh();
            dt.Clear();
        }
        private void cmdShow_Click(object sender, EventArgs e)
        {
            if (dtpdengay.Value.ToString() == "" || dtpTungay.Value.ToString() == "")
                MessageBox.Show("Nhập thông tin báo cáo");
            else
            {
                if (fg == 0)
                    ShowNhap(dtpTungay.Value, dtpdengay.Value);
                if (fg == 1)
                    ShowXuat(dtpTungay.Value, dtpdengay.Value);

            }
        }

        private void cmdTheKho_Click(object sender, EventArgs e)
        {
            int mahh = int.Parse(cmbTenThuoc.SelectedValue.ToString());
            int maK = int.Parse(cmbKho.SelectedValue.ToString());
            DateTime from = dpkfrom.Value;
            DateTime to = dkpTo.Value;
            ShowTheKho(mahh, maK, from, to);

        }
    }
}
