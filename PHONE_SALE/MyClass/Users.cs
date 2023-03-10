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
        private int _id;
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
        public int Id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }

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
        SqlDataReader dr = null;

        //Kullanıcı Girişi
        public void userEntry(TextBox tbUsername, TextBox tbPassword)
        {
            try
            {
                Username = tbUsername.Text;
                Password = tbPassword.Text;

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
                General._MyCustomErrorMessage(ex);
            }
        }

        //Kullanıcı Ekleme Methodu
        public void addUserInSystem(TextBox txtUsername, TextBox txtPassword, TextBox txtFullName, TextBox txtPhoneNumber, TextBox txtEmail, TextBox txtAddress)
        {
            try
            {
                Username = txtUsername.Text;
                Password = txtPassword.Text;
                FullName = txtFullName.Text;
                PhoneNumber = txtPhoneNumber.Text;
                Email = txtEmail.Text;
                Address = txtAddress.Text;

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

                    txtUsername.Text = "";
                    txtPassword.Text = "";
                    txtFullName.Text = "";
                    txtPhoneNumber.Text = "";
                    txtEmail.Text = "";
                    txtAddress.Text = "";

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
                General._MyCustomErrorMessage(ex);
            }
        }

        //Kullanıcı Listeleme Methodu
        //public void getUserList(DataGridView dataGridView)
        //{
        //    try
        //    {
        //        con = new SqlConnection(general.connectionString);
        //        query = "Select * from vw_getUserList";
        //        da = new SqlDataAdapter(query, con);

        //        if (con.State == ConnectionState.Closed)
        //        {
        //            con.Open();
        //        }

        //        dt = new DataTable();
        //        da.Fill(dt);

        //        dataGridView.DataSource = dt;

        //        if (con.State == ConnectionState.Open)
        //        {
        //            con.Close();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        General._ShowCustomMyMessage(ex.Message, "Hata", General._MessageTip._error, General._MessageCategory._DB);
        //    }
        //}

        //Kullanıcı Güncelle Methodu
        public void updateUsernameAndPassword(Label lblId,TextBox txtUsername,TextBox txtPassword, CheckBox cboxIsActive)
        {
            try
            {
                Id = Convert.ToInt32(lblId.Text);
                Username = txtUsername.Text;
                Password = txtPassword.Text;
                IsActive = cboxIsActive.Checked;

                con = new SqlConnection(general.connectionString);
                query = "Update Users set Username=@Username, Password=@Password, IsActive=@IsActive where Id=@Id";
                cmd = new SqlCommand(query, con);

                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                cmd.Parameters.AddWithValue("@Id", Id);
                cmd.Parameters.AddWithValue("@Username", Username);
                cmd.Parameters.AddWithValue("@Password", Password);
                cmd.Parameters.AddWithValue("@IsActive", IsActive);

                cmd.ExecuteNonQuery();
                General._ShowCustomMyMessage("Kullanıcı güncellenmiştir.", "Başarılı", General._MessageTip._info, General._MessageCategory._information);

                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                General._MyCustomErrorMessage(ex);
            }
        }

        //Kullanıcı kayıtlı mı kontrolü
        public bool state;
        public bool alreadyRegisteredUser(TextBox txtUsername)
        {
            try
            {
                state = true;
                Username = txtUsername.Text;

                con = new SqlConnection(general.connectionString);
                query = "Select * from Users";
                cmd = new SqlCommand(query, con);

                if (con.State == System.Data.ConnectionState.Closed)
                {
                    con.Open();
                }

                dr = cmd.ExecuteReader();

                while (dr.Read())
                    if (dr["Username"].ToString() == Username || dr["Username"].ToString() == null)
                        state = false;

                if (con.State == System.Data.ConnectionState.Open)
                {
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                General._MyCustomErrorMessage(ex);
            }

            return false;
        }
    }
}
