using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Pharmacy.BaoCao.BLL
{
    class TNhap
    {
        Pharmacy.DLL.DataAccess connect = new Pharmacy.DLL.DataAccess();
        DataTable data = new DataTable();
        DataTable dataSQL = new DataTable();
        public TNhap() {
            DataColumn[] dc = new DataColumn[]{ 
                               new DataColumn("SOHD", Type.GetType("System.String")),
                              
                               new DataColumn("NGAYLAP", Type.GetType("System.String")),
                               new DataColumn("TENHANG", Type.GetType("System.String")),
                               new DataColumn("tendvt", Type.GetType("System.String")),
                               new DataColumn("TEN", Type.GetType("System.String")),
                               new DataColumn("SOLUONG", Type.GetType("System.Int32")),
                               new DataColumn("DONGIA", Type.GetType("System.Double")),

                               new DataColumn("THANHTIEN", Type.GetType("System.Double")),
                                new DataColumn("MALO", Type.GetType("System.String")),
                               new DataColumn("Thang", Type.GetType("System.String")),
                               new DataColumn("Ngay", Type.GetType("System.String"))

            };
            data.Columns.AddRange(dc);

        }
        public DataTable GetNhap(DateTime tungay, DateTime denngay)
        {
            DataTable data = connect.GetDataByStoredProcedure("sp_report_nhapkho",
               new string[] { "@tungay", "@denngay" },
               new object[] { tungay, denngay }
                );
            return data;
        }
        public DataTable SetData(DateTime tu, DateTime den)
        {
            int i = 0;
            dataSQL = GetNhap(tu, den);
            for (i = 0; i < dataSQL.Rows.Count; i++)
            {
                DataRow r = data.NewRow();
                r["SOHD"] = dataSQL.Rows[i]["SOHD"];
                r["MALO"] = dataSQL.Rows[i]["MALO"];
                r["NGAYLAP"] = dataSQL.Rows[i]["NGAYLAP"];
                r["TENHANG"] = dataSQL.Rows[i]["TENHANGHOA"];
                r["tendvt"] = dataSQL.Rows[i]["tendvt"];
                r["TEN"] = dataSQL.Rows[i]["TEN"];
                r["SOLUONG"] = dataSQL.Rows[i]["SOLUONG"];
                r["DONGIA"] = dataSQL.Rows[i]["DONGIANHAP"];
                r["THANHTIEN"] = dataSQL.Rows[i]["TIENCOVAT"];
                r["Thang"] =String.Format("{0:dd/MM/yyyy}", tu);
                r["Ngay"] =String.Format("{0:dd/MM/yyyy}", den);
                data.Rows.Add(r);
            }
            return data;
        }
    }
}
