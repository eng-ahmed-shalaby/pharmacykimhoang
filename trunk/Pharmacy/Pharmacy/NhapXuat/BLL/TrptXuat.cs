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
                                 new DataColumn("TongTien", Type.GetType("System.Double")),
        
                               new DataColumn("TienChu", Type.GetType("System.String")),
                               new DataColumn("TaiKhoan", Type.GetType("System.String"))
            };
            dt.Columns.AddRange(dc);
            int i = 0;
            int stt=0;
            double TongTien = 0;
            dataSQL = GetXuat(ma); 
       
            for (i = 0; i < dataSQL.Rows.Count; i++)
            {
                DataRow r = dt.NewRow();
                r["Date"] = FormatDayHD(dataSQL.Rows[i]["NGAYLAP"].ToString());
                r["TenKH"] = dataSQL.Rows[i]["TENKH"];
                r["DiaChi"] = dataSQL.Rows[i]["DIACHI"];
                r["HTTT"] = "TM";
                r["MaThue"] = dataSQL.Rows[i]["MST"];
                stt += 1;
                r["STT"] = stt;
                if(dataSQL.Rows[i]["DONGIA"].ToString()=="0")
                r["TenHH"] ="KM: "+ dataSQL.Rows[i]["TENHANGHOA"];
                r["TenHH"] = dataSQL.Rows[i]["TENHANGHOA"] + "(" + dataSQL.Rows[i]["SOLO"] + ";" + dataSQL.Rows[i]["NGAYHH"]+")";
                r["DVT"] = dataSQL.Rows[i]["TENDV"];
                r["SL"] = dataSQL.Rows[i]["SOLUONG"];
                r["DonGia"] = dataSQL.Rows[i]["DONGIA"];
                double TienChuaAVT = int.Parse(dataSQL.Rows[i]["SOLUONG"].ToString()) *double.Parse(dataSQL.Rows[i]["DONGIA"].ToString());
                double TienCK = TienChuaAVT * double.Parse(dataSQL.Rows[i]["ChietKhau"].ToString());
                r["ThanhTien"] = TienChuaAVT;
                TongTien += TienChuaAVT;
                r["VAT"] = dataSQL.Rows[i]["VAT"]+"%";
              //XL_DOC_SO.DOC_SO_CHUOI(double.Parse(dataSQL.Rows[i]["TONGTIEN"].ToString()), "đồng", "0", 0);
                r["TaiKhoan"] = ""; 
                r["TienTra"] = TongTien;
                r["TienVAT"] = TongTien * double.Parse(dataSQL.Rows[i]["VAT"].ToString()) / 100;
                r["TongTien"] = TongTien + TongTien * double.Parse(dataSQL.Rows[i]["VAT"].ToString()) / 100;
                r["TienChu"] = XL_DOC_SO.DOC_SO_CHUOI(double.Parse(r["TongTien"].ToString()), "đồng", "0", 0);
                dt.Rows.Add( r);
                if(double.Parse(dataSQL.Rows[i]["ChietKhau"].ToString())!=0)
                {
                    AddCKhau(dt, i, ref TongTien, ref stt);
                }
               
            }
            ////////set 10 row
            DataRow rtemp = dt.Rows[dt.Rows.Count-1];
                for (i = dt.Rows.Count-1; i < 10; i++)
                {

                    DataRow r1 = dt.NewRow();
                  
                  r1["VAT"] = rtemp["VAT"] ;
                   r1["TaiKhoan"]=   rtemp["TaiKhoan"] ;
                     r1["TienTra"]= rtemp["TienTra"];
                    r1["TienVAT"]= rtemp["TienVAT"];
                    r1["TongTien"]= rtemp["TongTien"] ;
                    r1["TienChu"] = rtemp["TienChu"];
                     dt.Rows.Add(r1);
                }
            return dt;
        }
        public void AddCKhau(DataTable dt,int i, ref double _tongtien, ref int stt) {
            double TienCK = 0;
            double TienChuaAVT = int.Parse(dataSQL.Rows[i]["SOLUONG"].ToString()) *double.Parse(dataSQL.Rows[i]["DONGIA"].ToString());
           TienCK = TienChuaAVT * double.Parse(dataSQL.Rows[i]["ChietKhau"].ToString());
            DataRow r = dt.NewRow();
            r["Date"] = FormatDayHD(dataSQL.Rows[i]["NGAYLAP"].ToString());
            r["TenKH"] = dataSQL.Rows[i]["TENKH"];
            r["DiaChi"] = dataSQL.Rows[i]["DIACHI"];
            r["HTTT"] = "TM";
            r["MaThue"] = dataSQL.Rows[i]["MST"];
            stt += 1;
            r["STT"] = stt;
            r["TenHH"] = string.Format("Chiết Khấu ({0}%)", double.Parse(dataSQL.Rows[i]["ChietKhau"].ToString()) * 100);
            r["DVT"] = "";
            r["SL"] = 0;
            r["DonGia"] = 0;
            r["ThanhTien"] = -TienCK;
            r["VAT"] = dataSQL.Rows[i]["VAT"] + "%";
            _tongtien = _tongtien - TienCK;
            r["TienTra"] = _tongtien;
            r["TienVAT"] = _tongtien * double.Parse(dataSQL.Rows[i]["VAT"].ToString()) / 100;
            r["TongTien"] = _tongtien + _tongtien * double.Parse(dataSQL.Rows[i]["VAT"].ToString()) / 100;
            r["TienChu"] = XL_DOC_SO.DOC_SO_CHUOI(double.Parse(r["TongTien"].ToString()), "đồng", "0", 0);
    
            r["TaiKhoan"] = "";
            dt.Rows.Add(r);
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
                              r["Ma"] = dataSQL.Rows[i]["SOHD"];
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
                 return "Ngày " + arr[0] + " tháng " + arr[1] + " năm " + arr[2].Substring(0,4);
             else return date;
         }
         public string FormatDayHD(string date)
         {
             string[] arr = date.Split('/');
             if (arr.Length == 3)
                 return "" + arr[0] + "             " + arr[1] + "           " + arr[2].Substring(0, 4);
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
