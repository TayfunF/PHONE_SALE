using PHONE_SALE.Helpers;
using PHONE_SALE.MainMenuForms;
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
    public partial class frmMainMenu : Form
    {
        public frmMainMenu()
        {
            InitializeComponent();
        }

        private void FrmMainMenu_Load(object sender, EventArgs e) => panelMid.BackColor = Color.SkyBlue;

        //Container MdiParent Form Method
        private void showForm(Form form)
        {
            panelMid.Controls.Clear();
            form.MdiParent = this;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            form.BackColor = Color.DeepSkyBlue;
            panelMid.Controls.Add(form);
            form.Show();
        }

        //Telefon Ekle Butonu
        private void btnAddPhone_Click(object sender, EventArgs e) => showForm(new frmAddPhone());

        //Telefon Listesi Butonu
        private void btnPhoneList_Click(object sender, EventArgs e) => showForm(new frmPhoneList());

        //Kullanıcı Ekle Butonu
        private void btnAddUser_Click(object sender, EventArgs e) => showForm(new frmAddUser());

        //Kullanıcı Listesi Butonu
        private void btnUserList_Click(object sender, EventArgs e) => showForm(new frmUserList());

        //Müşteri Ekle Butonu
        private void btnAddCustomer_Click(object sender, EventArgs e) => showForm(new frmAddCustomer());

        //Müşsteri Listesi Butonu
        private void btnCustomerList_Click(object sender, EventArgs e) => showForm(new frmCustomerList());

        //Satış Yap Butonu
        private void btnSale_Click(object sender, EventArgs e) => showForm(new frmSaleList());

        //Satış Listesi Butonu
        private void btnSaleList_Click(object sender, EventArgs e) => showForm(new frmSaleList());

        private void btnExit_Click(object sender, EventArgs e)
        {
            General._CustomExitMessage();
        }
    }
}
