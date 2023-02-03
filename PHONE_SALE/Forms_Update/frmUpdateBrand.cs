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
    public partial class frmUpdateBrand : Form
    {
        public frmUpdateBrand()
        {
            InitializeComponent();
            lblId.Visible = false;
            txtId.Visible = false;
        }

        //Marka Güncelleme methodu
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                Brands brands = new Brands();
                brands.updateBrand(txtId, txtBrand);
            }
            catch (Exception ex)
            {
                General._ShowCustomMyMessage(ex.Message, "Hata", General._MessageTip._error, General._MessageCategory._DB);
            }
        }

        //Marka Silme methodu
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                bool messsage = General._ShowCustomMyMessage("Silmek istediğinize emin misiniz ?", "Uyarı", General._MessageTip._question, General._MessageCategory._systemQuestion);
                if (messsage)
                {
                    Brands brands = new Brands();
                    brands.deleteBrand(txtId);
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
