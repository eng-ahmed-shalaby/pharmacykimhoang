using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using Pharmacy.MyTable;

namespace Pharmacy.ThuChi
{
    public partial class frmPhieuChi : BASIC.frmChild
    {
        private static TblHD_Nhap tblHDNhap;
        private ThuChi.BLL.TPhieuChi  tPhieuChi= new ThuChi.BLL.TPhieuChi();
        Info.PhieuChi infoPhieuChi = new Info.PhieuChi();
        int idPhieu = 0;
        public frmPhieuChi()
        {
            InitializeComponent();
        }
        public void Refesh() {
            lvHD.Items.Clear();
            lvThu.Items.Clear();
            txtTongTien.Text = "0";
        }
        public void HDNhap_No(int maNCC)
        {
            Refesh();
            try
            {
                tblHDNhap = tPhieuChi.GetHD_No(maNCC);
                if (tblHDNhap != null)
                {
                    lvHD.Items.Clear();
                    for (int i = 0; i < tblHDNhap.Rows.Count; i++)
                    {
                        Add_LVHD(lvHD, tblHDNhap, i);
                    }
               
                    
                }
            }
            catch (Exception ex)
            {
                TLog.WriteErr("frmPHIEUCHI_LoadHD_No", ex.Message + "|" + ex.StackTrace);
            }
        }
        public void ShowNCC()
        {
            Pharmacy.BLL.TNhaCC tNCC = new Pharmacy.BLL.TNhaCC();
            DataTable dt = tNCC.GetNCC();
            cmbKH.DisplayMember = "TEN";
            cmbKH.ValueMember = "MANCC";
            cmbKH.DataSource = dt;
            LoadAutoNCC(dt);
        }
        public void LoadAutoNCC( DataTable dt)
        {
            AutoCompleteStringCollection collec = new AutoCompleteStringCollection();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                collec.Add(dt.Rows[i]["TEN"].ToString());
            }
            cmbKH.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbKH.AutoCompleteSource = AutoCompleteSource.CustomSource;
            cmbKH.AutoCompleteCustomSource = collec;
        }
        public void Init() {
            SetTitle("PHIẾU CHI");
            dtpNgayThu.Value = DateTime.Now;
            ShowPhieuChi(dtpNgayThu.Value,0);
        }
        private void frmPhieuThu_Load(object sender, EventArgs e)
        {
            Init();
            ShowNCC();
                     
        }

        private void lvHD_DoubleClick(object sender, EventArgs e)
        {
            if (lvHD.Items.Count > 0)
            {
                int flag = -1;
                for (int i = 0; i < lvHD.Items.Count; i++)
                {
                    if (lvHD.Items[i].Selected)
                    {
                        flag = i;
                    }
                }
                if (flag != -1)
                {
                    Add_LVNo(flag);
                    RemoveRow(lvHD, flag);
                    txtTongTien.Text = TongTien().ToString();
                }
            }

        }
        public float TongTien() {
            float result = 0;
            for (int i = 0; i < lvThu.Items.Count; i++)
               result += float.Parse(lvThu.Items[i].SubItems[2].Text);
            infoPhieuChi .TongTien = result;
            return result;
        }
        public void Add_LVNo(int i) {
            //MessageBox.Show(lvThu.Items[1].SubItems[1].Text);
            string[] s = new string[5];
            s[0] =(lvThu.Items.Count + 1).ToString();
            s[1] =lvHD.Items[i].SubItems[1].Text;
            s[2] = lvHD.Items[i].SubItems[4].Text;
            s[3] ="0";
            s[4] = lvHD.Items[i].SubItems[5].Text;
            lvThu.Items.Add(new ListViewItem(s));
        }
        public void Add_LVHD(ListView lv, DataTable dt, int i)
        {
            int stt = lv.Items.Count + 1;
            ListViewItem item = new ListViewItem(stt.ToString());
            lv.Items.Add(item);
            // item.SubItems.Add(stt.ToString());
            item.SubItems.Add(dt.Rows[i]["SOHD"].ToString().Trim());
            item.SubItems.Add(dt.Rows[i]["NGAYLAP1"].ToString().Trim());
            item.SubItems.Add(dt.Rows[i]["TONGTIEN"].ToString().Trim());
            item.SubItems.Add(dt.Rows[i]["TIENNO"].ToString().Trim());
            item.SubItems.Add(dt.Rows[i]["MA"].ToString().Trim());
        }
        public int FindRow(DataTable dt, string ma) {
            int result = -1;
            for (int i = 0; i < dt.Rows.Count; i++)
                if (dt.Rows[i]["MA"].ToString() == ma)
                    result = i;
            return result;

        }
        public void RemoveRow(ListView lv,int i) { 
            lv.Items[i].Remove();
        }
        private void lvThu_DoubleClick(object sender, EventArgs e)
        {
            int subItemSelected = 0;
            
            int nStart = lvThu.X;
            int spos = 0;
            int epos = lvThu.Columns[0].Width;
            for (int i = 0; i < lvThu.Columns.Count; i++)
            {
                if (nStart > spos && nStart < epos)
                {
                    subItemSelected = i;
                    break;
                }

                spos = epos;
                epos += lvThu.Columns[i].Width;
            }

            int colName = lvThu.Columns[subItemSelected].Index;
            if (colName != 2)
            {
                if (lvThu.Items.Count > 0)
                {
                    int flag = -1;
                    for (int i = 0; i < lvThu.Items.Count; i++)
                    {
                        if (lvThu.Items[i].Selected)
                        {
                            flag = i;
                        }
                    }
                    if (flag != -1)
                    {
                        
                        string ma =lvThu.Items[flag].SubItems[4].Text;
                        Add_LVHD(lvHD,tblHDNhap,FindRow(tblHDNhap,ma));
                        RemoveRow(lvThu, flag);
                    }
                }
            }
        }

