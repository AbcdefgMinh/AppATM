
using AppATM.BAL;
using AppATM.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
namespace AppATM
{
    public partial class ATM : Form
    {
        private readonly TaiKhoanBAL _taiKhoanBAL;
        public event LoginSucessDeligate loginSucess;
        public ATM()
        {
            InitializeComponent();
            _taiKhoanBAL = new TaiKhoanBAL();
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //kiem tra thông tin hợp lệ
            
            
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string userName = txtUserName.Text.Trim();
            string password = txtMatKhau.Text.Trim();
            if (userName == "" || password == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ Tên đăng nhập & Mật khẩu!");

                return;
            }
            string error;
            
            if (_taiKhoanBAL.KiemTraDangNhap(userName, password, out error))
            {
                MessageBox.Show("Đăng nhập thành công!");
                //loginSucess();
                //this.Close();
                txtSoDu.Text = _taiKhoanBAL.laySoDu().ToString();
                txtSoDu.Visible = true;
                btnRutTien.Visible = true;


            }
            else
            {
                MessageBox.Show("Đăng nhập sai\n" + error);
            }

        }
        
        private void btnRutTien_click(object sender, EventArgs e)
        {
            RutTien rt = new RutTien();
            rt.Show();
            rt.cashWithdrawal += FrmWithdraw_cashWithdrawal1;
        }
        private void FrmWithdraw_cashWithdrawal1(double cash)
        {
            double balance = double.Parse(txtSoDu.Text) - cash;
            txtSoDu.Text = balance.ToString();
        }
    }
}
