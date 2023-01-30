using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PHONE_SALE
{
    public partial class frmUpdatePhone : Form
    {
        public frmUpdatePhone()
        {
            InitializeComponent();
            lblId.Visible = false;
            txtId.Visible = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void btnFileDialog_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog1 = new OpenFileDialog();
                //openFileDialog.Filter = "Resim Dosyası |*.jpg;*.nef;*.png| Video|*.avi| Tüm Dosyalar |*.*";
                openFileDialog1.Filter = "Resim Dosyası |*.jpg;*.png";
                openFileDialog1.Title = "Ürüm Resmi Seç";
                openFileDialog1.ShowDialog();
                pictureBoxImage.ImageLocation = openFileDialog1.FileName;
            }
            catch (Exception ex)
            {
                General._ShowCustomMyMessage(ex.Message, "Hata", General._MessageTip._error, General._MessageCategory._DB);
            }
        }

        private void frmUpdatePhone_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: This line of code loads data into the 'brand_Model_DataSet.Model' table. You can move, or remove it, as needed.
                this.modelTableAdapter.Fill(this.brand_Model_DataSet.Model);
                // TODO: This line of code loads data into the 'brand_Model_DataSet.Brand' table. You can move, or remove it, as needed.
                this.brandTableAdapter.Fill(this.brand_Model_DataSet.Brand);
            }
            catch (Exception ex)
            {
                General._ShowCustomMyMessage(ex.Message, "Hata", General._MessageTip._error, General._MessageCategory._DB);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Productions productions = new Productions();
            productions.updateProduction(txtId, cbBrand, cbModel, txtSerialNumber, txtImeiNumber, dtpProductionDate, dtpPurchaseDate, txtPurchasePrice, txtSalePrice, txtAmount, txtVat, txtCPU, txtOS, txtMemory, txtResolution, txtCPU, pictureBoxImage);
            this.Close();
        }

        private void btnUpdateBrandModel_Click(object sender, EventArgs e)
        {
            lblBrand.Text = cbBrand.Text;
            lblModel.Text = cbModel.Text;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                bool messsage = General._ShowCustomMyMessage("Silmek istediğinize emin misiniz ?", "Uyarı", General._MessageTip._question, General._MessageCategory._systemQuestion);
                if (messsage)
                {
                    Productions productions = new Productions();
                    productions.deleteProduction(txtId);
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                General._ShowCustomMyMessage(ex.Message, "Hata", General._MessageTip._error, General._MessageCategory._DB);
            }
        }
    }
}
