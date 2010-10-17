using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BrightIdeasSoftware;

namespace Pharmacy.QuanLy
{
    public partial class frmHangHoa : BASIC.frmChild
    {
        #region Bien
        TLog tLog = new TLog(); 
        NhapXuat.BLL.TNhapKho tNhapKho = new NhapXuat.BLL.TNhapKho();
        Pharmacy.BLL.THangHoa tHH = new Pharmacy.BLL.THangHoa();

      Pharmacy.QuanLy.BLL.TTonkho tTonKho = new Pharmacy.QuanLy.BLL.TTonkho();

        Pharmacy.Info.HangHoaInfo infoHH = new Pharmacy.Info.HangHoaInfo();
       Pharmacy.QuanLy.Info.TonkhoInfo infoTK = new Pharmacy.QuanLy.Info.TonkhoInfo();

      Pharmacy.QuanLy.Info.CTTonkhoInfo infoCTTK = new Pharmacy.QuanLy.Info.CTTonkhoInfo();

        Pharmacy.BLL.TKho tKho = new Pharmacy.BLL.TKho();


        DataTable HH = new DataTable();
       
        #endregion
        public frmHangHoa()
        {
            InitializeComponent();
            this.SetTitle("THÊM HÀNG HÓA");
        }

        private void textBoxX1_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmHangHoa_Load(object sender, EventArgs e)
        {
            Init();
        }
        private void Init()
        {
            ShowDonVi();           
            ShowLoaiSP();
            ShowNhomSP();
            ShowQuycach();
            loadhanghoa();
        }
        public void ShowQuycach()
        {
            DataTable data = tNhapKho.GetQuycach();
            cmb_quycach.DisplayMember = "TEN";
            cmb_quycach.ValueMember = "MA";
            cmb_quycach.DataSource = data;
            cmb_quycach.SelectedIndex = 0;
        }
        public void ShowNhomSP()
        {

            DataTable data = tNhapKho.GetNhomHH(int.Parse( cmb_loai.SelectedValue.ToString()),1);
            if (data.Rows.Count > 0)
            {
                cmb_nhom.Enabled = true;
                cmb_nhom.DisplayMember = "TEN";
                cmb_nhom.ValueMember = "MA";
                cmb_nhom.DataSource = data;
            }
            else {
                cmb_nhom.Enabled = false;
                cmb_nhom.Text = "";
            }
        }
        public void ShowLoaiSP()
        {
            DataTable data = tNhapKho.GetLoaiSP();
            cmb_loai.DisplayMember = "TEN";
            cmb_loai.ValueMember = "MA";
            cmb_loai.DataSource = data;
          //  cmb_loai.SelectedIndex = 0;
        }
        public void ShowDonVi()
        {
            DataTable data = tNhapKho.GetDonVi();
            cmb_dvt.DataSource = data;
            cmb_dvt.DisplayMember = "TEN";
            cmb_dvt.ValueMember = "MADONVI";
        }

        private void buttonX5_Click(object sender, EventArgs e)
        {
            SetInfoHH();
            InsertHH();
            set_md();
        }
        public void set_md()
        {
            txttenthuoc.Text = "";
            txtMota.Text = "";
            txt_chidinh.Text = "";
            txt_ma.Text = "";
            loadhanghoa();
        }
        public void InsertHH()
        {
            try
            {
                if (CheckHH())
                {


                    DataTable data = tTonKho.GetKho_tonkho();

                    if (data.Rows.Count > 0)
                    {
                        infoHH.MA = tHH.Inserthanghoa(infoHH);
                        infoCTTK.Mahh = infoHH.MA;
                        SetInfoTK();
                        int i;
                        for (i = 0; i < data.Rows.Count; i++)
                        {
                            infoTK.MAKHO = int.Parse(data.Rows[i]["MAKHO"].ToString());
                            infoTK.Matonkho = int.Parse(data.Rows[i]["MATONKHO"].ToString());
                            infoCTTK.Matonkho = int.Parse(data.Rows[i]["MATONKHO"].ToString());
                            tTonKho.InsertCTTonKho(infoCTTK);
                        }


                    }

                    else
                    {
                        MessageBox.Show("Tháng này kho chưa kết chuyển!");
                    }


                }
                else
                {
                    MessageBox.Show("Điền đầy đủ thông tin hàng hóa!");
                }
            }
            catch (Exception ex) {
                TLog.WriteErr("frmHangHoa_InsertHH", ex.Message + "|" + ex.StackTrace);
                }
        }

        public void UpdateHH()
        {
            if (CheckHH())
                 tHH.Updatehanghoa(infoHH);
            else
            {
                MessageBox.Show("Điền đầy đủ thông tin hàng hóa!");
            }
        }

