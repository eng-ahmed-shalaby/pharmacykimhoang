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
    public partial class frmXuatKho : BASIC.frmChild
    {
        TLog tLog = new TLog(); 
        BLL.TNhapKho tNhapKho = new NhapXuat.BLL.TNhapKho();
        BLL.TXuatHang tXuatKho = new NhapXuat.BLL.TXuatHang();
        Pharmacy.BLL.THangHoa tHH = new Pharmacy.BLL.THangHoa();
        Pharmacy.BLL.TKhachHang tKH = new Pharmacy.BLL.TKhachHang();
        DataTable HANGHOA = new DataTable();
        DataTable CTHD = new DataTable();
        DataTable HD = new DataTable();
        DataTable LO = new DataTable();
        DataTable KM = new DataTable();
        DataTable dataKM = new DataTable();
        Info.HDXuatInfo infoHDXUAT= new NhapXuat.Info.HDXuatInfo();
        Info.CTXUATInfo infoCTXuat = new NhapXuat.Info.CTXUATInfo();
        int slton = 0;
        double tienhh = 0;
        public frmXuatKho()
        {

            InitializeComponent();
        }
        public void SetcmdNhomHHbyHH() {

        }
        public void ShowHH(int loaiHH)
        {
            HANGHOA = tNhapKho.GetHH(loaiHH);
            cmbTenThuoc.DisplayMember = "TENHANGHOA";
            cmbTenThuoc.ValueMember = "MA";
            cmbTenThuoc.DataSource = HANGHOA;
        }
        public void ShowTDV()
        {
            DataTable dt = tXuatKho.GetTDV(1);
            cmbTDV.DisplayMember = "TEN";
            cmbTDV.ValueMember = "MA";
            cmbTDV.DataSource = dt;
        }
        public void LoadAutoHH()
        {
            HANGHOA = tHH.GetHangHoa_ALL();
            AutoCompleteStringCollection collec = new AutoCompleteStringCollection();
            for (int i = 0; i < HANGHOA.Rows.Count; i++)
            {
                collec.Add(HANGHOA.Rows[i]["TENHANGHOA"].ToString());
            }
            cmbTenThuoc.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbTenThuoc.AutoCompleteSource = AutoCompleteSource.CustomSource;
            cmbTenThuoc.AutoCompleteCustomSource = collec;
        }
        private void frmXuatKho_Load(object sender, EventArgs e)
        {
            this.SetTitle("LẬP HÓA ĐƠN XUẤT");
            Init();
        }
        public void Init() {
            try
            {
                ShowLoaiSP();
                ShowNhomKH();
                LoadAutoHH();
                ShowTDV();
                cmdThemCT.Enabled = false;
                cmdTaoMoi.Visible = false;
                dpkNgayLap.Text = DateTime.Now.ToShortDateString();
                dpkNgayXuat.Text = DateTime.Now.ToShortDateString();
                dpkHH.Text = DateTime.Now.ToShortDateString();
            }
            catch (Exception ex)
            {
                TLog.WriteErr("frmXuatKho_Init", ex.Message + "|" + ex.StackTrace);
            }
        }

        public void ShowNhomKH()
        {
            DataTable data = tKH.GetNhomKhachHang();
            cmbNhomKH.DisplayMember = "TEN";
            cmbNhomKH.ValueMember = "MANHOMKH";
            cmbNhomKH.DataSource = data;
        }
        public void ShowKH(int nhom)
        {
            DataTable data = tKH.GetKhachHang(nhom);
            cmbKH.DisplayMember = "TEN";
            cmbKH.ValueMember = "MAKH";
            cmbKH.DataSource = data;
        }
        public void ShowLoaiSP()
        {
            DataTable data = tNhapKho.GetLoaiSP();
            cmbLoaiSP.DisplayMember = "TEN";
            cmbLoaiSP.ValueMember = "MA";
            cmbLoaiSP.DataSource = data;

            cmbLoaiSP.SelectedIndex = 0;
        }
        public void ShowNhomHH(int loaiSP, int tinhtrang)
        {
            DataTable data = tNhapKho.GetNhomHH(loaiSP, tinhtrang);
            cmbLoaiThuoc.DisplayMember = "TEN";
            cmbLoaiThuoc.ValueMember = "MA";
            cmbLoaiThuoc.DataSource = data;

        }
 
        public void ShowKho()
        {
            DataTable data = tNhapKho.GetKho(0);
            cmbKhoDen.DisplayMember = "TEN";
            cmbKhoDen.ValueMember = "MAKHO";
            cmbKhoDen.DataSource = data;

        }
        public void ShowCTKho(int makho)
        {
            DataTable data = tNhapKho.GetCTKho(makho);
            cmbKe.DisplayMember = "Ke";
            cmbKe.ValueMember = "MACTKHO";
            cmbKe.DataSource = data;
        }
        public void ShowLo(int maHH)
        {
            LO = tXuatKho.GetLO(maHH,1);
            cmbLo.DisplayMember = "MALO";
            cmbLo.ValueMember = "MA";
            cmbLo.DataSource = LO;
        }
        public void ShowInfoLo(string MaLo) {
            int i=0;
            for (i = 0; i < LO.Rows.Count; i++)
                if (LO.Rows[i]["MALO"].ToString() == MaLo)
                    break;
            txtSL.Text = LO.Rows[i]["SLTON_LO"].ToString();
            slton = int.Parse(LO.Rows[i]["SLTON_LO"].ToString());
            cmbDVT.Text = LO.Rows[i]["TENDV"].ToString();
            dpkHH.Text = LO.Rows[i]["NGAYHH"].ToString();
            txtKho.Text = LO.Rows[i]["TEN"].ToString();
            txtKe.Text = LO.Rows[i]["KE"].ToString();
        }
        private void cmbLoaiSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowNhomHH(int.Parse(cmbLoaiSP.SelectedValue.ToString()), 1);
      
        }

        public void ResetFromCTHD()
        {
            
         
        }

        public void ResetFromHD()
        {
            txtSOHD.Text = "";
            txtTongTien.Text = "0";
        }
        public bool CheckHD()
        {
            if (txtSOHD.Text == "") return false;
            if (txtLyDo.Text == "") return false;
            if (dpkNgayLap.Text == "") return false;
            if (dpkNgayXuat.Text == "") return false;
            return true;
        }
        public bool CheckCTHD()
        {
            Pharmacy.BLL.TBus tbus = new Pharmacy.BLL.TBus();
            if (!tbus.IsNumber(cmbVat.Text)) return false;
            if (txtDG.Text == "") return false;
         
            if (txtSL.Text == "") return false;
           
            return true;
        }


        private void cmbLoaiThuoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowHH(int.Parse(cmbLoaiThuoc.SelectedValue.ToString()));
        }

        private void cmbTenThuoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowLo(int.Parse(cmbTenThuoc.SelectedValue.ToString()));
            ShowKM(int.Parse(cmbTenThuoc.SelectedValue.ToString()));
        }

        private void cmbLo_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowInfoLo(cmbLo.Text);
        }

        private void cmbNhomKH_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowKH(int.Parse(cmbNhomKH.SelectedValue.ToString()));
        }

        private void cmbKhoDen_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowCTKho(int.Parse(cmbKhoDen.SelectedValue.ToString()));
        }
        private void txtLyDo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtLyDo.Text == "Chuyển kho")
            {
                panelKho.Enabled = true;
                panelKH.Enabled = false;
            }
            else {
                panelKho.Enabled = false;
                panelKH.Enabled = true;
            }
        }
      
        public void SetInfoHDXUAT()
        {
            infoHDXUAT.Sohd = txtSOHD.Text;
            if (txtLyDo.Text == "Chuyển kho")
            {
                infoHDXUAT.Makh = 0;
                infoHDXUAT.Mactkho= int.Parse(cmbKe.SelectedValue.ToString());
            }
            else {
                infoHDXUAT.Makh= int.Parse(cmbKH.SelectedValue.ToString());
                infoHDXUAT.Mactkho =  0;
            }
            infoHDXUAT.Matdv = int.Parse(cmbTDV.SelectedValue.ToString());
            infoHDXUAT.Ngaylap = dpkNgayLap.Value;
            infoHDXUAT.Ngayxuat = dpkNgayXuat.Value;
            infoHDXUAT.Lydo = txtLyDo.Text;
            infoHDXUAT.Tinhtrang = 1;
            
            infoHDXUAT.Tongtien = float.Parse(txtTongTien.Text);
            infoHDXUAT.TienNo = infoHDXUAT.Tongtien;
            infoHDXUAT.No = txtNo.Text;
            infoHDXUAT.Co = txtCO.Text;
        }

        void ChangeInsertCT()
        {
            txtSOHD.Enabled = false;
            cmdThemHD.Visible = false;
            cmdTaoMoi.Visible = true;
            cmdThemCT.Enabled = true;
        }
        void ChangeInsertHD()
        {
            txtSOHD.Enabled = true;
            cmdThemHD.Visible = true;
            cmdTaoMoi.Visible = false;
            cmdThemCT.Enabled = false;
        }
        public void InsertHD()
        {

            if (CheckHD())
            {
                infoHDXUAT.Ma = tXuatKho.InsertHDXUAT(infoHDXUAT);
                ChangeInsertCT();
            }
            else
            {
                MessageBox.Show("Điền đầy đủ thông tin hóa đơn!");
            }
        }
        public void LoadHD(string maHD)
        {
            HD = tXuatKho.GetHD(maHD);

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
                    item.SubItems.Add(HD.Rows[i]["MAKH"].ToString().Trim());
                    item.SubItems.Add(HD.Rows[i]["NGAYLAP"].ToString().Trim());
                    item.SubItems.Add(HD.Rows[i]["LYDO"].ToString().Trim());
                    item.SubItems.Add(HD.Rows[i]["TONGTIEN"].ToString().Trim());
                    item.SubItems.Add(HD.Rows[i]["MA"].ToString().Trim());
                }
            }
        }
        public void LoadHD(DateTime date)
        {
            HD = tXuatKho.GetHD(date);

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
                    item.SubItems.Add(HD.Rows[i]["MAKH"].ToString().Trim());
                    item.SubItems.Add(HD.Rows[i]["NGAYLAP"].ToString().Trim());
                    item.SubItems.Add(HD.Rows[i]["LYDO"].ToString().Trim());
                    item.SubItems.Add(HD.Rows[i]["TONGTIEN"].ToString().Trim());
                   
                    item.SubItems.Add(HD.Rows[i]["MA"].ToString().Trim());
                }
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
                     SetInfoHDXUAT();
                     InsertHD();
                     LoadHD(infoHDXUAT.Ma.ToString());
                 }
                 else
                 {
                     MessageBox.Show("Tháng này chưa kết chuyển tồn kho!Vui lòng kết chuyển");
                 }
                // LoadHD("24"); 
            }
            catch (Exception ex)
            {
                TLog.WriteErr("frmXuatKho_cmdThemHD_Click", ex.Message + "|" + ex.StackTrace);
            }
        }

        private void dpkNgayXuat_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dpkNgayLap_Click(object sender, EventArgs e)
        {

        }

        private void cmdTaoMoi_Click(object sender, EventArgs e)
        {
            ChangeInsertHD();
            ResetFromHD();
            lvCTHD.Items.Clear();
        }
        private void txtDG_ValueChanged(object sender, EventArgs e)
        {   double tienchuacat=0;
        try
        {
            if (txtSLban.Text != "" && txtDG.Text != "")
                tienchuacat = int.Parse(txtSLban.Text) * double.Parse(txtDG.Text);
            txtGia.Text = (tienchuacat + tienchuacat * (float.Parse(cmbVat.Text.ToString()) / 100)).ToString();
            tienhh = double.Parse(txtGia.Text);
        }
        catch (Exception ex) {
            TLog.WriteErr("frmXuatKho_txtDG_ValueChanged", ex.Message +"|"+ ex.StackTrace );
        }
        }
        private void cmbVat_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                double tienchuacat = int.Parse(txtSLban.Text) * double.Parse(txtDG.Text);
                txtGia.Text = (tienchuacat + tienchuacat * (float.Parse(cmbVat.Text.ToString()) / 100)).ToString();
                tienhh = double.Parse(txtGia.Text);
            }
            catch (Exception ex) {
                TLog.WriteErr("frmXuatKho_txtCMDVat_ValueChanged", ex.Message + "|" + ex.StackTrace);
            }
        }
        public Info.CTXUATInfo SetInfoCTXUAT()
        { 
            infoCTXuat.Mahdxuat = infoHDXUAT.Ma;
            infoCTXuat.Solo= cmbLo.Text;
            infoCTXuat.Mahh = int.Parse(cmbTenThuoc.SelectedValue.ToString());
            infoCTXuat.Soluong= int.Parse( txtSLban.Text);
            infoCTXuat.Dongia = double.Parse(txtDG.Text);
            infoCTXuat.Tienchuavat = int.Parse( txtSLban.Text) *double.Parse(txtDG.Text);
            infoCTXuat.Vat = int.Parse(cmbVat.Text.ToString());
            infoCTXuat.Tiencovat = infoCTXuat.Tienchuavat + infoCTXuat.Tienchuavat * (float.Parse(cmbVat.Text.ToString()) / 100);
            infoCTXuat.CK = txtCK.Value; 
            infoCTXuat.Tinhtrang = 1;
            return infoCTXuat;
        }
        public void InsertCTHD()
        {
            try
            {
                if (CheckCTHD())
                {

                    SetInfoCTXUAT();
                    tXuatKho.InsertCTNHAP(infoCTXuat);

                    txtTongTien.Text = (double.Parse(txtTongTien.Text) + double.Parse(txtGia.Text)).ToString();
                    tXuatKho.UpdateTongtienHD(infoHDXUAT.Ma, float.Parse(txtTongTien.Text));
                   
                    slton = slton - int.Parse(txtSLban.Text);
                    UpdateLo(int.Parse(cmbLo.SelectedValue.ToString()), slton);
         //////////////////////////////
                    SetHHKhuyenMai();
                }
                else MessageBox.Show("Vui lòng điền đầy đủ thông tin");
            }
            catch (Exception ex)
            {
                TLog.WriteErr("frmXuatKho_InsertCTHD", ex.Message + "|" + ex.StackTrace);
            }
        }

        public void LoadCTHD(int maHD)
        {

            CTHD = tXuatKho.GetCTHD(maHD);
            if (CTHD != null)
            {
                lvCTHD.Items.Clear();
                for (int i = 0; i < CTHD.Rows.Count; i++)
                {
                    int stt = i + 1;
                    ListViewItem item = new ListViewItem(stt.ToString());
                    lvCTHD.Items.Add(item);
                    // item.SubItems.Add(stt.ToString());
                    item.SubItems.Add(CTHD.Rows[i]["SOLO"].ToString().Trim());
                    item.SubItems.Add(CTHD.Rows[i]["TENHANGHOA"].ToString().Trim());
                    item.SubItems.Add(CTHD.Rows[i]["NGAYHH"].ToString().Trim());
                    item.SubItems.Add(CTHD.Rows[i]["SOLUONG"].ToString().Trim());
                    item.SubItems.Add(CTHD.Rows[i]["DONGIA"].ToString().Trim());
                    item.SubItems.Add(CTHD.Rows[i]["TIENCOVAT"].ToString().Trim());
                    item.SubItems.Add(CTHD.Rows[i]["MA"].ToString().Trim());
                }
            }
        }
        public void UpdateLo(int MaCT, int sl){
            int tt = 1;
            if (sl <= 0)
            {
                sl = 0;
                tt = 0;
            }
            tXuatKho.UpdateSLLo(MaCT, sl,tt);
        }
        public void SetHHKhuyenMai() {
            int tt = 1;
            KM = tXuatKho.GetLO(int.Parse(dataKM.Rows[0]["MaHHKM"].ToString()), 1);
            if (KM.Rows.Count < 0)
            {
                MessageBox.Show("Hết Hàng Khuyến mãi");
            }
            else
            {
                try
                {
                    int slKM = int.Parse(txtSLban.Text.ToString()) / int.Parse(dataKM.Rows[0]["SL"].ToString());
                    slKM = slKM * int.Parse(dataKM.Rows[0]["SLKM"].ToString());
                    int slKMTon = int.Parse(KM.Rows[0]["SLTON_LO"].ToString()) - slKM;
                    if (slKMTon <= 0)
                    {
                        slKMTon = 0;
                        tt = 0;
                    }
                    ////////Insert Update
                    Info.CTXUATInfo info = SetCTKM(slKM);
                    tXuatKho.InsertCTNHAP(info);
                    UpdateLo(int.Parse(KM.Rows[0]["MA"].ToString().ToString()), slKMTon);

                }
                catch (Exception ex)
                {
                    TLog.WriteErr("frmXuatKho_SetHHKhuyenMai", ex.Message + "|" + ex.StackTrace);
                }
            }

            

        }
        public Info.CTXUATInfo SetCTKM(int soluong) {
            Info.CTXUATInfo info = new Info.CTXUATInfo();
            info.Mahdxuat = infoHDXUAT.Ma;
            info.Solo =KM.Rows[0]["MALO"].ToString().ToString();
            info.Mahh = int.Parse(dataKM.Rows[0]["MaHHKM"].ToString());
            info.Soluong = soluong;
            info.Dongia = 0;
            info.Tienchuavat = 0;
            info.Vat = 0;
            info.Tiencovat = 0;
            info.CK =0;
            info.Tinhtrang = 1;
            return info;
        }
        private void cmdThemCT_Click(object sender, EventArgs e)
        {
   
            InsertCTHD();
            LoadCTHD(infoHDXUAT.Ma);
            ShowLo(int.Parse(cmbTenThuoc.SelectedValue.ToString()));
            ShowInfoLo(cmbLo.Text);
          // 
            //  LoadCTHD("20");
            ResetFromCTHD();
        }
        private void dpkDateHD_ValueChanged(object sender, EventArgs e)
        {
            LoadHD(dpkDateHD.Value);
        }
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
                    infoHDXUAT.Ma = int.Parse(lv.Items[flag].SubItems[6].Text);
                    LoadCTHD(int.Parse(lv.Items[flag].SubItems[6].Text));

                }
            }
        }

        private void cmdXoaCT_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < lvCTHD.Items.Count; i++)
                    if (lvCTHD.Items[i].Selected == true)
                    {
                        tXuatKho.DeleteCTHD(lvCTHD.Items[i].SubItems[7].Text);
                    }
                LoadCTHD(int.Parse(infoHDXUAT.Ma.ToString()));
            }
            catch (Exception ex)
            {
                TLog.WriteErr("frmXuatKho_cmdXoaCT_Click", ex.Message + "|" + ex.StackTrace);
            }
        }

        private void cmdXoaHD_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lvHD.Items.Count; i++)
                if (lvHD.Items[i].Selected == true)
                {
                    tXuatKho.DeleteHD(lvHD.Items[i].SubItems[6].Text);
                }
            LoadHD(dpkDateHD.Value);
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            frmPrintHD frm = new frmPrintHD();
            for (int i = 0; i < lvHD.Items.Count; i++)
                if (lvHD.Items[i].Selected == true)
                {
                    frm.ShowFromXuat(int.Parse(lvHD.Items[i].SubItems[6].Text));
                }
        }

        private void txtSLban_ValueChanged(object sender, EventArgs e)
        {

            if (txtSLban.Text != "")
            if (int.Parse(txtSL.Text) < int.Parse(txtSLban.Text))
            {
                MessageBox.Show("Không đủ số lượng trong lô");
                txtSLban.Value = 0;
            }

        }
        private void ShowKM(int MaHH) {
            dataKM = tXuatKho.GetHangKM(MaHH);
            if (dataKM.Rows.Count > 0)
            {
                //   MessageBox.Show(string.Format("Mua {0}{1} \n Khuyễn mãi \n{2} {3} {4}", dataKM.Rows[0]["SL"], cmbDVT.Text, dataKM.Rows[0]["SLKM"], dataKM.Rows[0]["Ten"], dataKM.Rows[0]["TENHANGHOA"]));
                lblKM.Text = string.Format("{0}{1}\nKhuyễn mãi\n{2} {3}\n{4}", dataKM.Rows[0]["SL"], cmbDVT.Text, dataKM.Rows[0]["SLKM"], dataKM.Rows[0]["Ten"], dataKM.Rows[0]["TENHANGHOA"]);
            }
            else lblKM.Text = "";

        }

        private void txtCK_ValueChanged(object sender, EventArgs e)
        {
            double tienCK = txtCK.Value * tienhh;
            txtGia.Text = (tienhh + tienCK).ToString();
        }
        /// <summary>
        /// In Hóa đơn đỏ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdHDDon_Click(object sender, EventArgs e)
        {
             frmPrintHD frm = new frmPrintHD();
            for (int i = 0; i < lvHD.Items.Count; i++)
                if (lvHD.Items[i].Selected == true)
                {
                    frm.ShowHD(int.Parse(lvHD.Items[i].SubItems[6].Text));
                }
        }
    }
}