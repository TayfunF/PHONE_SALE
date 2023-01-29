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
        #endregion

        General general = new General();
        SqlConnection con = null;
        string query = "";
        SqlCommand cmd = null;
        DataTable dt = null;
        SqlDataAdapter da = null;

        public void getModelList()
        {

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

        public void updateModel()
        {

        }

        public void deleteModel()
        {

        }
    }
}
