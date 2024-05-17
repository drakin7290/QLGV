using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TaiKhoan_DTO
    {

        private string _id;

        public string id
        {
            get { return _id; }
            set { _id = value; }
        }

        private string _taikhoan;

        public string taikhoan
        {
            get { return _taikhoan; }
            set { _taikhoan = value; }
        }

        private string _matkhau;

        public string matkhau
        {
            get { return _matkhau; }
            set { _matkhau = value; }
        }

        private string _chucvu_id;

        public string chucvu_id
        {
            get { return _chucvu_id; }
            set { _chucvu_id = value; }
        }
        private string _ten_chucvu;
        public string ten_chucvu
        {
            get { return _ten_chucvu; }
            set { _ten_chucvu = value; }
        }
    }
}
