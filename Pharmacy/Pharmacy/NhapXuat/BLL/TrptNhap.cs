using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DICHSO;
namespace Pharmacy.NhapXuat.BLL
{
    class TrptNhap
    {
         DataTable dataSQL = new DataTable();
         DataTable data = new DataTable();
         Pharmacy.DLL.DataAccess connect = new Pharmacy.DLL.DataAccess();
         public TrptNhap()
        {
            DataColumn[] dc = new DataColumn[]{ 
                               new DataColumn("Ma", Type.GetType("System.String")),
                               new DataColumn("NgayNhap", Type.GetType("System.String")),
                               new DataColumn("NCC", Type.GetType("System.String")),
                               new DataColumn("SoHD", Type.GetType("System.String")),
                               new DataColumn("NgayLap", Type.GetType("System.String")),
                               new DataColumn("NhomNCC", Type.GetType("System.String")),
                               new DataColumn("TenKho", Type.GetType("System.String")),
                               new DataColumn("NgoaiTe", Type.GetType("System.String")),
                               new DataColumn("TyGia", Type.GetType("System.String")),
                               new DataColumn("No", Type.GetType("System.String")),
                               new DataColumn("Co", Type.GetType("System.String")),
                                new DataColumn("Stt", Type.GetType("System.String")),
                                new DataColumn("TenHH", Type.GetType("System.String")),
                                new DataColumn("SoLo", Type.GetType("System.String")),
                                new DataColumn("NgayHH", Type.GetType("System.String")),
                                new DataColumn("DVT", Type.GetType("System.String")),
                                new DataColumn("SL", Type.GetType("System.String")),
                                new DataColumn("DonGia", Type.GetType("System.Double")),
                                new DataColumn("VAT", Type.GetType("System.String")),
                                new DataColumn("Tien", Type.GetType("System.Double")),
                                new DataColumn("CK", Type.GetType("System.String")),
                                new DataColumn("TongTien", Type.GetType("System.Double")),
                                 new DataColumn("ThanhToan", Type.GetType("System.String")),
                                   new DataColumn("Chu", Type.GetType("System.String"))

            };
            data.Columns.AddRange(dc);
        }

         public DataTable GetNhap(int ma)
         {
             DataTable data = connect.GetDataByStoredProcedure("usp_rptHD_NHAP",
                new string[] { "@MA"},
                new object[] {ma }
                 );
             return data;
         }

         public DataTable SetData(int ma)
         {
             int i = 0;
             dataSQL = GetNhap(ma);
             for (i = 0; i < dataSQL.Rows.Count; i++)
             {
                 DataRow r = data.NewRow();
                               r["Ma"]=dataSQL.Rows[i]["MA"];
                               r["NgayNhap"]=FormatDay(dataSQL.Rows[i]["NGAYNHAP"].ToString()); 
                               r["NCC"]=dataSQL.Rows[i]["TEN"];
                               r["SoHD"]=dataSQL.Rows[i]["SOHD"];
                               r["NgayLap"] = FormatDay(dataSQL.Rows[i]["NGAYLAP"].ToString());
                               r["NhomNCC"]=dataSQL.Rows[i]["TENNHOM"]; 
                               r["TenKho"]=dataSQL.Rows[i]["TenKho"];
                               r["NgoaiTe"]=dataSQL.Rows[i]["MALOAINT"];
                               r["TyGia"]=dataSQL.Rows[i]["TYGIA"];
                               r["No"] = dataSQL.Rows[i]["NO"];
                               r["Co"] = dataSQL.Rows[i]["CO"];
                               
                                r["Stt"]=i+1;
                                r["TenHH"]=dataSQL.Rows[i]["TENHANGHOA"];
                                r["SoLo"]=dataSQL.Rows[i]["MALO"]; 
                                r["NgayHH"]=dataSQL.Rows[i]["NGAYHH"];
                                r["DVT"]=dataSQL.Rows[i]["TenDV"]; 
                                r["SL"]=dataSQL.Rows[i]["SOLUONG"]; 
                                r["DonGia"]=dataSQL.Rows[i]["DONGIANHAP"];
                                r["VAT"]=dataSQL.Rows[i]["VAT"] +"%"; 
                                r["Tien"]=dataSQL.Rows[i]["TIENCOVAT"];
                                r["CK"]=dataSQL.Rows[i]["CHIETKHAU"];
                                r["TongTien"]=dataSQL.Rows[i]["TONGTIEN"];

                                r["ThanhToan"]="";
                                r["Chu"] = XL_DOC_SO.DOC_SO_CHUOI(double.Parse(dataSQL.Rows[i]["TONGTIEN"].ToString()),"đồng","",0);
                 data.Rows.Add(r);
             }
             return data;
         }
         public string FormatDay(string date) {
             string[] arr = date.Split('/');
             if (arr.Length == 3)
                 return "Ngày " + arr[1] + " tháng " + arr[0] + " năm " + arr[2];
             else return date;
         }
    }
}
