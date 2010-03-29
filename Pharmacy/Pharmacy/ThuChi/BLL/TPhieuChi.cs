using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Pharmacy.MyTable;

namespace Pharmacy.ThuChi.BLL
{
    class TPhieuChi
    {
        TblHD_Nhap tblHDNhap;
        DLL.DataAccess cn = new DLL.DataAccess();
        public TblHD_Nhap GetHD_No(int _maNCC)
        { 
            string sql =string.Format("select *, convert(char(10), NGAYLAP,103) as NGAYLAP1"+
                " from dbo.HD_NHAP where MaNCC={0} and TINHTRANG={1}", _maNCC, 1);
            tblHDNhap = new TblHD_Nhap(sql);
            return tblHDNhap;
        }
        public int InsertPHIEUCHI(Info.PhieuChi info)
        {
            int id = 0;
            try
            {

                id = cn.ExecuteInsert("usp_InsertPHIEUCHI",
                    new string[] { "@MaNCC", "@NgayChi", "@TongTien", "@LyDo", "@KemTheo", "@No", "@Co","@GhiChu" },
                   new object[] { info.MaNCC, info.NgayChi, info.TongTien, info.LyDo, info.KemTheo, info.No, info.Co,info.GhiChu});
                return id;
            }
            catch (Exception ex)
            {
                //ghi log
                throw ex;
            }

        }
        public int InsertCT_PHIEUCHI(Info.CTPHIEUCHI info)
        {
            int id = 0;
            try
            {   id = cn.ExecuteInsert("usp_InsertCT_PHIEUCHI",
                new string[] { "@MaPhieu", "@MaHDNhap", "@Tien" },
                new object[] { info.MaPhieu, info.MaHDNhap, info.Tien});
                return id;
            }
            catch (Exception ex)
            {
                //ghi log
                throw ex;
            }

        }
         public DataTable GetPhieuChi_Date(DateTime ngay, int flag)
         {
             try
             {
                 DataTable data = new DataTable();
                 data = cn.GetDataByStoredProcedure("usp_SelectPHIEUCHI",
                 new string[] { "@NgayChi", "@FlagMonth" },
                     new object[] { ngay,flag });
                 return data;
             }
             catch (Exception ex) { throw ex; }
         }
        
    }
}
