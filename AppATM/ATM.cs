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
using System.Security.Cryptography;

namespace AppATM
{
    public partial class ATM : Form
    {
        private readonly TaiKhoanBAL _taiKhoanBAL;
        
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
            rt.Cash += RutTien_Cash;
        }
        private void RutTien_Cash(double cash)
        {
            double balance = double.Parse(txtSoDu.Text) - cash;
            txtSoDu.Text = balance.ToString();
        }

        private void txtPass_Validating(object sender, CancelEventArgs e)
        {
            ValidateInput(sender);
        }
        private bool ValidateInput(object sender)
        {
            TextBox txtInput = (TextBox)sender;
            if (txtInput.Text == "")
            {
                errorProvider1.SetError(txtInput, "Vui lòng nhập thông tin!");
                return false;
            }

            errorProvider1.SetError(txtInput, "");
            return true;
        }
    }
}
