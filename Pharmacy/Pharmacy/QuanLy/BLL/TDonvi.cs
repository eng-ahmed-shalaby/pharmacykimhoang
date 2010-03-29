using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;

namespace Pharmacy.QuanLy.BLL
{
    class TDonvi
    {
        DLL.DataAccess cn = new DLL.DataAccess();
        public DataTable GetDVT()
        {
            DataTable data = new DataTable();
            data = cn.GetDataByStoredProcedure("sp_SelectDONVIsAll");
            return data;

        }

        public int InsertDVT(Info.DonViInfo info)
        {
            int id = cn.ExecuteInsert("SP_INSERTDONVI",
                new string[] { "@TEN" },
                new object[] { info.Ten });
            return id;
        }

        public int DeleteDVT(Info.DonViInfo info)
        {
            int id = cn.ExecuteNonQuery("sp_DeleteDONVI",
                new string[] { "@MADONVI" },
                new object[] { info.Ma });
            return id;
        }

        public int UpdateDVT(Info.DonViInfo info)
        {
            cn.ExecuteNonQuery("SP_UPDATEDONVI",
                new string[] { "@MADONVI", "@TEN" },
                new object[] { info.Ma, info.Ten });
            return 1;
        }
       

    }
}
