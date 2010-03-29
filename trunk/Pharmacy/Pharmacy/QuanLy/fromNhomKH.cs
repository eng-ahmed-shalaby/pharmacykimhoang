using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using PrintControl;

namespace Pharmacy.QuanLy
{
    public partial class fromNhomKH : Pharmacy.BASIC.frmChild
    {
        #region Bien


        Pharmacy.QuanLy.BLL.TNhomKH tNhomKH = new Pharmacy.QuanLy.BLL.TNhomKH();

        Pharmacy.QuanLy.Info.NhomKHInfo infoNhomKH = new Pharmacy.QuanLy.Info.NhomKHInfo();


        DataTable HH = new DataTable();

        #endregion
        public fromNhomKH()
        {
            InitializeComponent();
        }
        private void Init()
        {
            loadnhomkh();
            SetTitle("NHÓM KHÁCH HÀNG");
        }

        public void SetInfoNhomKH()
        {
            infoNhomKH.Tennhom = txttennsx.Text;
            infoNhomKH.Mota = txt_mota.Text;
        }
        public void loadnhomkh()
        {
            try
            {
                HH = tNhomKH.GetNhomKH();
                if (HH != null)
                {
                    lvhanghoa.Items.Clear();
                    for (int i = 0; i < HH.Rows.Count; i++)
                    {
                        int stt = i + 1;
                        ListViewItem item = new ListViewItem(stt.ToString());
                        lvhanghoa.Items.Add(item);
                        item.SubItems.Add(HH.Rows[i]["TEN"].ToString().Trim());
                        item.SubItems.Add(HH.Rows[i]["MOTA"].ToString().Trim());

                        item.SubItems.Add(HH.Rows[i]["MANHOMKH"].ToString().Trim());
                    }
                }
            }
            catch (Exception ex)
            {
                TLog.WriteErr("frmNhomKH_loadnhomkh", ex.Message + "|" + ex.StackTrace);
            }
        }
        public void set_md()
        {
            txttennsx.Text = "";
            txt_mota.Text = "";
            loadnhomkh();
        }
        public void ShowListToForm(int id)
        {
            try
            {
                infoNhomKH.Mannhomkh = int.Parse(HH.Rows[id]["MANHOMKH"].ToString());
                txttennsx.Text = HH.Rows[id]["TEN"].ToString();
            }
            catch (Exception ex)
            {
                TLog.WriteErr("frmNhomKH_ShowList", ex.Message + "|" + ex.StackTrace);
            }

        }
        public void InsertNhomKH()
        {
            try
            {
                if (CheckNhomKH())
                {
                    tNhomKH.InsertNhomKH(infoNhomKH);
                }
                else
                {
                    MessageBox.Show("Điền đầy đủ thông tin Nhóm NCC!");
                }
            }
            catch (Exception ex)
            {
                TLog.WriteErr("frmNhomKH_Insert", ex.Message + "|" + ex.StackTrace);
            }
        }

        public void UpdateNhomKH()
        {
            try
            {
                if (CheckNhomKH())
                    tNhomKH.UpdateNhomKH(infoNhomKH);
                else
                {
                    MessageBox.Show("Điền đầy đủ thông tin Nhóm NCC!");
                }
            }
            catch (Exception ex)
            {
                TLog.WriteErr("frmNhomKH_Update", ex.Message + "|" + ex.StackTrace);
            }
        }

        public void DeleteNhomKH()
        {
            try
            {   
                tNhomKH.DeleteNhomKH(infoNhomKH);
            }
            catch (Exception ex)
            {
                TLog.WriteErr("frmNhomKH_DeleteNhomKH", ex.Message + "|" + ex.StackTrace);
            }
        }
        public bool CheckNhomKH()
        {
            if (txttennsx.Text == "") return false;

            return true;
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

        private void buttonX5_Click(object sender, EventArgs e)
        {
            SetInfoNhomKH();
            InsertNhomKH();
            set_md();
        }

        private void buttonX6_Click(object sender, EventArgs e)
        {
            SetInfoNhomKH();
            UpdateNhomKH();
            set_md();
        }

        private void buttonX4_Click(object sender, EventArgs e)
        {
            SetInfoNhomKH();
            DeleteNhomKH();
            set_md();
        }

        private void fromNhomKH_Load(object sender, EventArgs e)
        {
            Init();
        }

      
        //public void SetInfoNhomKH()
        //{
        //    infoNhomKH.Tennhom = txttennsx.Text;
        //    infoNhomKH.Mota = txt_mota.Text;


        //}

    }
}
