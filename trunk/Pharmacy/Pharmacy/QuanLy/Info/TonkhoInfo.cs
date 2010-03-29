using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pharmacy.QuanLy.Info
{
    class TonkhoInfo
    {
        private int _matonkho;

        public int Matonkho
        {
            get { return _matonkho; }
            set { _matonkho = value; }
        }
        private int _MAKHO;

        public int MAKHO
        {
            get { return _MAKHO; }
            set { _MAKHO = value; }
        }
        private System.DateTime _NGAY;

        public System.DateTime NGAY
        {
            get { return _NGAY; }
            set { _NGAY = value; }
        }
        private int _TINHTRANG;

        public int TINHTRANG
        {
            get { return _TINHTRANG; }
            set { _TINHTRANG = value; }
        }
    }
}
