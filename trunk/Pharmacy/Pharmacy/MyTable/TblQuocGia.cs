using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Pharmacy.MyTable
{
    class TblQuocGia :MyTable
    {
          #region "Contructor"
        public static String MyTableName = "[QUOCGIA]";
        public TblQuocGia()     
            : base(MyTableName, "Select * From " + MyTableName)
        {
        }
        public TblQuocGia(object pID)
            : base(MyTableName, "Select * From " + MyTableName + " Where MAQG = '" + pID +"'")
        {
        }
        public TblQuocGia(string pChuoi_SQL)
            : base(MyTableName, pChuoi_SQL)
        {
        }
    #endregion
    #region "Static Instance"
        private static TblQuocGia _Table = null;
        public static TblQuocGia Table
        {
            get {
                if (_Table == null)
                    _Table = new TblQuocGia();
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
