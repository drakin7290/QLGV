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
    public class GiaoVien_DAO
    {
        static SqlConnection con;
        public static List<GiaoVien_DTO> LayDSGiaoVien(string filterName="", string filterValue="")
        {
            string filterString = filterName != "" ? string.Format(@" and GIAOVIEN.{0} like N'%{1}%'", filterName, filterValue) : "";
            string sTruyVan = "SELECT GIAOVIEN.*, MONHOC.name as name_monhoc FROM GIAOVIEN, MONHOC WHERE GIAOVIEN.id_monhoc = MONHOC.id" + filterString;
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<GiaoVien_DTO> lstGiaoVien = new List<GiaoVien_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                GiaoVien_DTO gv = new GiaoVien_DTO();
                gv.id = dt.Rows[i]["id"].ToString();
                gv.name = dt.Rows[i]["name"].ToString();
                gv.gioitinh = dt.Rows[i]["gioitinh"].ToString();
                gv.diachi = dt.Rows[i]["diachi"].ToString();
                gv.sodienthoai = dt.Rows[i]["sodienthoai"].ToString();
                gv.luong = int.Parse(dt.Rows[i]["luong"].ToString());
                gv.ngaysinh = DateTime.Parse(dt.Rows[i]["ngaysinh"].ToString());
                gv.id_monhoc = dt.Rows[i]["id_monhoc"].ToString();
                gv.name_monhoc = dt.Rows[i]["name_monhoc"].ToString();
                lstGiaoVien.Add(gv);
            }
            DataProvider.DongKetNoi(con);
            return lstGiaoVien;
        }

        public static GiaoVien_DTO LayThongTinGiaoVien(string id)
        {
            string sTruyVan = string.Format(@"SELECT GIAOVIEN.*, MONHOC.name as name_monhoc FROM GIAOVIEN, MONHOC WHERE GIAOVIEN.id_monhoc = MONHOC.id and GIAOVIEN.id = '{0}'", id);
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            GiaoVien_DTO gv = new GiaoVien_DTO();
            gv.id = dt.Rows[0]["id"].ToString();
            gv.name = dt.Rows[0]["name"].ToString();
            gv.gioitinh = dt.Rows[0]["gioitinh"].ToString();
            gv.diachi = dt.Rows[0]["diachi"].ToString();
            gv.sodienthoai = dt.Rows[0]["sodienthoai"].ToString();
            gv.luong = int.Parse(dt.Rows[0]["luong"].ToString());
            gv.ngaysinh = DateTime.Parse(dt.Rows[0]["ngaysinh"].ToString());
            gv.id_monhoc = dt.Rows[0]["id_monhoc"].ToString();
            gv.name_monhoc = dt.Rows[0]["name_monhoc"].ToString();

            DataProvider.DongKetNoi(con);
            return gv;
        }


        public static bool ThemGiaoVien(GiaoVien_DTO gv)
        {
            string sTruyVan = string.Format(@"insert into GiaoVien (name, ngaysinh, sodienthoai, gioitinh, diachi, luong, id_monhoc) values (N'{0}', '{1}', '{2}', N'{3}', '{4}', {5}, '{6}')", gv.name, gv.ngaysinh, gv.sodienthoai, gv.gioitinh, gv.diachi, gv.luong, gv.id_monhoc);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }

        public static bool XoaGiaoVien(GiaoVien_DTO gv)
        {
            string sTruyVan = string.Format(@"delete from GiaoVien where id=N'{0}'", gv.id);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }

        public static bool SuaGiaoVien(GiaoVien_DTO gv)
        {
            string sTruyVan = string.Format(@"update GIAOVIEN set name=N'{0}', gioitinh=N'{1}', ngaysinh='{2}', sodienthoai='{3}', diachi=N'{4}', luong='{5}', id_monhoc='{6}' where id='{7}'", gv.name, gv.gioitinh, gv.ngaysinh, gv.sodienthoai, gv.diachi, gv.luong, gv.id_monhoc, gv.id);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }
    }
}
