using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pharmacy.QuanLy.Info
{
    class QuyCachInfo
    {
        private int _ma;

        public int Ma
        {
            get { return _ma; }
            set { _ma = value; }
        }
        private string _ten;

        public string Ten
        {
            get { return _ten; }
            set { _ten = value; }
        }
        private int _sldv;

        public int Sldv
        {
            get { return _sldv; }
            set { _sldv = value; }
        }

    }
}
