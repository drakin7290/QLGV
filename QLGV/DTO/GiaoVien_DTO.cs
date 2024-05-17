using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class GiaoVien_DTO
    {
        private string _id;

        public string id
        {
            get { return _id; }
            set { _id = value; }
        }

        private string _name;

        public string name
        {
            get { return _name; }
            set { _name = value; }
        }

        private string _gioitinh;

        public string gioitinh
        {
            get { return _gioitinh; }
            set { _gioitinh = value; }
        }

        private DateTime _ngaysinh;

        public DateTime ngaysinh
        {
            get { return _ngaysinh; }
            set { _ngaysinh = value; }
        }

        private string _sodienthoai;

        public string sodienthoai
        {
            get { return _sodienthoai; }
            set { _sodienthoai = value; }
        }


        private string _diachi;

        public string diachi
        {
            get { return _diachi; }
            set { _diachi = value; }
        }


        private int _luong;

        public int luong
        {
            get { return _luong; }
            set { _luong = value; }
        }

        private string _id_monhoc;
        public string id_monhoc
        {
            get { return _id_monhoc; }
            set { _id_monhoc = value; }
        }

        private string _name_monhoc;

        public string name_monhoc
        {
            get { return _name_monhoc; }
            set { _name_monhoc = value; }
        }
    }
}
