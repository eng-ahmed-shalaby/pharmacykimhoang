using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Pharmacy.BaoCao
{
    public partial class frmDoanhthuKH : Pharmacy.BASIC.frmChild
    {
        BLL.TKhachHang tDoanhthuKH = new BLL.TKhachHang();

        public frmDoanhthuKH()
        {
            InitializeComponent();
            SetTitle("BÁO CÁO DOANH THU KHÁCH HÀNG");
            dpkfrom.Value = DateTime.Now;
            dkpTo.Value = DateTime.Now;
        }

         

       
        private void cmdShow_Click(object sender, EventArgs e)
        {
            DateTime from = dpkfrom.Value;
            DateTime to = dkpTo.Value;
            ShowDoanhthuKH(from, to);
        }
        private void ShowDoanhthuKH(DateTime from, DateTime to)
        {
            DataTable dt = tDoanhthuKH.SetData(from, to);
            RPT.rptDoanhthuKH rpt = new RPT.rptDoanhthuKH();
            rpt.SetDataSource(dt);
            crystalReportViewer1.ReportSource = rpt;
            crystalReportViewer1.Refresh();
            dt.Clear();
        }
    }
}
