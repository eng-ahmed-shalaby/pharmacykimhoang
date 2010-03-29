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
    public partial class frmPhieuThu : BASIC.frmChild
    {
        private static TblHD_Xuat tblHDXuat;
        private ThuChi.BLL.TPhieuThu  tPhieuThu= new ThuChi.BLL.TPhieuThu();
        Info.PhieuThu infoPhieuThu = new Info.PhieuThu();
        int idPhieu = 0;
        public frmPhieuThu()
        {
            InitializeComponent();
        }
        public void Refesh() {
            lvHD.Items.Clear();
            lvThu.Items.Clear();
            txtTongTien.Text = "0";
        }
        public void HDXuat_No(int maKH)
        {
            Refesh();
            try
            {
                tblHDXuat = tPhieuThu.GetHD_No(maKH);
                if (tblHDXuat != null)
                {
                    lvHD.Items.Clear();
                    for (int i = 0; i < tblHDXuat.Rows.Count; i++)
                    {
                        Add_LVHD(lvHD, tblHDXuat, i);
                    }
               
                    
                }
            }
            catch (Exception ex)
            {
                TLog.WriteErr("frmPHIEUTHU_LoadHD_No", ex.Message + "|" + ex.StackTrace);
            }
        }
        public void ShowKH()
        {
            Pharmacy.BLL.TKhachHang tKH = new Pharmacy.BLL.TKhachHang();
            DataTable dt = tKH.GetKhachHang();
            cmbKH.DisplayMember = "TEN";
            cmbKH.ValueMember = "MAKH";
            cmbKH.DataSource = dt;
            LoadAutoKH(dt);
        }
        public void LoadAutoKH( DataTable dt)
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
            SetTitle("PHIẾU THU");
            dtpNgayThu.Value = DateTime.Now;
            ShowPhieuThu(dtpNgayThu.Value,0);
        }
        private void frmPhieuThu_Load(object sender, EventArgs e)
        {
            Init();
            ShowKH();
                     
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
            infoPhieuThu.TongTien = result;
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
                        Add_LVHD(lvHD,tblHDXuat,FindRow(tblHDXuat,ma));
                        RemoveRow(lvThu, flag);
                    }
                }
            }
        }

        private void cmbKH_SelectedIndexChanged(object sender, EventArgs e)
        {
            int ma =int.Parse(cmbKH.SelectedValue.ToString());
            HDXuat_No(ma);
        }
        public Info.PhieuThu SetInfoPHIEUXUAT() {
            Info.PhieuThu info = new Info.PhieuThu();
            info.MaKH = int.Parse(cmbKH.SelectedValue.ToString());
            info.NgayThu = dtpNgayThu.Value;
            info.TongTien = float.Parse( txtTongTien.Text);
            info.LyDo = txtLyDo.Text;
            info.KemTheo = txtKeoTheo.Text;
            info.No= txtNo.Text;
            info.Co = txtCo.Text;
            info.GhiChu = DBNull.Value.ToString();
            return info;
        }
        public Info.CTPHIEUTHU SetInfoCTPIEUTHU(int ma,string maHD, float Tien) {
            Info.CTPHIEUTHU info = new Info.CTPHIEUTHU { };
            info.MaPhieu = ma;
            info.MaHDXuat=maHD;
            info.Tien = Tien;
            return info;
        }
        private void InsertPhieuThu() {
            if (rdKH.Checked == true)
                infoPhieuThu = SetInfoPHIEUXUAT();
            else 
                infoPhieuThu = SetInfoPHIEUXUAT_Khac();
            BLL.TPhieuThu tPhieuThu = new BLL.TPhieuThu();
            infoPhieuThu.Ma = tPhieuThu.InsertPHIEUTHU(infoPhieuThu);
        }
        private void InsertCTPhieuThu(int ma)
        {
         
            Info.CTPHIEUTHU info = new Info.CTPHIEUTHU();
            if (rdKH.Checked == true)
            {
                for (int i = 0; i < lvThu.Items.Count; i++)
                {
                    try
                    {
                        info = SetInfoCTPIEUTHU(ma, lvThu.Items[i].SubItems[1].Text, float.Parse(lvThu.Items[i].SubItems[2].Text));
                        BLL.TPhieuThu tPhieuThu = new BLL.TPhieuThu();
                         tPhieuThu.InsertCT_PHIEUTHU(info);

                    }
                    catch (Exception ex)
                    {
                        TLog.WriteErr("frmPHIEUTHU_InsertCTPhieuThu", ex.Message + "|" + ex.StackTrace);
                    }

                }
            }
            else {
                try
                {
                    info = SetInfoCTPIEUTHU(ma, DBNull.Value.ToString(), float.Parse(txtTongTien.Text));
                    BLL.TPhieuThu tPhieuThu = new BLL.TPhieuThu();
                   tPhieuThu.InsertCT_PHIEUTHU(info);
                }
                catch (Exception ex)
                {
                    TLog.WriteErr("frmPHIEUTHU_InsertCTPhieuThu", ex.Message + "|" + ex.StackTrace);
                }

            }
        }
        private void UpdateHD()
        {
            try
            {
                for (int i = 0; i < lvThu.Items.Count; i++)
                {
                    int _index = FindRow(tblHDXuat, lvThu.Items[i].SubItems[4].Text);
                    string _tienno=lvThu.Items[i].SubItems[3].Text;
                    int _tinhtrang = 1;
                    if (_tienno == "0")
                        _tinhtrang = 0;
                    tblHDXuat.Rows[_index]["TIENNO"] = _tienno;
                    tblHDXuat.Rows[_index]["TINHTRANG"] = _tinhtrang;
                }
                tblHDXuat.Update();
            }
            catch (Exception ex)
            {
                TLog.WriteErr("frmPHIEUTHU_UpdateHD", ex.Message + "|" + ex.StackTrace);
            }
        }
      
        public void ShowPhieuThu(DateTime date, int flag) {
            try
            {
                DataTable dt = tPhieuThu.GetPhieuThu_Date(date,flag);
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
                TLog.WriteErr("frmPHIEUTHU_LoadHD_No", ex.Message + "|" + ex.StackTrace);
            }

        }
        
        private void cmdThu_Click(object sender, EventArgs e)
        {
            InsertPhieuThu();
            InsertCTPhieuThu(infoPhieuThu.Ma);
            UpdateHD();
            ShowPhieuThu(dtpNgayThu.Value,0);
            ShowRPT(infoPhieuThu.Ma);
        }

       private void lvThu_DrawItem(object sender, DrawListViewItemEventArgs e)
        {
            txtTongTien.Text = TongTien().ToString();
        }
       public Info.PhieuThu SetInfoPHIEUXUAT_Khac()
       {
           Info.PhieuThu info = new Info.PhieuThu();
           info.MaKH = 0;
           info.NgayThu = dtpNgayThu.Value;
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
           ShowPhieuThu(dpkMonthThu.Value, 1);
           //
         //  LoadHD(dpkDateHD.Value);
       }

       public void ShowRPT(int ma) { 
           try
           {
          frmrptThu frm = new frmrptThu();
          frm.Show(ma,1);
              }
           catch (Exception ex)
           {
               TLog.WriteErr("frmPHIEUTHU_In", ex.Message + "|" + ex.StackTrace);
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