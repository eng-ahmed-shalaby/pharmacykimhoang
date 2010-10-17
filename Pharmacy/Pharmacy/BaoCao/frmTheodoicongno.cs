using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;

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
            //DateTime from =  dpkfrom.Value;
            //DateTime to = dkpTo.Value;
            //Showcongno(from, to);
            frmTuyChonCN frm = new frmTuyChonCN();
            frm.FormClosed += new FormClosedEventHandler(frm_FormClosed);
            frm.Show(0);
        }
        private void cmdNCC_Click(object sender, EventArgs e)
        {
            //DateTime from = dpkfrom.Value;
            //DateTime to = dkpTo.Value;
            //ShowcongnoNCC(from, to);
            frmTuyChonCN frm = new frmTuyChonCN();
            frm.FormClosed += new FormClosedEventHandler(frm1_FormClosed);
            frm.Show(1);
        }
        void frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            string ten = (string)((Form)sender).Tag;
            DateTime from = dpkfrom.Value;
            DateTime to = dkpTo.Value;
            ShowcongnoKH(ten,from, to);
        }
        void frm1_FormClosed(object sender, FormClosedEventArgs e)
        {
            string ten = (string)((Form)sender).Tag;
            DateTime from = dpkfrom.Value;
            DateTime to = dkpTo.Value;

            ShowcongnoNCC(ten,from, to);

        }
         private void ShowcongnoNCC(string ten, DateTime from, DateTime to)
        {    DataTable dt = new DataTable();
             dt = tcongno.SetData_NCC(from, to);
            if (ten != "")
            {
                int i = 0;
                for (i = 0; i < dt.Rows.Count; i++)
                {
                    if (dt.Rows[i]["kh"].ToString() != ten)
                    {
                        dt.Rows[i].Delete();
                        i -=1;
                    }

                }
            } 
             RPT.rptTheodoicongno_ncc rpt = new RPT.rptTheodoicongno_ncc();
                rpt.SetDataSource(dt);
                crystalReportViewer1.ReportSource = rpt;
                crystalReportViewer1.Refresh();
                dt.Clear();

        }

        
        private void ShowcongnoKH(string ten,DateTime from, DateTime to)
        {
            DataTable dt = tcongno.SetData(from, to);
            if (ten != "")
            {
                int i = 0;
                for (i = 0; i < dt.Rows.Count; i++)
                {
                    if (dt.Rows[i]["kh"].ToString() != ten)
                    {
                        dt.Rows[i].Delete();
                        i -= 1;
                    }

                }
            } 
                RPT.rptTheodoicongno rpt = new RPT.rptTheodoicongno();
                rpt.SetDataSource(dt);
                crystalReportViewer1.ReportSource = rpt;
                crystalReportViewer1.Refresh();
                dt.Clear();
        }
        private void dpkfrom_Click(object sender, EventArgs e)
        {

        }

    }
}
