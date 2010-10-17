using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.Windows.Forms;

namespace Pharmacy.NhapXuat
{
    public partial class frmPrintHD : BASIC.frmChild
    {
        BLL.TrptNhap trpt = new BLL.TrptNhap();
        BLL.TrptXuat tXuat = new BLL.TrptXuat();
        int maHD;
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
        public void ShowHD(int ma)
        {  DataTable dt = new DataTable();
        if (ma == 0)
            //   DataSet ds = new DataSet();
            dt = tXuat.GetDataHD(maHD);
        else dt = tXuat.GetDataHD(ma);
          //  ds.Tables.Add(dt);
            rptHD rpt = new rptHD();
            rpt.SetDataSource(dt);
            crystalReportViewer1.ReportSource = rpt;
            crystalReportViewer1.Refresh();
        }
        public void ShowHDNoView(int ma)
        {
            DataTable dt = new DataTable();
            if (ma == 0)
                //   DataSet ds = new DataSet();
                dt = tXuat.GetDataHD(maHD);
            else dt = tXuat.GetDataHD(ma);
            //  ds.Tables.Add(dt);
            rptHD rpt = new rptHD();
            rpt.SetDataSource(dt);
            CrystalReportViewer rptview = new CrystalReportViewer();
            rptview.ReportSource = rpt;
            rptview.Refresh();
            rptview.PrintReport();
        }
        public void ShowFromNhap(int ma) {
            maHD = ma;
            cmdHDDon.Visible = false;
            ShowNhap(ma);
            this.ShowDialog();

        }
        public void ShowFromXuat(int ma)
        {
            maHD = ma;
            cmdHDDon.Visible = true;
            ShowXuat(ma);
            this.ShowDialog();

        }

        private void cmdHDDon_Click(object sender, EventArgs e)
        {
            ShowHD(0);
        }
    }
}
