using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pharmacy.QuanLy.Info
{
    class NhomKHInfo
    {
        private int _mannhomkh;

        public int Mannhomkh
        {
            get { return _mannhomkh; }
            set { _mannhomkh = value; }
        }
        private string _tennhom;

        public string Tennhom
        {
            get { return _tennhom; }
            set { _tennhom = value; }
        }
        private string _mota;

        public string Mota
        {
            get { return _mota; }
            set { _mota = value; }
        }
    }
}
