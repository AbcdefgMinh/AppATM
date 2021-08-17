using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using AppATM.Helpers;

namespace AppATM
{
    public partial class RutTien : Form
    {
        public event CashDelegate Cash;
        public RutTien()
        {
            InitializeComponent();
        }
        private void btnOk_Click(object sender, EventArgs e)
        {
            double cash = double.Parse(txtSoTienDu.Text);
            Cash(cash);
            this.Close();
        }

        private void txtSoTienDu_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
