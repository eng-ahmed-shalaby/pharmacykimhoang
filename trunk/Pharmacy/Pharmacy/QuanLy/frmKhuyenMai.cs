using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Pharmacy.QuanLy
{
    public partial class frmKhuyenMai : Pharmacy.BASIC.frmChild
    {
        #region Bien

        BLL.TkhuyenMai tKM = new BLL.TkhuyenMai();
        Info.KhuyenMaiInfo info = new Info.KhuyenMaiInfo();
        Pharmacy.BLL.THangHoa tHH= new Pharmacy.BLL.THangHoa();
        #endregion
        public frmKhuyenMai()
        {
            InitializeComponent();
        }

        private void frmKhuyenMai_Load(object sender, EventArgs e)
        {
            Init();
            SetTitle("NHÓM NHÀ CUNG CẤP");
        }
        private void Init()
        {
           LoadKM(1,1);
           ShowHH(cmbHH);
           ShowHH(cmbHHKM);
        }

        public void SetInfoKhuyenMai()
        {
                info.MaHH = int.Parse(cmbHH.SelectedValue.ToString());
                info.SL =int.Parse(txtSLBan.Text);
                info.SLKM = int.Parse(txtSLKM.Text);
                info.NgayKM = DateTime.Now;
                info.MaHHKM = int.Parse(cmbHHKM.SelectedValue.ToString());
                info.TrangThai = 1;
        }
        public void ShowHH(ComboBox cmb)
        {
            Pharmacy.BLL.THangHoa tHH = new Pharmacy.BLL.THangHoa();
            DataTable dt = tHH.GetHangHoa_ALL();
            cmb.DisplayMember = "TENHANGHOA";
            cmb.ValueMember = "MA";
            cmb.DataSource = dt;
            LoadAutoHH(cmb,dt);
        }
        public void LoadAutoHH(ComboBox cmb,DataTable dt)
        {
            AutoCompleteStringCollection collec = new AutoCompleteStringCollection();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                collec.Add(dt.Rows[i]["TENHANGHOA"].ToString());
            }
            cmb.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmb.AutoCompleteSource = AutoCompleteSource.CustomSource;
            cmb.AutoCompleteCustomSource = collec;
        }
        public void LoadKM(int t1, int t2)
        {
            try
            {
                DataTable dt = tKM.GetKM(t1,t2);
                if (dt != null)
                {
                    lvhanghoa.Items.Clear();
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        int stt = i + 1;
                        ListViewItem item = new ListViewItem(stt.ToString());
                        lvhanghoa.Items.Add(item);
                        item.SubItems.Add(dt.Rows[i]["TENHH"].ToString().Trim());
                        item.SubItems.Add(dt.Rows[i]["TenDV"].ToString().Trim());
                        item.SubItems.Add(dt.Rows[i]["SL"].ToString().Trim());
                        item.SubItems.Add(dt.Rows[i]["TENHHKM"].ToString().Trim());
                        item.SubItems.Add(dt.Rows[i]["TenDVKM"].ToString().Trim());
                        item.SubItems.Add(dt.Rows[i]["SLKM"].ToString().Trim());
                        item.SubItems.Add(String.Format("{0:dd/MM/yyyy}",dt.Rows[i]["NgayKM"].ToString().Trim()));
                    }
                }
            }
            catch (Exception ex)
            {
                TLog.WriteErr("frmKhuyenMai_Load", ex.Message + "|" + ex.StackTrace);
            }
        }
        //public void set_md()
        //{
        //    txttennsx.Text = "";
        //    txt_mota.Text = "";
        //    loadnhomcc();
        //}
        //public void ShowListToForm(int id)
        //{
        //    try
        //    {
        //        infoNhomCC.Mannhomcc = int.Parse(HH.Rows[id]["MANHOMNCC"].ToString());
        //        txttennsx.Text = HH.Rows[id]["TENNHOM"].ToString();
        //    }
        //    catch (Exception ex)
        //    {
        //        TLog.WriteErr("frmKhuyenMai_ShowlisttoData", ex.Message + "|" + ex.StackTrace);
        //    }

        //}
        public bool CheckFrom()
        {

            double Num;
            bool isNum;
            isNum= double.TryParse(txtSLKM.Text, out Num);
            if (!isNum) return false;
            isNum = double.TryParse(txtSLBan.Text, out Num);
            if (!isNum) return false;
            if (txtSLKM.Text == "") return false;
            if (txtSLBan.Text == "") return false;
            return true;
        }
        bool IsNumber(string text)
        {
            Regex regex = new Regex(@"^[-+]?[0-9]*\.?[0-9]+$");
            return regex.IsMatch(text);
        }
        public void Reset()
        {
          txtSLKM.Text = "";
          txtSLBan.Text = "";
        }
        public void InsertKM()
        {
            try
            {
                if (CheckFrom())
                {
                    SetInfoKhuyenMai();
                    tKM.InsertKM(info);
                }
                else
                {
                    MessageBox.Show("Điền đầy đủ thông tin Khuyến mãi!");
                }
            }
            catch (Exception ex)
            {
                TLog.WriteErr("frmKhuyenMai_Insert", ex.Message + "|" + ex.StackTrace);
            }
        }

        //public void UpdateNhomCC()
        //{
        //    try
        //    {
        //        if (CheckNhomCC())
        //            tNhomCC.UpdateNhomCC(infoNhomCC);
        //        else
        //        {
        //            MessageBox.Show("Điền đầy đủ thông tin Nhóm NCC!");
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        TLog.WriteErr("frmKhuyenMai_Update", ex.Message + "|" + ex.StackTrace);
        //    }
        //}

        //public void DeleteNhomCC()
        //{
        //    try
        //    {
        //        if (CheckNhomCC())
        //            tNhomCC.DeleteNhomCC(infoNhomCC);
        //        else
        //        {
        //            MessageBox.Show("Điền đầy đủ thông tin Nhóm NCC!");
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        TLog.WriteErr("frmKhuyenMai_Delete", ex.Message + "|" + ex.StackTrace);
        //    }
        //}


        private void lvhanghoa_SelectedIndexChanged(object sender, EventArgs e)
        {
        //    if (lvhanghoa.Items.Count > 0)
        //    {
        //        int flag = -1;
        //        for (int i = 0; i < lvhanghoa.Items.Count; i++)
        //        {
        //            if (lvhanghoa.Items[i].Selected)
        //            {
        //                flag = i;
        //            }
        //        }
        //        if (flag != -1)
        //        {

        //            ShowListToForm(flag);

        //        }
        //    }
        }

        private void cmdThem_Click(object sender, EventArgs e)
        {
            InsertKM();
            Reset();
            LoadKM(1, 1);
        }
        public string GetDonVi(int ma)
        {
            DataTable dt = tKM.GetTenDV(ma);
            if (dt.Rows.Count > 0)
                return dt.Rows[0]["Ten"].ToString();
            else return "";
        }
        private void cmbHH_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtDVTban.Text = GetDonVi(int.Parse(cmbHH.SelectedValue.ToString()));
        }
    
        private void cmbHHKM_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtDVKM.Text = GetDonVi(int.Parse(cmbHHKM.SelectedValue.ToString()));
        }

        //private void buttonX5_Click(object sender, EventArgs e)
        //{
        //    SetInfoNhomCC();
        //    InsertNhomCC();
        //    set_md();
        //}

        //private void buttonX6_Click(object sender, EventArgs e)
        //{
        //    SetInfoNhomCC();
        //    UpdateNhomCC();
        //    set_md();
        //}

        //private void buttonX4_Click(object sender, EventArgs e)
        //{
        //    SetInfoNhomCC();
        //    DeleteNhomCC();
        //    set_md();
        //}
        //public void SetInfoNhomCC()
        //{
        //    infoNhomCC.Tennhom = txttennsx.Text;
        //    infoNhomCC.Mota = txt_mota.Text;


        //}

   
    }
}
