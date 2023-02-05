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
        General general;

        public frmModelList()
        {
            InitializeComponent();
        }

        private void frmModelList_Load(object sender, EventArgs e)
        {
            try
            {
                general = new General();
                general.getList(dataGridViewModel, "Select * from vw_getBrandModelList");
            }
            catch (Exception ex)
            {
                General._MyCustomErrorMessage(ex);
            }
        }

        private void dataGridViewModel_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                frmUpdateModel frmUpdateModel = new frmUpdateModel();

                if (dataGridViewModel.Rows.Count > 0)
                {
                    frmUpdateModel.lblId.Text = dataGridViewModel.CurrentRow.Cells["ModelId"].Value.ToString();
                    frmUpdateModel.txtModel.Text = dataGridViewModel.CurrentRow.Cells["Model"].Value.ToString();
                }

                frmUpdateModel.ShowDialog();
            }
            catch (Exception ex)
            {
                General._MyCustomErrorMessage(ex);
            }
        }
    }
}
