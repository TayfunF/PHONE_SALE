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
        Brands brands;

        public frmAddBrand()
        {
            InitializeComponent();
        }

        //Marka Ekleme Methodu
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                brands = new Brands();
                bool isNotRegistered = brands.alreadyRegisteredBrand(txtBrand);
                if (isNotRegistered)
                    brands.addBrand(txtBrand);
                else General._ShowCustomMyMessage("Marka zaten sisteme kayıtlı !", "Uyarı", General._MessageTip._warning, General._MessageCategory._information);
            }
            catch (Exception ex)
            {
                General._MyCustomErrorMessage(ex);
            }
        }
    }
}
