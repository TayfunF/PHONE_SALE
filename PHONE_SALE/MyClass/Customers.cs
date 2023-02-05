using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PHONE_SALE
{
    internal class Customers
    {
        #region Fields
        private int _id;
        private string _fullName;
        private string _phoneNumber;
        private string _email;
        private string _address;
        private bool _isActive;
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
        #endregion

        General general = new General();
        SqlConnection con = null;
        string query = "";
        SqlCommand cmd = null;
        DataTable dt = null;
        SqlDataAdapter da = null;
        SqlDataReader dr = null;

        //Müşteri Listeleme Methodu
        public void getCustomerList(DataGridView dataGridView)
        {
            try
            {
                con = new SqlConnection(general.connectionString);
                query = "Select * from vw_getCustomerList";
                da = new SqlDataAdapter(query, con);

                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                dt = new DataTable();
                da.Fill(dt);
                dataGridView.DataSource = dt;

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

        //Müşteri Ekleme Methodu
        public void addCustomer(TextBox txtFullName, MaskedTextBox maskedPhoneNumber, TextBox txtEmail, TextBox txtAddress)
        {
            try
            {
                FullName = txtFullName.Text;
                PhoneNumber = maskedPhoneNumber.Text;
                Email = txtEmail.Text;
                Address = txtAddress.Text;

                con = new SqlConnection(general.connectionString);
                query = "insert into Customer values (@FullName,@PhoneNumber,@Email,@Address,@IsActive)";
                cmd = new SqlCommand(query, con);

                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                if (FullName != "" || PhoneNumber != "" || Email != "" || Address != "")
                {
                    cmd.Parameters.AddWithValue("@FullName", FullName);
                    cmd.Parameters.AddWithValue("@PhoneNumber", PhoneNumber);
                    cmd.Parameters.AddWithValue("@Email", Email);
                    cmd.Parameters.AddWithValue("@Address", Address);
                    cmd.Parameters.AddWithValue("@IsActive", true);

                    cmd.ExecuteNonQuery();
                    General._ShowCustomMyMessage("Müşteri eklenmiştir.", "Başarılı", General._MessageTip._info, General._MessageCategory._information);

                    txtFullName.Text = "";
                    maskedPhoneNumber.Text = "";
                    txtEmail.Text = "";
                    txtAddress.Text = "";
                }
                else
                {
                    General._ShowCustomMyMessage("Eksik alanları doldurun", "Dikkat", General._MessageTip._info, General._MessageCategory._user);
                }

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

        //Müşteri Güncelleme Methodu
        public void updateCustomer(Label lblId, TextBox txtFullName, MaskedTextBox maskedPhoneNumber, TextBox txtEmail, TextBox txtAddress, CheckBox cboxIsActive)
        {
            try
            {
                Id = Convert.ToInt32(lblId.Text);
                FullName = txtFullName.Text;
                PhoneNumber = maskedPhoneNumber.Text;
                Email = txtEmail.Text;
                Address = txtAddress.Text;
                IsActive = cboxIsActive.Checked;

                con = new SqlConnection(general.connectionString);
                query = "Update Customer set FullName=@FullName, PhoneNumber=@PhoneNumber, Email=@Email, Address=@Address where Id=@Id";
                cmd = new SqlCommand(query, con);

                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                cmd.Parameters.AddWithValue("@FullName", FullName);
                cmd.Parameters.AddWithValue("@PhoneNumber", PhoneNumber);
                cmd.Parameters.AddWithValue("@Email", Email);
                cmd.Parameters.AddWithValue("@Address", Address);
                cmd.Parameters.AddWithValue("@IsActive", IsActive);

                cmd.ExecuteNonQuery();
                General._ShowCustomMyMessage("Müşteri güncellenmiştir.", "Başarılı", General._MessageTip._info, General._MessageCategory._information);

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

        //Müştesi kayıtlı mı kontrolü
        public bool state;
        public bool alreadyRegisteredCustomer(TextBox txtEmail)
        {
            try
            {
                state = true;
                Email = txtEmail.Text;

                con = new SqlConnection(general.connectionString);
                query = "Select * from Customer";
                cmd = new SqlCommand(query, con);

                if (con.State == System.Data.ConnectionState.Closed)
                {
                    con.Open();
                }

                dr = cmd.ExecuteReader();

                while (dr.Read())
                    if (dr["Email"].ToString() == Email || dr["Email"].ToString() == null)
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
