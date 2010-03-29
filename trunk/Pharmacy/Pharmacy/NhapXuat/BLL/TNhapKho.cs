using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Pharmacy.NhapXuat.BLL
{
    
    class TNhapKho
    {
        DLL.DataAccess cn = new DLL.DataAccess();
        Pharmacy.BLL.TDonVi tDonvi = new Pharmacy.BLL.TDonVi();
        Pharmacy.BLL.TNhaCC tNCC = new Pharmacy.BLL.TNhaCC();
        Pharmacy.BLL.TLoaiSP tLoaiSP = new Pharmacy.BLL.TLoaiSP();
        Pharmacy.BLL.TNhomHH tNHH = new Pharmacy.BLL.TNhomHH();
        Pharmacy.BLL.THangHoa tHH = new Pharmacy.BLL.THangHoa();
        Pharmacy.BLL.TQG tQG = new Pharmacy.BLL.TQG();
        Pharmacy.BLL.TKho tKho = new Pharmacy.BLL.TKho();
        Pharmacy.BLL.TQuycach tQuycach = new Pharmacy.BLL.TQuycach();
        public DataTable GetDonVi() {
            return tDonvi.GetDonVi("1");
        }
        public DataTable GetNCC()
        {
            return tNCC.GetNCC();
        }
        public DataTable GetQG()
        {
            return tQG.GetQG();
        }
        public DataTable GetLoaiSP()
        {
            return tLoaiSP.GetLoaiSP();
        }
        public DataTable GetNhomHH(int maloai,int tinhtrang)
        {
            return tNHH.GetNhomHH(maloai, tinhtrang);
        }
        public DataTable GetHH(int nhom)
        {
            return tHH.GetHangHoa(nhom);
        }
        public DataTable GetKho(int trangthai)
        {
            return tKho.GetKho(trangthai);
        }
        public DataTable GetCTKho(int maKho)
        {
            return tKho.GetCTKho(maKho);
        }
        public DataTable GetHD(string maHD)
        {
            try
            {
                DataTable data = new DataTable();
                data = cn.GetDataByStoredProcedure("usp_SelectHD_NHAP",
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
                data = cn.GetDataByStoredProcedure("usp_SelectHD_NHAPbyDate",
                new string[] { "@Date" },
                    new object[] { date });
                return data;
            }
            catch (Exception ex) { return null; }
        }
        public DataTable GetCTHD(string maHD)
        {
            try {
                DataTable data = new DataTable();
                data = cn.GetDataByStoredProcedure("usp_SelectCT_HDNHAP",
                new string[] { "@MAHDNHAP" },
                    new object[] { maHD});
                return data;
            }
            catch (Exception ex) {
                //ghi log
                return null;
            }
        }

        public void DeleteCTHD(string maCTHD) {
            try
            {
                 cn.ExecuteNonQuery("usp_DeleteCT_HDNHAP",
                    new string[] { "@MA"},
                   new object[] {int.Parse(maCTHD)});

            }
            catch (Exception ex)
            {

            }
        }
        public void DeleteHD(string maHD)
        {
            try
            {
                cn.ExecuteNonQuery("usp_DeleteHD_NHAP",
                   new string[] { "@MA" },
                  new object[] { int.Parse(maHD) });

            }
            catch (Exception ex)
            {

            }
        }
        public DataTable GetQuycach()
        {
            return tQuycach.GetQuycach();
        }
        public void UpdateTongtienHD(int maHD, double Tong, int Type)
        {
            try
            {
                cn.ExecuteNonQuery("usp_UpdateTongTienHD_NHAP",
                   new string[] { "@MA", "@TONGTIEN","@Type" },
                  new object[] { maHD, Tong, Type });

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
      
        public int InsertHDNHAP(Info.HDNhapInfo info)
        {
            int id = 0;
            try
            {
       
              id = cn.ExecuteInsert("usp_InsertHD_NHAP",
                    new string[] { "@SOHD", "@MANCC", "@NGAYLAP", "@NGAYNHAP", "@LYDO", "@NGUYENNHAN", "@TONGTIEN",	"@MALOAINT",	"@TYGIA",	"@TINHTRANG","@TIENNO","@NO","@CO" },
                   new object[] { info.Sohd, info.Mancc, info.Ngaylap, info.Ngaynhap, info.Lydo, info.Nguyennhan, info.Tongtien, info.Maloaint, info.Tygia, info.Tinhtrang,info.TienNo,info.No, info.Co });
                return id;
            }
            catch (Exception ex)
            {
                //ghi log
                throw ex;
               // return id;
            }

        }
        public int InsertCTNHAP( Info.CTNHAPInfo info) {
            int id = 0;
            try
            {
                id = cn.ExecuteInsert("usp_InsertCT_HDNHAP",
                    new string[] { "@MAHDNHAP", "@MALO", "@MACTKHO","@MAHH","@MANUOCSX","@SOLUONG","@DONGIANHAP","@TIENCHUAVAT","@NGAYSX","@NGAYHH","@SLTON_LO","@TINHTRANG","@VAT","@TIENCOVAT","@CHIETKHAU"},
                   new object[] { info.Mahdnhap, info.Malo, info.Mactkho, info.Mahh, info.Manuocsx, info.Soluong, info.Dongianhap, info.Tienchuavat, info.Ngaysx, info.Ngayhh, info.SltonLo, info.Tinhtrang, info.Vat, info.Tiencovat, info.Ck});
                return id;
            }
            catch (Exception ex)
            {
                //ghi log
                return id;
            }
        }
    }
}
