using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Pharmacy.QuanLy
{
    public partial class frmNhomNCC : Pharmacy.BASIC.frmChild
    {
        #region Bien


        Pharmacy.QuanLy.BLL.TNhomCC tNhomCC = new Pharmacy.QuanLy.BLL.TNhomCC();

        Pharmacy.QuanLy.Info.NhomCCInfo infoNhomCC = new Pharmacy.QuanLy.Info.NhomCCInfo();


        DataTable HH = new DataTable();

        #endregion
        public frmNhomNCC()
        {
            InitializeComponent();
        }

        private void frmNhomNCC_Load(object sender, EventArgs e)
        {
            Init();
            SetTitle("NHÓM NHÀ CUNG CẤP");
        }
        private void Init()
        {
            loadnhomcc();
        }

        public void SetInfoNSX()
        {
            infoNhomCC.Tennhom = txttennsx.Text;
            infoNhomCC.Mota = txt_mota.Text;



        }
        public void loadnhomcc()
        {
            try
            {
                HH = tNhomCC.GetNhomCC();
                if (HH != null)
                {
                    lvhanghoa.Items.Clear();
                    for (int i = 0; i < HH.Rows.Count; i++)
                    {
                        int stt = i + 1;
                        ListViewItem item = new ListViewItem(stt.ToString());
                        lvhanghoa.Items.Add(item);
                        item.SubItems.Add(HH.Rows[i]["TENNHOM"].ToString().Trim());
                        item.SubItems.Add(HH.Rows[i]["MOTA"].ToString().Trim());
                        item.SubItems.Add(HH.Rows[i]["MANHOMNCC"].ToString().Trim());
                    }
                }
            }
            catch (Exception ex)
            {
                TLog.WriteErr("frmNhomNCC_Load", ex.Message + "|" + ex.StackTrace);
            }
        }
        public void set_md()
        {
            txttennsx.Text = "";
            txt_mota.Text = "";
            loadnhomcc();
        }
        public void ShowListToForm(int id)
        {
            try
            {
                infoNhomCC.Mannhomcc = int.Parse(HH.Rows[id]["MANHOMNCC"].ToString());
                txttennsx.Text = HH.Rows[id]["TENNHOM"].ToString();
            }
            catch (Exception ex)
            {
                TLog.WriteErr("frmNhomNCC_ShowlisttoData", ex.Message + "|" + ex.StackTrace);
            }

        }
        public void InsertNhomCC()
        {
            try
            {
                if (CheckNhomCC())
                {
                    tNhomCC.InsertNhomCC(infoNhomCC);
                }
                else
                {
                    MessageBox.Show("Điền đầy đủ thông tin Nhóm NCC!");
                }
            }
            catch (Exception ex)
            {
                TLog.WriteErr("frmNhomNCC_InsertNhom", ex.Message + "|" + ex.StackTrace);
            }
        }

        public void UpdateNhomCC()
        {
            try
            {
                if (CheckNhomCC())
                    tNhomCC.UpdateNhomCC(infoNhomCC);
                else
                {
                    MessageBox.Show("Điền đầy đủ thông tin Nhóm NCC!");
                }
            }
            catch (Exception ex)
            {
                TLog.WriteErr("frmNhomNCC_Update", ex.Message + "|" + ex.StackTrace);
            }
        }

        public void DeleteNhomCC()
        {
            try
            {
                if (CheckNhomCC())
                    tNhomCC.DeleteNhomCC(infoNhomCC);
                else
                {
                    MessageBox.Show("Điền đầy đủ thông tin Nhóm NCC!");
                }
            }
            catch (Exception ex)
            {
                TLog.WriteErr("frmNhomNCC_Delete", ex.Message + "|" + ex.StackTrace);
            }
        }
        public bool CheckNhomCC()
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
            SetInfoNhomCC();
            InsertNhomCC();
            set_md();
        }

        private void buttonX6_Click(object sender, EventArgs e)
        {
            SetInfoNhomCC();
            UpdateNhomCC();
            set_md();
        }

        private void buttonX4_Click(object sender, EventArgs e)
        {
            SetInfoNhomCC();
            DeleteNhomCC();
            set_md();
        }
        public void SetInfoNhomCC()
        {
            infoNhomCC.Tennhom = txttennsx.Text;
            infoNhomCC.Mota = txt_mota.Text;


        }

   
    }
}
