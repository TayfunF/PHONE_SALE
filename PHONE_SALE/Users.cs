using PHONE_SALE.Helpers;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace PHONE_SALE
{
    class Users
    {
        #region Fields
        private string _username;
        private string _password;
        private string _fullName;
        private string _phoneNumber;
        private string _email;
        private string _address;
        private bool _isActive;
        private DateTime _createdDate;
        #endregion

        #region Properties
        public string Username
        {
            get
            {
                return _username;
            }
            set
            {
                _username = value;
            }
        }

        public string Password
        {
            get
            {
                return _password;
            }
            set
            {
                _password = value;
            }
        }

        public string FullName
        {
            get
            {
                return _fullName;
            }
            set
            {
                _fullName = value;
            }
        }

        public string PhoneNumber
        {
            get
            {
                return _phoneNumber;
            }
            set
            {
                _phoneNumber = value;
            }
        }

        public string Email
        {
            get
            {
                return _email;
            }
            set
            {
                _email = value;
            }
        }

        public string Address
        {
            get
            {
                return _address;
            }
            set
            {
                _address = value;
            }
        }

        public bool IsActive
        {
            get
            {
                return _isActive;
            }
            set
            {
                _isActive = value;
            }
        }

        public DateTime CreatedDate
        {
            get
            {
                return _createdDate;
            }
            set
            {
                _createdDate = value;
            }
        }
        #endregion

        General general = new General();

        public void userEntry(TextBox tbUsername, TextBox tbPassword)
        {
            Username = tbUsername.Text;
            Password = tbPassword.Text;

            if (Username != "" || Password != "")
            {
                string query = "Select * from Users where Username = '" + Username + "' and Password = '" + Password + "' ";
                SqlConnection con = new SqlConnection(general.connectionString);
                SqlCommand cmd = new SqlCommand(query, con);

                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                SqlDataReader _dr = cmd.ExecuteReader();

                if (_dr.Read())
                {
                    frmMainMenu mainMenu = new frmMainMenu();
                    mainMenu.Show();
                    frmLogin.ActiveForm.Visible = false;
                }
                else
                {
                    General._ShowCustomMyMessage("Kullanıcı adı ya da şifre hatalı", "Hata", General._MessageTip._error, General._MessageCategory._user);
                }

                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
            else
            {
                General._ShowCustomMyMessage("Kullanıcı adı ya da şifre boş olamaz", "Hata", General._MessageTip._error, General._MessageCategory._user);
            }
        }
    }
}
