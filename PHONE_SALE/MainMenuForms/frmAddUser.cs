using PHONE_SALE.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PHONE_SALE.MainMenuForms
{
    public partial class frmAddUser : Form
    {
        public frmAddUser()
        {
            InitializeComponent();
        }

        //Kişi Ekleme butonuna tıklanınca
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Users users = new Users();
            users.addUserInSystem(txtUsername, txtPassword, txtFullName, txtPhoneNumber, txtEmail, txtAddress);           
        }

        //PhoneNumber Sadece Rakam girebilme kontrolü
        private void txtPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void frmAddUser_Load(object sender, EventArgs e)
        {
            BackColor = Color.DeepSkyBlue;
        }
    }
}
