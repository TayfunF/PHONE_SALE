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
    public partial class frmCustomerList : Form
    {
        General general;
        frmUpdateCustomer frmUpdateCustomer;

        public frmCustomerList()
        {
            InitializeComponent();
        }

        private void frmCustomerList_Load(object sender, EventArgs e)
        {
            try
            {
                general = new General();
                general.getList(dataGridViewCustomer, "Select * from vw_getCustomerList");
            }
            catch (Exception ex)
            {
                General._MyCustomErrorMessage(ex);
            }
        }

        private void dataGridViewCustomer_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                frmUpdateCustomer = new frmUpdateCustomer();

                if (dataGridViewCustomer.Rows.Count > 0)
                {
                    frmUpdateCustomer.lblId.Text = dataGridViewCustomer.CurrentRow.Cells["Id"].Value.ToString();
                    frmUpdateCustomer.txtFullName.Text = dataGridViewCustomer.CurrentRow.Cells["AdSoyad"].Value.ToString();
                    frmUpdateCustomer.maskedtxtPhoneNumber.Text = dataGridViewCustomer.CurrentRow.Cells["Telefon"].Value.ToString();
                    frmUpdateCustomer.txtEmail.Text = dataGridViewCustomer.CurrentRow.Cells["Eposta"].Value.ToString();
                    frmUpdateCustomer.txtAddress.Text = dataGridViewCustomer.CurrentRow.Cells["Adres"].Value.ToString();
                }

                frmUpdateCustomer.ShowDialog();
            }
            catch (Exception ex)
            {
                General._MyCustomErrorMessage(ex);
            }
        }
    }
}
