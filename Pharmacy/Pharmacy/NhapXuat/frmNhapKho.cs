using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using Pharmacy.DLL;
namespace Pharmacy.NhapXuat
{

    public partial class frmNhapKho : BASIC.frmChild
    {
        #region Bien
        BLL.TNhapKho tNhapKho = new BLL.TNhapKho();
        DataTable HANGHOA = new DataTable();
        DataTable CTHD = new DataTable();
        DataTable HD = new DataTable();
        Info.HDNhapInfo infoHDNhap = new NhapXuat.Info.HDNhapInfo();
        Info.CTNHAPInfo infoCTNhap = new NhapXuat.Info.CTNHAPInfo();
        Info.CTNHAPInfo[] infoCTNhapArr = new NhapXuat.Info.CTNHAPInfo[50];
        Pharmacy.BLL.TBus tbus = new Pharmacy.BLL.TBus();
        double tienhh = 0;
        int num = 0;
       bool fagInsert = false;
       int SLQC = 0;
        #endregion
        public frmNhapKho()
        {
            InitializeComponent();
        }
       
        private void frmNhapKho_Load(object sender, EventArgs e)
        {
            this.SetTitle("LẬP HÓA ĐƠN NHẬP KHO");
            Init();
            cmdThemCT.Enabled = false;
            cmdTaoMoi.Visible = false;
        }
        #region Load Form

        private void Init()
        {
            try
            {
                ShowDonVi();
                ShowNCC();
                ShowLoaiSP();
                ShowQG();
                ShowKho();
                dpkNgayLap.Text = DateTime.Now.ToShortDateString();
                dpkNgayNhap.Text = DateTime.Now.ToShortDateString();
                dpkNgaySX.Text = DateTime.Now.ToShortDateString();
                dpkNgayHH.Text = DateTime.Now.ToShortDateString();
            }
            catch (Exception ex) {
                TLog.WriteErr("frmNhapkho_Init", ex.Message + "||" + ex.StackTrace);
            }
        }
        /// <summary>
        /// Hiển thị cmb đơn vị tính
        /// </summary>
        public void ShowDonVi()
        {
            DataTable data = tNhapKho.GetDonVi();
            cmbDonVi.DataSource = data;
            cmbDonVi.DisplayMember = "TEN";
            cmbDonVi.ValueMember = "MADONVI";
        }
        /// <summary>
        /// Hiển thị cmb
        /// </summary>
        public void ShowNCC()
        {
            DataTable data = tNhapKho.GetNCC();
            cmbNCC.DisplayMember = "TEN";
            cmbNCC.ValueMember = "MANCC";
            cmbNCC.DataSource = data;

        }
        public void ShowLoaiSP()
        {
            DataTable data = tNhapKho.GetLoaiSP();
            cmbLoaiSP.DisplayMember = "TEN";
            cmbLoaiSP.ValueMember = "MA";
            cmbLoaiSP.DataSource = data;

          //  cmbLoaiSP.SelectedIndex = 0;
        }
        public void ShowNhomHH(int loaiSP, int tinhtrang)
        {
            DataTable data = tNhapKho.GetNhomHH(loaiSP, tinhtrang);
            cmbNhomThuoc.DisplayMember = "TEN";
            cmbNhomThuoc.ValueMember = "MA";
            cmbNhomThuoc.DataSource = data;
            //cmbLoaiSP.SelectedIndex = 0;
        }
        public void ShowHH(int loaiHH)
        {
            HANGHOA = tNhapKho.GetHH(loaiHH);
            cmbTenThuoc.DisplayMember = "TENHANGHOA";
            cmbTenThuoc.ValueMember = "MA";
            cmbTenThuoc.DataSource = HANGHOA;
            //cmbTenThuoc.SelectedIndex= 0;
        }
        public void ShowQG()
        {
            DataTable data = tNhapKho.GetQG();
            cmdNuonSX.DataSource = data;
            cmdNuonSX.DisplayMember = "TEN";
            cmdNuonSX.ValueMember = "MA";
        }
        public void ShowKho()
        {
            DataTable data = tNhapKho.GetKho(0);
            cmbKho.DisplayMember = "TEN";
            cmbKho.ValueMember = "MAKHO";
            cmbKho.DataSource = data;

        }
        public void ShowCTKho(int makho)
        {
            DataTable data = tNhapKho.GetCTKho(makho);

            cmbKe.DisplayMember = "Ke";
            cmbKe.ValueMember = "MACTKHO"; 
            cmbKe.DataSource = data;
        }
        public void ShowDV(int i)
        {
            cmbDonVi.Text = HANGHOA.Rows[i]["TEN"].ToString();
            SLQC = int.Parse(HANGHOA.Rows[i]["SLDVT"].ToString());
        }
        #endregion
       
