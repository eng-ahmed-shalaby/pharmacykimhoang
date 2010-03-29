using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pharmacy.NhapXuat.Info
{
  public  class LOInfo
    {

        private string _malo;

        public string Malo
        {
            get { return _malo; }
            set { _malo = value; }
        }

        private int _mahh;

        public int Mahh
        {
            get { return _mahh; }
            set { _mahh = value; }
        }

        private int _soluong;

        public int Soluong
        {
            get { return _soluong; }
            set { _soluong = value; }
        }

        private System.DateTime _ngaysx;

        public System.DateTime Ngaysx
        {
            get { return _ngaysx; }
            set { _ngaysx = value; }
        }

        private System.DateTime _ngayhh;

        public System.DateTime Ngayhh
        {
            get { return _ngayhh; }
            set { _ngayhh = value; }
        }

        private string _nuocsx;

        public string Nuocsx
        {
            get { return _nuocsx; }
            set { _nuocsx = value; }
        }

        private double _dongianhap;

        public double Dongianhap
        {
            get { return _dongianhap; }
            set { _dongianhap = value; }
        }

        private double _tien;

        public double Tien
        {
            get { return _tien; }
            set { _tien = value; }
        }

        private int _tinhtrang;

        public int Tinhtrang
        {
            get { return _tinhtrang; }
            set { _tinhtrang = value; }
        }

        private int _slton;

        public int Slton
        {
            get { return _slton; }
            set { _slton = value; }
        }


    }
}
