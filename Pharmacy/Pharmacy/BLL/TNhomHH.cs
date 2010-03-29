using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Pharmacy.BLL
{
    class TNhomHH
    {
        DLL.DataAccess cn = new DLL.DataAccess();
        public DataTable GetNhomHH( int maloai,int trangthai)
        {
            DataTable data = new DataTable();
            data = cn.GetDataByStoredProcedure("sp_SelectNHOMHANGHOA",
                new string[] { "@MALOAISP","@TINHTRANG" },
                new object[] { maloai,trangthai });

            return data;
        }

    }
}
