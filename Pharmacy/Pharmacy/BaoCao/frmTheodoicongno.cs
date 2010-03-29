using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Pharmacy.BaoCao
{
    public partial class frmTheodoicongno : Pharmacy.BASIC.frmChild
    {
        BLL.TTheodoicongno tcongno = new BLL.TTheodoicongno();

        public frmTheodoicongno()
        {
            InitializeComponent();
            SetTitle("THEO DÕI CÔNG NỢ KHÁCH HÀNG");
            dpkfrom.Value = DateTime.Now;
            dkpTo.Value = DateTime.Now;
        }

        private void cmdShow_Click(object sender, EventArgs e)
        {
            DateTime from =  dpkfrom.Value;
            DateTime to = dkpTo.Value;
            Showcongno(from, to);
        }
        private void Showcongno(DateTime from, DateTime to)
        {
            DataTable dt = tcongno.SetData(from, to);
            RPT.rptTheodoicongno rpt = new RPT.rptTheodoicongno();
            rpt.SetDataSource(dt);
            crystalReportViewer1.ReportSource = rpt;
            crystalReportViewer1.Refresh();
            dt.Clear();
        }
    }
}
