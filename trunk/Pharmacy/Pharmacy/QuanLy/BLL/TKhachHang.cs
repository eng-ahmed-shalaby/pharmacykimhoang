using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Pharmacy.QuanLy.BLL
{
    class TKhachHang
    {
        DLL.DataAccess cn = new DLL.DataAccess();
        public DataTable GetKH()
        {
            DataTable data = new DataTable();
            data = cn.GetDataByStoredProcedure("sp_selectkh");
            return data;

        }

        public int InsertKH(Info.KhachHangInfo info)
        {
            int id = cn.ExecuteInsert("SP_INSERTKH",
                new string[] { "@CODEKH", "@MANHOM", "@TEN", "@TUOI", "@GIOITINH", "@MATINH", "@DIACHI", "@DIENTHOAI", "@CAPDO","@MST" },
                new object[] { info.CODEKH, info.MANHOM, info.TEN, info.TUOI, info.GIOITINH, info.MATINH, info.DIACHI, info.DIENTHOAI, info.CAPDO, info.MST });
            return id;
        }

        public int DeleteKH(Info.KhachHangInfo info)
        {
            int id = cn.ExecuteNonQuery("sp_DeleteKH",
                new string[] { "@MAKH" },
                new object[] { info.MAKH });
            return id;
        }

        public int UpdateKH(Info.KhachHangInfo info)
        {
            cn.ExecuteNonQuery("SP_UPDATEKH",
                new string[] { "@MAKH", "@CODEKH", "@MANHOM", "@TEN", "@TUOI", "@GIOITINH", "@MATINH", "@DIACHI", "@DIENTHOAI", "@CAPDO","@MST" },
                new object[] { info.MAKH, info.CODEKH, info.MANHOM, info.TEN, info.TUOI, info.GIOITINH, info.MATINH, info.DIACHI, info.DIENTHOAI, info.CAPDO,info.MST });
            return 1;
        }
    }
}
