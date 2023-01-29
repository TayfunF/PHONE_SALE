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

        private void FrmMainMenu_Load(object sender, EventArgs e)
        {
            panelMid.BackColor = Color.SkyBlue;
            this.MaximizeBox = false;
        }

        //Container MdiParent Form Method
        private void showListTypeForm(Form form)
        {
            panelMid.Controls.Clear();
            form.MdiParent = this;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            form.BackColor = Color.DeepSkyBlue;
            form.StartPosition = FormStartPosition.CenterParent;
            form.WindowState = FormWindowState.Normal;
            panelMid.Controls.Add(form);
            form.Show();
        }

        private void showAddTypeForm(Form form)
        {
            form.MaximizeBox = false;
            form.MinimizeBox = false;
            form.BackColor = Color.DeepSkyBlue;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.ShowDialog();
        }

        //Telefon Ekle Butonu
        private void ToolStripMenuItemAddPhone_Click(object sender, EventArgs e) => showAddTypeForm(new frmAddPhone());

        //Telefon Listesi Butonu
        private void ToolStripMenuItemPhoneList_Click(object sender, EventArgs e) => showListTypeForm(new frmPhoneList());

        //Kullanıcı Ekle Butonu
        private void ToolStripMenuItemAddUser_Click(object sender, EventArgs e) => showAddTypeForm(new frmAddUser());

        //Kullanıcı Listesi Butonu
        private void ToolStripMenuItemUserList_Click(object sender, EventArgs e) => showListTypeForm(new frmUserList());

        //Müşteri Ekle Butonu
        private void ToolStripMenuItemAddCustomer_Click(object sender, EventArgs e) => showAddTypeForm(new frmAddCustomer());

        //Müşteri Listesi Butonu
        private void ToolStripMenuItemCustomerList_Click(object sender, EventArgs e) => showListTypeForm(new frmCustomerList());

        //Satış Yap Butonu
        private void ToolStripMenuItemMakeSale_Click(object sender, EventArgs e) => showAddTypeForm(new frmMakeSale());

        //Satış Listesi Butonu
        private void ToolStripMenuItemSaleList_Click(object sender, EventArgs e) => showListTypeForm(new frmSaleList());

        //Çıkış Yap Butonu
        private void ToolStripMenuItemExit_Click(object sender, EventArgs e) => General._CustomExitMessage();

        //Marka Ekle Butonu
        private void ToolStripMenuItemmarkaEkle_Click(object sender, EventArgs e) => showAddTypeForm(new frmAddBrand());
    }
}
