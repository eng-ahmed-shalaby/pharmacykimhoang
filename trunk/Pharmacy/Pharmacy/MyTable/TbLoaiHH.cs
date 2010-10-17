using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Pharmacy.MyTable
{
    class TblLoaiHH: MyTable
    {
        #region "Contructor"
        public static String MyTableName = "LOAI_SP";
        public TblLoaiHH():base(MyTableName,"Select * from "+ MyTableName)
        {}
        public TblLoaiHH(int tt)
            : base(MyTableName, "Select * from " + MyTableName + " where TINHTRANG ="+ tt) { }

        public TblLoaiHH(string pChuoi_SQL)
            : base(MyTableName, pChuoi_SQL)
        {
        }   

        #endregion
        #region "Static Instance"
        private static TblLoaiHH _Table = null;
        public static TblLoaiHH Table
        {
            get
            {
                if (_Table == null)
                    _Table = new TblLoaiHH();
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
