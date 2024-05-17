using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class MonHoc_BUS
    {
        public static List<MonHoc_DTO> LayDSMonHoc()
        {
            return MonHoc_DAO.LayDSMonHoc();
        }

        public static bool ThemMonHoc(MonHoc_DTO mh)
        {
            return MonHoc_DAO.ThemMonHoc(mh);
        }

        public static bool SuaMonHoc(MonHoc_DTO mh)
        {
            return MonHoc_DAO.SuaMonHoc(mh);
        }

        public static bool XoaMonHoc(MonHoc_DTO mh)
        {
            return MonHoc_DAO.XoaMonHoc(mh);
        }
    }
}
