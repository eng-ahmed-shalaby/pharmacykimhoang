using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Pharmacy.QuanLy
{
    public partial class frmQuyCach : Pharmacy.BASIC.frmChild
    {
        #region Bien


        Pharmacy.QuanLy.BLL.TQuyCach tQC = new Pharmacy.QuanLy.BLL.TQuyCach();

        Pharmacy.QuanLy.Info.QuyCachInfo infoQC = new Pharmacy.QuanLy.Info.QuyCachInfo();


        DataTable HH = new DataTable();

        #endregion
        public frmQuyCach()
        {
            InitializeComponent();
        }
        private void frmQuyCach_Load(object sender, EventArgs e)
        {

        }

        public void loadQC()
        {

            HH = tQC.GetQC();
            if (HH != null)
            {
                lvhanghoa.Items.Clear();
                for (int i = 0; i < HH.Rows.Count; i++)
                {
                    int stt = i + 1;
                    ListViewItem item = new ListViewItem(stt.ToString());
                    lvhanghoa.Items.Add(item);
                    item.SubItems.Add(HH.Rows[i]["TEN"].ToString().Trim());
                    item.SubItems.Add(HH.Rows[i]["SLDVT"].ToString().Trim());
                    item.SubItems.Add(HH.Rows[i]["MA"].ToString().Trim());
                }
            }
        }
        public void set_md()
        {
            txttennsx.Text = "";
            txt_mota.Text = "";
            loadQC();
        }
        public void ShowListToForm(int id)
        {
            infoQC.Ma = int.Parse(HH.Rows[id]["MA"].ToString());
            txttennsx.Text = HH.Rows[id]["TEN"].ToString();
            txt_mota.Text = HH.Rows[id]["SLDVT"].ToString();


        }
        public void InsertQC()
        {
            if (CheckQC())
            {
                tQC.InsertQC(infoQC);

           }
            else
            {
                MessageBox.Show("Điền đầy đủ thông tin NSX!");
            }
        }

        public void UpdateQC()
        {
            if (CheckQC())
                tQC.UpdateQC(infoQC);
            else
            {
                MessageBox.Show("Điền đầy đủ thông tin hàng hóa!");
            }
        }
        public void DeleteQC()
        {
            if (CheckQC())
                tQC.DeleteQC(infoQC);
            else
            {
                MessageBox.Show("Điền đầy đủ thông tin hàng hóa!");
            }
        }
        public bool CheckQC()
        {
            if (txttennsx.Text == "") return false;
            if (txt_mota.Text == "") return false;

            return true;
        }

        private void buttonX5_Click(object sender, EventArgs e)
        {

        }

    }
}
