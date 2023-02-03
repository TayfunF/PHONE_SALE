using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PHONE_SALE.MyClass
{
    internal class Models
    {
        #region Fields
        private static int _id;
        private static string _model;
        private static int _brandId;
        private static string _brand;
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

        public string Model
        {
            get
            {
                return _model;
            }
            set
            {
                _model = value;
            }
        }

        public int BrandId
        {
            get
            {
                return _brandId;
            }
            set
            {
                _brandId = value;
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

        //Model Listeleme
        public void getModelList(DataGridView dataGridView)
        {
            try
            {
                con = new SqlConnection(general.connectionString);
                query = "Select * from v_getBrandModelList";
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

        //Model Ekleme methodu
        public void addModel(ComboBox cbBrand, TextBox txtModel)
        {
            try
            {
                BrandId = Convert.ToInt32(cbBrand.SelectedValue);
                Model = txtModel.Text;

                con = new SqlConnection(general.connectionString);
                query = "insert into Models values (@Model,@BrandId)";
                cmd = new SqlCommand(query, con);

                if (con.State == System.Data.ConnectionState.Closed)
                {
                    con.Open();
                }

                if (Model != "")
                {
                    cmd.Parameters.AddWithValue("@Model", Model);
                    cmd.Parameters.AddWithValue("@BrandId", BrandId);
                }
                else
                {
                    General._ShowCustomMyMessage("Eksik alanları doldurun", "Dikkat", General._MessageTip._info, General._MessageCategory._user);
                }

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

        //Model Güncelleme methodu
        public void updateModel(Label lblId, TextBox txtModel)
        {
            try
            {
                Id = Convert.ToInt32(lblId.Text);
                Model = txtModel.Text;

                con = new SqlConnection(general.connectionString);
                query = "Update Model set Model=@Model where Id=@Id";
                cmd = new SqlCommand(query, con);

                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                cmd.Parameters.AddWithValue("@Id", Id);
                cmd.Parameters.AddWithValue("@Model", Model);

                cmd.ExecuteNonQuery();
                General._ShowCustomMyMessage("Model güncellenmiştir.", "Başarılı", General._MessageTip._info, General._MessageCategory._information);

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

        public void deleteModel()
        {

        }
    }
}
