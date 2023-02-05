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

namespace PHONE_SALE
{
    public partial class frmAddUser : Form
    {
        Users users;

        public frmAddUser()
        {
            InitializeComponent();
        }

        //Kişi Ekleme butonuna tıklanınca
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                users = new Users();
                bool isNoRegistered = users.alreadyRegisteredUser(txtUsername);
                if (isNoRegistered)
                    users.addUserInSystem(txtUsername, txtPassword, txtFullName, txtPhoneNumber, txtEmail, txtAddress);
                else General._ShowCustomMyMessage("Kullanıcı zaten sisteme kayıtlı !", "Uyarı", General._MessageTip._warning, General._MessageCategory._information);
            }
            catch (Exception ex)
            {
                General._MyCustomErrorMessage(ex);
            }
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
