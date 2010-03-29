using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Pharmacy.BLL
{
    class TDonVi
    {
        DLL.DataAccess cn = new DLL.DataAccess();
        public DataTable GetDonVi(string tinhtrang)
        {
            DataTable data = new DataTable();
            data = cn.GetDataByStoredProcedure("sp_SelectDONVI",
                new string[] { "@TINHTRANG" },
                new object[] { tinhtrang });
            return data;

        }

        public int InsertEmployee(Info.DonViInfo info)
        {
            //int id = _cn.ExecuteInsert("sp_InserttblMember",
            //    new string[] { "@UserName", "@Password", "@FullName", "@AuthenticationID", "@Email", "@Address", "@IdentityCardNumber", "@Phone", "@Birthday", "@Pic", "@Active" },
            //    new object[] { ey.UserName, ey.Password, ey.FullName, ey.AuthenticationID, ey.Email, ey.Address, ey.IdentityCardNumber, ey.Phone, ey.Birthday, ey.Pic, ey.Active });
            return 0;
        }

        public void UpdateEmployee(Info.DonViInfo info)
        {
            //_cn.ExecuteNonQuery("sp_UpdatetblMember",
            //    new string[] { "@ID", "@UserName", "@Password", "@FullName", "@AuthenticationID", "@Email", "@Address", "@IdentityCardNumber", "@Phone", "@Birthday", "@Pic", "@Active" },
            //    new object[] { ey.ID, ey.UserName, ey.Password, ey.FullName, ey.AuthenticationID, ey.Email, ey.Address, ey.IdentityCardNumber, ey.Phone, ey.Birthday, ey.Pic, ey.Active });

        }
    }
}
