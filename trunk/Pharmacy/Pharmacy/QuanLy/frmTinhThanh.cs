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
    public partial class frmTinhThanh : BASIC.frmChild
    {
        MyTable.TblTinhThanh tblTinhThanh = new MyTable.TblTinhThanh();
        private static int index = -1;
        public frmTinhThanh()
        {
            InitializeComponent();
            Init();
        }
        public void Init() {
            SetTitle("TỈNH THÀNH");
            LoadTinhThanh();
    
        }

        private void LoadDataToText(int id)
        {
            try
            {
                if (tblTinhThanh.Rows.Count > 0)
                {
                    txtMa.Text = tblTinhThanh.Rows[id]["MA"].ToString();
                 //   cmb_loai.SelectedValue = tblTinhThanh.Rows[id]["MANHOM"].ToString();
                    txtten.Text = tblTinhThanh.Rows[id]["TEN"].ToString();
                }
            }
            catch (Exception ex)
            {
                TLog.WriteErr("frmTinhThanh_Loaddatatotext", ex.Message + "|" + ex.StackTrace);
            }
        }
        public void LoadTinhThanh()
        {
            try
            {
                tblTinhThanh = new MyTable.TblTinhThanh(1);
                if (tblTinhThanh != null)
                {
                    lvTinhThanh.Items.Clear();
                    for (int i = 0; i < tblTinhThanh.Rows.Count; i++)
                    {
                        int stt = i + 1;
                        ListViewItem item = new ListViewItem(stt.ToString());
                        lvTinhThanh.Items.Add(item);
                        // item.SubItems.Add(stt.ToString());
                        item.SubItems.Add(tblTinhThanh.Rows[i]["MA"].ToString().Trim());
                        item.SubItems.Add(tblTinhThanh.Rows[i]["TEN"].ToString().Trim());
                    }
                }
            }
            catch (Exception ex)
            {
                TLog.WriteErr("frmTinhThanh_LoadTinhThanh", ex.Message + "|" + ex.StackTrace);
            }
        }
        private void AddData()
        {
            try
            {
                DataRow newRow = tblTinhThanh.NewRow();
                newRow["MA"] = txtMa.Text.Trim();
                newRow["TEN"] = txtten.Text.Trim();
                newRow["TINHTRANG"] = 1;
                tblTinhThanh.Rows.Add(newRow);
                tblTinhThanh.Update(true);
            }
            catch (Exception ex)
            {
                TLog.WriteErr("frmTinhThanh_AddData", ex.Message + "|" + ex.StackTrace);
            }
        }
        private void UpdateData(int _index)
        {
            try
            {
                tblTinhThanh.Rows[_index]["TEN"] = txtten.Text.Trim();
                tblTinhThanh.Rows[_index]["MA"] = txtMa.Text;
                tblTinhThanh.Update();
            }
            catch (Exception ex)
            {
                TLog.WriteErr("frmTinhThanh_Update", ex.Message + "|" + ex.StackTrace);
            }
        }
        private void DeleteData(int _index)
        {
            try
            {
                tblTinhThanh.Rows[_index]["TINHTRANG"] = 0;
                tblTinhThanh.Update();
            }
            catch (Exception ex)
            {
                TLog.WriteErr("frmTinhThanh_Delete", ex.Message + "|" + ex.StackTrace);
            }

        }

        private void lvTinhThanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvTinhThanh.Items.Count > 0)
            {
                int flag = -1;
                for (int i = 0; i < lvTinhThanh.Items.Count; i++)
                {
                    if (lvTinhThanh.Items[i].Selected)
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
        public void ResertFrom()
        {
            txtten.Text = "";
            txtMa.Text = "";
        }
        private void cmdThemNhom_Click(object sender, EventArgs e)
        {
            AddData();
            LoadTinhThanh();
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
                LoadTinhThanh();
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
                LoadTinhThanh();
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
            lvTinhThanh.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            ControlPrint ctrP = new ControlPrint(lvTinhThanh, true);
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
