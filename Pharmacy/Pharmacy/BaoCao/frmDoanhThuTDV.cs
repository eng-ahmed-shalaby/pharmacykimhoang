using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Pharmacy.BaoCao
{
    public partial class frmDoanhThuTDV : Pharmacy.BASIC.frmChild
    {
        BLL.TDoanhthuTDV tDoanhthuTDV = new BLL.TDoanhthuTDV();

        public frmDoanhThuTDV()
        {
            InitializeComponent();
            SetTitle("BÁO CÁO DOANH THU TRÌNH DƯỢC VIÊN");
            dpkfrom.Value = DateTime.Now;
            dkpTo.Value = DateTime.Now;
        }

        private void cmdShow_Click(object sender, EventArgs e)
        {
            DateTime from = dpkfrom.Value;
            DateTime to = dkpTo.Value;
            ShowDoanhthuTDV(from, to);
        }
        private void ShowDoanhthuTDV(DateTime from, DateTime to)
        {
            DataTable dt = tDoanhthuTDV.SetData(from, to);
            RPT.rptDoanhthuTDV rpt = new RPT.rptDoanhthuTDV();
            rpt.SetDataSource(dt);
            crystalReportViewer1.ReportSource = rpt;
            crystalReportViewer1.Refresh();
            dt.Clear();
        }
    }
}
