using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Pharmacy.BaoCao
{
    public partial class frmTonghopthu_chi : Pharmacy.BASIC.frmChild
    {
        BLL.TTonghopthu tThu = new BLL.TTonghopthu();
        BLL.TTonghopchi tChi = new BLL.TTonghopchi();
        public frmTonghopthu_chi()
        {
            InitializeComponent();
            SetTitle("Báo cáo Thu chi theo tháng");
        }
        public void ShowThu(int thang, int nam) {
            DataTable dt = tThu.SetData(thang, nam);
            RPT.rptTonghopthu rpt = new RPT.rptTonghopthu();
            rpt.SetDataSource(dt);
            crystalReportViewer1.ReportSource = rpt;
            crystalReportViewer1.Refresh();
            dt.Clear();
        }
        public void ShowChi(int thang, int nam)
        {
            DataTable dt = tChi.SetData(thang, nam);
            RPT.rptTonghopchi rpt = new RPT.rptTonghopchi();
            rpt.SetDataSource(dt);
            crystalReportViewer1.ReportSource = rpt;
            crystalReportViewer1.Refresh();
            dt.Clear();
        }
        private void cmdShow_Click(object sender, EventArgs e)
        {
            if (rdThu.Checked) ShowThu(int.Parse(txtThang.Text), int.Parse(txtNam.Text));
            if(rdChi.Checked) ShowChi(int.Parse(txtThang.Text),int.Parse(txtNam.Text));
        }
    }
}
