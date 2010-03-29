using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DICHSO;

namespace Pharmacy.ThuChi.BLL
{
    class TrptThu
    {
         Pharmacy.DLL.DataAccess connect = new Pharmacy.DLL.DataAccess();
        DataTable data = new DataTable();
        DataSet dataSQL = new DataSet();
        public TrptThu() {
            DataColumn[] dc = new DataColumn[]{ 
                               new DataColumn("TenKH", Type.GetType("System.String")),
                               new DataColumn("DiaChi", Type.GetType("System.String")),
                               new DataColumn("LyDo", Type.GetType("System.String")),
                               new DataColumn("SoTien", Type.GetType("System.Double")),
                               new DataColumn("TienChu", Type.GetType("System.String")),
                               new DataColumn("NgayThu", Type.GetType("System.String")),
                               new DataColumn("KemTheo", Type.GetType("System.String")),
                               new DataColumn("MaHD", Type.GetType("System.String")),
                               new DataColumn("No", Type.GetType("System.String")),
                               new DataColumn("Co", Type.GetType("System.String")),
        
            };
            data.Columns.AddRange(dc);

        }
        public DataSet GetNhap(int ma)
        {
            DataSet data = connect.GetDataSetByStoredProcedure("usp_rptPHIEUTHU",
               new string[] { "@Ma" },
               new object[] { ma }
                );
            return data;
        }
        public DataTable SetData(int ma)
        {
            int i = 0;
            dataSQL = GetNhap(ma);
                DataRow r = data.NewRow();
                if (dataSQL.Tables[1].Rows[i]["MaKH"].ToString() == "0")
                {
                    string[] str = dataSQL.Tables[1].Rows[i]["GhiChu"].ToString().Split('_');
                    if(str.Length>1)
                    r["TenKH"] = str[0];
                    r["DiaChi"] = str[1];
                }
                else
                {
                    r["TenKH"] = dataSQL.Tables[1].Rows[i]["Ten"].ToString();

                    r["DiaChi"] = dataSQL.Tables[1].Rows[i]["DiaChi"].ToString();
                }
                r["LyDo"]=dataSQL.Tables[1].Rows[i]["LyDo"];
                r["SoTien"]=dataSQL.Tables[1].Rows[i]["TongTien"];
                r["TienChu"] = XL_DOC_SO.DOC_SO_CHUOI(double.Parse(dataSQL.Tables[1].Rows[i]["TongTien"].ToString()), "đồng", "0", 0);
                r["KemTheo"] = dataSQL.Tables[1].Rows[i]["KemTheo"];
                r["NgayThu"] = GetDateFormat(dataSQL.Tables[1].Rows[i]["NgayThu"].ToString());
                r["MaHD"] = dataSQL.Tables[0].Rows[i]["maHD"];
                r["No"]=dataSQL.Tables[1].Rows[i]["No"];
                r["Co"]=dataSQL.Tables[1].Rows[i]["Co"];
                data.Rows.Add(r);
            return data;
        }
        public string GetDateFormat(string date){
             string[] arr = date.Split('/');
             if (arr.Length == 3)
             {
              string str = string.Format("Ngày {0} tháng {1} năm {2}", arr[1], arr[0], arr[2].Substring(0, 4));
              return str;
            }
         else return date;
        }

    }
}
