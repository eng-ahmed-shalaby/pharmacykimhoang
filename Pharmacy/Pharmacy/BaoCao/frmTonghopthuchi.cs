using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Pharmacy.BaoCao
{
    public partial class frmTonghopthuchi : Pharmacy.BASIC.frmChild
    {
        BLL.TTonghopthuchi tcongno = new BLL.TTonghopthuchi();

        public frmTonghopthuchi()
        {
            InitializeComponent();
            SetTitle("TỔNG HỢP THU CHI THEO THÁNG");
            txtThang.Value = DateTime.Now.Month;
            txtNam.Value = DateTime.Now.Year;
        }

        private void cmdShow_Click(object sender, EventArgs e)
        {
            Showtonghopthuchi(int.Parse(txtThang.Text), int.Parse(txtNam.Text));
        }
        private void Showtonghopthuchi(int thang, int nam)
        {
            DataTable dt = tcongno.Gettonghopthuchi(thang, nam);
            RPT.rptTonghopthuchi rpt = new RPT.rptTonghopthuchi();
            rpt.SetDataSource(dt);
            crystalReportViewer1.ReportSource = rpt;
            crystalReportViewer1.Refresh();
            dt.Clear();
        }
    }
}
