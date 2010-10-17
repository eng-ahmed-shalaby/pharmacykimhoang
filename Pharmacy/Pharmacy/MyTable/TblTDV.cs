using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Pharmacy.MyTable
{
    class TblTDV :MyTable
    {
        #region "Contructor"
        public static String MyTableName = "[TRINHDUOCVIEN]";
        public TblTDV()     
            : base(MyTableName, "Select * From " + MyTableName)
        {
        }
        public TblTDV(int tt)
            : base(MyTableName, "Select * From " + MyTableName + " Where TINHTRANG = " + tt+" order by PHONGBAN")
        {
        }
        public TblTDV(string pChuoi_SQL)
            : base(MyTableName, pChuoi_SQL)
        {
        }
    #endregion
    #region "Static Instance"
        private static TblTDV _Table = null;
        public static TblTDV Table
        {
            get {
                if (_Table == null)
                    _Table = new TblTDV();
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
                TLog.WriteErr("TTblTDV:GetQuocGia", ex.Message);
            }
            return ret;
        }
    #endregion
    }
}
