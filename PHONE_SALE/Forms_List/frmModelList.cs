﻿using PHONE_SALE.MyClass;
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
        public frmModelList()
        {
            InitializeComponent();
        }

        private void frmModelList_Load(object sender, EventArgs e)
        {
            Models models = new Models();
            models.getModelList(dataGridViewModel);
        }

        private void dataGridViewModel_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewModel.Rows.Count > 0)
            {

            }
        }
    }
}
