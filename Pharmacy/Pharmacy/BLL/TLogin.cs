using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Pharmacy.BLL
{
    class TLogin
    {
        DLL.DataAccess cn = new DLL.DataAccess();
        public DataTable GetQuyen(int maTDV)
        {
            DataTable data = new DataTable();
            data = cn.GetDataByStoredProcedure("usp_SelectPHANQUYEN",
            new string[] { "@MATDV"},
                new object[] { maTDV });
            return data;

        }
        public DataTable CheckMatKhau(string user, string pass) {
            DataTable data = new DataTable();
            data = cn.GetDataByStoredProcedure("usp_DangNhap",
            new string[] { "@TenDN", "@MatKhau" },
                new object[] { user,pass });
            return data;

        }
    }
}
