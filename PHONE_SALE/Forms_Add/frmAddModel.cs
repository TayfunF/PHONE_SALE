using PHONE_SALE.MyClass;
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
    public partial class frmAddModel : Form
    {
        public frmAddModel()
        {
            InitializeComponent();
        }

        private void frmAddModel_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'brand_Model_DataSet.Brand' table. You can move, or remove it, as needed.
            this.brandTableAdapter.Fill(this.brand_Model_DataSet.Brand);

        }

        //Model Ekleme Methodu
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Models models = new Models();
            models.addModel(cbBrand,txtModel);
        }
    }
}
