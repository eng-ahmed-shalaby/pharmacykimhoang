using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Pharmacy.BLL
{
    class TQG
    {
        DLL.DataAccess cn = new DLL.DataAccess();
        public DataTable GetQG()
        {
            DataTable data = new DataTable();
            data = cn.GetDataByStoredProcedure("sp_SelectQUOCGIAsAll");
            return data;
        }

    }
}
