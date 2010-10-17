using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PrintControl;
using System.Drawing.Printing;

namespace Pharmacy.QuanLy
{
    public partial class frmNhomHH : BASIC.frmChild
    {
        NhapXuat.BLL.TNhapKho tNhapKho = new NhapXuat.BLL.TNhapKho();
        MyTable.TblNhomHH tblNhomHH = new MyTable.TblNhomHH();
        private static int index = -1;
        public frmNhomHH()
        {
            InitializeComponent();
            Init();
        }
        public void Init() {
            SetTitle("NHÓM HÀNG HÓA");
            ShowNhomSP();
    
        }
        public void ShowNhomSP()
        {
            DataTable data = tNhapKho.GetLoaiSP();
            cmb_loai.DisplayMember = "TEN";
            cmb_loai.ValueMember = "MA";
            cmb_loai.DataSource = data;
            cmb_loai.SelectedIndex = 0;
        }
        private void LoadDataToText(int id)
        {
            try
            {
                if (tblNhomHH.Rows.Count > 0)
                {
                    txtten.Text = tblNhomHH.Rows[id]["TEN"].ToString();
                 //   cmb_loai.SelectedValue = tblNhomHH.Rows[id]["MANHOM"].ToString();
                    txt_mota.Text = tblNhomHH.Rows[id]["MOTA"].ToString();
                }
            }
            catch (Exception ex)
            {
                TLog.WriteErr("frmNHomHH_Loaddatatotext", ex.Message + "|" + ex.StackTrace);
            }
        }
        public void LoadNhomHH()
        {
            try
            {
                tblNhomHH = new MyTable.TblNhomHH(int.Parse(cmb_loai.SelectedValue.ToString()),1);
                if (tblNhomHH != null)
                {
                    lvNhomHH.Items.Clear();
                    for (int i = 0; i < tblNhomHH.Rows.Count; i++)
                    {
                        int stt = i + 1;
                        ListViewItem item = new ListViewItem(stt.ToString());
                        lvNhomHH.Items.Add(item);
                        // item.SubItems.Add(stt.ToString());
                        item.SubItems.Add(tblNhomHH.Rows[i]["TEN"].ToString().Trim());
                        item.SubItems.Add(tblNhomHH.Rows[i]["MOTA"].ToString().Trim());
                        item.SubItems.Add(tblNhomHH.Rows[i]["MA"].ToString().Trim());
                    }
                }
            }
            catch (Exception ex)
            {
                TLog.WriteErr("frmNHOMHH_LoadNHOMHH", ex.Message + "|" + ex.StackTrace);
            }
        }
        private void AddData()
        {
            try
            {
                DataRow newRow = tblNhomHH.NewRow();
                newRow["TEN"] = txtten.Text.Trim();

                newRow["MALOAISP"] = cmb_loai.SelectedValue.ToString();
                newRow["MOTA"] = txt_mota.Text.ToString();
                newRow["TINHTRANG"] = 1;
                tblNhomHH.Rows.Add(newRow);
                tblNhomHH.Update(true);
            }
            catch (Exception ex)
            {
                TLog.WriteErr("frmNHOMHH_AddData", ex.Message + "|" + ex.StackTrace);
            }
        }
        private void UpdateData(int _index)
        {
            try
            {
                tblNhomHH.Rows[_index]["TEN"] = txtten.Text.Trim();
                tblNhomHH.Rows[_index]["MALOAISP"] = cmb_loai.SelectedValue.ToString();
                tblNhomHH.Rows[_index]["MOTA"] = txt_mota.Text.ToString();
                tblNhomHH.Update();
            }
            catch (Exception ex)
            {
                TLog.WriteErr("frmNHOMHH_Update", ex.Message + "|" + ex.StackTrace);
            }
        }
        private void DeleteData(int _index)
        {
            try
            {
                tblNhomHH.Rows[_index]["TINHTRANG"] = 0;
                tblNhomHH.Update();
            }
            catch (Exception ex)
            {
                TLog.WriteErr("frmNHOMHH_Delete", ex.Message + "|" + ex.StackTrace);
            }

        }

        private void lvNhomHH_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvNhomHH.Items.Count > 0)
            {
                int flag = -1;
                for (int i = 0; i < lvNhomHH.Items.Count; i++)
                {
                    if (lvNhomHH.Items[i].Selected)
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

        private void cmb_loai_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadNhomHH();
        }
        public void ResertFrom()
        {
            txtten.Text = "";
            txt_mota.Text = "";
        }
        private void cmdThemNhom_Click(object sender, EventArgs e)
        {
            AddData();
            LoadNhomHH();
            index = -1;
            ResertFrom();
        }

        private void cmdSuaNhom_Click(object sender, EventArgs e)
        {
            if (index == -1)
                MessageBox.Show("Chọn Nhóm Hang hóa cần update");
            else
            {
                UpdateData(index);
                LoadNhomHH();
                ResertFrom();
            }
        }

        private void cmdXoaNhom_Click(object sender, EventArgs e)
        {

            if (index == -1)
                MessageBox.Show("Chọn Nhóm Hàng hóa cần xóa");
            else
            {
                DeleteData(index);
                LoadNhomHH();
                index = -1;
                ResertFrom();
            }
        }

        private void cmdIn_Click(object sender, EventArgs e)
        {
            printDoc.Print();
        }

        private void printDoc_PrintPage(object sender, PrintPageEventArgs e)
        {

            ColumnHeaderStyle c = new ColumnHeaderStyle();
            lvNhomHH.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            ControlPrint ctrP = new ControlPrint(lvNhomHH, true);
            ctrP.PrintWidth = ctrP.CalculateSize().Width;
            ctrP.PrintHeight = ctrP.CalculateSize().Height;
           e.Graphics.DrawString("DANH SÁCH NHÓM THUỐC", new Font("Tahoma", 16), Brushes.Black, new PointF(40, 40));
            e.Graphics.DrawImageUnscaled(ctrP.GetBitmap(), new Point(100, 100));
            e.Graphics.DrawString("STT", new Font("Arial", 11), Brushes.Black, new PointF(100, 100));
            e.Graphics.DrawString("Tên", new Font("Arial", 11), Brushes.Black, new PointF(160, 100));
            e.Graphics.DrawString("Mô tả", new Font("Arial", 11), Brushes.Black, new PointF(500, 100));
        }
    }
}
