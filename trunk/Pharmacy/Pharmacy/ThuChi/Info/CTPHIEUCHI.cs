using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pharmacy.ThuChi.Info
{
   public class CTPHIEUCHI
    {

        private int _ma;

        public int Ma
        {
            get { return _ma; }
            set { _ma = value; }
        }

        private int _maPhieu;

        public int MaPhieu
        {
            get { return _maPhieu; }
            set { _maPhieu = value; }
        }

        private string _maHDNhap;

        public string MaHDNhap
        {
            get { return _maHDNhap; }
            set { _maHDNhap = value; }
        }

        private double _tien;

        public double Tien
        {
            get { return _tien; }
            set { _tien = value; }
        }


    }
}
