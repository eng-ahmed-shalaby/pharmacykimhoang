using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pharmacy.QuanLy.Info
{
    class NhaSXInfo
    {
        private int _mansx;

        public int Mansx
        {
            get { return _mansx; }
            set { _mansx = value; }
        }
        private string _tennsx;

        public string Tennsx
        {
            get { return _tennsx; }
            set { _tennsx = value; }
        }
        private string _dienthoai;
        public string DienThoai
        {
            get { return _dienthoai; }
            set { _dienthoai = value; }
        }
        private int _maQG;
        public int MaQG
        {
            get { return _maQG; }
            set { _maQG = value; }
        }
    }
}
