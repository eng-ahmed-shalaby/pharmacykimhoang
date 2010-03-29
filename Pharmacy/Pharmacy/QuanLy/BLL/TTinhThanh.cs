using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Pharmacy.QuanLy.BLL
{
    class TTinhThanh
    {
        DLL.DataAccess cn = new DLL.DataAccess();
        public DataTable GetTT()
        {
            DataTable data = new DataTable();
            data = cn.GetDataByStoredProcedure("sp_SelectTT");
            return data;

        }

        //public int InsertLoaiSP(Info.LoaiHHInfo info)
        //{
        //    int id = cn.ExecuteInsert("sp_InsertLOAI_SP",
        //        new string[] { "@TEN", "@MOTA" },
        //        new object[] { info.TEN, info.MOTA });
        //    return id;
        //}

        //public int DeleteLoaiSP(Info.LoaiHHInfo info)
        //{
        //    int id = cn.ExecuteNonQuery("sp_Deleteloaihh",
        //        new string[] { "@MA" },
        //        new object[] { info.MA });
        //    return id;
        //}

        //public int UpdateLoaiSP(Info.LoaiHHInfo info)
        //{
        //    cn.ExecuteNonQuery("sp_UpdateLOAI_SP",
        //        new string[] { "@MA", "@TEN", "@MOTA" },
        //        new object[] { info.MA, info.TEN, info.MOTA });
        //    return 1;
        //}
    }
}
