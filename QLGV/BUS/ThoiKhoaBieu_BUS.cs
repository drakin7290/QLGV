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

        private static bool ProveData (ThoiKhoaBieu_DTO tkb)
        {
            List<ThoiKhoaBieu_DTO> lstTKB = LayDSThoiKhoaBieu(tkb.id_giaovien, tkb.ngayday);
            if (lstTKB != null)
            {
                for (int i=0; i<lstTKB.Count(); i++)
                {
                    ThoiKhoaBieu_DTO row = lstTKB[i];
                    Boolean isSelf = row.id == tkb.id;
                    if (tkb.tietbatdau >= row.tietbatdau && tkb.tietbatdau <= row.tietketthuc && !isSelf)
                    {
                        return false;
                    }
                    if (tkb.tietketthuc >= row.tietbatdau && tkb.tietketthuc <= row.tietketthuc && !isSelf)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public static List<ThoiKhoaBieu_DTO> LayDSThoiKhoaBieu (string id_giaovien, DateTime ngayday)
        {
            return ThoiKhoaBieu_DAO.LayDSThoiKhoaBieu(id_giaovien, ngayday);
        }

        public static bool ThemTietDay(ThoiKhoaBieu_DTO tkb)
        {
            if (ProveData(tkb))
            {
                return ThoiKhoaBieu_DAO.ThemTietDay(tkb);
            }
            return false;
        }

        public static bool SuaTietDay(ThoiKhoaBieu_DTO tkb)
        {
            if (ProveData(tkb))
            {
                return ThoiKhoaBieu_DAO.SuaTietDay(tkb);
            }
            return false;
        }

        public static bool XoaTietDay(ThoiKhoaBieu_DTO tkb)
        {
            return ThoiKhoaBieu_DAO.XoaTietDay(tkb);
        }
    }
}
