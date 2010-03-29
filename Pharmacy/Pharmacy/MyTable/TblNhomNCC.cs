using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Pharmacy.MyTable
{
    class TblNhomNCC: MyTable
    {
        #region "Contructor"
        public static String MyTableName = "NHOM_NCC";
        public TblNhomNCC():base(MyTableName,"Select * from "+ MyTableName)
        {}
        public TblNhomNCC(int id)
            : base(MyTableName, "Select * from " + MyTableName + "where MANHOMNCC=" + id) { }

        public TblNhomNCC(string pChuoi_SQL)
            : base(MyTableName, pChuoi_SQL)
        {
        }   

        #endregion
        #region "Static Instance"
        private static TblNhomNCC _Table = null;
        public static TblNhomNCC Table
        {
            get
            {
                if (_Table == null)
                    _Table = new TblNhomNCC();
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
