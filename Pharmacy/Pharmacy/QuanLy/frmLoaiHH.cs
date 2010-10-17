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
    public partial class frmLoaiHH : BASIC.frmChild
    {
        NhapXuat.BLL.TNhapKho tNhapKho = new NhapXuat.BLL.TNhapKho();
        MyTable.TblLoaiHH tblLoaiHH = new MyTable.TblLoaiHH();
        private static int index = -1;
        public frmLoaiHH()
        {
            InitializeComponent();
            Init();
        }
        public void Init() {
            SetTitle("LOẠI HÀNG HÓA");
   
        }

        private void LoadDataToText(int id)
        {
            try
            {
                if (tblLoaiHH.Rows.Count > 0)
                {
                    txtten.Text = tblLoaiHH.Rows[id]["TEN"].ToString();
                 //   cmb_loai.SelectedValue = tblLoaiHH.Rows[id]["MALoai"].ToString();
                    txt_mota.Text = tblLoaiHH.Rows[id]["MOTA"].ToString();
                }
            }
            catch (Exception ex)
            {
                TLog.WriteErr("frmLoaiHH_Loaddatatotext", ex.Message + "|" + ex.StackTrace);
            }
        }
        public void LoadLoaiHH()
        {
            try
            {
                tblLoaiHH = new MyTable.TblLoaiHH(1);
                if (tblLoaiHH != null)
                {
                    lvLoaiHH.Items.Clear();
                    for (int i = 0; i < tblLoaiHH.Rows.Count; i++)
                    {
                        int stt = i + 1;
                        ListViewItem item = new ListViewItem(stt.ToString());
                        lvLoaiHH.Items.Add(item);
                        // item.SubItems.Add(stt.ToString());
                        item.SubItems.Add(tblLoaiHH.Rows[i]["TEN"].ToString().Trim());
                        item.SubItems.Add(tblLoaiHH.Rows[i]["MOTA"].ToString().Trim());
                        item.SubItems.Add(tblLoaiHH.Rows[i]["MA"].ToString().Trim());
                    }
                }
            }
            catch (Exception ex)
            {
                TLog.WriteErr("frmLoaiHH_LoadLoaiHH", ex.Message + "|" + ex.StackTrace);
            }
        }
        private void AddData()
        {
            try
            {
                DataRow newRow = tblLoaiHH.NewRow();
                newRow["TEN"] = txtten.Text.Trim();
                newRow["TEN"] = txtten.Text.Trim();
                newRow["MOTA"] = txt_mota.Text.ToString();
                newRow["TINHTRANG"] = 1;
                tblLoaiHH.Rows.Add(newRow);
                tblLoaiHH.Update(true);
            }
            catch (Exception ex)
            {
                TLog.WriteErr("frmLoaiHH_AddData", ex.Message + "|" + ex.StackTrace);
            }
        }
        private void UpdateData(int _index)
        {
            try
            {
                tblLoaiHH.Rows[_index]["TEN"] = txtten.Text.Trim();
                 tblLoaiHH.Rows[_index]["MOTA"] = txt_mota.Text.ToString();
                tblLoaiHH.Update();
            }
            catch (Exception ex)
            {
                TLog.WriteErr("frmLoaiHH_Update", ex.Message + "|" + ex.StackTrace);
            }
        }
        private void DeleteData(int _index)
        {
            try
            {
                tblLoaiHH.Rows[_index]["TINHTRANG"] = 0;
                tblLoaiHH.Update();
            }
            catch (Exception ex)
            {
                TLog.WriteErr("frmLoaiHH_Delete", ex.Message + "|" + ex.StackTrace);
            }

        }

        private void lvLoaiHH_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvLoaiHH.Items.Count > 0)
            {
                int flag = -1;
                for (int i = 0; i < lvLoaiHH.Items.Count; i++)
                {
                    if (lvLoaiHH.Items[i].Selected)
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
            LoadLoaiHH();
        }
        public void ResertFrom()
        {
            txtten.Text = "";
            txt_mota.Text = "";
        }
        private void cmdThemLoai_Click(object sender, EventArgs e)
        {
            AddData();
            LoadLoaiHH();
            index = -1;
            ResertFrom();
        }

        private void cmdSuaLoai_Click(object sender, EventArgs e)
        {
            if (index == -1)
                MessageBox.Show("Chọn Nhóm Hang hóa cần update");
            else
            {
                UpdateData(index);
                LoadLoaiHH();
                ResertFrom();
            }
        }

        private void cmdXoaLoai_Click(object sender, EventArgs e)
        {

            if (index == -1)
                MessageBox.Show("Chọn Nhóm Hàng hóa cần xóa");
            else
            {
                DeleteData(index);
                LoadLoaiHH();
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
            lvLoaiHH.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            ControlPrint ctrP = new ControlPrint(lvLoaiHH, true);
            ctrP.PrintWidth = ctrP.CalculateSize().Width;
            ctrP.PrintHeight = ctrP.CalculateSize().Height;
           e.Graphics.DrawString("DANH SÁCH LOẠI SẢN PHẨM", new Font("Tahoma", 16), Brushes.Black, new PointF(40, 40));
            e.Graphics.DrawImageUnscaled(ctrP.GetBitmap(), new Point(100, 100));
            e.Graphics.DrawString("STT", new Font("Arial", 11), Brushes.Black, new PointF(100, 100));
            e.Graphics.DrawString("Tên", new Font("Arial", 11), Brushes.Black, new PointF(160, 100));
            e.Graphics.DrawString("Mô tả", new Font("Arial", 11), Brushes.Black, new PointF(500, 100));
        }

        private void frmLoaiHH_Load(object sender, EventArgs e)
        {
            LoadLoaiHH();
        }
    }
}
