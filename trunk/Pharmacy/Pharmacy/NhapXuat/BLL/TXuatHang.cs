using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Pharmacy.NhapXuat.BLL
{
    class TXuatHang
    {

        DLL.DataAccess cn = new DLL.DataAccess();
         public DataTable GetLO(int maHH, int tinhTrang)
        {
            try
            {
                DataTable data = new DataTable();
                data = cn.GetDataByStoredProcedure("usp_SelectCT_HDNHAPbyMaHH",
                new string[] { 	"@MAHH","@TINHTRANG"},
                    new object[] { maHH,tinhTrang });
                return data;
            }
            catch (Exception ex) { return null; }
        }
         public DataTable GetHangKM(int maHH)
         {
             try
             {
                 DataTable data = new DataTable();
                 data = cn.GetDataByStoredProcedure("usp_SelectKhuyenMai_HH",
                 new string[] { "@MaHH",  },
                     new object[] { maHH});
                 return data;
             }
             catch (Exception ex) { throw ex; }
         }
         public DataTable GetHD(string maHD)
         {
             try
             {
                 DataTable data = new DataTable();
                 data = cn.GetDataByStoredProcedure("usp_SelectHD_XUAT",
                 new string[] { "@MA" },
                     new object[] { maHD });
                 return data;
             }
             catch (Exception ex) { return null; }
         }
         public DataTable GetHD(DateTime date)
         {
             try
             {
                 DataTable data = new DataTable();
                 data = cn.GetDataByStoredProcedure("usp_SelectHD_XUATbyDate",
                 new string[] { "@Date" },
                     new object[] { date });
                 return data;
             }
             catch (Exception ex) { return null; }
         }
         public DataTable GetTDV(int _tinhtrang)
         {
             try
             {
                 DataTable data = new DataTable();
                 data = cn.GetDataByStoredProcedure("usp_SelectTRINHDUOCVIEN_TT",
                 new string[] { "@TINHTRANG" },
                     new object[] { _tinhtrang });
                 return data;
             }
             catch (Exception ex) { return null; }
         }

         public DataTable GetCTHD(int maHD)
         {
             try
             {
                 DataTable data = new DataTable();
                 data = cn.GetDataByStoredProcedure("usp_SelectCT_HDXUAT",
                 new string[] { "@MAHDXUAT" },
                     new object[] { maHD });
                 return data;
             }
             catch (Exception ex)
             {
                 //ghi log
                 return null;
             }
         }

         public void DeleteCTHD(string ma)
         {
             try
             {
                 cn.ExecuteNonQuery("usp_DeleteCT_HDXUAT",
                    new string[] { "@MA" },
                   new object[] { int.Parse(ma) });

             }
             catch (Exception ex)
             {

             }
         }
         public void DeleteHD(string ma)
         {
             try
             {
                 cn.ExecuteNonQuery("usp_DeleteHD_XUAT",
                    new string[] { "@MA" },
                   new object[] { int.Parse(ma) });

             }
             catch (Exception ex)
             {

             }
         }
         public void UpdateTongtienHD(int maHD, double Tong, int Type)
         {
             try
             {
                 cn.ExecuteNonQuery("usp_UpdateTongTienHD_XUAT",
                    new string[] { "@MA", "@TONGTIEN","@TIENNO","@Type" },
                   new object[] { maHD, Tong,Tong,Type });

             }
             catch (Exception ex)
             {
                 throw ex;
             }
         }
         public void UpdateSLLo(int ma, int sl, int trangthai,int flag)
         {
             try
             {
                 cn.ExecuteNonQuery("usp_UpdateSL_CT_HDNHAP",
                    new string[] { "@MA","@SLTON_LO","@TINHTRANG","@Flag" },
                   new object[] { ma,sl,trangthai,flag });

             }
             catch (Exception ex)
             {

             }
         }
               public int InsertHDXUAT(Info.HDXuatInfo info)
         {
             int id = 0;
             try
             {
                 id = cn.ExecuteInsert("usp_InsertHD_XUAT",
                     new string[] { "@SOHD", "@MAKH","@MATDV", "@NGAYLAP", "@NGAYXUAT", "@LYDO", "@MACTKHO", "@TONGTIEN","@TIENVAT","@TINHTRANG","@TIENNO","@NO","@CO","@DIENGIAI" },
                    new object[] { info.Sohd, info.Makh,info.Matdv, info.Ngaylap, info.Ngayxuat, info.Lydo, info.Mactkho, info.Tongtien, info.Tienvat, info.Tinhtrang,info.TienNo,info.No, info.Co,info.DienGiai });
                 return id;
             }
             catch (Exception ex)
             {
                 //ghi log
                 return id;
             }

         }
         public int InsertCTNHAP(Info.CTXUATInfo info)
         {
             int id = 0;
             try
             {
                 id = cn.ExecuteInsert("usp_InsertCT_HDXUAT",
                     new string[] { "@MAHDXUAT","@MAHH","@MaCTNhap", "@SOLO","@MACTKHO", "@SOLUONG","@DONGIA","@VAT","@TIENCHUAVAT","@TIENCOVAT","@ChietKhau","@TINHTRANG" },
                    new object[] { info.Mahdxuat,info.Mahh, info.MaCTNhap, info.Solo,  info.MaCTKho,info.Soluong,info.Dongia,info.Vat,info.Tienchuavat, info.Tiencovat,info.CK, info.Tinhtrang });
                 return id;
             }
             catch (Exception ex)
             {
                 //ghi log
                 throw ex;
               //  return id;
             }
         }

        

    }
}
