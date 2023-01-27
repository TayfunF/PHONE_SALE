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
            
        }
    }
}
