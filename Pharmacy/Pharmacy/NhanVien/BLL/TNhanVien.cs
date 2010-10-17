using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Pharmacy.NhanVien.BLL
{
    class TNhanVien
    {
        DLL.DataAccess cn = new DLL.DataAccess();
        public DataTable GetTDV()
        {
            DataTable data = new DataTable();
            data = cn.GetDataByStoredProcedure("usp_SelectTRINHDUOCVIEN_TT", new string[] { "@TINHTRANG" },
                new object[] { 1 });
            return data;

        }
    }
}
