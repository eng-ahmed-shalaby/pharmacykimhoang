using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using Pharmacy.MyTable;
namespace Pharmacy.QuanLy
{
    public partial class frmNCC : BASIC.frmChild
    {
        private static TblNCC tblNCC;
        private static TblNhomNCC tblNhomNCC;
        private static TblQuocGia tblQG;
        private static int index=-1;
        public frmNCC()
        {
            InitializeComponent();
        }

        private void frmNCC_Load(object sender, EventArgs e)
        {
            SetTitle("THÊM NHÀ CUNG CẤP");
            LoadNCC();
            LoadNhomNCC();
            LoadQG();
        }
        public void ResertFrom() {
            txtMa.Text = "";
            txtTen.Text = "";
            txtDiaChi.Text = "";
            txtDienThoai.Text = "";
            txtMST.Text = "";
        }
        public void LoadNhomNCC() {
            try
            {
                tblNhomNCC = new TblNhomNCC();
                cmb_NhomNCC.DataSource = tblNhomNCC;
                cmb_NhomNCC.DisplayMember = "TENNHOM";
                cmb_NhomNCC.ValueMember = "MANHOMNCC";
            }
            catch (Exception ex)
            {
                TLog.WriteErr("frmNCC_Load", ex.Message + "|" + ex.StackTrace);
            }
        }
        public void LoadQG()
        {
            try
            {
                tblQG = new TblQuocGia();
                cmb_QG.DataSource = tblQG;
                cmb_QG.DisplayMember = "TEN";
                cmb_QG.ValueMember = "MAQG";
            }
            catch (Exception ex)
            {
                TLog.WriteErr("frmNCC_LOADQG", ex.Message + "|" + ex.StackTrace);
            }
        }
        private void LoadDataToText(int id)
        {
            try
            {
                if (tblNCC.Rows.Count > 0)
                {
                    txtMa.Text = tblNCC.Rows[id]["CODENCC"].ToString();
                    txtTen.Text = tblNCC.Rows[id]["TEN"].ToString();
                    cmb_NhomNCC.SelectedValue = tblNCC.Rows[id]["MANHOM"].ToString();
                    cmb_QG.SelectedValue = tblNCC.Rows[id]["MAQG"].ToString();
                    txtDiaChi.Text = tblNCC.Rows[id]["DIACHI"].ToString();
                    txtDienThoai.Text = tblNCC.Rows[id]["DIENTHOAI"].ToString();
                    txtMST.Text = tblNCC.Rows[id]["MST"].ToString();
                }
            }
            catch (Exception ex)
            {
                TLog.WriteErr("frmNCC_Loaddatatotext", ex.Message + "|" + ex.StackTrace);
            }
        }
        public void LoadNCC()
        {
            try
            {
                tblNCC = new TblNCC(1);
                if (tblNCC != null)
                {
                    lvNCC.Items.Clear();
                    for (int i = 0; i < tblNCC.Rows.Count; i++)
                    {
                        string _Qg = tblNCC.GetQuocGia(tblNCC.Rows[i]["MAQG"]);
                        int stt = i + 1;
                        ListViewItem item = new ListViewItem(stt.ToString());
                        lvNCC.Items.Add(item);
                        // item.SubItems.Add(stt.ToString());
                        item.SubItems.Add(tblNCC.Rows[i]["CODENCC"].ToString().Trim());
                        item.SubItems.Add(tblNCC.Rows[i]["TEN"].ToString().Trim());
                        item.SubItems.Add(tblNCC.Rows[i]["MANHOM"].ToString().Trim());
                        item.SubItems.Add(_Qg);
                        item.SubItems.Add(tblNCC.Rows[i]["DIACHI"].ToString().Trim());
                        item.SubItems.Add(tblNCC.Rows[i]["DIENTHOAI"].ToString().Trim());
                        item.SubItems.Add(tblNCC.Rows[i]["MST"].ToString().Trim());
                    }
                }
            }
            catch (Exception ex)
            {
                TLog.WriteErr("frmNCC_LoadNCC", ex.Message + "|" + ex.StackTrace);
            }
        }
        private void AddData()
        {
            try
            {
                DataRow newRow = tblNCC.NewRow();
                newRow["CODENCC"] = txtMa.Text.Trim();
                newRow["TEN"] = txtTen.Text.Trim();
                newRow["MANHOM"] = cmb_NhomNCC.SelectedValue;
                newRow["MAQG"] = cmb_QG.SelectedValue;
                newRow["DIACHI"] = txtDiaChi.Text.Trim();
                newRow["DIENTHOAI"] = txtDienThoai.Text.ToString();
                newRow["CAPDO"] = "";
                newRow["TINHTRANG"] = 1;
                newRow["MST"] = txtMST.Text.ToString();
                tblNCC.Rows.Add(newRow);
                tblNCC.Update(true);
            }
            catch (Exception ex)
            {
                TLog.WriteErr("frmNCC_AddData", ex.Message + "|" + ex.StackTrace);
            }
        }
        private void UpdateData(int _index)
        {
            try
            {
                tblNCC.Rows[_index]["CODENCC"] = txtMa.Text.Trim();
                tblNCC.Rows[_index]["TEN"] = txtTen.Text.Trim();
                tblNCC.Rows[_index]["MANHOM"] = cmb_NhomNCC.SelectedValue;
                tblNCC.Rows[_index]["MAQG"] = cmb_QG.SelectedValue;
                tblNCC.Rows[_index]["DIACHI"] = txtDiaChi.Text.Trim();
                tblNCC.Rows[_index]["DIENTHOAI"] = txtDienThoai.Text.ToString();
                tblNCC.Rows[_index]["CAPDO"] = "";
                tblNCC.Rows[_index]["MST"] = txtMST.Text.ToString();
                tblNCC.Update();
            }
            catch (Exception ex)
            {
                TLog.WriteErr("frmNCC_Update", ex.Message + "|" + ex.StackTrace);
            }
        }
        private void DeleteData(int _index)
        {
            try
            {
                tblNCC.Rows[_index]["TINHTRANG"] = 0;
                tblNCC.Update();
            }
            catch (Exception ex)
            {
                TLog.WriteErr("frmNCC_Delete", ex.Message + "|" + ex.StackTrace);
            }
            
        }
        private void cmdThem_Click(object sender, EventArgs e)
        {
            AddData();
            LoadNCC();
            index = -1;
            ResertFrom();
        }

        private void lvNCC_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvNCC.Items.Count > 0)
            {
                int flag = -1;
                for (int i = 0; i < lvNCC.Items.Count; i++)
                {
                    if (lvNCC.Items[i].Selected)
                    {
                        flag = i;
                    }
                }
                if (flag != -1)
                {
                    index = flag;
                    LoadDataToText(flag);
                }
            }
        }

        private void cmdSua_Click(object sender, EventArgs e)
        {
            if (index == -1)
                MessageBox.Show("Chọn Nhóm NCC cần update");
            else
            {
                UpdateData(index);
                LoadNCC();
                ResertFrom();
            }
        }

        private void cmdXoa_Click(object sender, EventArgs e)
        {
            if (index == -1)
                MessageBox.Show("Chọn Nhóm NCC cần xóa");
            else
            {
                DeleteData(index);
                LoadNCC();
                index = -1;
                ResertFrom();
            }
        }

        private void cmdNhomNCC_Click(object sender, EventArgs e)
        {
            frmNhomNCC frm = new frmNhomNCC();
            frm.ShowDialog();
        }

    }
}