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
    public partial class girisekrani : Form
    {
        public girisekrani()
        {
            InitializeComponent();
        }
        public static SqlConnection baglanti = new SqlConnection("Data Source=.;Initial Catalog=yazılımyapımı;Integrated Security=True;");
        
        private void Girisyap_Bttn_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                string sql = "Select *From kullanici where Email=@email AND Şifre=@şifre";
                SqlParameter prm1 = new SqlParameter("email", email_Txtbox.Text.Trim());
                SqlParameter prm2 = new SqlParameter("şifre", sifreTxtbox.Text.Trim());
                SqlCommand komut = new SqlCommand(sql, baglanti);
                komut.Parameters.Add(prm1);
                komut.Parameters.Add(prm2);
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(komut);
                da.Fill(dt);
                if (dt.Rows.Count>0)
                {
                   frmUyeol fr = new frmUyeol();
                    fr.Show();

                }
                else
                {
                    MessageBox.Show("kullanıcı adı veya şifreyi yanlış girdiniz");
                }
                baglanti.Close();
             


            }
            catch (Exception)
            {
                MessageBox.Show("kullanıcı adı veya şifreyi yanlış girdiniz");

            }
        }

        private void uyeolBttn_Click(object sender, EventArgs e)
        {
            this.Hide();
           frmUyeol uyeolForm1 = new frmUyeol();
            
            uyeolForm1.Show();
            

        }

        private void sifremiunuttumBttn_Click(object sender, EventArgs e)
        {
            sifremiunuttumFrm sifremiunuttumFrm= new sifremiunuttumFrm();
            sifremiunuttumFrm.Show();
            this.Hide();
        }
    }
}
