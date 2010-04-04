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
        QuanLy.BLL.TDonvi tDonvi = new QuanLy.BLL.TDonvi();

        DataTable HH = new DataTable();

        #endregion
        public frmQuyCach()
        {
            InitializeComponent();
        }
        private void frmQuyCach_Load(object sender, EventArgs e)
        {
            loadQC();
            SetTitle("QUY CÁCH ĐƠN VỊ");
            LoadDonVi(cmb_dvt);
            LoadDonVi(cmbdvQD);
        }
        private void LoadDonVi(ComboBox cmb)
        {
            DataTable dt = tDonvi.GetDVT();
            cmb.DisplayMember = "TEN";
            cmb.ValueMember = "MADONVI";
            cmb.DataSource = dt;
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
            txtten.Text = "";
            txtSL.Text = "0";
            txtten.Text = "";
            loadQC();
        }
        public void ShowListToForm(int id)
        {
            infoQC.Ma = int.Parse(HH.Rows[id]["MA"].ToString());
            txtten.Text = HH.Rows[id]["TEN"].ToString();
            txtSL.Text = HH.Rows[id]["SLDVT"].ToString();
            cmbdvQD.SelectedValue =HH.Rows[id]["MA_DONVI_LO"].ToString();
            cmb_dvt.Text =GetDVT(HH.Rows[id]["TEN"].ToString());
        }
        public void Setinfo()
        {
            txtten.Text = cmbdvQD.Text + "/" + txtSL.Text + " " + cmb_dvt.Text;
            infoQC.Sldv = int.Parse(txtSL.Text.ToString());
            infoQC.DVTLo = int.Parse(cmbdvQD.SelectedValue.ToString());
            infoQC.Ten = txtten.Text;
            infoQC.TinhTrang = 1;
        }
        public void InsertQC()
        {
            if (CheckQC())
            {
                try
                {
                    Setinfo();
                    tQC.InsertQC(infoQC);
                }
                catch (Exception ex)
                {
                    TLog.WriteErr("frmQuyCach_Update", ex.Message);
                }

            }
            else
            {
                MessageBox.Show("Điền đầy đủ thông tin!");
            }
        }

        public void UpdateQC()
        {

            if (CheckQC())
                try
                {
                    Setinfo();
                    tQC.UpdateQC(infoQC);
                }
                catch (Exception ex)
                {
                    TLog.WriteErr("frmQuyCach_Update", ex.Message);
                }
            else
            {
                MessageBox.Show("Điền đầy đủ thông tin !");
            }
        }
        public void DeleteQC()
        {
            if (CheckQC())
                try
                {
                    Setinfo();
                    infoQC.TinhTrang = 0;
                    tQC.UpdateQC(infoQC);
                }
                catch (Exception ex)
                {
                    TLog.WriteErr("frmQuyCach_Delete", ex.Message);
                }
               
            else
            {
                MessageBox.Show("Điền đầy đủ thông tin!");
            }
        }
        public bool CheckQC()
        {
            if (txtten.Text == "") return false;
            if (txtSL.Text == "") return false;

            return true;
        }

        private void buttonX5_Click(object sender, EventArgs e)
        {
            InsertQC();
            loadQC();
        }
        private string GetDVT(string str) {

           string kq=str;
           try
           {
               int i = str.LastIndexOf('/');
               kq = str.Substring(i+1);
               kq = kq.Split(' ')[1];
           }
            catch(Exception ex){return "";}
           return kq.Trim();

        }
        private void txtSL_TextChanged(object sender, EventArgs e)
        {
            txtten.Text = cmbdvQD.Text + "/" + txtSL.Text + " " + cmb_dvt.Text;
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

        private void cmbXoa_Click(object sender, EventArgs e)
        {
            DeleteQC();
            loadQC();
        }

        private void cmbSua_Click(object sender, EventArgs e)
        {
            UpdateQC();
            loadQC();
        }

    }
}
