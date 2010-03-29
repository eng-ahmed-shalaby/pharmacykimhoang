using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Pharmacy.BLL
{
    class TLoaiSP
    {
        DLL.DataAccess cn = new DLL.DataAccess();
        public DataTable GetLoaiSP()
        {
            DataTable data = new DataTable();
            data = cn.GetDataByStoredProcedure("sp_SelectLOAI_SPsAll");
            return data;
        }

    }
}
