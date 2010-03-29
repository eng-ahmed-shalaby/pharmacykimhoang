using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pharmacy.ThuChi.Info
{
   public class CTPHIEUTHU
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

        private string _maHDXuat;

        public string MaHDXuat
        {
            get { return _maHDXuat; }
            set { _maHDXuat = value; }
        }

        private double _tien;

        public double Tien
        {
            get { return _tien; }
            set { _tien = value; }
        }


    }
}
