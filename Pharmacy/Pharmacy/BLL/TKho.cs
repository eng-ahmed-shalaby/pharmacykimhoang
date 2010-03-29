using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Pharmacy.BLL
{
    class TKho
    {
        DLL.DataAccess cn = new DLL.DataAccess();
        public DataTable GetKho(int tinhtrang)
        {
            DataTable data = new DataTable();
            data = cn.GetDataByStoredProcedure("sp_SelectKHO",
                new string[] {"@TINHTRANG" },
                new object[] { tinhtrang });
            return data;
        }
        public DataTable GetCTKho(int maKho)
        {
            DataTable data = new DataTable();
            data = cn.GetDataByStoredProcedure("sp_SelectCT_KHO",
                new string[] { "@MAKHO" },
                new object[] { maKho });
            return data;
        }

    }
}
