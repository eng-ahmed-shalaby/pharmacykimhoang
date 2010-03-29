using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Pharmacy.MyTable
{
    class TblKhuyenMai: MyTable
    {
        #region "Contructor"
        public static String MyTableName = "KHUYENMAI";
        public TblKhuyenMai():base(MyTableName,"Select * from "+ MyTableName)
        {}
        public TblKhuyenMai(int id)
            : base(MyTableName, "Select * from " + MyTableName + "where MA=" + id) { }

        public TblKhuyenMai(string pChuoi_SQL)
            : base(MyTableName, pChuoi_SQL)
        {
        }   

        #endregion
        #region "Static Instance"
        private static TblKhuyenMai _Table = null;
        public static TblKhuyenMai Table
        {
            get
            {
                if (_Table == null)
                    _Table = new TblKhuyenMai();
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
    }
}
