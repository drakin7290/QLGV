using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ThoiKhoaBieu_DTO
    {
        private string _id;

        public string id
        {
            get { return _id; }
            set { _id = value; }
        }

        private string _id_giaovien;

        public string id_giaovien
        {
            get { return _id_giaovien; }
            set { _id_giaovien = value; }
        }

        private string _id_monhoc;

        public string id_monhoc
        {
            get { return _id_monhoc; }
            set { _id_monhoc = value; }
        }

        private string _ten_monhoc;

        public string ten_monhoc
        {
            get { return _ten_monhoc; }
            set { _ten_monhoc = value; }
        }


        private DateTime _ngayday;

        public DateTime ngayday
        {
            get { return _ngayday; }
            set { _ngayday = value; }
        }

        private int _tietbatdau;

        public int tietbatdau
        {
            get { return _tietbatdau; }
            set { _tietbatdau = value; }
        }

        private int _tietketthuc;

        public int tietketthuc
        {
            get { return _tietketthuc; }
            set { _tietketthuc = value; }
        }

        private string _ten_lop;

        public string ten_lop
        {
            get { return _ten_lop; }
            set { _ten_lop = value; }
        }
    }
}
