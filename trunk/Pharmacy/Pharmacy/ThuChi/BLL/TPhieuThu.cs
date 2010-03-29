using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Pharmacy.MyTable;

namespace Pharmacy.ThuChi.BLL
{
    class TPhieuThu
    {
        TblHD_Xuat tblHDXuat;
        DLL.DataAccess cn = new DLL.DataAccess();
        public TblHD_Xuat GetHD_No(int _maKH) { 
            string sql =string.Format("select *, convert(char(10), NGAYLAP,103) as NGAYLAP1"+
                " from dbo.HD_XUAT where MAKH={0} and TINHTRANG={1}",_maKH,1);
            tblHDXuat = new TblHD_Xuat(sql);
            return tblHDXuat;
        }
        public int InsertPHIEUTHU(Info.PhieuThu info)
        {
            int id = 0;
            try
            {

                id = cn.ExecuteInsert("usp_InsertPHIEUXUAT",
                    new string[] { "@MaKH", "@NgayThu", "@TongTien", "@LyDo", "@KemTheo", "@No", "@Co","@GhiChu" },
                   new object[] { info.MaKH, info.NgayThu, info.TongTien, info.LyDo, info.KemTheo, info.No, info.Co,info.GhiChu});
                return id;
            }
            catch (Exception ex)
            {
                //ghi log
                throw ex;
            }

        }
        public int InsertCT_PHIEUTHU(Info.CTPHIEUTHU info)
        {
            int id = 0;
            try
            {   id = cn.ExecuteInsert("usp_InsertCT_PHIEUTHU",
                new string[] { "@MaPhieu", "@MaHDXuat", "@Tien" },
                new object[] { info.MaPhieu, info.MaHDXuat, info.Tien});
                return id;
            }
            catch (Exception ex)
            {
                //ghi log
                throw ex;
            }

        }
         public DataTable GetPhieuThu_Date(DateTime ngay, int flag)
         {
             try
             {
                 DataTable data = new DataTable();
                 data = cn.GetDataByStoredProcedure("usp_SelectPHIEUTHU",
                 new string[] { "@NgayThu", "@FlagMonth" },
                     new object[] { ngay,flag });
                 return data;
             }
             catch (Exception ex) { throw ex; }
         }
        
    }
}
