using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Pharmacy.ThuChi
{
    public partial class frmrptThu : BASIC.frmChild
    {
     
        public frmrptThu()
        {
            InitializeComponent();
            
        }
        public void Show(int ma , int type)
        {
            if (type == 0)
            {
                SetTitle("PHIẾU CHI"); 
              ShowrptChi(ma);
            }
            else {
                SetTitle("PHIẾU THU");
                ShowrptThu(ma);
            }
            
            this.ShowDialog();
            
        }
        private void ShowrptThu(int ma)
        {
            ThuChi.BLL.TrptThu trptThu = new ThuChi.BLL.TrptThu();
            DataTable dt = trptThu.SetData(ma);
            rptPhieuThu rpt = new rptPhieuThu();
            rpt.SetDataSource(dt);
            crystalReportViewer1.ReportSource = rpt;
            crystalReportViewer1.Refresh();
            dt.Clear();
        }
        private void ShowrptChi(int ma)
        {
           ThuChi.BLL.TrptChi trptChi = new ThuChi.BLL.TrptChi();
            DataTable dt = trptChi.SetData(ma);
            rptPhieuChi rpt = new rptPhieuChi();
            rpt.SetDataSource(dt);
            crystalReportViewer1.ReportSource = rpt;
            crystalReportViewer1.Refresh();
            dt.Clear();
        }
        private void Demo()
        {
            ThuChi.Info.PhieuChi phieuthu = new Pharmacy.ThuChi.Info.PhieuChi();
            phieuthu.Ma = 1;
            phieuthu.MaNCC = 34;
               rptPhieuChi rpt = new rptPhieuChi();
            crystalReportViewer1.ReportSource = rpt;
            crystalReportViewer1.Refresh();
        }
    }
}
