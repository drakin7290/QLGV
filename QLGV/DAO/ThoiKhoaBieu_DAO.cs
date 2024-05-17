using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class ThoiKhoaBieu_DAO
    {
        static SqlConnection con;
        public static List<LichDayTheoThang_DTO> LayLichDayTheoThang(string id_giaovien, int month)
        {
            string sTruyVan = String.Format ("SELECT ngayday, SUM(tietketthuc - tietbatdau + 1) AS sotiet FROM THOIKHOABIEU WHERE id_giaovien='{0}' and MONTH(ngayday) = '{1}' GROUP BY ngayday", id_giaovien, month);
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<LichDayTheoThang_DTO> lstLichDayTheoThang = new List<LichDayTheoThang_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                LichDayTheoThang_DTO lichday = new LichDayTheoThang_DTO();
                lichday.sotiet = int.Parse(dt.Rows[i]["sotiet"].ToString());
                lichday.ngayday = DateTime.Parse(dt.Rows[i]["ngayday"].ToString());
                lstLichDayTheoThang.Add(lichday);
            }
            DataProvider.DongKetNoi(con);
            return lstLichDayTheoThang;
        }

        public static List<ThoiKhoaBieu_DTO> LayDSThoiKhoaBieu(string id_giaovien, DateTime ngayday)
        {
            string sTruyVan = String.Format("SELECT THOIKHOABIEU.*, MONHOC.name as ten_monhoc FROM THOIKHOABIEU, MONHOC WHERE THOIKHOABIEU.id_monhoc = MONHOC.id and id_giaovien='{0}' and ngayday='{1}' ORDER BY tietbatdau ASC", id_giaovien, ngayday);
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<ThoiKhoaBieu_DTO> lstThoiKhoaBieu = new List<ThoiKhoaBieu_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ThoiKhoaBieu_DTO tkb = new ThoiKhoaBieu_DTO();
                tkb.id = dt.Rows[i]["id"].ToString();
                tkb.tietbatdau = int.Parse(dt.Rows[i]["tietbatdau"].ToString());
                tkb.tietketthuc = int.Parse(dt.Rows[i]["tietketthuc"].ToString());
                tkb.id_giaovien = dt.Rows[i]["id_giaovien"].ToString();
                tkb.id_monhoc = dt.Rows[i]["id_monhoc"].ToString();
                tkb.ten_lop = dt.Rows[i]["ten_lop"].ToString();
                tkb.ten_monhoc = dt.Rows[i]["ten_monhoc"].ToString();
                tkb.ngayday = DateTime.Parse(dt.Rows[i]["ngayday"].ToString());
                lstThoiKhoaBieu.Add(tkb);
            }
            DataProvider.DongKetNoi(con);
            return lstThoiKhoaBieu;
        }

        public static bool ThemTietDay(ThoiKhoaBieu_DTO tkb)
        {
            string sTruyVan = string.Format(@"insert into ThoiKhoaBieu (id_giaovien, id_monhoc, ngayday, tietbatdau, tietketthuc, ten_lop) values ('{0}','{1}','{2}','{3}','{4}','{5}')", tkb.id_giaovien, tkb.id_monhoc, tkb.ngayday, tkb.tietbatdau, tkb.tietketthuc, tkb.ten_lop);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }

        public static bool SuaTietDay(ThoiKhoaBieu_DTO tkb)
        {
            string sTruyVan = string.Format(@"update ThoiKhoaBieu set id_monhoc='{0}', ngayday='{1}', tietbatdau='{2}', tietketthuc='{3}', ten_lop='{4}' where id='{5}'", tkb.id_monhoc, tkb.ngayday, tkb.tietbatdau, tkb.tietketthuc, tkb.ten_lop, tkb.id);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }

        public static bool XoaTietDay(ThoiKhoaBieu_DTO tkb)
        {
            string sTruyVan = string.Format(@"delete from ThoiKhoaBieu where id=N'{0}'", tkb.id);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }
    }
}
