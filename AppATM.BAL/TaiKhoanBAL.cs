using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using AppATM.DAL;
using AppATM.DAL.Entities;

namespace AppATM.BAL
{
    public class TaiKhoanBAL
    {
        private readonly TaiKhoanDAL _taiKhoanDAL;
        private TaiKhoan taikhoan;
        public TaiKhoanBAL()
        {
            _taiKhoanDAL = new TaiKhoanDAL();
            taikhoan = new TaiKhoan();
        }

        public bool KiemTraDangNhap(string STK, string password, out string error)
        {
            return _taiKhoanDAL.KiemTraDangNhap(STK, password, out error);
        }
        public double laySoDu()
        {
            return _taiKhoanDAL.laySoDu();
        }
        public string MD5Hash(string text)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            md5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(text));
            byte[] result = md5.Hash;
            StringBuilder strBuilder = new StringBuilder();
            for (int i = 0; i < result.Length; i++)
            {
                strBuilder.Append(result[i].ToString("x2"));
            }
            return strBuilder.ToString();
        }
    }
}
