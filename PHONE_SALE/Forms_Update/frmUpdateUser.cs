using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PHONE_SALE.Forms_Update
{
    public partial class frmUpdateUser : Form
    {
        public frmUpdateUser()
        {
            InitializeComponent();
            lblId.Visible = false;
            btnDelete.Visible = false;
        }

        //Kullanıcı Güncelleme Butonu
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                Users users = new Users();
                users.updateUsernameAndPassword(lblId, txtUsername, txtPassword,cboxIsActive);
            }
            catch (Exception ex)
            {
                General._ShowCustomMyMessage(ex.Message, "Hata", General._MessageTip._error, General._MessageCategory._DB);
            }
        }
    }
}
