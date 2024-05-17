using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class GiaoVien_BUS
    {
        public static List<GiaoVien_DTO> LayDSGiaoVien(string filterName = "", string filterValue = "")
        {
            return GiaoVien_DAO.LayDSGiaoVien(filterName, filterValue);
        }

        
        public static GiaoVien_DTO LayThongTinGiaoVien(string id)
        {
            return GiaoVien_DAO.LayThongTinGiaoVien(id);
        }

        public static bool ThemGiaoVien(GiaoVien_DTO gv)
        {
            return GiaoVien_DAO.ThemGiaoVien(gv);
        }

        public static bool XoaGiaoVien (GiaoVien_DTO gv)
        {
            return GiaoVien_DAO.XoaGiaoVien(gv);
        }

        public static bool SuaGiaoVien (GiaoVien_DTO gv)
        {
            return GiaoVien_DAO.SuaGiaoVien(gv);
        }
    }
}
