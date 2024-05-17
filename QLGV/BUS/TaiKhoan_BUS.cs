using DTO;
using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class TaiKhoan_BUS
    {
        static string GetMd5Hash(MD5 md5Hash, string input)
        {

            // Convert the input string to a byte array and compute the hash.
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            // Create a new Stringbuilder to collect the bytes
            // and create a string.
            StringBuilder sBuilder = new StringBuilder();

            // Loop through each byte of the hashed data 
            // and format each one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            // Return the hexadecimal string.
            return sBuilder.ToString();
        }

        public static TaiKhoan_DTO LayTaiKhoan(string taikhoan, string matkhau)
        {
            MD5 md5Hash = MD5.Create();
            string matkhau_mahoa = GetMd5Hash(md5Hash, matkhau);
            return TaiKhoan_DAO.LayTaiKhoan(taikhoan, matkhau_mahoa);
        }

        public static List<TaiKhoan_DTO> LayDSTaiKhoan()
        {
            return TaiKhoan_DAO.LayDSTaiKhoan();
        }

        public static bool ThemTaiKhoan(TaiKhoan_DTO tk)
        {
            return TaiKhoan_DAO.ThemTaiKhoan(tk);
        }

        public static bool SuaTaiKhoan(TaiKhoan_DTO tk)
        {
            return TaiKhoan_DAO.SuaTaiKhoan(tk);
        }

        public static bool DoiMatKhau(TaiKhoan_DTO tk)
        {
            MD5 md5Hash = MD5.Create();
            string matkhau_mahoa = GetMd5Hash(md5Hash, tk.matkhau);
            tk.matkhau = matkhau_mahoa;
            return TaiKhoan_DAO.DoiMatKhau(tk);
        }

        public static bool XoaTaiKhoan(TaiKhoan_DTO tk)
        {
            return TaiKhoan_DAO.XoaTaiKhoan(tk);
        }
    }
}
