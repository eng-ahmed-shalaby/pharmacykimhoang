using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DICHSO;
namespace Pharmacy.NhapXuat.BLL
{
    class TrptXuat
    {
         DataTable dataSQL = new DataTable();
         DataTable data = new DataTable();
         Pharmacy.DLL.DataAccess connect = new Pharmacy.DLL.DataAccess();
         public TrptXuat()
        {
            DataColumn[] dc = new DataColumn[]{ 
                               new DataColumn("Ma", Type.GetType("System.String")),
                               new DataColumn("NgayLap", Type.GetType("System.String")),
                               new DataColumn("KH", Type.GetType("System.String")),
                               new DataColumn("DiaChi", Type.GetType("System.String")),
                               new DataColumn("LyDo", Type.GetType("System.String")),
                               new DataColumn("kho", Type.GetType("System.String")),
                               new DataColumn("No", Type.GetType("System.String")),
                               new DataColumn("Co", Type.GetType("System.String")),
                               new DataColumn("STT", Type.GetType("System.String")),
                               new DataColumn("TenHH", Type.GetType("System.String")),
                               new DataColumn("SoLo", Type.GetType("System.String")),
                               new DataColumn("NgayHH", Type.GetType("System.String")),
                               new DataColumn("DVT", Type.GetType("System.String")),
                               new DataColumn("SL", Type.GetType("System.String")),
                               new DataColumn("DonGia", Type.GetType("System.Double")),
                               new DataColumn("Tien", Type.GetType("System.Double")),
                               new DataColumn("CK", Type.GetType("System.String")),
                               new DataColumn("TongTien", Type.GetType("System.Double")),
                               new DataColumn("Chu", Type.GetType("System.String"))
                             

            };
            data.Columns.AddRange(dc);
        }

        public DataTable GetDataHD( int ma){
            DataTable dt = new DataTable();
            DataColumn[] dc = new DataColumn[]{ 
                               new DataColumn("Date", Type.GetType("System.String")),
                               new DataColumn("TenKH", Type.GetType("System.String")),
                               new DataColumn("DiaChi", Type.GetType("System.String")),
                               new DataColumn("HTTT", Type.GetType("System.String")),
                               new DataColumn("MaThue", Type.GetType("System.String")),
                              new DataColumn("STT", Type.GetType("System.String")),
                               new DataColumn("TenHH", Type.GetType("System.String")),
                               new DataColumn("DVT", Type.GetType("System.String")),
                               new DataColumn("SL", Type.GetType("System.String")),
                               new DataColumn("DonGia", Type.GetType("System.Double")),
                               new DataColumn("ThanhTien", Type.GetType("System.Double")),
                               new DataColumn("VAT", Type.GetType("System.String")),
                              new DataColumn("TienVAT", Type.GetType("System.Double")),
                            
                               new DataColumn("TienTra", Type.GetType("System.Double")),
                               new DataColumn("Chu", Type.GetType("System.String")),
                               new DataColumn("TaiKhoan", Type.GetType("System.String"))
            };
            dt.Columns.AddRange(dc);
            int i = 0;
            dataSQL = GetXuat(ma);
            for (i = 0; i < dataSQL.Rows.Count; i++)
            {
                DataRow r = dt.NewRow();

                r["Date"] = FormatDayHD(dataSQL.Rows[i]["NGAYLAP"].ToString());
                r["TenKH"] = dataSQL.Rows[i]["TENKH"];
                r["DiaChi"] = dataSQL.Rows[i]["DIACHI"];
                r["HTTT"] = "TM";
                r["MaThue"] = dataSQL.Rows[i]["MST"];
                r["STT"] = i + 1;
                r["TenHH"] = dataSQL.Rows[i]["TENHANGHOA"];

                r["DVT"] = dataSQL.Rows[i]["TENDV"];
                r["SL"] = dataSQL.Rows[i]["SOLUONG"];
                r["DonGia"] = dataSQL.Rows[i]["DONGIA"];
                
                r["ThanhTien"] = dataSQL.Rows[i]["TIENCOVAT"];
                r["VAT"] = "";
                r["TienVAT"] =0;
                r["TienTra"] = dataSQL.Rows[i]["TONGTIEN"];

                r["Chu"] = XL_DOC_SO.DOC_SO_CHUOI(double.Parse(dataSQL.Rows[i]["TONGTIEN"].ToString()), "đồng", "0", 0);
                r["TaiKhoan"] = "";
                dt.Rows.Add(r);
            }

            return dt;
        }
         public DataTable GetXuat(int ma)
         {
             DataTable data = connect.GetDataByStoredProcedure("usp_rptHD_XUAT",
                new string[] { "@MA"},
                new object[] {ma }
                 );
             return data;
         }

         public DataTable SetData(int ma)
         {
             int i = 0;
             dataSQL = GetXuat(ma);
             for (i = 0; i < dataSQL.Rows.Count; i++)
             {       
                 DataRow r = data.NewRow();
                              r["Ma"] = dataSQL.Rows[i]["MA"];
                              r["NgayLap"] =FormatDay(dataSQL.Rows[i]["NGAYLAP"].ToString());
                              r["KH"] = dataSQL.Rows[i]["TENKH"]; 
                              r["DiaChi"] = dataSQL.Rows[i]["DIACHI"];
                              r["LyDo"] = dataSQL.Rows[i]["LYDO"]; 
                              r["kho"] = dataSQL.Rows[i]["TEN"];
                              r["No"] = dataSQL.Rows[i]["NO"];
                              r["Co"] = dataSQL.Rows[i]["CO"]; 
                              r["STT"] = i+1;
                              r["TenHH"] = dataSQL.Rows[i]["TENHANGHOA"];
                              r["SoLo"] = dataSQL.Rows[i]["SOLO"]; 
                               r["NgayHH"] = dataSQL.Rows[i]["NGAYHH"];
                               r["DVT"] = dataSQL.Rows[i]["TENDV"]; 
                               r["SL"] = dataSQL.Rows[i]["SOLUONG"]; 
                               r["DonGia"] = dataSQL.Rows[i]["DONGIA"];
                               r["Tien"] = dataSQL.Rows[i]["TIENCOVAT"];
                               r["CK"] = dataSQL.Rows[i]["ChietKhau"]; 
                               r["TongTien"] = dataSQL.Rows[i]["TONGTIEN"];
                               r["Chu"] = XL_DOC_SO.DOC_SO_CHUOI(double.Parse(dataSQL.Rows[i]["TONGTIEN"].ToString()), "đồng", "0", 0);  
                 data.Rows.Add(r);
             }
             return data;
         }
         public string FormatDay(string date) {
             string[] arr = date.Split('/');
             if (arr.Length == 3)
                 return "Ngày " + arr[1] + " tháng " + arr[0] + " năm " + arr[2].Substring(0,4);
             else return date;
         }
         public string FormatDayHD(string date)
         {
             string[] arr = date.Split('/');
             if (arr.Length == 3)
                 return "" + arr[1] + "       " + arr[0] + "     " + arr[2].Substring(0, 4);
             else return date;
         }
         public string FormatMST(string mst)
         {
             string result = "";
             for (int i = 0; i < mst.Length; i++)
             {
                 result += mst.Substring(i, 1) + "  ";
             }
             return result;
         }
    }
}
