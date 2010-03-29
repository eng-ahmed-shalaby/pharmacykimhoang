using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Pharmacy.MyTable
{
    class TblNhomHH: MyTable
    {
        #region "Contructor"
        public static String MyTableName = "NHOMHANGHOA";
        public TblNhomHH():base(MyTableName,"Select * from "+ MyTableName)
        {}
        public TblNhomHH(int id, int tt)
            : base(MyTableName, "Select * from " + MyTableName + " where  MALOAISP=" + id +" and TINHTRANG ="+ tt) { }

        public TblNhomHH(string pChuoi_SQL)
            : base(MyTableName, pChuoi_SQL)
        {
        }   

        #endregion
        #region "Static Instance"
        private static TblNhomHH _Table = null;
        public static TblNhomHH Table
        {
            get
            {
                if (_Table == null)
                    _Table = new TblNhomHH();
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
