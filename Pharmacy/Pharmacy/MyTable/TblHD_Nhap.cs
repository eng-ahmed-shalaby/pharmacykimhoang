using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Pharmacy.MyTable
{
    class TblHD_Nhap:MyTable
    {
        #region "Contructor"
        public static String MyTableName = "[HD_NHAP]";
        public TblHD_Nhap()     
            : base(MyTableName, "Select * From " + MyTableName)
        {

        }
        public TblHD_Nhap(int tt)
            : base(MyTableName, "Select * From " + MyTableName + " Where TINHTRANG = " + tt)
        {
        }
        public TblHD_Nhap(string pChuoi_SQL)
            : base(MyTableName, pChuoi_SQL)
        {
        }
    #endregion
    #region "Static Instance"
        private static TblHD_Nhap _Table = null;
        public static TblHD_Nhap Table
        {
            get {
                if (_Table == null)
                    _Table = new TblHD_Nhap();
                return _Table; 
            }
        }
        public static DataView ToView(string pFilterCon)
        {
            DataView ret = new DataView(Table);
            ret.RowFilter = pFilterCon;
            return ret;
        }
    #endregion
    #region "Infomation"

      
    #endregion
    }
}