        #region Function

        public void SetInfoHDNhap() { 
            infoHDNhap.Sohd=txtSoHD.Text;
            infoHDNhap.Mancc =int.Parse(cmbNCC.SelectedValue.ToString());
            infoHDNhap.Ngaylap = dpkNgayLap.Value;
            infoHDNhap.Ngaynhap=dpkNgayNhap.Value;
            infoHDNhap.Lydo= cmbLiDo.Text;
            infoHDNhap.Nguyennhan=txtNguyenNhan.Text;
            infoHDNhap.Tongtien = double.Parse(txtTongTien.Text);
            infoHDNhap.Maloaint=cmbNgoaiTe.Text;
            infoHDNhap.Tygia= txtTyGia.Value;
            infoHDNhap.Tinhtrang= 1;
            infoHDNhap.TienNo = infoHDNhap.Tongtien;
            infoHDNhap.No =txtNo.Text;
            infoHDNhap.Co = txtCO.Text;
        }
        public Info.CTNHAPInfo SetInfoCTNhap() { 
               infoCTNhap.Mahdnhap=infoHDNhap.Ma;
               infoCTNhap.Malo= txtSoLo.Text;
               infoCTNhap.Mactkho =int.Parse(cmbKe.SelectedValue.ToString());

             infoCTNhap.Mahh=int.Parse(cmbTenThuoc.SelectedValue.ToString()); 
            infoCTNhap.Soluong=int.Parse(txtSoLuong.Text.ToString()) * SLQC;
            infoCTNhap.Ngaysx=dpkNgaySX.Value;
            infoCTNhap.Ngayhh=dpkNgayHH.Value;
            infoCTNhap.Manuocsx =int.Parse(cmdNuonSX.SelectedValue.ToString());
            double dg =txtDonGiaNhap.Value;
            infoCTNhap.Dongianhap=dg; 
            infoCTNhap.Tienchuavat=dg*int.Parse(txtSoLuong.Text.ToString())*txtTyGia.Value;
            infoCTNhap.Tinhtrang=1 ;
            infoCTNhap.SltonLo = int.Parse(txtSoLuong.Text.ToString()) * SLQC;
            infoCTNhap.Vat=int.Parse(cmbVAT.Text);
            infoCTNhap.Ck = txtCK.Value;
            infoCTNhap.Tiencovat = infoCTNhap.Tienchuavat + infoCTNhap.Tienchuavat *  ((float)infoCTNhap.Vat / 100);
            return infoCTNhap;
        }
      
        public void InsertHDNhap() {
            infoHDNhap.Ma = tNhapKho.InsertHDNHAP(infoHDNhap);
        }

        public void LoadHD(string maHD)
        {
            HD = tNhapKho.GetHD(maHD);
            
            if (HD != null)
            {
              //  lvHD.Items.Clear();
                for (int i = 0; i < HD.Rows.Count; i++)
                {
                    int stt = i + 1;
                    ListViewItem item = new ListViewItem(stt.ToString());
                    lvHD.Items.Add(item);
                    // item.SubItems.Add(stt.ToString());
                    item.SubItems.Add(HD.Rows[i]["SOHD"].ToString().Trim());
                    item.SubItems.Add(HD.Rows[i]["NGAYLAP"].ToString().Trim());
                    item.SubItems.Add(HD.Rows[i]["TEN"].ToString().Trim());
                    item.SubItems.Add(HD.Rows[i]["LYDO"].ToString().Trim());
                    item.SubItems.Add(HD.Rows[i]["TONGTIEN"].ToString().Trim());
                    item.SubItems.Add(HD.Rows[i]["MA"].ToString().Trim());
                }
            }
        }
        public void LoadHD(DateTime date)
        {
            HD = tNhapKho.GetHD(date);

            if (HD != null)
            {
                  lvHD.Items.Clear();
                for (int i = 0; i < HD.Rows.Count; i++)
                {
                    int stt = i + 1;
                    ListViewItem item = new ListViewItem(stt.ToString());
                    lvHD.Items.Add(item);
                    // item.SubItems.Add(stt.ToString());
                    item.SubItems.Add(HD.Rows[i]["SOHD"].ToString().Trim());
                    item.SubItems.Add(HD.Rows[i]["NGAYLAP"].ToString().Trim());
                    item.SubItems.Add(HD.Rows[i]["TEN"].ToString().Trim());
                    item.SubItems.Add(HD.Rows[i]["LYDO"].ToString().Trim());
                    item.SubItems.Add(HD.Rows[i]["TONGTIEN"].ToString().Trim());
                    item.SubItems.Add(HD.Rows[i]["MA"].ToString().Trim());
                }
            }
        }

