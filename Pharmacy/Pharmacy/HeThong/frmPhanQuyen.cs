using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Pharmacy.HeThong
{
    public partial class frmPhanQuyen : BASIC.frmChild
    {
        BLL.TPhanQuyen tPhanQuyen = new BLL.TPhanQuyen();
        int maTDV = 0;
        Pharmacy.NhanVien.BLL.TNhanVien tNhanVien = new Pharmacy.NhanVien.BLL.TNhanVien();

        public frmPhanQuyen()
        {
            InitializeComponent();
        }

        private void frmPhanQuyen_Load(object sender, EventArgs e)
        {
            Init();

        }
        private void Init() {
            SetTitle("PHÂN QUYỀN HỆ THỐNG");
            LoadTDV();
            LoadChucNang();
        }
        public void LoadTDV()
        {
            lvTDV.Items.Clear();
            try
            {
                 DataTable dt = tNhanVien.GetTDV();
                 if (dt != null)
                {
                    lvTDV.Items.Clear();
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        int stt = i + 1;
                        ListViewItem item = new ListViewItem(stt.ToString());
                        lvTDV.Items.Add(item);
                        // item.SubItems.Add(stt.ToString());
                        item.SubItems.Add(dt.Rows[i]["MA_TDV"].ToString().Trim());
                        item.SubItems.Add(dt.Rows[i]["TEN"].ToString().Trim());
                        item.SubItems.Add(dt.Rows[i]["MA"].ToString().Trim());
                    }


                }
            }
            catch (Exception ex)
            {
                TLog.WriteErr("frmPhanQuyen_LoadTDV", ex.Message + "|" + ex.StackTrace);
            }
        }
        public void LoadChucNang()
        {
            lvChucNang.Items.Clear();
            try
            {
                DataTable dt = tPhanQuyen.GetChuNang();
                if (dt != null)
                {
                    lvChucNang.Items.Clear();
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        int stt = i + 1;
                        ListViewItem item = new ListViewItem("");
                        lvChucNang.Items.Add(item);
                        // item.SubItems.Add(stt.ToString());
                        item.SubItems.Add(stt.ToString());
                        item.SubItems.Add(dt.Rows[i]["TEN"].ToString().Trim());
                        item.SubItems.Add(dt.Rows[i]["MA"].ToString().Trim());
                    }


                }
            }
            catch (Exception ex)
            {
                TLog.WriteErr("frmPhanQuyen_LoadChucNang", ex.Message + "|" + ex.StackTrace);
            }
        }

        public void RefeshLVQuyen() {
            for (int i = 0; i < lvChucNang.Items.Count; i++) {
                lvChucNang.Items[i].Checked = false;
            }
        }
        public void LoadQuyen(int _maTDV)
        {
            RefeshLVQuyen();
            try
            {
                DataTable dataQuyen = tPhanQuyen.GetPhanQuyen(_maTDV);
                if (dataQuyen != null)
                {
                    int row = -1;
                    for (int i = 0; i < dataQuyen.Rows.Count; i++)
                    {
                        row = FindRow(int.Parse(dataQuyen.Rows[i]["MaCN"].ToString()));
                        lvChucNang.Items[row].Checked =bool.Parse(dataQuyen.Rows[i]["Quyen"].ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                TLog.WriteErr("frmPhanQuyen_LoadQuyen", ex.Message + "|" + ex.StackTrace);
            }
        }
        public int FindRow(int maChuNang) {
            int result = -1;
            for (int i = 0; i < lvChucNang.Items.Count; i++)
                if (lvChucNang.Items[i].SubItems[3].Text == maChuNang.ToString())
                { result = i; break; }
            return result;
        }
        private void lvTDV_SelectedIndexChanged(object sender, EventArgs e)
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
                    maTDV = int.Parse(lv.Items[flag].SubItems[3].Text);
                    grpQuyen.Text = lv.Items[flag].SubItems[2].Text;
                    LoadQuyen(maTDV);
                }
            }
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
        }
        private void InsertUpdateQuyen() { 
            int _maTDV= maTDV;
            for(int i=0;i< lvChucNang.Items.Count;i++)
            {
            int maCN = int.Parse(lvChucNang.Items[i].SubItems[3].Text);
            bool Quyen = lvChucNang.Items[i].Checked;
            tPhanQuyen.UpdatePhanQuyen(maCN, _maTDV, Quyen);
            }
        
        }
        private void cmdLuu_Click(object sender, EventArgs e)
        {
            InsertUpdateQuyen();
        }

        private void cmdBo_Click(object sender, EventArgs e)
        {
            LoadQuyen(maTDV);
        }
       
        
    }
}
