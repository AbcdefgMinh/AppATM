using AppATM.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SqlProviderServices = System.Data.Entity.SqlServer.SqlProviderServices;

namespace AppATM.DAL
{
    public class TaiKhoanDAL
    {
        public bool KiemTraDangNhap(string stk, string password, out string error)
        {
            error = string.Empty;
            try
            {
                using (var dbcontext = new AppRutTien())
                {
                    return dbcontext.TaiKhoans.Any(tk => tk.STK == stk && tk.PassWord == password);
                }
            }
            catch (Exception exception)
            {
                error = exception.Message;
                return false;
            }
        }
        public double laySoDu()
        {
            using (var dbcontext = new AppRutTien())
            {
                return double.Parse(dbcontext.TaiKhoans.Select(tk => tk.SoTien).FirstOrDefault());
            }
        }
    }
}
