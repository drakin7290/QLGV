using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class ThoiKhoaBieu_BUS
    {
        public static List<LichDayTheoThang_DTO> LayLichDayTheoThang(string id_giaovien, int month)
        {
            return ThoiKhoaBieu_DAO.LayLichDayTheoThang(id_giaovien, month);
        }

        public static List<ThoiKhoaBieu_DTO> LayDSThoiKhoaBieu (string id_giaovien, DateTime ngayday)
        {
            return ThoiKhoaBieu_DAO.LayDSThoiKhoaBieu(id_giaovien, ngayday);
        }

        public static bool ThemTietDay(ThoiKhoaBieu_DTO tkb)
        {
            return ThoiKhoaBieu_DAO.ThemTietDay(tkb);
        }

        public static bool SuaTietDay(ThoiKhoaBieu_DTO tkb)
        {
            return ThoiKhoaBieu_DAO.SuaTietDay(tkb);
        }

        public static bool XoaTietDay(ThoiKhoaBieu_DTO tkb)
        {
            return ThoiKhoaBieu_DAO.XoaTietDay(tkb);
        }
    }
}
