using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Pharmacy.BaoCao.BLL
{
    class TTonghopthuchi
    {
        Pharmacy.DLL.DataAccess connect = new Pharmacy.DLL.DataAccess();
        DataTable data = new DataTable();
        DataTable dataSQL = new DataTable();
        public TTonghopthuchi()
        {
            DataColumn[] dc = new DataColumn[]{ 
                                                             
                               new DataColumn("ngay", Type.GetType("System.DateTime")),
                               new DataColumn("thu", Type.GetType("System.String")),
                               new DataColumn("chi", Type.GetType("System.String")),
                               new DataColumn("tenkh", Type.GetType("System.String")),
                               new DataColumn("diengiai", Type.GetType("System.String")),                              
                               new DataColumn("thu_ps", Type.GetType("System.Double")),
                               new DataColumn("chi_ps", Type.GetType("System.Double")),
                               new DataColumn("sodu", Type.GetType("System.Double")),
                           
                               new DataColumn("thang", Type.GetType("System.Int16")),
                                new DataColumn("nam", Type.GetType("System.Int16"))
                               
                              

            };
            data.Columns.AddRange(dc);

        }
        public DataTable Gettonghopthuchi(int thang,int nam)
        {
            DataTable data = connect.GetDataByStoredProcedure("sp_report_tonghopthuchi",
               new string[] { "@thang", "@nam" },
               new object[] { thang, nam }
                );
            return data;
        }
        
        public DataTable SetData(int thang, int nam)
        {
            int i = 0;
            dataSQL = Gettonghopthuchi(thang, nam);
            for (i = 0; i < dataSQL.Rows.Count; i++)
            {
                DataRow r = data.NewRow();

                r["ngay"] = dataSQL.Rows[i]["ngay"];
                r["thu"] = dataSQL.Rows[i]["thu"];
                r["chi"] = dataSQL.Rows[i]["chi"];
                r["tenkh"] = dataSQL.Rows[i]["tenkh"];
                r["diengiai"] = dataSQL.Rows[i]["diengiai"];
                r["thu_ps"] = dataSQL.Rows[i]["thu_ps"];
                r["chi_ps"] = dataSQL.Rows[i]["chi_ps"];
                r["sodu"] = dataSQL.Rows[i]["sodu"];
               
                r["thang"] = thang;
                r["nam"] = nam;
                
                data.Rows.Add(r);
            }
            return data;
        }

   

     
        }

}
