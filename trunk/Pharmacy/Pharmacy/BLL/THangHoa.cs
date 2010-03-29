using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Pharmacy.BLL
{
    class THangHoa
    {
        DLL.DataAccess cn = new DLL.DataAccess();
        public DataTable GetHangHoa(int maNhom)
        {
            DataTable data = new DataTable();
            data = cn.GetDataByStoredProcedure("sp_SelectHANGHOA",
            new string[] { "@MANHOM" },
                new object[] { maNhom });
            return data;

        }
        public DataTable GetHangHoa_ALL()
        {
            DataTable data = new DataTable();
            data = cn.GetDataByStoredProcedure("sp_SelectHANGHOAsAll");

            return data;

        }
        public int Inserthanghoa(Info.HangHoaInfo info)
        {
            int id = cn.ExecuteInsert("sp_InsertHANGHOA",
                new string[] { "@TENHANGHOA", "@MANHOM", "@MADV", "@CHIDINH", "@MOTA", "@TINHTRANG", "@MAQUYCACH", "@CODE" },
                new object[] { info.TENHANGHOA, info.MANHOM, info.MADV, info.CHIDINH, info.MOTA, 1, info.MAQUYCACH, info.CODE });
            return id;
        }

        public int Deletehanghoa(Info.HangHoaInfo info)
        {
            int id = cn.ExecuteNonQuery("usp_DeleteHH",
                new string[] { "@MA" },
                new object[] { info.MA });
            return id;
        }

        public int Updatehanghoa(Info.HangHoaInfo info)
        {
            cn.ExecuteNonQuery("sp_UpdateHANGHOA",
                new string[] { "@MA", "@TENHANGHOA", "@MANHOM", "@MADV", "@CHIDINH", "@MOTA", "@TINHTRANG", "@MAQUYCACH", "CODE" },
                new object[] { info.MA, info.TENHANGHOA, info.MANHOM, info.MADV, info.CHIDINH, info.MOTA, 1, info.MAQUYCACH, info.CODE });
            return 1;
        }

    }
}
