using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Pharmacy.BaoCao.BLL
{
    class TTonKho
    {
        Pharmacy.DLL.DataAccess connect = new Pharmacy.DLL.DataAccess();
        DataTable data = new DataTable();
        DataTable dataSQL = new DataTable();
        public TTonKho()
        {
            DataColumn[] dc = new DataColumn[]{ 
                              new DataColumn("Thang", Type.GetType("System.String")),
                              new DataColumn("Nam", Type.GetType("System.String")),
                               new DataColumn("TenHH", Type.GetType("System.String")),
                               new DataColumn("QuyCach", Type.GetType("System.String")),
                               new DataColumn("DVT", Type.GetType("System.String")),

                               new DataColumn("DienGiai", Type.GetType("System.String")),
                               new DataColumn("SLTonDau", Type.GetType("System.String")),
                               new DataColumn("SLNhap", Type.GetType("System.String")),
                               new DataColumn("SLXuat", Type.GetType("System.String")),
                               new DataColumn("SLTon", Type.GetType("System.String")),
          
            };
            data.Columns.AddRange(dc);

        }
        public DataTable GetXuat(int thang, int nam)
        {
            DataTable data = connect.GetDataByStoredProcedure("sp_tonkho",
               new string[] { "@thang","@nam" },
               new object[] {thang ,nam }
                );
            return data;
        }
        public DataTable SetData(int thang, int nam)
        {
            int i = 0;
            dataSQL = GetXuat(thang,nam);
            for (i = 0; i < dataSQL.Rows.Count; i++)
            {
                DataRow r = data.NewRow();
                r["Thang"] = thang;
                r["Nam"] = thang;
                r["TenHH"]= dataSQL.Rows[i]["tenhang"];
                r["QuyCach"]= dataSQL.Rows[i]["quycach"];
                r["DVT"]= dataSQL.Rows[i]["donvitinh"];
                r["SLTonDau"] = dataSQL.Rows[i]["tondau"];
                r["DienGiai"]= dataSQL.Rows[i]["diengiai"]; 
                r["SLNhap"]= dataSQL.Rows[i]["nhap"]; 
                r["SLXuat"]= dataSQL.Rows[i]["xuat"];
                r["SLTon"]= dataSQL.Rows[i]["ton"];
                data.Rows.Add(r);
            }
            return data;
        }
    }
}
