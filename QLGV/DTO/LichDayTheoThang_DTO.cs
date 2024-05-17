using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LichDayTheoThang_DTO
    {
        private int _sotiet;

        public int sotiet
        {
            get { return _sotiet; }
            set { _sotiet = value; }
        }

        private DateTime _ngayday;

        public DateTime ngayday
        {
            get { return _ngayday; }
            set { _ngayday = value; }
        }
    }
}
