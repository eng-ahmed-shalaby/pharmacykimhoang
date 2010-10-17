using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Pharmacy.MyTable;
using PrintControl;

using BrightIdeasSoftware;
namespace Pharmacy.ThuChi
{
    public partial class frmCongNo : BASIC.frmChild
    {
        private static TblHD_Xuat tblHDXuat;
        Pharmacy.BLL.TKhachHang tKH = new Pharmacy.BLL.TKhachHang();
        private ThuChi.BLL.TPhieuThu tPhieuThu = new ThuChi.BLL.TPhieuThu();
        public frmCongNo()
        {
            InitializeComponent();
        }
        public void Refesh()
        {
            lvHD.Items.Clear();
            txtDiaChi.Text = "";
            txtDT.Text = "";
            cmbKH.Text = "";
            txtMaKH.Text = "";
        }
        public void HDXuat_No(int maKH)
        {
            try
            {
                tblHDXuat = tPhieuThu.GetHD_CongNo(maKH);
                DataTable dt = tKH.GetKhachHangID(maKH);
                txtDiaChi.Text = dt.Rows[0]["DIACHI"].ToString();
                txtDT.Text = dt.Rows[0]["DIENTHOAI"].ToString();
                txtMaKH.Text = dt.Rows[0]["CODEKH"].ToString();
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
                TLog.WriteErr("frmCongNo_LoadHD_No", ex.Message + "|" + ex.StackTrace);
            }
        }
        public void ShowKH()
        {
          
            DataTable dt = tKH.GetKhachHang();
            cmbKH.DisplayMember = "TEN";
            cmbKH.ValueMember = "MAKH";
            cmbKH.DataSource = dt;
            LoadAutoKH(dt);
        }
        public void LoadAutoKH(DataTable dt)
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
        public void Init()
        {
            SetTitle("NHẮC NHỞ CÔNG NỢ");
            ShowKH();
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
            item.SubItems.Add(dt.Rows[i]["SoNgayNo"].ToString().Trim());

            item.SubItems.Add(dt.Rows[i]["MA"].ToString().Trim());
            item.SubItems.Add(dt.Rows[i]["HanTra"].ToString().Trim());
                  item.SubItems.Add(dt.Rows[i]["SoNgayCL"].ToString().Trim());
        }

        private void frmCongNo_Load(object sender, EventArgs e)
        {
            Init();
        }

        private void cmbKH_SelectedIndexChanged(object sender, EventArgs e)
        {
            int ma = int.Parse(cmbKH.SelectedValue.ToString());
            HDXuat_No(ma);
        }

        private void rdTenKH_CheckedChanged(object sender, EventArgs e)
        {
            cmbKH.Enabled = true;
            txtMaKH.Enabled = false;
            Refesh();
        }

        private void rdMaKH_CheckedChanged(object sender, EventArgs e)
        {
            txtMaKH.Enabled = true;
            cmbKH.Enabled = false;
            Refesh();
        }
        private bool CheckForm(int type) {
            if (type == 0)
                if (cmbKH.Text == "")
                    return false;
            if (type == 1)
                if (txtMaKH.Text == "")
                    return false;
            return true;

        }

        private void cmdTim_Click(object sender, EventArgs e)
        {
            try
            {
                if (rdMaKH.Checked == true)
                {
                    if (CheckForm(1))
                    {
                        DataTable dt = tKH.GetKhachHang(txtMaKH.Text);

                        cmbKH.Text = dt.Rows[0]["TEN"].ToString();

                        int ma = int.Parse(dt.Rows[0]["MAKH"].ToString());
                        HDXuat_No(ma);
                    }

                }
                else
                {
                    cmbKH_SelectedIndexChanged(null, null);
                }
            }
            catch (Exception ex)
            {
                TLog.WriteErr("frmCongNo_Tim", ex.Message + "|" + ex.StackTrace);
            }
        }
      
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            ColumnHeaderStyle c = new ColumnHeaderStyle();
            lvHD.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            ControlPrint ctrP = new ControlPrint(lvHD, true);
            ctrP.PrintWidth = ctrP.CalculateSize().Width;
            ctrP.PrintHeight = ctrP.CalculateSize().Height;
            e.Graphics.DrawString("NHẮC NHỞ CÔNG NỢ KHÁCH HÀNG", new Font("Tahoma", 16), Brushes.Black, new PointF(40, 40));
            e.Graphics.DrawImageUnscaled(ctrP.GetBitmap(), new Point(100, 100));
            e.Graphics.DrawString("STT", new Font("Arial", 11), Brushes.Black, new PointF(100, 100));
            e.Graphics.DrawString("Mã HD", new Font("Arial", 11), Brushes.Black, new PointF(160, 100));
            //e.Graphics.DrawString("Mô tả", new Font("Arial", 11), Brushes.Black, new PointF(500, 100));
        }

        private void cmdin_Click_1(object sender, EventArgs e)
        {
          //  printDocument1.Print();
            ListViewPrinter pr = new ListViewPrinter("BÁO CÁO CÔNG NỢ");
            pr.ListView = lvHD;
            pr.PrintPreview();
          
        }
    }
}
