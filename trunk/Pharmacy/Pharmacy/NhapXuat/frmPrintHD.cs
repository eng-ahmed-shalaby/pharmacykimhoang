using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Pharmacy.NhapXuat
{
    public partial class frmPrintHD : BASIC.frmChild
    {
        BLL.TrptNhap trpt = new BLL.TrptNhap();
        BLL.TrptXuat tXuat = new BLL.TrptXuat();
        public frmPrintHD()
        {
            InitializeComponent();
            SetTitle("");
        }
        private void ShowNhap(int ma)
        {
            DataSet ds = new DataSet();
            DataTable dt = trpt.SetData(ma);
            ds.Tables.Add(dt);
            rptHDNhap rpt = new rptHDNhap();
            rpt.SetDataSource(ds.Tables[0]);
            crystalReportViewer1.ReportSource = rpt;
            crystalReportViewer1.Refresh();
        }
        private void ShowXuat(int ma)
        {
            DataSet ds = new DataSet();
            DataTable dt = tXuat.SetData(ma);
            ds.Tables.Add(dt);
            rptHDXuat rpt = new rptHDXuat();
            rpt.SetDataSource(ds.Tables[0]);
            crystalReportViewer1.ReportSource = rpt;
            crystalReportViewer1.Refresh();
        }
        public void ShowFromNhap(int ma) {
            ShowNhap(ma);
            this.ShowDialog();

        }
        public void ShowFromXuat(int ma)
        {
            ShowXuat(ma);
            this.ShowDialog();

        }
    }
}
