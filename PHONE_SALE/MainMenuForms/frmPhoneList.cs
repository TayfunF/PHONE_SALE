using PHONE_SALE.PhoneForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PHONE_SALE.MainMenuForms
{
    public partial class frmPhoneList : Form
    {
        public frmPhoneList()
        {
            InitializeComponent();
        }

        private void frmPhoneList_Load(object sender, EventArgs e)
        {
            //this.productionsTableAdapter.Fill(this.pHONE_SALEDataSet.Productions);
            Productions productions = new Productions();
            productions.getProductionList(dataGridViewProductions);
        }

        private void dataGridViewProductions_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmUpdatePhone frmUpdatePhone = new frmUpdatePhone();

            if (dataGridViewProductions.Rows.Count > 0)
            {
                frmUpdatePhone.txtId.Text = dataGridViewProductions.CurrentRow.Cells[0].Value.ToString();
                //frmUpdatePhone.cbBrand.Text = dataGridViewProductions.CurrentRow.Cells[1].Value.ToString();
                frmUpdatePhone.lblBrand.Text = dataGridViewProductions.CurrentRow.Cells[1].Value.ToString();
                //frmUpdatePhone.cbModel.Text = dataGridViewProductions.CurrentRow.Cells[2].Value.ToString();
                frmUpdatePhone.lblModel.Text = dataGridViewProductions.CurrentRow.Cells[2].Value.ToString();
                frmUpdatePhone.txtSerialNumber.Text = dataGridViewProductions.CurrentRow.Cells[3].Value.ToString();
                frmUpdatePhone.txtImeiNumber.Text = dataGridViewProductions.CurrentRow.Cells[4].Value.ToString();
                frmUpdatePhone.dtpProductionDate.Text = dataGridViewProductions.CurrentRow.Cells[5].Value.ToString();
                frmUpdatePhone.dtpPurchaseDate.Text = dataGridViewProductions.CurrentRow.Cells[6].Value.ToString();
                frmUpdatePhone.txtPurchasePrice.Text = dataGridViewProductions.CurrentRow.Cells[7].Value.ToString();
                frmUpdatePhone.txtSalePrice.Text = dataGridViewProductions.CurrentRow.Cells[8].Value.ToString();
                frmUpdatePhone.txtAmount.Text = dataGridViewProductions.CurrentRow.Cells[9].Value.ToString();
                frmUpdatePhone.txtVat.Text = dataGridViewProductions.CurrentRow.Cells[10].Value.ToString();
                frmUpdatePhone.txtCPU.Text = dataGridViewProductions.CurrentRow.Cells[11].Value.ToString();
                frmUpdatePhone.txtOS.Text = dataGridViewProductions.CurrentRow.Cells[12].Value.ToString();
                frmUpdatePhone.txtMemory.Text = dataGridViewProductions.CurrentRow.Cells[13].Value.ToString();
                frmUpdatePhone.txtResolution.Text = dataGridViewProductions.CurrentRow.Cells[14].Value.ToString();
                frmUpdatePhone.txtColor.Text = dataGridViewProductions.CurrentRow.Cells[15].Value.ToString();
                frmUpdatePhone.pictureBoxImage.ImageLocation = dataGridViewProductions.CurrentRow.Cells[16].Value.ToString();
            }

            frmUpdatePhone.ShowDialog();
        }
    }
}
