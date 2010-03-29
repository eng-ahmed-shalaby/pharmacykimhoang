using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Pharmacy.MyTable;

namespace Pharmacy.NhanVien
{
    public partial class frmTDV : BASIC.frmChild
    {
        MyTable.TblTDV tblTDV;
        int _index = -1;
        public frmTDV()
        {
            InitializeComponent();
        }
        public void ResertFrom()
        {
            txtTenDN.Text = "";
            txtMK.Text = "";
            txt_tenTDV.Text ="";
            txtdienthoai.Text ="";
            txt_diachi.Text ="";
            txt_codeTDV.Text ="";
            txtTuoi.Text ="";
        }
        private void AddData()
        {
            try
            {
                DataRow newRow = tblTDV.NewRow();
                newRow["TENDANGNHAP"] = txtTenDN.Text.Trim();
                newRow["MATKHAU"] = txtMK.Text.Trim();
                newRow["TEN"] = txt_tenTDV.Text;
                newRow["SDT"] = txtdienthoai.Text.ToString();
                newRow["DIACHI"] = txt_diachi.Text.Trim();
                newRow["TINHTRANG"] = 1;
                newRow["MA_TDV"] = txt_codeTDV.Text;
                newRow["TUOI"] = txtTuoi.Text;
                tblTDV.Rows.Add(newRow);
                tblTDV.Update(true);
            }
            catch (Exception ex)
            {
                TLog.WriteErr("frmTDV_AddData", ex.Message + "|" + ex.StackTrace);
            }
        }
        private void DeleteData(int _index)
        {
            try
            {
                tblTDV.Rows[_index]["TINHTRANG"] = 0;
                tblTDV.Update();
            }
            catch (Exception ex)
            {
                TLog.WriteErr("frmNCC_Delete", ex.Message + "|" + ex.StackTrace);
            }

        }
        public void LoadTDV()
        {
            try
            {
                tblTDV = new TblTDV(1);
                if (tblTDV != null)
                {
                    lvTDV.Items.Clear();
                    for (int i = 0; i < tblTDV.Rows.Count; i++)
                    {
                        int stt = i + 1;
                        ListViewItem item = new ListViewItem(stt.ToString());
                        lvTDV.Items.Add(item);
                        // item.SubItems.Add(stt.ToString());
                        item.SubItems.Add(tblTDV.Rows[i]["MA_TDV"].ToString().Trim());
                        item.SubItems.Add(tblTDV.Rows[i]["TEN"].ToString().Trim());
                        item.SubItems.Add(tblTDV.Rows[i]["TENDANGNHAP"].ToString().Trim());
                        item.SubItems.Add(tblTDV.Rows[i]["TUOI"].ToString().Trim());
                        item.SubItems.Add(tblTDV.Rows[i]["SDT"].ToString().Trim());
                        item.SubItems.Add(tblTDV.Rows[i]["DIACHI"].ToString().Trim());
                       }
                }
            }
            catch (Exception ex)
            {
                TLog.WriteErr("frmTDV_LoadTDV", ex.Message + "|" + ex.StackTrace);
            }
        }

        private void frmTDV_Load(object sender, EventArgs e)
        {
            LoadTDV();
            SetTitle("QUẢN LÝ TRÌNH DƯỢC VIÊN");
        }

        private void cmdThem_Click(object sender, EventArgs e)
        {
            AddData();
            LoadTDV();
           _index = -1;
            ResertFrom();
        }

        private void cmdXoa_Click(object sender, EventArgs e)
        {
            if (_index == -1)
                MessageBox.Show("Chọn TDV cần xóa");
            else
            {
                DeleteData(_index);
                LoadTDV();
                _index = -1;
                ResertFrom();
            }
        }

        private void lvTDV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvTDV.Items.Count > 0)
            {
                int flag = -1;
                for (int i = 0; i < lvTDV.Items.Count; i++)
                {
                    if (lvTDV.Items[i].Selected)
                    {
                        flag = i;
                    }
                }
                if (flag != -1)
                {
                    _index = flag;
                    LoadDataToText(flag);
                }
            }
        }
        private void LoadDataToText(int id)
        {
            try
            {
                if (lvTDV.Items.Count > 0)
                {
                    
                    txtTenDN.Text = tblTDV.Rows[id]["TENDANGNHAP"].ToString();
                    txtMK.Text = tblTDV.Rows[id]["MATKHAU"].ToString();
                    txt_tenTDV.Text = tblTDV.Rows[id]["TEN"].ToString();
                    txtdienthoai.Text = tblTDV.Rows[id]["SDT"].ToString();
                    txt_diachi.Text = tblTDV.Rows[id]["DIACHI"].ToString();

                    txt_codeTDV.Text = tblTDV.Rows[id]["MA_TDV"].ToString();
                    txtTuoi.Text = tblTDV.Rows[id]["TUOI"].ToString();
                }
            }
            catch (Exception ex)
            {
                TLog.WriteErr("frmNCC_Loaddatatotext", ex.Message + "|" + ex.StackTrace);
            }
        }
        private void UpdateData(int index)
        {
  
    
            try
            {
                tblTDV.Rows[index]["TENDANGNHAP"] = txtTenDN.Text.Trim();
                tblTDV.Rows[index]["MATKHAU"] = txtMK.Text.Trim();
                tblTDV.Rows[index]["TEN"] = txt_tenTDV.Text;
                tblTDV.Rows[index]["SDT"] = txtdienthoai.Text.ToString();
                tblTDV.Rows[index]["DIACHI"] = txt_diachi.Text.Trim();
                tblTDV.Rows[index]["TINHTRANG"] = 1;
                tblTDV.Rows[index]["MA_TDV"] = txt_codeTDV.Text;
                tblTDV.Rows[index]["TUOI"] = txtTuoi.Text;
                tblTDV.Update();
            }
            catch (Exception ex)
            {
                TLog.WriteErr("frmTDV_Update", ex.Message + "|" + ex.StackTrace);
            }
        }
        private void cmbSua_Click(object sender, EventArgs e)
        {
            if (_index == -1)
                MessageBox.Show("Chọn TDV cần update");
            else
            {
                UpdateData(_index);
                LoadTDV();
                ResertFrom();
            }
        }


    
    }
}
