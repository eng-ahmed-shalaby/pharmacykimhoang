using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;

namespace Pharmacy.QuanLy.BLL
{
    class TQuyCach
    {
        DLL.DataAccess cn = new DLL.DataAccess();
        public DataTable GetQC()
        {
            DataTable data = new DataTable();
            data = cn.GetDataByStoredProcedure("sp_SelectQuycach");
            return data;

        }

        public int InsertQC(Info.QuyCachInfo info)
        {
            int id = cn.ExecuteInsert("SP_INSERTQuyCach",
                new string[] { "@TEN" },
                new object[] { info.Ten });
            return id;
        }

        public int DeleteQC(Info.QuyCachInfo info)
        {
            int id = cn.ExecuteNonQuery("sp_DeleteQuyCach",
                new string[] { "@MA" },
                new object[] { info.Ma });
            return id;
        }

        public int UpdateQC(Info.QuyCachInfo info)
        {
            cn.ExecuteNonQuery("SP_UPDATEQuyCach",
                new string[] { "@MA", "@TEN" },
                new object[] { info.Ma, info.Ten });
            return 1;
        }

    }
}
