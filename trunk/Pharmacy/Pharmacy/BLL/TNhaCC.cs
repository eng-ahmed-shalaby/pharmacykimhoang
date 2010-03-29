using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Pharmacy.BLL
{
    class TNhaCC
    {
        DLL.DataAccess cn = new DLL.DataAccess();
        public DataTable GetNCC()
        {
            DataTable data = new DataTable();
            data = cn.GetDataByStoredProcedure("sp_SelectNCCsAll");
            return data;
        }

    }
}
