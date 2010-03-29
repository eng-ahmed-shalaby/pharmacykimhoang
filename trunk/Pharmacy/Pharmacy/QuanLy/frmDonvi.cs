using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Pharmacy.QuanLy
{
    public partial class frmDonvi : Pharmacy.BASIC.frmChild
    {
        #region Bien


        Pharmacy.QuanLy.BLL.TDonvi tDVT = new Pharmacy.QuanLy.BLL.TDonvi();

        Pharmacy.QuanLy.Info.DonViInfo infoDVT = new Pharmacy.QuanLy.Info.DonViInfo();


        DataTable HH = new DataTable();

        #endregion
        public frmDonvi()
        {
            InitializeComponent();
        }

        private void frmDonvi_Load(object sender, EventArgs e)
        {
            Init();
        }
        private void Init()
        {

            SetTitle("ĐƠN VỊ HÀNG HÓA");
            loadDONVI();

        }

       
        public void loadDONVI()
        {

            HH = tDVT.GetDVT();
            if (HH != null)
            {
                lvhanghoa.Items.Clear();
                for (int i = 0; i < HH.Rows.Count; i++)
                {
                    int stt = i + 1;
                    ListViewItem item = new ListViewItem(stt.ToString());
                    lvhanghoa.Items.Add(item);
                    item.SubItems.Add(HH.Rows[i]["TEN"].ToString().Trim());

                    item.SubItems.Add(HH.Rows[i]["MADONVI"].ToString().Trim());
                }
            }
        }
        public void set_md()
        {
            txttennsx.Text = "";
            loadDONVI();
        }
        public void ShowListToForm(int id)
        {
            infoDVT.Ma = int.Parse(HH.Rows[id]["MADONVI"].ToString());
            txttennsx.Text = HH.Rows[id]["TEN"].ToString();


        }
        public void InsertDVT()
        {
            if (CheckDVT())
            {



                tDVT.InsertDVT(infoDVT);




            }
            else
            {
                MessageBox.Show("Điền đầy đủ thông tin NSX!");
            }
        }

        public void UpdateDVT()
        {
            if (CheckDVT())
                tDVT.UpdateDVT(infoDVT);
            else
            {
                MessageBox.Show("Điền đầy đủ thông tin hàng hóa!");
            }
        }

        public void DeleteDVT()
        {
            if (CheckDVT())
                tDVT.DeleteDVT(infoDVT);
            else
            {
                MessageBox.Show("Điền đầy đủ thông tin hàng hóa!");
            }
        }
        public bool CheckNSX()
        {
            if (txttennsx.Text == "") return false;

            return true;
        }

        private void buttonX5_Click(object sender, EventArgs e)
        {
            SetInfoDVT();
            InsertDVT();
            set_md();
        }

        private void buttonX6_Click(object sender, EventArgs e)
        {
            SetInfoDVT();
            UpdateDVT();
            set_md();
        }

        private void buttonX4_Click(object sender, EventArgs e)
        {
            SetInfoDVT();
            DeleteDVT();
            set_md();
        }

        public void SetInfoDVT()
        {
            infoDVT.Ten = txttennsx.Text;



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
        public bool CheckDVT()
        {
            if (txttennsx.Text == "") return false;

            return true;
        }
    }
}
