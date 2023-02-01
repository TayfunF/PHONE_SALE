using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PHONE_SALE
{
    class Productions
    {
        #region Fields
        private int _id;
        private string _brand;
        private string _model;
        private string _serialNumber;
        private string _imeiNumber;
        private DateTime _productionDate;
        private DateTime _purchaseDate;
        private double _purchasePrice;
        private double _salePrice;
        private int _amount;
        private short _vat;
        private string _cpu;
        private string _os;
        private string _memory;
        private string _resolution;
        private string _color;
        private string _image;
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
        public string SerialNumber
        {
            get
            {
                return _serialNumber;
            }
            set
            {
                _serialNumber = value;
            }
        }
        public string ImeiNumber
        {
            get
            {
                return _imeiNumber;
            }
            set
            {
                _imeiNumber = value;
            }
        }
        public DateTime ProductionDate
        {
            get
            {
                return _productionDate;
            }
            set
            {
                _productionDate = value;
            }
        }
        public DateTime PurchaseDate
        {
            get
            {
                return _purchaseDate;
            }
            set
            {
                _purchaseDate = value;
            }
        }
        public double PurchasePrice
        {
            get
            {
                return _purchasePrice;
            }
            set
            {
                _purchasePrice = value;
            }
        }
        public double SalePrice
        {
            get
            {
                return _salePrice;
            }
            set
            {
                _salePrice = value;
            }
        }

        public int Amount
        {
            get
            {
                return _amount;
            }
            set
            {
                _amount = value;
            }
        }

        public short Vat
        {
            get
            {
                return _vat;
            }
            set
            {
                _vat = value;
            }
        }
        public string Cpu
        {
            get
            {
                return _cpu;
            }
            set
            {
                _cpu = value;
            }
        }
        public string OS
        {
            get
            {
                return _os;
            }
            set
            {
                _os = value;
            }
        }
        public string Memory
        {
            get
            {
                return _memory;
            }
            set
            {
                _memory = value;
            }
        }
        public string Resolution
        {
            get
            {
                return _resolution;
            }
            set
            {
                _resolution = value;
            }
        }
        public string Color
        {
            get
            {
                return _color;
            }
            set
            {
                _color = value;
            }
        }
        public string Image
        {
            get
            {
                return _image;
            }
            set
            {
                _image = value;
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

        //Ürün Ekleme Methodu
        public void addProduction(ComboBox cbBrand, ComboBox cbModel, TextBox txtSerialNumber, TextBox txtImeiNumber, DateTimePicker dtpProductionDate, DateTimePicker dtpPurchaseDate, TextBox txtPurchasePrice, TextBox txtSalePrice, TextBox txtAmount, TextBox txtVat, TextBox txtCPU, TextBox txtOS, TextBox txtMemory, TextBox txtResolution, TextBox txtColor, PictureBox pictureBoxImage)
        {
            try
            {
                Brand = cbBrand.Text;
                Model = cbModel.Text;
                SerialNumber = txtSerialNumber.Text;
                ImeiNumber = txtImeiNumber.Text;
                ProductionDate = Convert.ToDateTime(dtpProductionDate.Text);
                PurchaseDate = Convert.ToDateTime(dtpPurchaseDate.Text);
                PurchasePrice = Convert.ToDouble(txtPurchasePrice.Text);
                SalePrice = Convert.ToDouble(txtSalePrice.Text);
                Amount = Convert.ToInt32(txtAmount.Text);
                Vat = Convert.ToInt16(txtVat.Text);
                Cpu = txtCPU.Text;
                OS = txtOS.Text;
                Memory = txtMemory.Text;
                Resolution = txtResolution.Text;
                Color = txtColor.Text;
                Image = pictureBoxImage.ImageLocation;

                con = new SqlConnection(general.connectionString);
                query = "insert into Productions values (@Brand,@Model,@SerialNumber,@ImeiNumber,@ProductionDate,@PurchaseDate,@PurchasePrice,@SalePrice,@Amount,@VAT,@CPU,@OS,@Memory,@Resolution,@Color,@Image,@CreatedDate,@IsActive)";
                cmd = new SqlCommand(query, con);

                if (con.State == System.Data.ConnectionState.Closed)
                {
                    con.Open();
                }

                if (Brand != "" && Model != "" && SerialNumber != "" && ImeiNumber != "" && PurchasePrice != 0 && SalePrice != 0 && Image != "")
                {
                    cmd.Parameters.AddWithValue("@Brand", Brand);
                    cmd.Parameters.AddWithValue("@Model", Model);
                    cmd.Parameters.AddWithValue("@SerialNumber", SerialNumber);
                    cmd.Parameters.AddWithValue("@ImeiNumber", ImeiNumber);
                    cmd.Parameters.AddWithValue("@ProductionDate", ProductionDate);
                    cmd.Parameters.AddWithValue("@PurchaseDate", PurchaseDate);
                    cmd.Parameters.AddWithValue("@PurchasePrice", PurchasePrice);
                    cmd.Parameters.AddWithValue("@SalePrice", SalePrice);
                    cmd.Parameters.AddWithValue("@Amount", Amount);
                    cmd.Parameters.AddWithValue("@VAT", Vat);
                    cmd.Parameters.AddWithValue("@CPU", Cpu);
                    cmd.Parameters.AddWithValue("@OS", OS);
                    cmd.Parameters.AddWithValue("@Memory", Memory);
                    cmd.Parameters.AddWithValue("@Resolution", Resolution);
                    cmd.Parameters.AddWithValue("@Color", Color);
                    cmd.Parameters.AddWithValue("@Image", Image);
                    cmd.Parameters.AddWithValue("@CreatedDate", DateTime.Now);
                    cmd.Parameters.AddWithValue("@IsActive", 1);

                    cmd.ExecuteNonQuery();
                    General._ShowCustomMyMessage("Ürün eklenmiştir.", "Başarılı", General._MessageTip._info, General._MessageCategory._information);

                    txtSerialNumber.Text = "";
                    txtImeiNumber.Text = "";
                    txtVat.Text = "1";
                    txtCPU.Text = "";
                    txtOS.Text = "";
                    txtPurchasePrice.Text = "";
                    txtSalePrice.Text = "";
                    txtAmount.Text = "";
                    txtMemory.Text = "";
                    txtResolution.Text = ""; ;
                    txtColor.Text = "";
                    pictureBoxImage.Image = null;
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

        //Ürün Listeleme Methodu
        public void getProductionList(DataGridView dataGridView)
        {
            try
            {
                con = new SqlConnection(general.connectionString);
                query = "Select * from v_getProductionList";
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

        //Ürün Güncelleme Methodu
        public void updateProduction(TextBox txtId, ComboBox cbBrand, ComboBox cbModel, TextBox txtSerialNumber, TextBox txtImeiNumber, DateTimePicker dtpProductionDate, DateTimePicker dtpPurchaseDate, TextBox txtPurchasePrice, TextBox txtSalePrice, TextBox txtAmount, TextBox txtVAT, TextBox txtCPU, TextBox txtOS, TextBox txtMemory, TextBox txtResolution, TextBox txtColor, PictureBox pictureBoxImage)
        {
            try
            {
                Id = Convert.ToInt32(txtId.Text);
                Brand = cbBrand.Text;
                Model = cbModel.Text;
                SerialNumber = txtSerialNumber.Text;
                ImeiNumber = txtImeiNumber.Text;
                ProductionDate = Convert.ToDateTime(dtpProductionDate.Text);
                PurchaseDate = Convert.ToDateTime(dtpPurchaseDate.Text);
                PurchasePrice = Convert.ToDouble(txtPurchasePrice.Text);
                SalePrice = Convert.ToDouble(txtSalePrice.Text);
                Amount = Convert.ToInt32(txtAmount.Text);
                Vat = Convert.ToInt16(txtVAT.Text);
                Cpu = txtCPU.Text;
                OS = txtOS.Text;
                Memory = txtMemory.Text;
                Resolution = txtResolution.Text;
                Color = txtColor.Text;
                Image = pictureBoxImage.ImageLocation;

                con = new SqlConnection(general.connectionString);
                query = "update Productions set Brand=@Brand, Model=@Model, SerialNumber=@SerialNumber, ImeiNumber=@ImeiNumber, ProductionDate=@ProductionDate, PurchaseDate=@PurchaseDate, PurchasePrice=@PurchasePrice, SalePrice=@SalePrice, Amount=@Amount, VAT=@VAT, CPU=@CPU, OS=@OS, Memory=@Memory, Resolution=@Resolution, Color=@Color, Image=@Image, CreatedDate=@CreatedDate, IsActive=@IsActive where Id=@Id";
                cmd = new SqlCommand(query, con);

                if (con.State == System.Data.ConnectionState.Closed)
                {
                    con.Open();
                }

                if (Brand != "" && Model != "" && SerialNumber != "" && ImeiNumber != "" && PurchasePrice != 0 && SalePrice != 0 && Image != "")
                {
                    cmd.Parameters.AddWithValue("@Id", Id);
                    cmd.Parameters.AddWithValue("@Brand", Brand);
                    cmd.Parameters.AddWithValue("@Model", Model);
                    cmd.Parameters.AddWithValue("@SerialNumber", SerialNumber);
                    cmd.Parameters.AddWithValue("@ImeiNumber", ImeiNumber);
                    cmd.Parameters.AddWithValue("@ProductionDate", ProductionDate);
                    cmd.Parameters.AddWithValue("@PurchaseDate", PurchaseDate);
                    cmd.Parameters.AddWithValue("@PurchasePrice", PurchasePrice);
                    cmd.Parameters.AddWithValue("@SalePrice", SalePrice);
                    cmd.Parameters.AddWithValue("@Amount", Amount);
                    cmd.Parameters.AddWithValue("@VAT", Vat);
                    cmd.Parameters.AddWithValue("@CPU", Cpu);
                    cmd.Parameters.AddWithValue("@OS", OS);
                    cmd.Parameters.AddWithValue("@Memory", Memory);
                    cmd.Parameters.AddWithValue("@Resolution", Resolution);
                    cmd.Parameters.AddWithValue("@Color", Color);
                    cmd.Parameters.AddWithValue("@Image", Image);
                    cmd.Parameters.AddWithValue("@CreatedDate", DateTime.Now);
                    cmd.Parameters.AddWithValue("@IsActive", 1);

                    cmd.ExecuteNonQuery();
                    General._ShowCustomMyMessage("Ürün güncellenmiştir.", "Başarılı", General._MessageTip._info, General._MessageCategory._information);
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

        //Ürün Silme Methodu
        public void deleteProduction(TextBox txtId)
        {
            try
            {
                Id = Convert.ToInt32(txtId.Text);

                con = new SqlConnection(general.connectionString);
                query = "delete from Productions where Id = @Id";
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

        //Seri ya da Imei No varsa kaydetme kontrolü
        public bool state;
        public bool alreadyRegisteredProduction(TextBox txtSerialNumber, TextBox txtImeiNumber)
        {
            try
            {
                state = true;
                SerialNumber = txtSerialNumber.Text;
                ImeiNumber = txtImeiNumber.Text;

                con = new SqlConnection(general.connectionString);
                query = "Select * from Productions";
                cmd = new SqlCommand(query, con);

                if (con.State == System.Data.ConnectionState.Closed)
                {
                    con.Open();
                }

                dr = cmd.ExecuteReader();

                while (dr.Read())
                    if (dr["SerialNumber"].ToString() == SerialNumber || dr["ImeiNumber"].ToString() == ImeiNumber)
                        state = false;

                if (con.State == System.Data.ConnectionState.Open)
                {
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                General._ShowCustomMyMessage(ex.Message, "Hata", General._MessageTip._error, General._MessageCategory._DB);
            }

            return state;
        }
    }
}
