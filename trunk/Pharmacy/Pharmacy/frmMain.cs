using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace Pharmacy
{
    public partial class frmMain : DevComponents.DotNetBar.Office2007RibbonForm
    {
        public frmMain()
        {
            InitializeComponent();
        }
        BLL.TLogin tlogin = new BLL.TLogin();
        private DataTable LayQuyen(int _maTDV)
        {
            DataTable dt = tlogin.GetQuyen(_maTDV);
            return dt;

        }
        public void HideTab() {
            tab1.Visible = false;
            tab2.Visible = false;
            tab3.Visible = false;
            tab4.Visible = false;
            tab5.Visible = false;
            tab6.Visible = false;
            tab7.Visible = false;
        }
        public static Form fLogin;
        public void Show(Form f, int maTDV,string ten) {
            fLogin = f;
            lblUser.Text = ten;
            DataTable dt = LayQuyen(maTDV);
            this.Show();
            HideTab();
            for (int i = 0; i < dt.Rows.Count; i++) {
                if ((bool)dt.Rows[i]["Quyen"] == true)
                {
                    switch (dt.Rows[i]["TabName"].ToString().Trim())
                    {
                        case "tab1":
                                tab1.Visible = true;
                                break;
                        case "tab2":
                                tab2.Visible = true;
                                break;
                        case "tab3":
                                tab3.Visible = true;
                                break;
                        case "tab4":
                                tab4.Visible = true;
                                break;
                        case "tab5":
                                tab5.Visible = true;
                                break;
                        case "tab6":
                                tab6.Visible = true;
                                break;
                        case "tab7":
                                tab7.Visible = true;
                                break;
                    }
                }
            }

        }
        private void tab2bntNhapKho_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
                this.ActiveMdiChild.Close();
            NhapXuat.frmNhapKho frmNhapKho = new NhapXuat.frmNhapKho();
            frmNhapKho.MdiParent = this;
            frmNhapKho.Show();
        }

      

        private void tab1btn1_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
                this.ActiveMdiChild.Close();
            QuanLy.frmHangHoa frm = new Pharmacy.QuanLy.frmHangHoa();
            frm.MdiParent = this;
            frm.Show();
        }

        private void tab2btn2XuatKho_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
                this.ActiveMdiChild.Close();
            NhapXuat.frmXuatKho frmXuatKho = new NhapXuat.frmXuatKho();
            frmXuatKho.MdiParent = this;
            frmXuatKho.Show();
        }

        private void tab3bntrptNhap_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
                this.ActiveMdiChild.Close();
            BaoCao.frmRptNhap frm = new Pharmacy.BaoCao.frmRptNhap();
            frm.MdiParent = this;
            frm.ShowRPT(0);
        }

        private void tab3bnt2rptXuat_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
                this.ActiveMdiChild.Close();
            BaoCao.frmRptNhap frm = new Pharmacy.BaoCao.frmRptNhap();
            frm.MdiParent = this;
            frm.ShowRPT(1);
        }
        private void tab3btnTheKho_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
                this.ActiveMdiChild.Close();
            BaoCao.frmRptNhap frm = new Pharmacy.BaoCao.frmRptNhap();
            frm.MdiParent = this;
            frm.ShowRPT(2);
        }

    
        private void ribbonPanel5_Click(object sender, EventArgs e)
        {

        }

      
        private void btnKC_Click(object sender, EventArgs e)
        {
            Pharmacy.QuanLy.BLL.TTonkho tTonKho = new Pharmacy.QuanLy.BLL.TTonkho();
            DataTable data = tTonKho.GetKho_tonkho();
            if (data.Rows.Count > 0) MessageBox.Show("Tháng này đã kết chuyển");
            else
            {
                DLL.DataAccess cn = new DLL.DataAccess();
                cn.ExecuteNonQuery("sp_ketchuyenkho", null);
                MessageBox.Show("Đã kết chuyển thành công");
            }

        }
        private void btnNCC_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
                this.ActiveMdiChild.Close();
            QuanLy.frmNCC frm = new QuanLy.frmNCC();
            frm.MdiParent = this;
            frm.Show();
        }
        private void btnNhaSX_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
                this.ActiveMdiChild.Close();
            QuanLy.frmNSX frm = new QuanLy.frmNSX();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnKH_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
                this.ActiveMdiChild.Close();
            QuanLy.frmKhachHang frm = new QuanLy.frmKhachHang();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnKhuyenMai_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
                this.ActiveMdiChild.Close();
            QuanLy.frmKhuyenMai frm = new QuanLy.frmKhuyenMai();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnHeSo_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
                this.ActiveMdiChild.Close();
            QuanLy.frmQuyCach frm = new QuanLy.frmQuyCach();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnDonVi_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
                this.ActiveMdiChild.Close();
            QuanLy.frmDonvi frm = new QuanLy.frmDonvi();
            frm.MdiParent = this;
            frm.Show();
        }

        private void bntDonGia_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
                this.ActiveMdiChild.Close();
            QuanLy.frmQuyCach frm = new QuanLy.frmQuyCach();
            frm.MdiParent = this;
            frm.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
         
        }

        private void btnPhieuThu_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
                this.ActiveMdiChild.Close();
            ThuChi.frmPhieuThu frm = new ThuChi.frmPhieuThu();
            frm.MdiParent = this;
            frm.Show();

        }

        private void btnPhanQuyen_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
                this.ActiveMdiChild.Close();
            HeThong.frmPhanQuyen frm = new HeThong.frmPhanQuyen();
            frm.MdiParent = this;
            frm.Show();

        }

        private void tab4cmdDoanhThuKH_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
                this.ActiveMdiChild.Close();
            BaoCao.frmDoanhthuKH frm = new Pharmacy.BaoCao.frmDoanhthuKH();
            frm.MdiParent = this;
            frm.Show();
        }

        private void tab4cmdDoanhThu_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
                this.ActiveMdiChild.Close();
            BaoCao.frmDoanhthuBH frm = new Pharmacy.BaoCao.frmDoanhthuBH();
            frm.MdiParent = this;
            frm.Show();
        }

        private void tab4cmdTDV_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
                this.ActiveMdiChild.Close();
            BaoCao.frmDoanhThuTDV frm = new Pharmacy.BaoCao.frmDoanhThuTDV();
            frm.MdiParent = this;
            frm.Show();
        }
        /// <summary>
        ///  Tab menu control
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cmdDangXuat_Click(object sender, EventArgs e)
        {
            this.Close();
           // fLogin.Show();
            
        }

        private void buttonItem12_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
                this.ActiveMdiChild.Close();
            BaoCao.frmTheodoicongno frm = new Pharmacy.BaoCao.frmTheodoicongno();
            frm.MdiParent = this;
            frm.Show();
        }

        private void tab6cmd1_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
                this.ActiveMdiChild.Close();
            NhanVien.frmTDV frm = new NhanVien.frmTDV();
            frm.MdiParent = this;
            frm.Show();
        }

        private void bar2cmdThuChi_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
                this.ActiveMdiChild.Close();
            BaoCao.frmTonghopthuchi frm = new BaoCao.frmTonghopthuchi();
            frm.MdiParent = this;
            frm.Show();
        }

        private void bntPhieuChi_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
                this.ActiveMdiChild.Close();
            ThuChi.frmPhieuChi frm = new ThuChi.frmPhieuChi();
            frm.MdiParent = this;
            frm.Show();
        }

        private void tab7_Click(object sender, EventArgs e)
        {

        }

        private void btnLuTru_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
                this.ActiveMdiChild.Close();
            HeThong.frmBk_Restore frm = new HeThong.frmBk_Restore();
            frm.MdiParent = this;
            frm.Show();
        }

        private void tab3btnNhacNho_Click(object sender, EventArgs e)
        {

           ThuChi.frmCongNo frm = new ThuChi.frmCongNo();
            frm.MdiParent = this;
            frm.Show();
        }

     

      

     


   

    

     

      

    

     
    }
}