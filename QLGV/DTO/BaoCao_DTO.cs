using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class BaoCao_DTO
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

        private int _sotietday;
        public int sotietday
        {
            get { return _sotietday; }
            set { _sotietday = value; }
        }

    }
}
