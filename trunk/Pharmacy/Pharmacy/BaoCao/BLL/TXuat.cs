using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Pharmacy.BaoCao.BLL
{
    class TXuat
    {
        Pharmacy.DLL.DataAccess connect = new Pharmacy.DLL.DataAccess();
        DataTable data = new DataTable();
        DataTable dataSQL = new DataTable();
        public TXuat() {
            DataColumn[] dc = new DataColumn[]{ 
                               new DataColumn("SOHD", Type.GetType("System.String")),
                              
                               new DataColumn("NGAYLAP", Type.GetType("System.String")),
                               new DataColumn("TenHang", Type.GetType("System.String")),
                               new DataColumn("tendvt", Type.GetType("System.String")),
                               new DataColumn("KH", Type.GetType("System.String")),
                               new DataColumn("SOLUONG", Type.GetType("System.Int32")),
                               new DataColumn("DONGIA", Type.GetType("System.Double")),

                               new DataColumn("THANHTIEN", Type.GetType("System.Double")),
                                new DataColumn("MALO", Type.GetType("System.String")),
                               new DataColumn("Thang", Type.GetType("System.String")),
                               new DataColumn("Ngay", Type.GetType("System.String"))

            };
            data.Columns.AddRange(dc);
        }
        public DataTable GetXuat(DateTime tu, DateTime den)
        {
            DataTable data = connect.GetDataByStoredProcedure("sp_report_xuatkho",
               new string[] { "@tungay", "@denngay" },
               new object[] { tu, den }
                );
            return data;
        }
        public DataTable SetData(DateTime tu, DateTime den)
        {
            int i = 0;
            dataSQL = GetXuat(tu, den);
            for (i = 0; i < dataSQL.Rows.Count; i++)
            {

                DataRow r = data.NewRow();
                r["SOHD"] = dataSQL.Rows[i]["SOHD"];
                r["MALO"] = dataSQL.Rows[i]["MALO"];
                r["NGAYLAP"] = dataSQL.Rows[i]["NGAYLAP"];
                r["TenHang"] = dataSQL.Rows[i]["TENHANG"];
                r["tendvt"] = dataSQL.Rows[i]["tendvt"];
                r["KH"] = dataSQL.Rows[i]["tenkh"];
                r["SOLUONG"] = dataSQL.Rows[i]["SOLUONG"];
                r["DONGIA"] = dataSQL.Rows[i]["DONGIA"];
                 r["THANHTIEN"] = dataSQL.Rows[i]["TIENCOVAT"];
                r["Thang"] = String.Format("{0:dd/MM/yyyy}", tu);
                r["Ngay"] =String.Format("{0:dd/MM/yyyy}", den);
                data.Rows.Add(r);
            }
            return data;
        }
    }
}
