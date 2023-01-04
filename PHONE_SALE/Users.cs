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
        SqlConnection con = null;
        string query = "";
        SqlCommand cmd = null;
        DataTable dt = null;
        SqlDataAdapter da = null;

        //Kullanıcı Girişi
        public void userEntry(TextBox tbUsername, TextBox tbPassword)
        {
            Username = tbUsername.Text;
            Password = tbPassword.Text;

            try
            {
                if (Username != "" || Password != "")
                {
                    query = "Select * from Users where Username = '" + Username + "' and Password = '" + Password + "' ";
                    con = new SqlConnection(general.connectionString);
                    cmd = new SqlCommand(query, con);

                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }

                    SqlDataReader _dr = cmd.ExecuteReader();

                    if (_dr.Read())
                    {
                        frmMainMenu mainMenu = new frmMainMenu();
                        frmLogin.ActiveForm.Visible = false;
                        mainMenu.Show();
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
            catch (Exception ex)
            {
                General._ShowCustomMyMessage(ex.Message, "Hata", General._MessageTip._error, General._MessageCategory._DB);
            }
        }

        //Kullanıcı Ekleme Methodu
        public void addUserInSystem(TextBox tbUsername, TextBox tbPassword, TextBox tbFullName, TextBox tbPhoneNumber, TextBox tbEmail, TextBox tbAddress)
        {
            Username = tbUsername.Text;
            Password = tbPassword.Text;
            FullName = tbFullName.Text;
            PhoneNumber = tbPhoneNumber.Text;
            Email = tbEmail.Text;
            Address = tbAddress.Text;

            try
            {
                if (Username != "" || Password != "" || FullName != "")
                {
                    con = new SqlConnection(general.connectionString);
                    query = "insert into Users values (@Username,@Password,@FullName,@PhoneNumber,@Email,@Address,@IsActive,@CreatedDate)";
                    cmd = new SqlCommand(query, con);

                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }

                    cmd.Parameters.AddWithValue("@Username", Username);
                    cmd.Parameters.AddWithValue("@Password", Password);
                    cmd.Parameters.AddWithValue("@FullName", FullName);
                    cmd.Parameters.AddWithValue("@PhoneNumber", PhoneNumber);
                    cmd.Parameters.AddWithValue("@Email", Email);
                    cmd.Parameters.AddWithValue("@Address", Address);
                    cmd.Parameters.AddWithValue("@IsActive", 1);
                    cmd.Parameters.AddWithValue("@CreatedDate", DateTime.Now.Date);

                    cmd.ExecuteNonQuery();

                    General._ShowCustomMyMessage("Kullanıcı sisteme eklendi", "Başarılı", General._MessageTip._info, General._MessageCategory._information);

                    if (con.State == ConnectionState.Open)
                    {
                        con.Close();
                    }
                }
                else
                {
                    General._ShowCustomMyMessage("Kullanıcı Adı - Şifre - Ad Soyad alanları boş bırakılamaz", "Dikkat", General._MessageTip._warning, General._MessageCategory._user);
                }
            }
            catch (Exception ex)
            {
                General._ShowCustomMyMessage(ex.Message, "Hata", General._MessageTip._error, General._MessageCategory._DB);
            }
        }

        //Kullanıcı Listeleme Methodu
        public void getUserList(DataGridView dataGridView)
        {
            con = new SqlConnection(general.connectionString);
            query = "Select Username,FullName,PhoneNumber,Email,Address from Users where IsActive = 1";
            da = new SqlDataAdapter(query, con);

            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            dt = new DataTable();
            dt.Columns.Add("Username");
            dt.Columns.Add("FullName");
            dt.Columns.Add("PhoneNumber");
            dt.Columns.Add("Email");
            dt.Columns.Add("Address");
            da.Fill(dt);

            dataGridView.DataSource = dt;

            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }
    }
}
