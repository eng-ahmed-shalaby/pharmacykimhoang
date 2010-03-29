using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Pharmacy.MyTable
{
    class TblHD_Xuat:MyTable
    {
        #region "Contructor"
        public static String MyTableName = "[HD_XUAT]";
        public TblHD_Xuat()     
            : base(MyTableName, "Select * From " + MyTableName)
        {

        }
        public TblHD_Xuat(int tt)
            : base(MyTableName, "Select * From " + MyTableName + " Where TINHTRANG = " + tt)
        {
        }
        public TblHD_Xuat(string pChuoi_SQL)
            : base(MyTableName, pChuoi_SQL)
        {
        }
    #endregion
    #region "Static Instance"
        private static TblHD_Xuat _Table = null;
        public static TblHD_Xuat Table
        {
            get {
                if (_Table == null)
                    _Table = new TblHD_Xuat();
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
