using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Pharmacy.QuanLy.BLL
{
    class TNhaCC
    {
        DLL.DataAccess cn = new DLL.DataAccess();
        public DataTable GetNCC()
        {
            DataTable data = new DataTable();
            data = cn.GetDataByStoredProcedure("sp_SelectNCCsAll");
            return data;

        }
        
        public int InsertNCC(Info.NhaCCInfo info)
        {
            int id = cn.ExecuteInsert("SP_INSERTCC",
                new string[] { "@CODENCC", "@MANHOM", "@TEN", "@MAQG", "@DIACHI", "@DIENTHOAI", "@CAPDO"},
                new object[] { info.Codencc, info.Manhom, info.Ten, info.Maqg, info.Diachi,info.Dienthoai, info.Capdo });
            return id;
        }

        public int DeleteNCC(Info.NhaCCInfo info)
        {
            int id = cn.ExecuteNonQuery("sp_DeleteCC",
                new string[] { "@MA" },
                new object[] { info.Mancc });
            return id;
        }

        public int UpdateNCC(Info.NhaCCInfo info)
        {
            cn.ExecuteNonQuery("sp_UpdateCC",
                new string[] { "@MA", "@CODENCC", "@MANHOM", "@TEN", "@MAQG", "@DIACHI", "@DIENTHOAI", "@CAPDO" },
                new object[] { info.Mancc, info.Codencc, info.Manhom, info.Ten, info.Maqg, info.Diachi, info.Dienthoai, info.Capdo });
            return 1;
        }
    }
}
