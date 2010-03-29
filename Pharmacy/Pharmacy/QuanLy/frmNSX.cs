using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Pharmacy.QuanLy
{
    public partial class frmNSX : Pharmacy.BASIC.frmChild
    {
        #region Bien   

        
        Pharmacy.QuanLy.BLL.TNhaSX tNSX = new Pharmacy.QuanLy.BLL.TNhaSX();

        Pharmacy.QuanLy.Info.NhaSXInfo infoNSX = new Pharmacy.QuanLy.Info.NhaSXInfo();      


        DataTable HH = new DataTable();

        #endregion

        public frmNSX()
        {
            InitializeComponent();
        }

        private void frmNSX_Load(object sender, EventArgs e)
        {
            SetTitle("THÊM NHÀ SẢN XUẤT");
            Init();
        }
        private void Init()
        {          
            loadnhasanxuat();
            LoadQG();
        }

        public void LoadQG() {
            try
            {
                Pharmacy.BLL.TQG tQG = new Pharmacy.BLL.TQG();
                DataTable dt = tQG.GetQG();
                cmb_QG.DataSource = dt;
                cmb_QG.ValueMember = "MA";
                cmb_QG.DisplayMember = "TEN";
            }
            catch (Exception ex)
            {
                TLog.WriteErr("frmNSX_LoadQG", ex.Message + "|||" + ex.StackTrace);
            }
        }
        public void SetInfoNSX()
        {
            infoNSX.Tennsx = txttennsx.Text;
            infoNSX.MaQG = int.Parse(cmb_QG.SelectedValue.ToString());
            infoNSX.DienThoai = txtDienThoai.Text;
        }
        public void loadnhasanxuat()
        {
            try
            {
                HH = tNSX.GetNSX();
                if (HH != null)
                {
                    lvhanghoa.Items.Clear();
                    for (int i = 0; i < HH.Rows.Count; i++)
                    {
                        int stt = i + 1;
                        ListViewItem item = new ListViewItem(stt.ToString());
                        lvhanghoa.Items.Add(item);
                        item.SubItems.Add(HH.Rows[i]["TENSX"].ToString().Trim());
                        item.SubItems.Add(HH.Rows[i]["TEN"].ToString().Trim());
                        item.SubItems.Add(HH.Rows[i]["DIENTHOAI"].ToString().Trim());
                        item.SubItems.Add(HH.Rows[i]["MA"].ToString().Trim());
                    }
                }
            }
            catch (Exception ex)
            {
                TLog.WriteErr("frmNSX_loadnsx", ex.Message + "|" + ex.StackTrace);
            }
        }
        public void set_md()
        {
            txttennsx.Text = "";
            loadnhasanxuat();
        }
        public void ShowListToForm(int id)
        {
            try
            {
                infoNSX.Mansx = int.Parse(HH.Rows[id]["MA"].ToString());
                txttennsx.Text = HH.Rows[id]["TENSX"].ToString();
                txtDienThoai.Text = HH.Rows[id]["DIENTHOAI"].ToString();
                cmb_QG.Text = HH.Rows[id]["TEN"].ToString();
            }
            catch (Exception ex)
            {
                TLog.WriteErr("frmNSX_ShowListToForm", ex.Message + "|" + ex.StackTrace);
            }
        }
        public void InsertNSX()
        {
            try
            {
                if (CheckNSX())
                {
                    tNSX.InsertNSX(infoNSX);
                }
                else
                {
                    MessageBox.Show("Điền đầy đủ thông tin NSX!");
                }
            }
            catch (Exception ex)
            {
                TLog.WriteErr("frmNSX_Insert", ex.Message + "|" + ex.StackTrace);
            }
        }

        public void UpdateNSX()
        {
            try
            {
                if (CheckNSX())
                    tNSX.UpdateNSX(infoNSX);
                else
                {
                    MessageBox.Show("Điền đầy đủ thông tin hàng hóa!");
                }
            }
            catch (Exception ex)
            {
                TLog.WriteErr("frmNSX_Update", ex.Message + "|" + ex.StackTrace);
            }
        }

        public void DeleteNSX()
        {
            try
            {
                if (CheckNSX())
                    tNSX.DeleteNSX(infoNSX);
                else
                {
                    MessageBox.Show("Điền đầy đủ thông tin hàng hóa!");
                }
            }
            catch (Exception ex)
            {
                TLog.WriteErr("frmNSX_Delete", ex.Message + "|" + ex.StackTrace);
            }
        }
        public bool CheckNSX()
        {
            if (txttennsx.Text == "") return false;            

            return true;
        }

        private void buttonX5_Click(object sender, EventArgs e)
        {
            SetInfoNSX();
            InsertNSX();
            set_md();
        }

        private void buttonX6_Click(object sender, EventArgs e)
        {
            SetInfoNSX();
            UpdateNSX();
            set_md();
        }

        private void buttonX4_Click(object sender, EventArgs e)
        {
            SetInfoNSX();
            DeleteNSX();
            set_md();
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
       
       
    }
}
