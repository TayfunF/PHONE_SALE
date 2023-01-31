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
    public partial class frmAddBrand : Form
    {
        public frmAddBrand()
        {
            InitializeComponent();
        }

        //Marka Ekleme Methodu
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Brands brands = new Brands();
            //MARKA ZATEN VAR KONTROL
            bool isNotRegistered = brands.alreadyRegistered(txtBrand);
            if (isNotRegistered)
            brands.addBrand(txtBrand);
            else General._ShowCustomMyMessage("Marka zaten sisteme kayıtlı !", "Uyarı", General._MessageTip._warning, General._MessageCategory._information);
        }
    }
}
