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
    public partial class frmUpdateBrand : Form
    {
        public frmUpdateBrand()
        {
            InitializeComponent();
            lblId.Visible = false;
            txtId.Visible = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                Brands brands = new Brands();
                brands.updateBrand(txtId, txtBrand);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
