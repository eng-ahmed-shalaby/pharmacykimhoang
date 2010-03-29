using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pharmacy.QuanLy.Info
{
    class KhuyenMaiInfo
    {

        private int _Ma;

        public int Ma
        {
            get { return _Ma; }
            set { _Ma = value; }
        }
        private int _MaHH;

        public int MaHH
        {
            get { return _MaHH; }
            set { _MaHH = value; }
        }

        private int _SL;

        public int SL
        {
            get { return _SL; }
            set { _SL = value; }
        }
        private int _MaHHKM;

        public int MaHHKM
        {
            get { return _MaHHKM; }
            set { _MaHHKM = value; }
        }

        private int _SLKM;

        public int SLKM
        {
            get { return _SLKM; }
            set { _SLKM = value; }
        }
        private DateTime _NgayKM;

        public DateTime NgayKM
        {
            get { return _NgayKM; }
            set { _NgayKM = value; }
        }
        private int _TrangThai;

        public int TrangThai
        {
            get { return _TrangThai; }
            set { _TrangThai = value; }
        }
    }
}
