using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Pharmacy.QuanLy.BLL
{
    class TNhomKH
    {
        DLL.DataAccess cn = new DLL.DataAccess();
        public DataTable GetNhomKH()
        {
            DataTable data = new DataTable();
            data = cn.GetDataByStoredProcedure("sp_selectnhomKH");
            return data;

        }

        public int InsertNhomKH(Info.NhomKHInfo info)
        {
            int id = cn.ExecuteInsert("SP_INSERTNhomKH",
                new string[] { "@TENNHOM", "@MOTA" },
                new object[] { info.Tennhom, info.Mota });
            return id;
        }

        public int DeleteNhomKH(Info.NhomKHInfo info)
        {
            int id = cn.ExecuteNonQuery("sp_DeleteNhomKH",
                new string[] { "@MANHOMKH" },
                new object[] { info.Mannhomkh });
            return id;
        }

        public int UpdateNhomKH(Info.NhomKHInfo info)
        {
            cn.ExecuteNonQuery("SP_UPDATENhomKH",
                new string[] { "@MA", "@TENNHOM", "@MOTA" },
                new object[] { info.Mannhomkh, info.Tennhom, info.Mota });
            return 1;
        }
    }
}
