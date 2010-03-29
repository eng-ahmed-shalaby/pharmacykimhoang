using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pharmacy.Info
{
    class HangHoaInfo
    {

        private int _ma;
        private int _MADV;
        private string _CODE;

        public string CODE
        {
            get { return _CODE; }
            set { _CODE = value; }
        }
        public int MADV
        {
            get { return _MADV; }
            set { _MADV = value; }
        }


        private int _MAQUYCACH;

        public int MAQUYCACH
        {
            get { return _MAQUYCACH; }
            set { _MAQUYCACH = value; }
        }
        public int MA
        {
            get { return _ma; }
            set { _ma = value; }
        }

        private string _tENHANGHOA;

        public string TENHANGHOA
        {
            get { return _tENHANGHOA; }
            set { _tENHANGHOA = value; }
        }

        private int _mANHOM;

        public int MANHOM
        {
            get { return _mANHOM; }
            set { _mANHOM = value; }
        }

        private string _cHIDINH;

        public string CHIDINH
        {
            get { return _cHIDINH; }
            set { _cHIDINH = value; }
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
