using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pharmacy.Info
{
    public class KhoInfo
    {
        private int _makho;

        public int Makho
        {
            get { return _makho; }
            set { _makho = value; }
        }

        private string _ten;

        public string Ten
        {
            get { return _ten; }
            set { _ten = value; }
        }

        private string _diachi;

        public string Diachi
        {
            get { return _diachi; }
            set { _diachi = value; }
        }

        private string _dienthoai;

        public string Dienthoai
        {
            get { return _dienthoai; }
            set { _dienthoai = value; }
        }

        private System.DateTime _ngaylap;

        public System.DateTime Ngaylap
        {
            get { return _ngaylap; }
            set { _ngaylap = value; }
        }

        private int _tinhtrang;

        public int Tinhtrang
        {
            get { return _tinhtrang; }
            set { _tinhtrang = value; }
        }

        private string _sodk;

        public string Sodk
        {
            get { return _sodk; }
            set { _sodk = value; }
        }


    }
}
