﻿using PHONE_SALE.Helpers;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PHONE_SALE
{
    class Productions
    {
        #region Fields
        private string _brand;
        private string _model;
        private string _serialNumber;
        private string _imeiNumber;
        private DateTime _productionDate;
        private DateTime _purchaseDate;
        private float _purchasePrice;
        private float _salePrice;
        private int _vat;
        private string _cpu;
        private string _os;
        private string _memory;
        private string _resolution;
        private string _color;
        private string _image;
        #endregion

        #region Properties
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
        public float PurchasePrice
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
        public float SalePrice
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
        public int Vat
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

        //Ürün Ekleme Methodu
        public void addProduction(TextBox txtBrand, TextBox txtModel, TextBox txtSerialNumber, TextBox txtImeiNumber, TextBox txtProductionDate, TextBox txtPurchaseDate, TextBox txtPurchasePrice, TextBox txtSalePrice, TextBox txtVAT, TextBox txtCPU, TextBox txtOS, TextBox txtMemory, TextBox txtResolution, TextBox txtColor, TextBox txtImage)
        {
            Brand = txtBrand.Text;
            Model = txtModel.Text;
            SerialNumber = txtSerialNumber.Text;
            ImeiNumber = txtImeiNumber.Text;
            ProductionDate = Convert.ToDateTime(txtProductionDate.Text);
            PurchaseDate = Convert.ToDateTime(txtPurchaseDate.Text);
            PurchasePrice = Convert.ToInt32(txtPurchasePrice.Text);
            SalePrice = Convert.ToInt32(txtSalePrice.Text);
            Vat = Convert.ToInt32(txtVAT);
            Cpu = txtCPU.Text;
            OS = txtOS.Text;
            Memory = txtMemory.Text;
            Resolution = txtResolution.Text;
            Color = txtColor.Text;
            Image = txtImage.Text;

            con = new SqlConnection(general.connectionString);
            query = "insert into Productions values (@Brand,@Model,@SerialNumber,@ImeiNumber,@ProductionDate,@PurchaseDate,@PurchasePrice,@SalePrice,@VAT,@CPU,@OS,@Memory,@Resolution,@Color,@Image,@CreatedDate,@IsActive)";
            cmd = new SqlCommand(query, con);

            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }

            try
            {
                cmd.Parameters.AddWithValue("@Brand", Brand);
                cmd.Parameters.AddWithValue("@Model", Model);
                cmd.Parameters.AddWithValue("@SerialNumber", SerialNumber);
                cmd.Parameters.AddWithValue("@ImeiNumber", ImeiNumber);
                cmd.Parameters.AddWithValue("@ProductionDate", ProductionDate);
                cmd.Parameters.AddWithValue("@PurchaseDate", PurchaseDate);
                cmd.Parameters.AddWithValue("@PurchasePrice", PurchasePrice);
                cmd.Parameters.AddWithValue("@SalePrice", SalePrice);
                cmd.Parameters.AddWithValue("@VAT", Vat);
                cmd.Parameters.AddWithValue("@CPU", Cpu);
                cmd.Parameters.AddWithValue("@OS", OS);
                cmd.Parameters.AddWithValue("@Memory", Memory);
                cmd.Parameters.AddWithValue("@Resolution", Resolution);
                cmd.Parameters.AddWithValue("@Color", Color);
                cmd.Parameters.AddWithValue("@Image", Image);
                cmd.Parameters.AddWithValue("@CreatedDate", DateTime.Now.Date);
                cmd.Parameters.AddWithValue("@IsActive", 1);

                cmd.ExecuteNonQuery();
                General._ShowCustomMyMessage("Ürün eklenmiştir.", "Başarılı", General._MessageTip._info, General._MessageCategory._information);
            }
            catch (Exception ex)
            {
                General._ShowCustomMyMessage(ex.Message, "Hata", General._MessageTip._error, General._MessageCategory._DB);
            }

            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
        }
    }
}
