using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Pharmacy.HeThong.BLL
{
    class TPhanQuyen
    {
        DLL.DataAccess cn = new DLL.DataAccess();
        public DataTable GetChuNang()
        {
            DataTable data = new DataTable();
            data = cn.GetDataByStoredProcedure("usp_SelectCHUCNANGsAll");
            return data;
        }
        public DataTable GetPhanQuyen(int MaTDV)
        {
            DataTable data = new DataTable();
            data = cn.GetDataByStoredProcedure("usp_SelectPHANQUYEN",
                new string[] { "@MATDV" },
                new object[] { MaTDV });
            return data;
        }

           public void UpdatePhanQuyen(int MaCN,int MaTDV, bool Quyen)
        {
            try
            {
                cn.ExecuteNonQuery("usp_InsertUpdatePHANQUYEN",
                   new string[] { "@MaCN", "@MaTDV","@Quyen" },
                  new object[] { MaCN, MaTDV, Quyen });

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
