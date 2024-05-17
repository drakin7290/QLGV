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
    public class ChucVu_BUS
    {
        public static List<ChucVu_DTO> LayDSChucVu()
        {
            return ChucVu_DAO.LayDSChucVu();
        }

        public static ChucVu_DTO LayChucVu(string id)
        {
            return ChucVu_DAO.LayChucVu(id);
        }
    }
}
