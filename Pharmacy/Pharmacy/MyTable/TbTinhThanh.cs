using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Pharmacy.MyTable
{
    class TblTinhThanh :MyTable
    {
          #region "Contructor"
        public static String MyTableName = "[TinhThanh]";
        public TblTinhThanh()     
            : base(MyTableName, "Select * From " + MyTableName)
        {
        }
        public TblTinhThanh(object pID)
            : base(MyTableName, "Select * From " + MyTableName + " Where TINHTRANG = '" + pID +"' order by TEN")
        {
        }
        public TblTinhThanh(string pChuoi_SQL)
            : base(MyTableName, pChuoi_SQL)
        {
        }
    #endregion
    #region "Static Instance"
        private static TblTinhThanh _Table = null;
        public static TblTinhThanh Table
        {
            get {
                if (_Table == null)
                    _Table = new TblTinhThanh();
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
