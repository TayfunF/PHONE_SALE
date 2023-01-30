using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PHONE_SALE.Forms_Update
{
    public partial class frmUpdateModel : Form
    {
        public frmUpdateModel()
        {
            InitializeComponent();
        }

        private void frmUpdateModel_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'brand_Model_DataSet.Model' table. You can move, or remove it, as needed.
            this.modelTableAdapter.Fill(this.brand_Model_DataSet.Model);
            // TODO: This line of code loads data into the 'brand_Model_DataSet.Brand' table. You can move, or remove it, as needed.
            this.brandTableAdapter.Fill(this.brand_Model_DataSet.Brand);

        }
    }
}
