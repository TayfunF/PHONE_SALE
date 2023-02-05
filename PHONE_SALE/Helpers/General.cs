using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PHONE_SALE
{
    public class General
    {
        SqlConnection con;
        SqlDataAdapter da;
        DataTable dt;

        public string connectionString = "Data Source=DESKTOP-9PD212P\\SQLEXPRESS;Initial Catalog=PHONE_SALE;Integrated Security=True";
        public static int _personelUserId;  //Her yeden erişebilmek için static yaptım
        public static int _personelGorevId; //Her yeden erişebilmek için static yaptım
        public static string _soyad;        //Her yeden erişebilmek için static yaptım
        public static string _ad;           //Her yeden erişebilmek için static yaptım
        public static string _kullaniciAdi; //Her yeden erişebilmek için static yaptım

        #region MESAJKUTUSU_KODLARIM
        public enum _MessageTip
        {
            _info,
            _error,
            _question,
            _warning
        }

        public enum _MessageCategory
        {
            _DB,
            _user,
            _system,
            _systemQuestion,
            _transfer,
            _information
        }

        public static bool _ShowCustomMyMessage(string _message, string _title, _MessageTip _messageTip, _MessageCategory _messageCategory)
        {
            bool messageResult;

            frmMessage message = new frmMessage();

            message._messageTip = _messageTip;
            message.lblMessageTitle.Text = _title;
            message.lblMesaj.Text = _message;


            switch (_messageCategory)
            {
                case _MessageCategory._DB:
                    message.lblMessageCategory.Text = "Veritabanı hatası";
                    break;

                case _MessageCategory._user:
                    message.lblMessageCategory.Text = "Kullanıcı hatası";
                    break;

                case _MessageCategory._system:
                    message.lblMessageCategory.Text = "Sistem hatası";
                    break;

                case _MessageCategory._systemQuestion:
                    message.lblMessageCategory.Text = "Sistem mesajı";
                    break;

                case _MessageCategory._transfer:
                    message.lblMessageCategory.Text = "Aktarım hatası";
                    break;

                case _MessageCategory._information:
                    message.lblMessageCategory.Text = "PHONE_SALE bilgilendirme";
                    break;
            }

            switch (_messageTip)
            {
                case _MessageTip._info:

                    message.pbMsgIcon.Image = message.imgList.Images[0];
                    message.Text = "Bilgi mesajı";
                    message.btnOk.Location = new Point(180, 3);
                    message.btnYes.Visible = false;
                    message.btnNo.Visible = false;
                    break;

                case _MessageTip._error:

                    message.pbMsgIcon.Image = message.imgList.Images[1];
                    message.Text = "Hata mesajı";
                    message.btnOk.Location = new Point(180, 3);
                    message.btnYes.Visible = false;
                    message.btnNo.Visible = false;
                    break;

                case _MessageTip._question:

                    message.pbMsgIcon.Image = message.imgList.Images[2];
                    message.Text = "Onaylama mesajı";
                    message.btnOk.Visible = false;
                    break;

                case _MessageTip._warning:

                    message.pbMsgIcon.Image = message.imgList.Images[3];
                    message.Text = "Uyarı mesajı";
                    message.btnOk.Location = new Point(180, 3);
                    message.btnYes.Visible = false;
                    message.btnNo.Visible = false;
                    break;
            }

            message.ShowDialog();
            messageResult = message._result;
            message.Dispose();

            return messageResult;
        }
        #endregion

        //Ortak Verileri Listeleme Metodu
        public DataTable getList(DataGridView dataGridView, string query)
        {
            try
            {
                con = new SqlConnection(connectionString);
                da = new SqlDataAdapter(query, con);
                dt = new DataTable();

                if (con.State == ConnectionState.Closed)
                    con.Open();

                da.Fill(dt);
                dataGridView.DataSource = dt;

                if (con.State == ConnectionState.Open)
                    con.Close();
            }
            catch (Exception ex)
            {
                General._MyCustomErrorMessage(ex);
            }

            return dt;
        }

        //Ortak Hata Mesajları Methodu
        public static void _MyCustomErrorMessage(Exception ex)
        {
            General._ShowCustomMyMessage(ex.Message, "Hata", General._MessageTip._error, General._MessageCategory._DB);
        }

        //Çıkış mesajı göstermek için
        public static void _CustomExitMessage()
        {
            if (General._ShowCustomMyMessage("Çıkmak istediğinize emin misiniz", "Uyarı", General._MessageTip._question, General._MessageCategory._systemQuestion) == true)
            {
                System.Diagnostics.Process.GetCurrentProcess().Kill();
            }
        }

        //Saati almak için
        public static void _MyCustomerTimer(Label label)
        {
            int count = 0;
            count++;
            label.Text = DateTime.Now.ToString("HH:mm:ss");
        }
    }
}
