﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pharmacy.ThuChi.Info
{
  public class PhieuChi
    {


        private int _ma;

        public int Ma
        {
            get { return _ma; }
            set { _ma = value; }
        }

        private int _maNCC;

        public int MaNCC
        {
            get { return _maNCC; }
            set { _maNCC = value; }
        }

        private System.DateTime _ngayChi;

        public System.DateTime NgayChi
        {
            get { return _ngayChi; }
            set { _ngayChi = value; }
        }

        private string _lyDo;

        public string LyDo
        {
            get { return _lyDo; }
            set { _lyDo = value; }
        }

        private double _tongTien;

        public double TongTien
        {
            get { return _tongTien; }
            set { _tongTien = value; }
        }

        private string _kemTheo;

        public string KemTheo
        {
            get { return _kemTheo; }
            set { _kemTheo = value; }
        }

        private string _no;

        public string No
        {
            get { return _no; }
            set { _no = value; }
        }

        private string _co;

        public string Co
        {
            get { return _co; }
            set { _co = value; }
        }
        private string _ghichu;

        public string GhiChu
        {
            get { return _ghichu; }
            set { _ghichu = value; }
        }
    }
}
