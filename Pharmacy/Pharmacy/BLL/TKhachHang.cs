using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Pharmacy.BLL
{
    class TKhachHang
    {
        DLL.DataAccess cn = new DLL.DataAccess();

        public DataTable GetNhomKhachHang()
        {
            DataTable data = new DataTable();
            data = cn.GetDataByStoredProcedure("usp_SelectNHOM_KHsAll");
            return data;
        }

        public DataTable GetKhachHang_All()
        {
            DataTable data = new DataTable();
            data = cn.GetDataByStoredProcedure("usp_SelectKH_All");
            return data;
        }
        public DataTable GetKhachHang(string CodeKH)
        {
            DataTable data = new DataTable();
            data = cn.GetDataBySQL("Select * from KH where CODEKH='"+ CodeKH +"'");
            return data;
        }
        public DataTable GetKhachHangID(int ID)
        {
            DataTable data = new DataTable();
            data = cn.GetDataBySQL("Select * from KH where MAKH=" + ID);
            return data;
        }
        public DataTable GetKhachHang(int maNhom)
        {
            DataTable data = new DataTable();
            data = cn.GetDataByStoredProcedure("usp_SelectKH",
            new string[] { "@MANHOM" },
                new object[] { maNhom });
            return data;

        }
        public DataTable GetKhachHang()
        {
            DataTable data = new DataTable();
            data = cn.GetDataBySQL("Select * from KH");
            return data;

        }

    }
}
