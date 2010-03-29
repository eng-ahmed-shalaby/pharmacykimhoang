using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Pharmacy.BaoCao
{
    public partial class frmRptKH : Pharmacy.BASIC.frmChild
    {
        Pharmacy.BLL.TKhachHang tKH = new Pharmacy.BLL.TKhachHang();
        Pharmacy.BLL.TKho tKho = new Pharmacy.BLL.TKho();
        public frmRptKH()
        {
            InitializeComponent();
            ShowKH();
            ShowKho();
        }
        public void ShowKH()
        {
            DataTable dt = tKH.GetKhachHang_All();
            cmbTenThuoc.DisplayMember = "TEN";
            cmbTenThuoc.ValueMember = "MAKH";
            cmbTenThuoc.DataSource = dt;
        }
        public void ShowKho()
        {
            DataTable data = tKho.GetKho(0);
            cmbKho.DisplayMember = "TEN";
            cmbKho.ValueMember = "MAKHO";
            cmbKho.DataSource = data;

        }
        public void ShowRPT()
        {
            SetTitle("BÁO CÁO KHÁCH HÀNG");
            this.Show();
            //DataTable dt = tNhap.SetData(thang, nam);
            //RPT.rptNhap rpt = new RPT.rptNhap();
            //rpt.SetDataSource(dt);
            //crystalReportViewer1.ReportSource = rpt;
            //crystalReportViewer1.Refresh();
            //dt.Clear();

           

        }
        private void Showreport(int thang, int nam,int makh)
        {
            //DataTable dt = tKH.SetData(thang, nam,makh);
            //RPT.rptNhap rpt = new RPT.rptNhap();
            //rpt.SetDataSource(dt);
            //crystalReportViewer1.ReportSource = rpt;
            //crystalReportViewer1.Refresh();
            //dt.Clear();
        }
        private void ShowXuat(int thang, int nam)
        {
            //DataTable dt = tXuat.SetData(thang, nam);
            //RPT.rptXuat rpt = new RPT.rptXuat();
            //rpt.SetDataSource(dt);
            //crystalReportViewer1.ReportSource = rpt;
            //crystalReportViewer1.Refresh();
            //dt.Clear();
        }

        private void ShowTheKho(int maHH, int maKho, DateTime from, DateTime to)
        {
            //DataTable dt = tTheKho.SetData(maHH, maKho, from, to);
            //RPT.rptTheKho rpt = new RPT.rptTheKho();
            //rpt.SetDataSource(dt);
            //crystalReportViewer1.ReportSource = rpt;
            //crystalReportViewer1.Refresh();
            //dt.Clear();
        }
    }
}
