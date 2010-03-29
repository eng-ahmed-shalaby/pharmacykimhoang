using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Pharmacy.BaoCao.BLL
{
    class TDoanhthuBH
    {
        Pharmacy.DLL.DataAccess connect = new Pharmacy.DLL.DataAccess();
        DataTable data = new DataTable();
        DataTable dataSQL = new DataTable();
        public TDoanhthuBH()
        {
            DataColumn[] dc = new DataColumn[]{ 
                               new DataColumn("soct", Type.GetType("System.String")),                              
                               new DataColumn("ngay", Type.GetType("System.String")),
                               new DataColumn("tenkh", Type.GetType("System.String")),
                               new DataColumn("tdv", Type.GetType("System.String")),
                               new DataColumn("sotien", Type.GetType("System.Double")),
                               new DataColumn("ghichu", Type.GetType("System.String")),
                               new DataColumn("tungay", Type.GetType("System.DateTime")),
                               new DataColumn("denngay", Type.GetType("System.DateTime"))
                               
                              

            };
            data.Columns.AddRange(dc);

        }
        public DataTable GetDoanhthuBH(DateTime from, DateTime to)
        {
            DataTable data = connect.GetDataByStoredProcedure("sp_report_DoanhthuBH",
               new string[] {"@tungay", "@denngay" },
               new object[] { from, to }
                );
            return data;
        }
        public DataTable SetData(DateTime from, DateTime to)
        {
            int i = 0;
            dataSQL = GetDoanhthuBH(from, to);
            for (i = 0; i < dataSQL.Rows.Count; i++)
            {
                DataRow r = data.NewRow();
                r["soct"] = dataSQL.Rows[i]["soct"];
                r["ngay"] = dataSQL.Rows[i]["ngay"];
                r["tenkh"] = dataSQL.Rows[i]["tenkh"];
                r["tdv"] = dataSQL.Rows[i]["tdv"];
                r["sotien"] = dataSQL.Rows[i]["sotien"];
                r["ghichu"] = dataSQL.Rows[i]["ghichu"];
                r["tungay"] = from;
                r["denngay"] = to;
                data.Rows.Add(r);
            }
            return data;
        }

    }
}
