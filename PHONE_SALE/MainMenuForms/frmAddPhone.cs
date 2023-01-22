using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PHONE_SALE.MainMenuForms
{
    public partial class frmAddPhone : Form
    {
        public frmAddPhone()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Productions productions = new Productions();
            productions.addProduction(cbBrand, cbModel, txtSerialNumber, txtImeiNumber, dtpProductionDate, dtpPurchaseDate, nudPurchasePrice, nudSalePrice, nudVat, txtCPU, txtOS, txtMemory, txtResolution, txtColor, pictureBoxImage);
            txtSerialNumber.Clear();
            txtImeiNumber.Clear();
            nudVat.Value = 1;
            txtCPU.Clear();
            txtOS.Clear();
            nudPurchasePrice.Value = 0;
            nudSalePrice.Value = 0;
            txtMemory.Clear();
            txtResolution.Clear();
            txtColor.Clear();
            pictureBoxImage.Image = null;
        }

        //Kullanıcıdan Resim Dosyası Seçmesini istediğimiz zaman
        private void btnFileDialog_Click(object sender, EventArgs e)
        {
            openFileDialog1 = new OpenFileDialog();
            //openFileDialog.Filter = "Resim Dosyası |*.jpg;*.nef;*.png| Video|*.avi| Tüm Dosyalar |*.*";
            openFileDialog1.Filter = "Resim Dosyası |*.jpg;*.png";
            openFileDialog1.Title = "Ürüm Resmi Seç";
            openFileDialog1.ShowDialog();
            pictureBoxImage.ImageLocation = openFileDialog1.FileName;
            //lblImagePath.Text = openFileDialog1.SafeFileName;
        }

        private void frmAddPhone_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'brand_Model_DataSet.Model' table. You can move, or remove it, as needed.
            this.modelTableAdapter.Fill(this.brand_Model_DataSet.Model);
            // TODO: This line of code loads data into the 'brand_Model_DataSet.Brand' table. You can move, or remove it, as needed.
            this.brandTableAdapter.Fill(this.brand_Model_DataSet.Brand);

        }
    }
}
