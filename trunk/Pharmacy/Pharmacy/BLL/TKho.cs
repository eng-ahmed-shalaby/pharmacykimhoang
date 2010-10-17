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
             public int InsertCTKho(int maKho, string ke)
        {
            int id = 0;
            try
            {

                id = cn.ExecuteInsert("usp_InsertCT_KHO",
                      new string[] { "@MAKHO", "@KE", "@NGAN", "@TINHTRANG"},
                     new object[] { maKho,ke, "", 1 });
                return id;
            }
            catch (Exception ex)
            {
                //ghi log
                throw ex;
                // return id;
            }

        }
        public int InsertKho(Info.KhoInfo info)
        {
            int id = 0;
            try
            {

                id = cn.ExecuteInsert("sp_InsertKHO",
                      new string[] { "@TEN", "@DIACHI", "@DIENTHOAI", "@NGAYLAP", "@TINHTRANG", "@SODK" },
                     new object[] { info.Ten, info.Diachi, info.Dienthoai, info.Ngaylap, info.Tinhtrang, info.Sodk });
                return id;
            }
            catch (Exception ex)
            {
                //ghi log
                throw ex;
                // return id;
            }

        }
        public int UpdateKho(Info.KhoInfo info)
        {
            try
            {
                cn.ExecuteNonQuery("sp_UpdateKHO",
                    new string[] { "@MAKHO", "@TEN", "@DIACHI", "@DIENTHOAI", "@NGAYLAP", "@TINHTRANG", "@SODK" },
                    new object[] { info.Makho, info.Ten, info.Diachi, info.Dienthoai, info.Ngaylap, info.Tinhtrang, info.Sodk });
                return 1;
            }
            catch (Exception ex)
            {
                //ghi log
                throw ex;
                // return id;
            }
        }
        public int UpdateCTKho(int maCT,int ma, string ke, int tt)
        {
            try
            {           cn.ExecuteNonQuery("usp_UpdateCT_KHO",
                    new string[] { "@MACTKHO", "@MAKHO", "@KE", "@NGAN", "@TINHTRANG"},
                    new object[] { maCT, ma,ke,"",tt});
                return 1;
            }
            catch (Exception ex)
            {
                //ghi log
                throw ex;
                // return id;
            }
        }
       

    }
}
