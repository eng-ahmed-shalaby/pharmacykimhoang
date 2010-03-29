using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Pharmacy.BaoCao.BLL
{
    class TKhachHang
    {
        Pharmacy.DLL.DataAccess connect = new Pharmacy.DLL.DataAccess();
        DataTable data = new DataTable();
        DataTable dataSQL = new DataTable();
        public TKhachHang()
        {
            DataColumn[] dc = new DataColumn[]{ 
                               new DataColumn("mahh", Type.GetType("System.String")),                              
                               new DataColumn("tenhh", Type.GetType("System.String")),
                               new DataColumn("dvt", Type.GetType("System.String")),
                               new DataColumn("soluong", Type.GetType("System.Int16")),
                               new DataColumn("doanhthu", Type.GetType("System.Double")),
                               new DataColumn("thue", Type.GetType("System.Double")),
                               new DataColumn("thanhtien", Type.GetType("System.Double")),
                                new DataColumn("makh", Type.GetType("System.String")),
                                 new DataColumn("tentdv", Type.GetType("System.String")),
                               new DataColumn("tungay", Type.GetType("System.DateTime")),
                               new DataColumn("denngay", Type.GetType("System.DateTime"))

            };
            data.Columns.AddRange(dc);

        }
        public DataTable GetDoanhthuKH(DateTime from, DateTime to)
        {
            DataTable data = connect.GetDataByStoredProcedure("sp_report_DoanhthuKH",
               new string[] { "@tungay", "@denngay" },
               new object[] { from, to }
                );
            return data;
        }
        public DataTable SetData(DateTime from, DateTime to)
        {
            int i = 0;
            dataSQL = GetDoanhthuKH(from, to);
            for (i = 0; i < dataSQL.Rows.Count; i++)
            {
                DataRow r = data.NewRow();
                r["mahh"] = dataSQL.Rows[i]["mahh"];
                r["tenhh"] = dataSQL.Rows[i]["tenhh"];
                r["dvt"] = dataSQL.Rows[i]["dvt"];
                //r["tdv"] = dataSQL.Rows[i]["tdv"];
                r["soluong"] = dataSQL.Rows[i]["soluong"];
                r["doanhthu"] = dataSQL.Rows[i]["doanhthu"];
                r["thue"] = dataSQL.Rows[i]["thue"];
                r["thanhtien"] = dataSQL.Rows[i]["thanhtien"];
                r["makh"] = dataSQL.Rows[i]["makh"];
                //r["tentdv"] = dataSQL.Rows[i]["tentdv"];
                r["tungay"] = from;
                r["denngay"] = to;
                data.Rows.Add(r);
            }
            return data;
        }
    }
}
