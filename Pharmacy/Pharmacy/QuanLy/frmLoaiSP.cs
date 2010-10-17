using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Pharmacy.QuanLy
{
    public partial class frmLoaiSP : Pharmacy.BASIC.frmChild
    {
        #region Bien


        Pharmacy.QuanLy.BLL.TLoaiHH tLoaiSP = new Pharmacy.QuanLy.BLL.TLoaiHH();

        Pharmacy.QuanLy.Info.LoaiHHInfo infoLoaiSP = new Pharmacy.QuanLy.Info.LoaiHHInfo();


        DataTable HH = new DataTable();

        #endregion

        public frmLoaiSP()
        {
            InitializeComponent();
        }

        private void frmLoaiSP_Load(object sender, EventArgs e)
        {
            Init();

        }
        private void Init()
        {


            loadLoaiSP();

        }

        public void SetInfoLoaiSP()
        {
            infoLoaiSP.TEN = txt_tenloai.Text;
            infoLoaiSP.MOTA = txt_mota.Text;



        }
        public void loadLoaiSP()
        {

            HH = tLoaiSP.GetLoaiSP();
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

                    item.SubItems.Add(HH.Rows[i]["MA"].ToString().Trim());
                }
            }
        }
        public void set_md()
        {
            txt_tenloai.Text = "";
            txt_mota.Text = "";
            loadLoaiSP();
        }
        public void ShowListToForm(int id)
        {
            infoLoaiSP.MA = int.Parse(HH.Rows[id]["MA"].ToString());
            txt_tenloai.Text = HH.Rows[id]["TEN"].ToString();
            txt_mota.Text = HH.Rows[id]["MOTA"].ToString();


        }
        public void InsertLoaiSP()
        {
            if (CheckLoaiSP())
            {



                tLoaiSP.InsertLoaiSP(infoLoaiSP);




            }
            else
            {
                MessageBox.Show("Điền đầy đủ thông tin Nhóm NCC!");
            }
        }

        public void UpdateLoaiSP()
        {
            if (CheckLoaiSP())
                tLoaiSP.UpdateLoaiSP(infoLoaiSP);
            else
            {
                MessageBox.Show("Điền đầy đủ thông tin Nhóm NCC!");
            }
        }

        public void DeleteLoaiSP()
        {
            if (CheckLoaiSP())
                tLoaiSP.DeleteLoaiSP(infoLoaiSP);
            else
            {
                MessageBox.Show("Điền đầy đủ thông tin Nhóm NCC!");
            }
        }
        public bool CheckLoaiSP()
        {
            if (txt_tenloai.Text == "") return false;

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
            SetInfoLoaiSP();
            InsertLoaiSP();
            set_md();
        }

        private void buttonX6_Click(object sender, EventArgs e)
        {
            SetInfoLoaiSP();
            UpdateLoaiSP();
            set_md();
        }

        private void buttonX4_Click(object sender, EventArgs e)
        {
            SetInfoLoaiSP();
            DeleteLoaiSP();
            set_md();
        }
        
    }
}