        private void cmbKH_SelectedIndexChanged(object sender, EventArgs e)
        {
            int ma =int.Parse(cmbKH.SelectedValue.ToString());
            HDNhap_No(ma);
        }
        public Info.PhieuChi SetInfoPHIEUNHAP() {
            Info.PhieuChi info = new Info.PhieuChi();
            info.MaNCC= int.Parse(cmbKH.SelectedValue.ToString());
            info.NgayChi = dtpNgayThu.Value;
            info.TongTien = float.Parse( txtTongTien.Text);
            info.LyDo = txtLyDo.Text;
            info.KemTheo = txtKeoTheo.Text;
            info.No= txtNo.Text;
            info.Co = txtCo.Text;
            info.GhiChu = DBNull.Value.ToString();
            return info;
        }
        public Info.CTPHIEUCHI SetInfoCTPIEUCHI(int ma,string maHD, float Tien) {
            Info.CTPHIEUCHI info = new Info.CTPHIEUCHI { };
            info.MaPhieu = ma;
            info.MaHDNhap=maHD;
            info.Tien = Tien;
            return info;
        }
        private void InsertPhieuChi() {
            if (rdKH.Checked == true)
                infoPhieuChi= SetInfoPHIEUNHAP();
            else 
                infoPhieuChi = SetInfoPHIEUNHAP_Khac();
            BLL.TPhieuChi tPhieuChi = new BLL.TPhieuChi();
            infoPhieuChi.Ma = tPhieuChi.InsertPHIEUCHI(infoPhieuChi);
        }
        private void InsertCTPhieuChi(int ma)
        {
         
            Info.CTPHIEUCHI info = new Info.CTPHIEUCHI();
            if (rdKH.Checked == true)
            {
                for (int i = 0; i < lvThu.Items.Count; i++)
                {
                    try
                    {
                        info = SetInfoCTPIEUCHI(ma, lvThu.Items[i].SubItems[1].Text, float.Parse(lvThu.Items[i].SubItems[2].Text));
                        BLL.TPhieuChi tPhieuChi= new BLL.TPhieuChi();
                         tPhieuChi.InsertCT_PHIEUCHI(info);

                    }
                    catch (Exception ex)
                    {
                        TLog.WriteErr("frmPHIEUCHI_InsertCTPhieuchi", ex.Message + "|" + ex.StackTrace);
                    }

                }
            }
            else {
                try
                {
                    info = SetInfoCTPIEUCHI(ma, DBNull.Value.ToString(), float.Parse(txtTongTien.Text));
                    BLL.TPhieuChi tPhieuChi= new BLL.TPhieuChi();
                    tPhieuChi.InsertCT_PHIEUCHI(info);
                }
                catch (Exception ex)
                {
                    TLog.WriteErr("frmPHIEUCHI_InsertCTPhieuchi", ex.Message + "|" + ex.StackTrace);
                }

            }
        }
        private void UpdateHD()
        {
            try
            {
                for (int i = 0; i < lvThu.Items.Count; i++)
                {
                    int _index = FindRow(tblHDNhap, lvThu.Items[i].SubItems[4].Text);
                    string _tienno=lvThu.Items[i].SubItems[3].Text;
                    int _tinhtrang = 1;
                    if (_tienno == "0")
                        _tinhtrang = 0;
                    tblHDNhap.Rows[_index]["TIENNO"] = _tienno;
                    tblHDNhap.Rows[_index]["TINHTRANG"] = _tinhtrang;
                }
                tblHDNhap.Update();
            }
            catch (Exception ex)
            {
                TLog.WriteErr("frmPHIEUCHI_UpdateHD", ex.Message + "|" + ex.StackTrace);
            }
        }
      
