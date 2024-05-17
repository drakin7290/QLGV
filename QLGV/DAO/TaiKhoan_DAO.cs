using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DTO;

namespace DAO
{
    public class TaiKhoan_DAO
    {
        static SqlConnection con;

        public static List<TaiKhoan_DTO> LayDSTaiKhoan ()
        {
            string sTruyVan = "SELECT TAIKHOAN.*, CHUCVU.name as ten_chucvu FROM TAIKHOAN, CHUCVU WHERE TAIKHOAN.chucvu_id = CHUCVU.id";
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<TaiKhoan_DTO> lstTaiKhoan = new List<TaiKhoan_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                TaiKhoan_DTO tk = new TaiKhoan_DTO();
                tk.id = dt.Rows[i]["id"].ToString();
                tk.taikhoan = dt.Rows[i]["taikhoan"].ToString();
                tk.chucvu_id = dt.Rows[i]["chucvu_id"].ToString();
                tk.ten_chucvu = dt.Rows[i]["ten_chucvu"].ToString();
                lstTaiKhoan.Add(tk);
            }
            DataProvider.DongKetNoi(con);
            return lstTaiKhoan;
        }
        public static TaiKhoan_DTO LayTaiKhoan(string taikhoan, string matkhau)
        {
            string sTruyVan = string.Format(@"select * from TAIKHOAN where taikhoan=N'{0}' and matkhau='{1}'", taikhoan, matkhau);
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            TaiKhoan_DTO tk = new TaiKhoan_DTO();
            tk.id = dt.Rows[0]["id"].ToString();
            tk.taikhoan = dt.Rows[0]["taikhoan"].ToString();
            tk.matkhau = dt.Rows[0]["matkhau"].ToString();
            tk.chucvu_id = dt.Rows[0]["chucvu_id"].ToString();

            DataProvider.DongKetNoi(con);
            return tk;
        }

        public static bool ThemTaiKhoan(TaiKhoan_DTO tk)
        {
            string sTruyVan = string.Format(@"insert into TAIKHOAN (taikhoan, chucvu_id) values ('{0}','{1}')", tk.taikhoan, tk.chucvu_id);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }

        public static bool SuaTaiKhoan(TaiKhoan_DTO tk)
        {
            string sTruyVan = string.Format(@"update TAIKHOAN set taikhoan='{0}', chucvu_id='{1}' where id=N'{2}'", tk.taikhoan, tk.chucvu_id, tk.id);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }

        public static bool DoiMatKhau(TaiKhoan_DTO tk)
        {
            string sTruyVan = string.Format(@"update TAIKHOAN set matkhau='{0}' where id='{1}'", tk.matkhau, tk.id);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }

        public static bool XoaTaiKhoan(TaiKhoan_DTO tk)
        {
            string sTruyVan = string.Format(@"delete from TAIKHOAN where id='{0}'", tk.id);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }

    }
}
