using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Yazılımyapımı
{
    public partial class frmUyeol : Form
    {

        SqlConnection connection = girisekrani.baglanti;

        public frmUyeol()
        {
            InitializeComponent();
        }
        static string constring = ("Data Source=.;Initial Catalog=yazılımyapımı;Integrated Security=True;");
        SqlConnection baglan = new SqlConnection(constring);
        private void cikisBttn_Click(object sender, EventArgs e)
        {
            girisekrani formgirisekrani = new girisekrani();
            formgirisekrani.Show();
            this.Hide();
        }

        private void uyeolBttn_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglan.State == ConnectionState.Closed)
                {
                    baglan.Open();
                    string Rez = "insert into kullanici (email,şifre,soru,cevap)values(@email,@şifre,@soru,@cevap)";

                    SqlCommand komut = new SqlCommand(Rez, baglan);
                    komut.Parameters.AddWithValue("@email", emailTxtbox.Text);
                    komut.Parameters.AddWithValue("@şifre", sifreTxtbox.Text);
                    komut.Parameters.AddWithValue("@soru", soruCmbbox.Text);
                    komut.Parameters.AddWithValue("@cevap", cevapTxtbox.Text);
                    

                    komut.ExecuteNonQuery();

                    MessageBox.Show("Kaydınız yapılmıştır.");
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show("hata" + hata.Message);

            }
        }

       
    }
}
