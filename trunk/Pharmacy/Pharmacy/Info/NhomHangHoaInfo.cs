using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pharmacy.Info
{
    class NhomHangHoaInfo
    {

        private int _ma;

        public int MA
        {
            get { return _ma; }
            set { _ma = value; }
        }

        private string _tEN;

        public string TEN
        {
            get { return _tEN; }
            set { _tEN = value; }
        }

        private string _mOTA;

        public string MOTA
        {
            get { return _mOTA; }
            set { _mOTA = value; }
        }

        private int _tINHTRANG;

        public int TINHTRANG
        {
            get { return _tINHTRANG; }
            set { _tINHTRANG = value; }
        }


    }
}
