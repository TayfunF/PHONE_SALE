using PHONE_SALE.Helpers;
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
    public partial class frmMessage : Form
    {
        public frmMessage()
        {
            InitializeComponent();
        }

        public bool _result;

        public General._MessageTip _messageTip;

        private void frmMessage_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            MinimizeBox = false;
            _result = false;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            _result = false;
            this.Close();
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            _result = true;
            this.Close();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            _result = false;
            this.Close();
        }

        private void frmMessage_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (_messageTip == General._MessageTip._question)
                {
                    _result = false;
                    Close();
                }

                else
                {
                    _result = true;
                    Close();
                }
            }

            if (e.KeyCode == Keys.Escape)
            {
                _result = false;
                Close();
            }

            if (e.KeyCode == Keys.F4 && e.Alt)
            {
                e.SuppressKeyPress = true;
            }
        }
    }
}
