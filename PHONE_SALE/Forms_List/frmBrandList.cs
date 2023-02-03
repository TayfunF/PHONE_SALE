using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PHONE_SALE.Forms_List
{
    public partial class frmBrandList : Form
    {
        public frmBrandList()
        {
            InitializeComponent();
        }

        private void frmBrandList_Load(object sender, EventArgs e)
        {
            Brands brands = new Brands();
            brands.getBrandList(dataGridViewBrand);
        }

        private void dataGridViewBrand_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmUpdateBrand frmUpdateBrand = new frmUpdateBrand();

            if (dataGridViewBrand.Rows.Count > 0)
            {
                frmUpdateBrand.txtId.Text = dataGridViewBrand.CurrentRow.Cells[0].Value.ToString();
                frmUpdateBrand.txtBrand.Text = dataGridViewBrand.CurrentRow.Cells[1].Value.ToString();
            }

            frmUpdateBrand.ShowDialog();
        }
    }
}
