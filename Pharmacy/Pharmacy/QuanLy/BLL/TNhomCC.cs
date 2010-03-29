using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Pharmacy.QuanLy.BLL
{
    class TNhomCC
    {
        DLL.DataAccess cn = new DLL.DataAccess();
        public DataTable GetNhomCC()
        {
            DataTable data = new DataTable();
            data = cn.GetDataByStoredProcedure("sp_selectnhomncc");
            return data;

        }

        public int InsertNhomCC(Info.NhomCCInfo info)
        {
            int id = cn.ExecuteInsert("SP_INSERTNhomCC",
                new string[] { "@TENNHOM", "@MOTA" },
                new object[] { info.Tennhom,info.Mota });
            return id;
        }

        public int DeleteNhomCC(Info.NhomCCInfo info)
        {
            int id = cn.ExecuteNonQuery("sp_DeleteNhomCC",
                new string[] { "@MANHOMNCC" },
                new object[] { info.Mannhomcc });
            return id;
        }

        public int UpdateNhomCC(Info.NhomCCInfo info)
        {
            cn.ExecuteNonQuery("SP_UPDATENhomCC",
                new string[] { "@MA", "@TENNHOM", "@MOTA" },
                new object[] { info.Mannhomcc, info.Tennhom,info.Mota });
            return 1;
        }
    }
}
