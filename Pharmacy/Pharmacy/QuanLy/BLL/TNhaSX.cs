using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Pharmacy.QuanLy.BLL
{
    class TNhaSX
    {
        DLL.DataAccess cn = new DLL.DataAccess();
        public DataTable GetNSX()
        {
            DataTable data = new DataTable();
            data = cn.GetDataByStoredProcedure("sp_SelectNSXAll");
            return data;

        }

        public int InsertNSX(Info.NhaSXInfo info)
        {  
            int id = cn.ExecuteInsert("SP_INSERTNSX",
                new string[] { "@MAQG","@DIENTHOAI","@TENSX" },
                new object[] {info.MaQG,info.DienThoai, info.Tennsx });
            return id;
        }

        public int DeleteNSX(Info.NhaSXInfo info)
        {
            int id = cn.ExecuteNonQuery("sp_DeleteNSX",
                new string[] { "@MASX" },
                new object[] { info.Mansx });
            return id;
        }

        public int UpdateNSX(Info.NhaSXInfo info)
        {
            cn.ExecuteNonQuery("SP_UPDATENHASX",
                new string[] { "@MA","@MAQG","@DIENTHOAI", "@TENSX"},
                new object[] { info.Mansx,info.MaQG, info.DienThoai, info.Tennsx });
            return 1;
        }

    }
}
