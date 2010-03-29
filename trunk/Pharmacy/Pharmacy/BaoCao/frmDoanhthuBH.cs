using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Pharmacy.BaoCao
{

    public partial class frmDoanhthuBH : Pharmacy.BASIC.frmChild
    {
        BLL.TDoanhthuBH tDoanhthuBH = new BLL.TDoanhthuBH();
        public frmDoanhthuBH()
        {
            InitializeComponent();
            SetTitle("BÁO CÁO DOANH THU BÁN HÀNG");
            dpkfrom.Value = DateTime.Now;
            dkpTo.Value = DateTime.Now;

        }

        private void cmdShow_Click(object sender, EventArgs e)
        {


            //if (dateti dpkfrom.Value  || dkpTo.Value == "")
            //    MessageBox.Show("Nhập thông tin báo cáo");
            //else
            //{
                DateTime from = dpkfrom.Value;
                DateTime to = dkpTo.Value;
                ShowDoanhthuBH(from, to);

            //}
        }
        private void ShowDoanhthuBH(DateTime from, DateTime to)
        {
            DataTable dt = tDoanhthuBH.SetData(from, to);
            RPT.rptDoanhthuBH rpt = new RPT.rptDoanhthuBH();
            rpt.SetDataSource(dt);
            crystalReportViewer1.ReportSource = rpt;
            crystalReportViewer1.Refresh();
            dt.Clear();
        }
    }
}
