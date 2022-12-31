using PHONE_SALE.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PHONE_SALE
{
    public partial class frmLogin : Form
    {
        Users users = new Users();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            MinimizeBox = false;
            lblDate.Text = DateTime.Now.ToString("dd.MM.yyyy");
            timerClock.Start();
        }


        private void timerClock_Tick(object sender, EventArgs e)
        {
            General._MyCustomerTimer(lblClock);
        }

        private void cbShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShowPassword.Checked)
            {
                txtPassword.PasswordChar = default;
                cbShowPassword.Text = "Gizle";
            }
            else
            {
                txtPassword.PasswordChar = '*';
                cbShowPassword.Text = "Göster";
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {            
            users.userEntry(txtUsername, txtPassword);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            General._CustomExitMessage();
        }
    }
}
