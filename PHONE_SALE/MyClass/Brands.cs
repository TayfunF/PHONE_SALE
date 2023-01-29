using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

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
        public void getBrandList()
        {
            
        }

        //Marka Ekleme
        public void addBrand()
        {

        }

        //Marka Güncelleme
        public void updateBrand()
        {

        }

        //Marka Silme
        public void deleteBrand()
        {

        }
    }
}
