using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Pharmacy.MyTable
{
    class TblNCC :MyTable
    {
        #region "Contructor"
        public static String MyTableName = "[NCC]";
        public TblNCC()     
            : base(MyTableName, "Select * From " + MyTableName)
        {
        }
        public TblNCC(int tt)
            : base(MyTableName, "Select * From " + MyTableName + " Where TINHTRANG = " + tt)
        {
        }
        public TblNCC(string pChuoi_SQL)
            : base(MyTableName, pChuoi_SQL)
        {
        }
    #endregion
    #region "Static Instance"
        private static TblNCC _Table = null;
        public static TblNCC Table
        {
            get {
                if (_Table == null)
                    _Table = new TblNCC();
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
        public string GetQuocGia(object ma)
        {
           string ret = "";
            try
            {
                TblQuocGia tblQG = new TblQuocGia(ma);
                ret = tblQG.Rows[0]["TEN"].ToString();
            }
            catch (Exception ex)
            {
                TLog.WriteErr("TTblNCC:GetQuocGia", ex.Message);
            }
            return ret;
        }
    #endregion
    }
}