        public bool CheckLoNew(string maLo)
        {
            for (int i = 0; i < CTHD.Rows.Count; i++)
                if (CTHD.Rows[i]["MALO"].ToString().Trim() == maLo)
                    return true;
            return false;
        }
        public void LoadCTHD(string maHD) {
            CTHD = tNhapKho.GetCTHD(maHD);
            if (CTHD != null)
            {
                lvCTHD.Items.Clear();
                for (int i = 0; i < CTHD.Rows.Count; i++)
                {
                    int stt = i + 1;
                    ListViewItem item = new ListViewItem(stt.ToString());
                    lvCTHD.Items.Add(item);
                    // item.SubItems.Add(stt.ToString());
                    item.SubItems.Add(CTHD.Rows[i]["MALO"].ToString().Trim());
                    item.SubItems.Add(CTHD.Rows[i]["TENHANGHOA"].ToString().Trim());
                    item.SubItems.Add(CTHD.Rows[i]["NGAYSX"].ToString().Trim());
                    item.SubItems.Add(CTHD.Rows[i]["NGAYHH"].ToString().Trim());
                    item.SubItems.Add(CTHD.Rows[i]["TEN"].ToString().Trim());
                    item.SubItems.Add(CTHD.Rows[i]["SOLUONG"].ToString().Trim());
                    item.SubItems.Add(CTHD.Rows[i]["DONGIANHAP"].ToString().Trim());
                    item.SubItems.Add(CTHD.Rows[i]["MA"].ToString().Trim());
                }
            }
        }
        void ChangeInsertCT() {
            txtSoHD.Enabled = false;
            cmdThemHD.Visible = false;
            cmdTaoMoi.Visible = true;
            cmdThemCT.Enabled = true;
        }
        void ChangeInsertHD()
        {
            txtSoHD.Enabled = true;
            cmdThemHD.Visible = true;
            cmdTaoMoi.Visible = false;
            cmdThemCT.Enabled = true;
        }
        public void InsertHD()
        {
            if (CheckHD())
            {
              SetInfoHDNhap();
              infoHDNhap.Ma= tNhapKho.InsertHDNHAP(infoHDNhap);
              ChangeInsertCT();
            }
            else
            {
                MessageBox.Show("Điền đầy đủ thông tin hóa đơn!");
            }
        }
        public void ResetFromCTHD() {
            txtSoLo.Text = "";
            txtDonGiaNhap.Text = "0";
            txtSoLuong.Text = "0";
            txtCK.Value = 0.0;
        }
 
        public void ResetFromHD()
        {
            txtSoHD.Text = "";
            txtTongTien.Text = "0";
            txtNguyenNhan.Text = "";
        }
        public bool CheckHD()
        {
            if (txtSoHD.Text == "") return false;
            if (cmbLiDo.Text == "") return false;
            if (dpkNgayLap.Text == "") return false;
            if (dpkNgayNhap.Text == "") return false;
            return true;
        }
        public bool CheckCTHD()
        {
            if (txtSoLo.Text == "") return false;
            if (txtDonGiaNhap.Text == "") return false;
            if (txtSoLuong.Text == "") return false;
            if (cmbTenThuoc.Text == "") return false;
            if (cmbKe.Text == "") return false;
            return true;
        }
        public void InsertCTHD() {
            if (CheckCTHD())
            {
                SetInfoCTNhap();
                tNhapKho.InsertCTNHAP(infoCTNhap);
                txtTongTien.Text = (double.Parse(txtTongTien.Text) + double.Parse(txtTienHH.Text)).ToString();

                tNhapKho.UpdateTongtienHD(infoHDNhap.Ma, float.Parse(txtTongTien.Text), 0);
                //LoadHD(infoHDNhap.Ma.ToString());  
            }
            else MessageBox.Show("Vui lòng điền đầy đủ thông tin");
        }
        #endregion

