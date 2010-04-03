using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Pharmacy.QuanLy.BLL
{
    class TkhuyenMai
    {
        DLL.DataAccess cn = new DLL.DataAccess();
        public DataTable GetKM(int t1, int t2)
        {
            DataTable data = new DataTable();
            data = cn.GetDataByStoredProcedure("[usp_SelectKMai]",
                new string[] { "@TrangThai1", "@TrangThai2" },
                new object[] { t1, t2 });
            return data;

        }
        public DataTable GetTenDV(int Ma)
        {
            DataTable data = new DataTable();
            data = cn.GetDataByStoredProcedure("usp_selectTenDV",
                new string[] { "@MaHH"},
                new object[] { Ma });
            return data;

        }
     
        public int InsertKM(Info.KhuyenMaiInfo info)
        {
            int id = cn.ExecuteInsert("usp_InsertKhuyen",
                new string[] { "@MaHH", "@SLBan","@MaHH_KM","@SLKM","@NgayKM","@TrangThai" },
                new object[] { info.MaHH, info.SL,info.MaHHKM, info.SLKM, info.NgayKM,info.TrangThai });
            return id;
        }
        public int UpdateKM(Info.KhuyenMaiInfo info)
        {
            int id = cn.ExecuteNonQuery("usp_UpdateKHUYENMAI",
                new string[] {"@MA", "@MaHH", "@SL", "@MaHHKM", "@SLKM", "@TrangThai", "@NgayKM" },
                new object[] {info.Ma, info.MaHH, info.SL, info.MaHHKM, info.SLKM, info.TrangThai, info.NgayKM });
            return id;
        }
    }
}
