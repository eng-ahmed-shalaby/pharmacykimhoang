using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Pharmacy.BLL
{
    class TQuycach
    {
        DLL.DataAccess cn = new DLL.DataAccess();
        public DataTable GetQuycach()
        {
            DataTable data = new DataTable();
            data = cn.GetDataByStoredProcedure("sp_SelectQuycach");
            return data;
        }
    }
}