        public void DeleteHH()
        {
            if (CheckHH())
                tHH.Deletehanghoa(infoHH);
            else
            {
                MessageBox.Show("Điền đầy đủ thông tin hàng hóa!");
            }
        }
        public bool CheckHH()
        {
            if (txttenthuoc.Text == "") return false;
            if (cmb_dvt.Text == "") return false;
            //if (dpkNgayLap.Text == "") return false;
            //if (dpkNgayNhap.Text == "") return false;
            return true;
        }
        public void SetInfoHH()
        {
            infoHH.TENHANGHOA = txttenthuoc.Text;
            infoHH.MADV = int.Parse(cmb_dvt.SelectedValue.ToString());

            infoHH.MAQUYCACH = int.Parse(cmb_quycach.SelectedValue.ToString());
            infoHH.MANHOM = int.Parse(cmb_nhom.SelectedValue.ToString());

            infoHH.MOTA = txtMota.Text;
            infoHH.CHIDINH = txt_chidinh.Text;
            infoHH.CODE = txt_ma.Text;
            
            
        }
        public void SetInfoTK()
        {
            infoTK.NGAY = DateTime.Now.Date;
            infoTK.TINHTRANG = 1;
            infoCTTK.Soluongton = 0;

        }

        public void loadhanghoa()
        {
            HH = tHH.GetHangHoa_ALL();
            if (HH != null)
            {
                lvhanghoa.Items.Clear();
                for (int i = 0; i < HH.Rows.Count; i++)
                {
                    int stt = i + 1;
                    ListViewItem item = new ListViewItem(stt.ToString());
                    lvhanghoa.Items.Add(item);
                    // item.SubItems.Add(stt.ToString());
                    item.SubItems.Add(HH.Rows[i]["CODE"].ToString().Trim());
                    item.SubItems.Add(HH.Rows[i]["TENHANGHOA"].ToString().Trim());                    
                    item.SubItems.Add(HH.Rows[i]["TENDVT"].ToString().Trim());
                    item.SubItems.Add(HH.Rows[i]["MAQUYCACH"].ToString().Trim());
                    item.SubItems.Add(HH.Rows[i]["TENLOAISP"].ToString().Trim());
                    item.SubItems.Add(HH.Rows[i]["TENNHOM"].ToString().Trim());
                    item.SubItems.Add(HH.Rows[i]["CHIDINH"].ToString().Trim());
                    item.SubItems.Add(HH.Rows[i]["MOTA"].ToString().Trim());
                    item.SubItems.Add(HH.Rows[i]["MA"].ToString().Trim());
                }
            }
        } 
        public void ShowListToForm(int id)
        {
            infoHH.MA = int.Parse(HH.Rows[id]["MA"].ToString());
            txttenthuoc.Text = HH.Rows[id]["TENHANGHOA"].ToString();
            txt_ma.Text = HH.Rows[id]["CODE"].ToString();
            cmb_dvt.Text = HH.Rows[id]["TENDVT"].ToString();
            cmb_quycach.SelectedValue = HH.Rows[id]["MAQUYCACH"].ToString();
            cmb_loai.Text = HH.Rows[id]["TENLOAISP"].ToString();
            cmb_nhom.Text = HH.Rows[id]["TENNHOM"].ToString();
            txtMota.Text = HH.Rows[id]["MOTA"].ToString();
            txt_chidinh.Text = HH.Rows[id]["CHIDINH"].ToString();
        }

        private void buttonX6_Click(object sender, EventArgs e)
        {
            SetInfoHH();
            UpdateHH();
            set_md();
        }

        private void buttonX4_Click(object sender, EventArgs e)
        {
            SetInfoHH();
            DeleteHH();
            set_md();
        }

        private void lvhanghoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvhanghoa.Items.Count > 0)
            {
                int flag = -1;
                for (int i = 0; i < lvhanghoa.Items.Count; i++)
                {
                    if (lvhanghoa.Items[i].Selected)
                    {
                        flag = i;
                    }
                }
                if (flag != -1)
                {

                    ShowListToForm(flag);

                }
            }
        }

        private void cmdNhomHH_Click(object sender, EventArgs e)
        {
            frmNhomHH frm = new frmNhomHH();
            frm.ShowDialog();
        }

        private void cmdInDS_Click(object sender, EventArgs e)
        {

            ListViewPrinter pr = new ListViewPrinter("DANH SÁCH HÀNG HÓA");
            pr.ListView = lvhanghoa;
            pr.PrintPreview();
        }

        private void cmdDVT_Click(object sender, EventArgs e)
        {
            frmDonvi frm = new frmDonvi();
            frm.ShowDialog();
        }

        private void cmbQuyCach_Click(object sender, EventArgs e)
        {
            frmQuyCach frm = new frmQuyCach();
            frm.ShowDialog();
        }

        private void cmdLoaiHH_Click(object sender, EventArgs e)
        {
            frmLoaiHH frm = new frmLoaiHH();
            frm.FormClosed += new FormClosedEventHandler(frm_FormClosed);
            frm.ShowDialog();
        }

        void frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            ShowLoaiSP();

        }
        private void cmb_loai_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowNhomSP();
        }

     
      

      

    }
}
