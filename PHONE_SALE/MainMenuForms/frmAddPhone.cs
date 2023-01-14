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
            productions.addProduction(txtBrand, txtModel, txtSerialNumber, txtImeiNumber, dtpProductionDate, dtpPurchaseDate, nudPurchasePrice, nudSalePrice, nudVat, txtCPU, txtOS, txtMemory, txtResolution, txtColor, btnFileDialog);
            txtBrand.Clear();
            txtModel.Clear();
            txtSerialNumber.Clear();
            txtImeiNumber.Clear();
            nudVat.Accelerations.Clear();
            txtCPU.Clear();
            txtOS.Clear();
            nudPurchasePrice.Accelerations.Clear();
            nudSalePrice.Accelerations.Clear();
            txtMemory.Clear();
            txtResolution.Clear();
            txtColor.Clear();
        }

        //Kullanıcıdan Dosya Seçmesini istediğimiz zaman
        private void btnFileDialog_Click(object sender, EventArgs e)
        {
            openFileDialog1 = new OpenFileDialog();
            //openFileDialog.Filter = "Resim Dosyası |*.jpg;*.nef;*.png| Video|*.avi| Tüm Dosyalar |*.*";
            openFileDialog1.Filter = "Resim Dosyası |*.jpg;*.png";
            openFileDialog1.Title = "Ürüm Resmi Seç";
            openFileDialog1.ShowDialog();
            lblImagePath.Text = openFileDialog1.SafeFileName;
        }

        private void frmAddPhone_Load(object sender, EventArgs e)
        {
            lblImagePath.Text = "";
        }
    }
}
