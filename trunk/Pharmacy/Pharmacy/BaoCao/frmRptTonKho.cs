using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Pharmacy.BaoCao
{
    public partial class frmTonKho : Pharmacy.BASIC.frmChild
    {
        BaoCao.BLL.TTonKho tTK = new BaoCao.BLL.TTonKho();
        Pharmacy.BLL.TKho tKho = new Pharmacy.BLL.TKho();
        public frmTonKho()
        {
            InitializeComponent(); 
            SetTitle("BÁO CÁO TỔNG HỢP TỒN KHO");
           // ShowKho();
        }
      
        //public void ShowKho()
        //{
        //    DataTable data = tKho.GetKho(0);
        //    cmbKho.DisplayMember = "TEN";
        //    cmbKho.ValueMember = "MAKHO";
        //    cmbKho.DataSource = data;

        //}
       
        private void Showreport(int thang, int nam)
        {
            DataTable dt = tTK.SetData(thang, nam);
            RPT.rptTonKho rpt = new RPT.rptTonKho();
            rpt.SetDataSource(dt);
            crystalReportViewer1.ReportSource = rpt;
            crystalReportViewer1.Refresh();
            dt.Clear();
        }
        private void cmdTheKho_Click(object sender, EventArgs e)
        {
            try
            {
                Showreport(int.Parse(txtThang.Text.ToString()), int.Parse(txtNam.Text.ToString()));
            }
            catch (Exception ex) { TLog.WriteErr("frmfptTonKho_click", ex.Message); }
        }
    }
}
