using PHONE_SALE.Forms_Update;
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
    public partial class frmModelList : Form
    {
        public frmModelList()
        {
            InitializeComponent();
        }

        private void frmModelList_Load(object sender, EventArgs e)
        {
            Models models = new Models();
            models.getModelList(dataGridViewModel);
        }

        private void dataGridViewModel_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmUpdateModel frmUpdateModel = new frmUpdateModel();

            if (dataGridViewModel.Rows.Count > 0)
            {
                frmUpdateModel.lblId.Text = dataGridViewModel.CurrentRow.Cells["ModelId"].Value.ToString();
                frmUpdateModel.txtModel.Text = dataGridViewModel.CurrentRow.Cells["Model"].Value.ToString();
            }

            frmUpdateModel.ShowDialog();
        }
    }
}
