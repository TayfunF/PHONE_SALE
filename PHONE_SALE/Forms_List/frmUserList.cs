using PHONE_SALE.Forms_Update;
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
    public partial class frmUserList : Form
    {
        public frmUserList()
        {
            InitializeComponent();
        }

        private void frmUserList_Load(object sender, EventArgs e)
        {
            Users users = new Users();
            users.getUserList(dataGridViewUsers);
        }

        private void dataGridViewUsers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                frmUpdateUser frmUpdateUser = new frmUpdateUser();

                if (dataGridViewUsers.Rows.Count > 0)
                {
                    frmUpdateUser.lblId.Text = dataGridViewUsers.CurrentRow.Cells["Id"].Value.ToString();
                    frmUpdateUser.txtUsername.Text = dataGridViewUsers.CurrentRow.Cells["KullanıcıAdı"].Value.ToString();
                    frmUpdateUser.txtPassword.Text = dataGridViewUsers.CurrentRow.Cells["Şifre"].Value.ToString();
                    frmUpdateUser.cboxIsActive.Checked = Convert.ToBoolean(dataGridViewUsers.CurrentRow.Cells["AktifMi"].Value.ToString());
                }

                frmUpdateUser.ShowDialog();
            }
            catch (Exception ex)
            {
                General._ShowCustomMyMessage(ex.Message, "Hata", General._MessageTip._error, General._MessageCategory._DB);
            }
        }
    }
}
