using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pharmacy.QuanLy.Info
{
    class DonViInfo
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
        private int _trangthai;
        public int TrangThai
        {
            get { return _trangthai; }
            set { _trangthai = value; }
        }
    }
}
