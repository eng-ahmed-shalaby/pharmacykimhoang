using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Pharmacy.QuanLy
{
    public partial class frmKhachHang : Pharmacy.BASIC.frmChild
    {
        #region Bien


        Pharmacy.QuanLy.BLL.TTinhThanh tTT = new Pharmacy.QuanLy.BLL.TTinhThanh();
        Pharmacy.QuanLy.BLL.TNhomKH tNhom = new Pharmacy.QuanLy.BLL.TNhomKH();

        Pharmacy.QuanLy.BLL.TKhachHang tKH = new Pharmacy.QuanLy.BLL.TKhachHang();



        Pharmacy.QuanLy.Info.KhachHangInfo infoKH = new Pharmacy.QuanLy.Info.KhachHangInfo();



        DataTable HH = new DataTable();

        #endregion
        public frmKhachHang()
        {
            InitializeComponent();
        }

        private void buttonX5_Click(object sender, EventArgs e)
        {
            SetInfoKH();
            InsertKH();
            set_md();
        }

        private void buttonX6_Click(object sender, EventArgs e)
        {
            SetInfoKH();
            UpdateKH();
            set_md();
        }

        private void buttonX4_Click(object sender, EventArgs e)
        {
            SetInfoKH();
            DeleteKH();
            set_md();
        }
        private void Init()
        {

            ShowNhom();
            ShowTinh();
            loadnhacungcap();

        }


        public void ShowNhom()
        {
            try
            {
                DataTable data = tNhom.GetNhomKH();
                cmb_nhom.DisplayMember = "TEN";
                cmb_nhom.ValueMember = "MANHOMKH";
                cmb_nhom.DataSource = data;
                cmb_nhom.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                TLog.WriteErr("frmKhachHang_ShowNhom", ex.Message + "|" + ex.StackTrace);
            }
        }
        public void ShowTinh()
        {
            try
            {
                DataTable data = tTT.GetTT();
                cmb_tinhthanh.DisplayMember = "TEN";
                cmb_tinhthanh.ValueMember = "MA";
                cmb_tinhthanh.DataSource = data;
                cmb_tinhthanh.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                TLog.WriteErr("frmKhachHang_ShowTinh", ex.Message + "|" + ex.StackTrace);
            }
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
        public void SetInfoKH()
        {
            infoKH.TEN = txt_tenkh.Text;
            infoKH.MANHOM = int.Parse(cmb_nhom.SelectedValue.ToString());
            infoKH.MATINH = cmb_tinhthanh.SelectedValue.ToString();
            infoKH.GIOITINH = "";
            infoKH.CODEKH = txt_codekh.Text;
            infoKH.DIACHI = txt_diachi.Text;
            infoKH.DIENTHOAI = txtdienthoai.Text;
            infoKH.CAPDO = txt_capdo.Text;
            infoKH.MST = txtMST.Text;


        }
        public void loadnhacungcap()
        {
            try
            {
                HH = tKH.GetKH();
                if (HH != null)
                {
                    lvhanghoa.Items.Clear();
                    for (int i = 0; i < HH.Rows.Count; i++)
                    {
                        int stt = i + 1;
                        ListViewItem item = new ListViewItem(stt.ToString());
                        lvhanghoa.Items.Add(item);

                        item.SubItems.Add(HH.Rows[i]["CODEKH"].ToString().Trim());
                        item.SubItems.Add(HH.Rows[i]["TEN"].ToString().Trim());
                        item.SubItems.Add(HH.Rows[i]["MST"].ToString().Trim());
                        item.SubItems.Add(HH.Rows[i]["TENNHOM"].ToString().Trim());
                        item.SubItems.Add(HH.Rows[i]["TENTT"].ToString().Trim());
                        item.SubItems.Add(HH.Rows[i]["DIACHI"].ToString().Trim());
                        item.SubItems.Add(HH.Rows[i]["DIENTHOAI"].ToString().Trim());
                        item.SubItems.Add(HH.Rows[i]["CAPDO"].ToString().Trim());
                        item.SubItems.Add(HH.Rows[i]["MANHOM"].ToString().Trim());
                        item.SubItems.Add(HH.Rows[i]["MATINH"].ToString().Trim());
                        item.SubItems.Add(HH.Rows[i]["MAKH"].ToString().Trim());
                    }
                }
            }
            catch (Exception ex)
            {
                TLog.WriteErr("frmKhachHang_loadnhacungcap", ex.Message + "|" + ex.StackTrace);
            }
        }
        public void set_md()
        {
            txt_tenkh.Text = "";
            txt_codekh.Text = "";
            cmb_nhom.Text = "";
            cmb_tinhthanh.Text = "";
           // cmb_gioitinh.Text = "";
            txt_capdo.Text = "";
            txtdienthoai.Text = "";
            txt_diachi.Text = "";
            txtMST.Text = "";
            loadnhacungcap();
        }
        public void ShowListToForm(int id)
        {
            try
            {
                infoKH.MAKH = int.Parse(HH.Rows[id]["MAKH"].ToString());
                txt_tenkh.Text = HH.Rows[id]["TEN"].ToString();
                txt_codekh.Text = HH.Rows[id]["CODEKH"].ToString();
                cmb_nhom.SelectedValue = int.Parse(HH.Rows[id]["MANHOM"].ToString());
                cmb_tinhthanh.SelectedValue = HH.Rows[id]["MATINH"].ToString();
                txtdienthoai.Text = HH.Rows[id]["DIACHI"].ToString();
                txt_diachi.Text = HH.Rows[id]["DIENTHOAI"].ToString();
                txt_capdo.Text = HH.Rows[id]["CAPDO"].ToString();
                txtMST.Text = HH.Rows[id]["MST"].ToString();
                //cmb_gioitinh.Text = HH.Rows[id]["GIOITINH"].ToString();
            }
            catch (Exception ex)
            {
                TLog.WriteErr("frmKhachHang_ShowList", ex.Message + "|" + ex.StackTrace);
            }
        }
        public void InsertKH()
        {
            try
            {
                if (CheckKH())
                {
                    tKH.InsertKH(infoKH);
                }
                else
                    MessageBox.Show("Điền đầy đủ thông tin NCC!");
            }
            catch (Exception ex)
            {
                TLog.WriteErr("frmKhachHang_Insert", ex.Message + "|" + ex.StackTrace);
            }

        }

        public void UpdateKH()
        {
            try
            {
                if (CheckKH())
                    tKH.UpdateKH(infoKH);
                else
                {
                    MessageBox.Show("Điền đầy đủ thông tin hàng hóa!");
                }
            }
            catch (Exception ex)
            {
                TLog.WriteErr("frmKhachHang_UpdateKH", ex.Message + "|" + ex.StackTrace);
            }
        }

        public void DeleteKH()
        {

            try { tKH.DeleteKH(infoKH); }
            catch (Exception ex) {
                TLog.WriteErr("frmKhachHang_DeleteKH", ex.Message + "|" + ex.StackTrace); 
            }
        }
        public bool CheckKH()
        {
            if (txt_tenkh.Text == "") return false;
            if (txt_codekh.Text == "") return false;
            if (cmb_tinhthanh.Text == "") return false;
            return true;
        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            SetTitle("KHÁCH HÀNG");
            Init();
        }

        private void btnNhomKH_Click(object sender, EventArgs e)
        {
            fromNhomKH frm = new fromNhomKH();
            frm.ShowDialog();
        }

    }
}
