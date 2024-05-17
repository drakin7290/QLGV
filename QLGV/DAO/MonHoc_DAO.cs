using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class MonHoc_DAO
    {
        static SqlConnection con;
        public static List<MonHoc_DTO> LayDSMonHoc()
        {
            string sTruyVan = "select * from MONHOC";
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<MonHoc_DTO> lstMonHoc = new List<MonHoc_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                MonHoc_DTO mh = new MonHoc_DTO();
                mh.id = dt.Rows[i]["id"].ToString();
                mh.name = dt.Rows[i]["name"].ToString();
                lstMonHoc.Add(mh);
            }
            DataProvider.DongKetNoi(con);
            return lstMonHoc;
        }

        public static bool ThemMonHoc (MonHoc_DTO mh)
        {
            string sTruyVan = string.Format(@"insert into MONHOC (name) values (N'{0}')", mh.name);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }

        public static bool SuaMonHoc (MonHoc_DTO mh)
        {
            string sTruyVan = string.Format(@"update MONHOC set name=N'{0}' where id=N'{1}'", mh.name, mh.id);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }

        public static bool XoaMonHoc(MonHoc_DTO mh)
        {
            string sTruyVan = string.Format(@"delete from MonHoc where id=N'{0}'", mh.id);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }
    }
}
