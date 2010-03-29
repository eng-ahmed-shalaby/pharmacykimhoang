using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Pharmacy.BaoCao.BLL
{
    class TTheodoicongno
    {
         Pharmacy.DLL.DataAccess connect = new Pharmacy.DLL.DataAccess();
        DataTable data = new DataTable();
        DataTable dataSQL = new DataTable();
        public TTheodoicongno()
        {
            DataColumn[] dc = new DataColumn[]{ 
                                                             
                               new DataColumn("ngay", Type.GetType("System.DateTime")),
                               new DataColumn("soct", Type.GetType("System.String")),
                               new DataColumn("diengiai", Type.GetType("System.String")),                              
                               new DataColumn("thu_ps", Type.GetType("System.Double")),
                               new DataColumn("chi_ps", Type.GetType("System.Double")),
                               new DataColumn("thu_sd", Type.GetType("System.Double")),
                               new DataColumn("chi_sd", Type.GetType("System.Double")),
                               new DataColumn("kh", Type.GetType("System.String")),
                               new DataColumn("tungay", Type.GetType("System.DateTime")),
                               new DataColumn("denngay", Type.GetType("System.DateTime")),
                               new DataColumn("tongtien", Type.GetType("System.Double"))
                               
                              

            };
            data.Columns.AddRange(dc);

        }
        public DataTable Getcongno(DateTime from, DateTime to)
        {
            DataTable data = connect.GetDataByStoredProcedure("sp_report_theodoicongno",
               new string[] {"@tungay", "@denngay" },
               new object[] { from, to }
                );
            return data;
        }
        public DataTable Getcongno_NCC(DateTime from, DateTime to)
        {
            DataTable data = connect.GetDataByStoredProcedure("sp_report_theodoicongno_NCC",
               new string[] { "@tungay", "@denngay" },
               new object[] { from, to }
                );
            return data;
        }
        public DataTable SetData(DateTime from, DateTime to)
        {
            int i = 0;
            dataSQL = Getcongno(from, to);
            for (i = 0; i < dataSQL.Rows.Count; i++)
            {
                DataRow r = data.NewRow();
                
                r["ngay"] = dataSQL.Rows[i]["ngay"];
                r["soct"] = dataSQL.Rows[i]["soct"];
                r["diengiai"] = dataSQL.Rows[i]["diengiai"];
                r["thu_ps"] = dataSQL.Rows[i]["thu_ps"];
                r["chi_ps"] = dataSQL.Rows[i]["chi_ps"];
                r["thu_sd"] = dataSQL.Rows[i]["thu_sd"];
                r["chi_sd"] = dataSQL.Rows[i]["chi_sd"];
                r["kh"] = dataSQL.Rows[i]["kh"];
                r["tungay"] = from;
                r["denngay"] = to;
                r["tongtien"] = dataSQL.Rows[i]["tongtien"];
                data.Rows.Add(r);
            }
            return data;
        }

        public DataTable SetData_NCC(DateTime from, DateTime to)
        {
            int i = 0;
            dataSQL = Getcongno_NCC(from, to);
            for (i = 0; i < dataSQL.Rows.Count; i++)
            {
                DataRow r = data.NewRow();

                r["ngay"] = dataSQL.Rows[i]["ngay"];
                r["soct"] = dataSQL.Rows[i]["soct"];
                r["diengiai"] = dataSQL.Rows[i]["diengiai"];
                r["thu_ps"] = dataSQL.Rows[i]["thu_ps"];
                r["chi_ps"] = dataSQL.Rows[i]["chi_ps"];
                r["thu_sd"] = dataSQL.Rows[i]["thu_sd"];
                r["chi_sd"] = dataSQL.Rows[i]["chi_sd"];
                r["kh"] = dataSQL.Rows[i]["kh"];
                r["tungay"] = from;
                r["denngay"] = to;
                r["tongtien"] = dataSQL.Rows[i]["tongtien"];
                data.Rows.Add(r);
            }
            return data;
        }

    }
}
