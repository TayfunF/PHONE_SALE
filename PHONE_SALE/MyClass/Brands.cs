using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
using System.Windows.Forms;

namespace PHONE_SALE
{
    internal class Brands
    {
        #region Fields
        private int _id;
        private string _brand;
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

        public string Brand
        {
            get
            {
                return _brand;
            }
            set
            {
                _brand = value;
            }
        }
        #endregion

        General general = new General();
        SqlConnection con = null;
        string query = "";
        SqlCommand cmd = null;
        DataTable dt = null;
        SqlDataAdapter da = null;

        //Marka Listeleme
        public void getBrandList(DataGridView dataGridView)
        {
            try
            {
                con = new SqlConnection(general.connectionString);
                query = "Select * from v_getBrandList";
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
                General._ShowCustomMyMessage(ex.Message, "Hata", General._MessageTip._error, General._MessageCategory._DB);
            }
        }

        //Marka Ekleme
        public void addBrand(TextBox txtBrand)
        {
            try
            {
                Brand = txtBrand.Text;

                con = new SqlConnection(general.connectionString);
                query = "insert into Brand values (@Brand)";
                cmd = new SqlCommand(query, con);

                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                if (Brand != "")
                {
                    cmd.Parameters.AddWithValue("@Brand", Brand);

                    cmd.ExecuteNonQuery();
                    General._ShowCustomMyMessage("Marka eklenmiştir.", "Başarılı", General._MessageTip._info, General._MessageCategory._information);

                    txtBrand.Text = "";
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
                General._ShowCustomMyMessage(ex.Message, "Hata", General._MessageTip._error, General._MessageCategory._DB);
            }
        }

        //Marka Güncelleme
        public void updateBrand(TextBox txtId, TextBox txtBrand)
        {
            try
            {
                Id = Convert.ToInt32(txtId.Text);
                Brand = txtBrand.Text;

                con = new SqlConnection(general.connectionString);
                query = "Update Brand set Brand=@Brand where Id=@Id";
                cmd = new SqlCommand(query, con);

                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                cmd.Parameters.AddWithValue("@Id", Id);
                cmd.Parameters.AddWithValue("@Brand", Brand);

                cmd.ExecuteNonQuery();
                General._ShowCustomMyMessage("Marka güncellenmiştir.", "Başarılı", General._MessageTip._info, General._MessageCategory._information);

                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                General._ShowCustomMyMessage(ex.Message, "Hata", General._MessageTip._error, General._MessageCategory._DB);
            }
        }

        //Marka Silme
        public void deleteBrand(TextBox txtId)
        {
            try
            {
                Id = Convert.ToInt32(txtId.Text);

                con = new SqlConnection(general.connectionString);
                query = "delete from Brand where Id = @Id";
                cmd = new SqlCommand(query, con);

                if (con.State == System.Data.ConnectionState.Closed)
                {
                    con.Open();
                }

                cmd.Parameters.AddWithValue("@Id", Id);

                cmd.ExecuteNonQuery();
                General._ShowCustomMyMessage("Ürün silinmiştir.", "Başarılı", General._MessageTip._info, General._MessageCategory._information);

                if (con.State == System.Data.ConnectionState.Open)
                {
                    con.Close();
                }

            }
            catch (Exception ex)
            {
                General._ShowCustomMyMessage(ex.Message, "Hata", General._MessageTip._error, General._MessageCategory._DB);
            }
        }
    }
}