        #region Event
        private void cmbLoaiSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowNhomHH(int.Parse(cmbLoaiSP.SelectedValue.ToString()), 1);
        }

        private void cmbNhomThuoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowHH(int.Parse(cmbNhomThuoc.SelectedValue.ToString()));
        }
       
        private void cmbKho_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowCTKho(int.Parse(cmbKho.SelectedValue.ToString()));
        }

        private void cmbTenThuoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowDV(cmbTenThuoc.SelectedIndex);

        }

        #endregion

        private void cmdThemCT_Click(object sender, EventArgs e)
        {
            
            try
            {
                InsertCTHD();
                LoadCTHD(infoHDNhap.Ma.ToString());
                //  LoadCTHD("20");

                ResetFromCTHD();
                fagInsert = false;
            }
            catch (Exception ex)
            {
                TLog.WriteErr("frmNhapkho_cmdThemCT_Click", ex.Message + "||" + ex.StackTrace);
            }
        }
        Pharmacy.QuanLy.BLL.TTonkho tTonKho = new Pharmacy.QuanLy.BLL.TTonkho();

        private void cmdThemHD_Click(object sender, EventArgs e)
        {
            try
            {

                DataTable data = tTonKho.GetKho_tonkho();

                if (data.Rows.Count > 0)
                {
                    InsertHD();
                    LoadHD(infoHDNhap.Ma.ToString());
                    // LoadHD("24"); 
                    fagInsert = true;
                }
                else {
                    MessageBox.Show("Tháng này chưa kết chuyển tồn kho!Vui lòng kết chuyển");
                }
            }
            catch (Exception ex)
            {
                TLog.WriteErr("frmNhapkho_cmdThemHD_Click", ex.Message + "||" + ex.StackTrace);
            }
        }

        private void cmbNgan_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmdXoaCT_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < lvCTHD.Items.Count; i++)
                    if (lvCTHD.Items[i].Selected == true)
                    {

                        double tienCK = double.Parse(CTHD.Rows[i]["TIENCOVAT"].ToString()) * double.Parse(CTHD.Rows[i]["CHIETKHAU"].ToString());
                        double tienHH = double.Parse(CTHD.Rows[i]["TIENCOVAT"].ToString()) + tienCK;
                        tNhapKho.UpdateTongtienHD(infoHDNhap.Ma, tienHH, 1);
                        tNhapKho.DeleteCTHD(lvCTHD.Items[i].SubItems[8].Text);

                        //I show here the second field text (SubItems[1].Text) from the selected row(Items[i]) 
                        //   MessageBox.Show(lvCTHD.Items[i].SubItems[1].Text);
                        // utlEy.DeleteEmployee(lvEmployee.Items[i].SubItems[2].Text);
                    }
                LoadCTHD(infoHDNhap.Ma.ToString());
            }
            catch (Exception ex)
            {
                TLog.WriteErr("frmNhapkho_cmdXoaCT_Click", ex.Message + "||" + ex.StackTrace);
            }
        }

        //private void frmNhapKho_FormClosing(object sender, FormClosingEventArgs e)
        //{
        //    if (!fagInsert)
        //    {
        //        DialogResult result1 = MessageBox.Show("Bạn chưa Lập Hóa Đơn!\nBạn có muốn lập ko?",
        //    "Dược phẩm", MessageBoxButtons.YesNo);

        //        if (result1 == DialogResult.Yes) {
        //            InsertHDNhap();
        //            MessageBox.Show("lập");
        //        }
        //        else if (result1 == DialogResult.No) {
        //            for (int i = 0; i < lvCTHD.Items.Count; i++)
        //            {     tNhapKho.DeleteCTHD(lvCTHD.Items[i].SubItems[1].Text);
        //                  tNhapKho.DeleteLo(lvCTHD.Items[i].SubItems[1].Text);
        //            }

        //        }


        //    }
        //}

        private void lvHD_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView lv = (ListView)sender;

            if (lv.Items.Count > 0)
            {
                int flag = -1;
                for (int i = 0; i < lv.Items.Count; i++)
                {
                    if (lv.Items[i].Selected)
                    {
                        flag = i;
                    }
                }
                if (flag != -1)
                {
                    infoHDNhap.Ma=int.Parse(lv.Items[flag].SubItems[6].Text);
                    LoadCTHD(lv.Items[flag].SubItems[6].Text);
        
                }
            }
        }
       private void cmdTaoMoi_Click(object sender, EventArgs e)
        {

            ChangeInsertHD();
            ResetFromHD();
            lvCTHD.Items.Clear();
        }
       private void buttonX8_Click(object sender, EventArgs e)
       {
           QuanLy.frmHangHoa frm = new Pharmacy.QuanLy.frmHangHoa();
           frm.WindowState = FormWindowState.Normal;
           frm.AutoSize = false;
           frm.ShowDialog(this);
       }

       private void cmbKe_SelectedIndexChanged(object sender, EventArgs e)
       {

       }

        private void dpkDateHD_ValueChanged(object sender, EventArgs e)
        {
            LoadHD(dpkDateHD.Value);
        }

       
        private void cmbVAT_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (!tbus.IsNumber(cmbVAT.Text))
                MessageBox.Show("Nhập số");
            else
            {
                try
                {
                    double dg = txtDonGiaNhap.Value;
                    txtTienHH.Text = (dg * txtSoLuong.Value * txtTyGia.Value + (dg * txtSoLuong.Value * txtTyGia.Value) * (float.Parse(cmbVAT.Text) / 100)).ToString();
                    tienhh = double.Parse(txtTienHH.Text);
                }
                catch (Exception ex) {
                    TLog.WriteErr("frmNhapkho_cmbVAT_SelectedIndexChanged_1", ex.Message + "||" + ex.StackTrace);
       
                }
            }
        }

        private void txtDonGiaNhap_TabIndexChanged(object sender, EventArgs e)
        {
            double dg = txtDonGiaNhap.Value;
            txtTienHH.Text = (dg * txtSoLuong.Value * txtTyGia.Value + (dg * txtSoLuong.Value * txtTyGia.Value) * (float.Parse(cmbVAT.Text) / 100)).ToString();
   
        }

        private void buttonX4_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < lvHD.Items.Count; i++)
                    if (lvHD.Items[i].Selected == true)
                    {
                        tNhapKho.DeleteHD(lvHD.Items[i].SubItems[6].Text);

                        //I show here the second field text (SubItems[1].Text) from the selected row(Items[i]) 
                        //   MessageBox.Show(lvCTHD.Items[i].SubItems[1].Text);
                        // utlEy.DeleteEmployee(lvEmployee.Items[i].SubItems[2].Text);
                    }
                LoadHD(dpkDateHD.Value);
            }
            catch (Exception ex)
            {
                TLog.WriteErr("frmNhapkho_buttonX4_Click", ex.Message + "||" + ex.StackTrace);
            }
        }

        private void txtDonGiaNhap_ValueChanged(object sender, EventArgs e)
        {
            double dg = txtDonGiaNhap.Value;
            txtTienHH.Text = (dg * txtSoLuong.Value * txtTyGia.Value + (dg * txtSoLuong.Value * txtTyGia.Value) * (float.Parse(cmbVAT.Text) / 100)).ToString();
            tienhh = double.Parse(txtTienHH.Text);    
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            frmPrintHD frm = new frmPrintHD();
            for (int i = 0; i < lvHD.Items.Count; i++)
                if (lvHD.Items[i].Selected == true)
                {
                    frm.ShowFromNhap(int.Parse(lvHD.Items[i].SubItems[6].Text));
                }
       
        }
    
        private void txtCK_ValueChanged(object sender, EventArgs e)
        {
            double tienCK = txtCK.Value * tienhh;
            txtTienHH.Text = (tienhh + tienCK).ToString();
        }

        private void cmdAddNCC_Click(object sender, EventArgs e)
        {
            QuanLy.frmNCC frm = new Pharmacy.QuanLy.frmNCC();
            frm.WindowState = FormWindowState.Normal;
            frm.AutoSize = false;
            frm.ShowDialog(this);
        }

     
        private void frmNhapKho_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyData == Keys.Enter)
            //{
            //    SendKeys.Send("{TAB}");
            //}
        }

      


    

     

  

      

   
     













    }
}