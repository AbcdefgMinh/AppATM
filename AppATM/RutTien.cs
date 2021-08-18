using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppATM.DAL.Entities;
using AppATM.Helpers;

namespace AppATM
{
    public partial class RutTien : Form
    {
        TaiKhoan taiKhoan; 
        public event CashDelegate Cash;
        public RutTien()
        {
            InitializeComponent();
        }
        public RutTien(TaiKhoan taiKhoan)
        {
            InitializeComponent();
            this.taiKhoan = taiKhoan;
        }
        private void btnOk_Click(object sender, EventArgs e)
        {
            //double sotientk = double.Parse(taiKhoan.SoTien);
            double sotienrut = double.Parse(txtSoTienRut.Text);
            if ((taiKhoan.SoTien - sotienrut)  <= 50000)
            {
                MessageBox.Show("Số dư không đủ !");
                return;
            }
            using (var dbcontext = new AppRutTien())
            {
                TaiKhoan tk = dbcontext.TaiKhoans.Find(this.taiKhoan.id);
                tk.SoTien -= sotienrut;
                dbcontext.SaveChanges();
                taiKhoan = tk;
                Cash((double)tk.SoTien);

            }
            
            
        }

        private void txtSoTienDu_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