        public void ShowPhieuChi(DateTime date, int flag) {
            try
            {
                DataTable dt = tPhieuChi.GetPhieuChi_Date(date,flag);
                if (dt != null)
                {
                    lvDisplayPhieuThu.Items.Clear();
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        int stt = i + 1;
                        ListViewItem item = new ListViewItem(stt.ToString());
                        lvDisplayPhieuThu.Items.Add(item);
                        // item.SubItems.Add(stt.ToString());
                        item.SubItems.Add(dt.Rows[i]["MA"].ToString().Trim());
                        item.SubItems.Add(dt.Rows[i]["TEN"].ToString().Trim());
                        item.SubItems.Add(dt.Rows[i]["TongTien"].ToString().Trim());
                        item.SubItems.Add(dt.Rows[i]["NgayThu"].ToString().Trim());
                        item.SubItems.Add(dt.Rows[i]["LyDo"].ToString().Trim());
                        item.SubItems.Add(dt.Rows[i]["KemTheo"].ToString().Trim());
                    }
                }
            }
            catch (Exception ex)
            {
                TLog.WriteErr("frmPHIEUCHI_LoadHD_No", ex.Message + "|" + ex.StackTrace);
            }

        }
        
        private void cmdThu_Click(object sender, EventArgs e)
        {
            InsertPhieuChi();
            InsertCTPhieuChi(infoPhieuChi.Ma);
            UpdateHD();
            ShowPhieuChi(dtpNgayThu.Value,0);
            ShowRPT(infoPhieuChi.Ma);
        }

       private void lvThu_DrawItem(object sender, DrawListViewItemEventArgs e)
        {
            txtTongTien.Text = TongTien().ToString();
        }
       public Info.PhieuChi SetInfoPHIEUNHAP_Khac()
       {
           Info.PhieuChi info = new Info.PhieuChi();
           info.MaNCC = 0;
           info.NgayChi = dtpNgayThu.Value;
           info.TongTien = float.Parse(txtTongTien.Text);
           info.LyDo = txtLyDo.Text;
           info.KemTheo = txtKeoTheo.Text;
           info.No = txtNo.Text;
           info.Co = txtCo.Text;
           info.GhiChu = cmbKH.Text.ToString()+"_" +txtDiaChi.Text;
           return info;
       }
       private void rdKhac_CheckedChanged(object sender, EventArgs e)
       {
           grbHD.Enabled = false;
           grbTra.Enabled = false;
           cmbKH.Text = "";
           txtDiaChi.Enabled = true;
       }

       private void rdKH_CheckedChanged(object sender, EventArgs e)
       {
           grbHD.Enabled = true;
           grbTra.Enabled = true;
           txtDiaChi.Enabled = false;
       }

       private void cmdXoa_Click(object sender, EventArgs e)
       {

       }

       private void cmdSua_Click(object sender, EventArgs e)
       {
           Refesh();
           txtLyDo.Text = "";
           txtKeoTheo.Text = "";
           txtDiaChi.Text = "";
           txtNo.Text = "";
           txtCo.Text = "";
       }

       private void dpkDateHD_ValueChanged(object sender, EventArgs e)
       {
           ShowPhieuChi(dpkMonthThu.Value, 1);
           //
         //  LoadHD(dpkDateHD.Value);
       }

       public void ShowRPT(int ma) { 
           try
           {
          frmrptThu frm = new frmrptThu();
          frm.Show(ma,0);
              }
           catch (Exception ex)
           {
               TLog.WriteErr("frmPHIEUCHI_In", ex.Message + "|" + ex.StackTrace);
           }
       }
       private void cmdIn_Click(object sender, EventArgs e)
       {
          
               for (int i = 0; i < lvDisplayPhieuThu.Items.Count; i++)
                   if (lvDisplayPhieuThu.Items[i].Selected == true)
                   {
                       ShowRPT(int.Parse(lvDisplayPhieuThu.Items[i].SubItems[1].Text));

                   }
       }
      
     
    
    }
}