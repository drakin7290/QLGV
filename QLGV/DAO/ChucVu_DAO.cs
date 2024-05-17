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
    public class ChucVu_DAO
    {
        static SqlConnection con;
        public static List<ChucVu_DTO> LayDSChucVu()
        {
            string sTruyVan = "select * from CHUCVU";
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<ChucVu_DTO> lstChucVu = new List<ChucVu_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ChucVu_DTO cv = new ChucVu_DTO();
                cv.id = dt.Rows[i]["id"].ToString();
                cv.name = dt.Rows[i]["name"].ToString();
                lstChucVu.Add(cv);
            }
            DataProvider.DongKetNoi(con);
            return lstChucVu;
        }

        public static ChucVu_DTO LayChucVu (string id)
        {
            string sTruyVan = string.Format(@"select * from CHUCVU where id='{0}'", id);
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            ChucVu_DTO cv = new ChucVu_DTO();
            cv.id = dt.Rows[0]["id"].ToString();
            cv.name = dt.Rows[0]["name"].ToString();

            DataProvider.DongKetNoi(con);
            return cv;
        }
    }
}
