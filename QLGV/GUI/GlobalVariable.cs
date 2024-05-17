using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace GUI
{
    static class GlobalVariable
    {
        private static TaiKhoan_DTO _tk;

        public static TaiKhoan_DTO tk
        {
            get { return _tk; }
            set { _tk = value; }
        }
    }
}
