using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
namespace Pharmacy.BaoCao.BLL
{
    class TTonghopchi
    {
        Pharmacy.DLL.DataAccess connect = new Pharmacy.DLL.DataAccess();
        DataTable data = new DataTable();
        DataTable dataSQL = new DataTable();
        public TTonghopchi()
        {
            DataColumn[] dc = new DataColumn[]{ 
                                                             
                               new DataColumn("ngay", Type.GetType("System.DateTime")),
                               new DataColumn("soct", Type.GetType("System.String")),                              
                               new DataColumn("tenkh", Type.GetType("System.String")),
                               new DataColumn("diengiai", Type.GetType("System.String")),                              
                               new DataColumn("tongtien", Type.GetType("System.Double")),                              
                               new DataColumn("thang", Type.GetType("System.Int16")),
                                new DataColumn("nam", Type.GetType("System.Int16"))
                               
                              

            };
            data.Columns.AddRange(dc);

        }
        public DataTable Gettonghopchi(int thang,int nam)
        {
            DataTable data = connect.GetDataByStoredProcedure("sp_report_tonghopchi",
               new string[] { "@thang", "@nam" },
               new object[] { thang, nam }
                );
            return data;
        }
        
        public DataTable SetData(int thang, int nam)
        {
            int i = 0;
            dataSQL = Gettonghopchi(thang, nam);
            for (i = 0; i < dataSQL.Rows.Count; i++)
            {
                DataRow r = data.NewRow();

                r["ngay"] = dataSQL.Rows[i]["ngay"];
                if (dataSQL.Rows[i]["thu"].ToString() == "0")
                    r["soct"] = "";
                else
                r["soct"] = dataSQL.Rows[i]["thu"];                
                r["tenkh"] = dataSQL.Rows[i]["tenkh"];
                r["diengiai"] = dataSQL.Rows[i]["diengiai"];
                r["tongtien"] = dataSQL.Rows[i]["tongtien"];
                r["thang"] = thang;
                r["nam"] = nam;
                
                data.Rows.Add(r);
            }
            return data;
        }

   
    }
}
