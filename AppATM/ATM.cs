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
using AppATM.DAL.Entities;

namespace AppATM
{
    public partial class ATM : Form
    {
        public event CashDelegate Cash;
        private readonly TaiKhoanBAL _taiKhoanBAL;
        TaiKhoan taiKhoan = null;
        public ATM()
        {
            InitializeComponent();
            taiKhoan = new TaiKhoan();
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
            string password =_taiKhoanBAL.MD5Hash(txtMatKhau.Text).Trim();
            if (userName == "" || password == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ Tên đăng nhập & Mật khẩu!");

                return;
            }
            using (var dbcontext = new AppRutTien())
            {
                //string error;
                taiKhoan = dbcontext.TaiKhoans.Where(tk => tk.STK == userName && tk.PassWord == password).FirstOrDefault();

                if (taiKhoan !=null)
                {
                    MessageBox.Show("Đăng nhập thành công!");

                    txtSoDu.Text = taiKhoan.SoTien.ToString();
                    txtSoDu.Visible = true;
                    lblSoDu.Visible = true;
                    btnRutTien.Visible = true;
                }
                else
                {
                    MessageBox.Show("Đăng nhập sai\n" );
                }

            }
            

        }
        
        private void btnRutTien_click(object sender, EventArgs e)
        {
            RutTien rt = new RutTien(taiKhoan);
           
            rt.Cash += RutTien_Cash;
            rt.Show();
        }
        private void RutTien_Cash(double cash)
        {
            //double balance = double.Parse(txtSoDu.Text) - cash;
            txtSoDu.Text = cash.ToString();
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
