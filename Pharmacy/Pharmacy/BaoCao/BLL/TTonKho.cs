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
                              new DataColumn("TenHang", Type.GetType("System.String")),
                              new DataColumn("DVT", Type.GetType("System.String")),
                              new DataColumn("TonDau", Type.GetType("System.Int32")),
                              new DataColumn("PhatSinhNhap", Type.GetType("System.Int32")),
                                new DataColumn("PhatSinhXuat", Type.GetType("System.Int32")),
                              new DataColumn("Ton", Type.GetType("System.Int32")),
                              new DataColumn("Kho", Type.GetType("System.String"))
          
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
                r["Nam"] = nam;
                r["TenHang"]= dataSQL.Rows[i]["tenhang"];
                r["DVT"]= dataSQL.Rows[i]["donvitinh"];
                r["TonDau"] = dataSQL.Rows[i]["tondau"];
                r["PhatSinhNhap"]= dataSQL.Rows[i]["nhap"];
                r["PhatSinhXuat"] = dataSQL.Rows[i]["xuat"]; 
                r["Ton"]= dataSQL.Rows[i]["ton"];
                r["Kho"]= "";
                data.Rows.Add(r);
            }
            return data;
        }
    }
}
