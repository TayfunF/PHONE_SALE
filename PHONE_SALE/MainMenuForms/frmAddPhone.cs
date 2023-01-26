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
            productions.addProduction(cbBrand, cbModel, txtSerialNumber, txtImeiNumber, dtpProductionDate, dtpPurchaseDate, txtPurchasePrice, txtSalePrice, txtAmount, txtSalePrice, txtCPU, txtOS, txtMemory, txtResolution, txtColor, pictureBoxImage);
            txtSerialNumber.Text = "";
            txtImeiNumber.Text = "";
            txtVat.Text = "1";
            txtCPU.Text = "";
            txtOS.Text = "";
            txtPurchasePrice.Text = "";
            txtSalePrice.Text = "";
            txtAmount.Text = "";
            txtMemory.Text = "";
            txtResolution.Text = ""; ;
            txtColor.Text = "";
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
            this.modelTableAdapter.Fill(this.brand_Model_DataSet.Model);
            this.brandTableAdapter.Fill(this.brand_Model_DataSet.Brand);
        }
    }
}
