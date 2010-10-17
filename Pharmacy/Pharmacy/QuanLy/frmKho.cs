using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Pharmacy.QuanLy
{
    public partial class frmKho : Pharmacy.BASIC.frmChild
    {
        #region Bien


        Pharmacy.BLL.TKho tKho = new Pharmacy.BLL.TKho();

        DataTable HH = new DataTable();
        int maKho = 0;
        #endregion

        public frmKho()
        {
            InitializeComponent();
        }
        public void ShowKho()
        {
            DataTable data = tKho.GetKho(0);
            dgvKho.AutoGenerateColumns = false;
            dgvKho.DataSource = data;


        }
        public void ShowCT(int ma)
        {
            DataTable dt = tKho.GetCTKho(ma);
            dgvCTKho.AutoGenerateColumns = false;
            dgvCTKho.DataSource = dt;
        }
        private void frmKho_Load(object sender, EventArgs e)
        {
            SetTitle("THÊM KHO");
            Init();
        }
        private void Init()
        {
            ShowKho();
        }
        public bool isNewRow(DataRow dtRow)
        {
            if (dtRow.RowState == DataRowState.Added)
            { return true; } return false;
        }
        public bool isDeletedRow(DataRow dtRow)
        {
            if (dtRow.RowState == DataRowState.Deleted)
            { return true; } return false;
        }
        public bool isModifedRow(DataRow dtRow)
        {
            if (dtRow.RowState == DataRowState.Modified)
            { return true; }
            return false;
        }
        public Pharmacy.Info.KhoInfo SetInfo(DataTable tb, int i, int flag)
        { 
            Pharmacy.Info.KhoInfo info = new Pharmacy.Info.KhoInfo();
            
                if (flag == 1)//insert
                    info.Makho = 0;
                else
                    info.Makho = int.Parse(tb.Rows[i]["MAKHO"].ToString());
                info.Ten = tb.Rows[i]["TEN"].ToString();
                info.Diachi = tb.Rows[i]["DIACHI"].ToString();
                info.Dienthoai = tb.Rows[i]["DIENTHOAI"].ToString();
                info.Ngaylap = DateTime.Parse(tb.Rows[i]["NGAYLAP"].ToString());
                info.Tinhtrang = 0;
                info.Sodk = tb.Rows[i]["SODK"].ToString();
          
            return info;

        }
        public Pharmacy.Info.KhoInfo SetInfoDelete(DataTable tb, int i)
        {
            Pharmacy.Info.KhoInfo info = new Pharmacy.Info.KhoInfo();

            info.Makho = int.Parse(tb.Rows[i]["MAKHO", DataRowVersion.Original].ToString());
            info.Ten = tb.Rows[i]["TEN", DataRowVersion.Original].ToString();
            info.Diachi = tb.Rows[i]["DIACHI", DataRowVersion.Original].ToString();
            info.Dienthoai = tb.Rows[i]["DIENTHOAI", DataRowVersion.Original].ToString();
            info.Ngaylap = DateTime.Parse(tb.Rows[i]["NGAYLAP", DataRowVersion.Original].ToString());
            info.Tinhtrang = -1;
            info.Sodk = tb.Rows[i]["SODK", DataRowVersion.Original].ToString();

            return info;

        }
        private void cmdLuu_Click(object sender, EventArgs e)
        {
            try
            {

                DataTable tb = (DataTable)dgvKho.DataSource;
                if (tb != null)
                {
                    for (int i = 0; i < tb.Rows.Count; i++)
                    {
                        if (isModifedRow(tb.Rows[i]))
                        {
                            Pharmacy.Info.KhoInfo info = SetInfo(tb, i, 0);
                            tKho.UpdateKho(info);
                            //tpriceUnit.Update_priceunit1(int.Parse(tb.Rows[i]["ID"].ToString()),
                            //  float.Parse(tb.Rows[i]["Price"].ToString()), DateTime.Now);
                        }
                        if (isNewRow(tb.Rows[i]))
                        {
                            Pharmacy.Info.KhoInfo info = SetInfo(tb, i, 1);
                            tKho.InsertKho(info);

                        }
                        if (isDeletedRow(tb.Rows[i]))
                        {
                            Pharmacy.Info.KhoInfo info = SetInfoDelete(tb, i);
                            tKho.UpdateKho(info);

                        }
                    }
                }
                ShowKho();
            }
            catch (Exception ex)
            {
                TLog.WriteErr("frmKho_SetInfo", ex.Message + "|" + ex.StackTrace);

            }
        }

        private void dgvKho_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
             }

        private void cmdLuuCT_Click(object sender, EventArgs e)
        {
            DataTable tb = (DataTable)dgvCTKho.DataSource;
            if (tb != null)
            {
                for (int i = 0; i < tb.Rows.Count; i++)
                {
                    if (isModifedRow(tb.Rows[i]))
                    {
                        int maCT = int.Parse(tb.Rows[i]["MACTKHO"].ToString());
                        string ke = tb.Rows[i]["KE"].ToString();

                        tKho.UpdateCTKho(maCT, maKho, ke, 1);
                        //tpriceUnit.Update_priceunit1(int.Parse(tb.Rows[i]["ID"].ToString()),
                        //  float.Parse(tb.Rows[i]["Price"].ToString()), DateTime.Now);
                    }
                    if (isNewRow(tb.Rows[i]))
                    {
                        tKho.InsertCTKho(maKho, tb.Rows[i]["KE"].ToString());
                    }
                    if (isDeletedRow(tb.Rows[i]))
                    {
                        int maCT = int.Parse(tb.Rows[i]["MAKHO", DataRowVersion.Original].ToString());
                        string ke = tb.Rows[i]["KE", DataRowVersion.Original].ToString();

                        tKho.UpdateCTKho(maCT, maKho, ke, -1);
                    }
                }
            }
            ShowCT(maKho);
        }

        private void cmdBo_Click(object sender, EventArgs e)
        {
            ShowKho();

        }

        private void cmdBoCT_Click(object sender, EventArgs e)
        {
            ShowCT(maKho);
        }

        private void dgvKho_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvKho.CurrentRow.Cells[0].Value.ToString() == "")
                return;
            maKho = int.Parse(dgvKho.CurrentRow.Cells[0].Value.ToString());
            ShowCT(int.Parse(dgvKho.CurrentRow.Cells[0].Value.ToString()));
    
        }
    }
}
