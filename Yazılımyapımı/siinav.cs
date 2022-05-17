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
using System.IO;
using System.Drawing.Imaging;

namespace Yazılımyapımı
{
    public partial class siinav : Form
    {
        public siinav()
        {
            InitializeComponent();
        }
        public ogrenci yogr = new ogrenci();
        public int x = 0;
        public int y = 0;
        public int z = 0;
        public int soru_id { get; set; }
        public int[] soru = new int[100];
        public int dogru_soru_sayisi { get; set; }
        public int yanlis_soru_sayisi { get; set; }
        public int bos_soru_sayisi { get; set; }
        public int soru_numara { get; set; }
        public int toplam_puan { get; set; }
        public int sinav_ogr_id { get; set; }
        string imgeLocation1 ="";
        SqlConnection conn = new SqlConnection("Data Source =.; Initial Catalog = yazılımyapımı; Integrated Security = True;");

        SqlCommand comm;
        SqlCommand com2;
        SqlCommand com3;
        SqlDataReader red3;
        SqlCommand com;
        SqlCommand com1;
        SqlDataReader reder;
        SqlDataAdapter da;
        string secencevap;
     // public ogrenci ogr1 = new ogrenci();
      public  frmOgrenciAnaEkran ogranar = new frmOgrenciAnaEkran();
        //InitializeComponent();
        //lbl_tarih.Text= DateTime.Now.ToString("dd MMMM dddd | yyyy");

        public void sorular()
        {
            for (int i = 0; i < 10; i++)
            {
                com = new SqlCommand("SELECT TOP 1 soru_tbl.Id FROM soru_tbl ORDER BY NEWID()", conn);
                //comm= new SqlCommand("SELECT COUNT(ID) from soru_tbl WHERE ID=58");
                conn.Open();
                soru[i] = (int)com.ExecuteScalar();
                soru_numara++;
                conn.Close();
            }
        }

        private void siinav_Load(object sender, EventArgs e)
        {
            MessageBox.Show("x="+x.ToString());
            sinav_ogr_id = yogr.id;
           // MessageBox.Show(z.ToString());
            //MessageBox.Show(  yogr.id.ToString());
            label1.Text = yogr.id.ToString();
            sorular();
            conn.Open();
            com1 = new SqlCommand("SELECT  soru_photo  from soru_tbl where ID=@id", conn);
            com1.Parameters.AddWithValue("@id", soru[x]);
            DataTable table = new DataTable();
            da = new SqlDataAdapter(com1);
            da.Fill(table);
            Byte[] img = (Byte[])table.Rows[0][0];
            MemoryStream ms = new MemoryStream(img);
            pictureBox1.Image = Image.FromStream(ms);
            conn.Close();
            conn.Open();
            com2 = new SqlCommand("SELECT soru_cevap  from soru_tbl where ID=@id", conn);
            com2.Parameters.AddWithValue("@id", soru[x]);
            secencevap = (string)com2.ExecuteScalar();
            conn.Close();
            //x++;
            //z++;
            MessageBox.Show("x=" + x.ToString());
        }
        public void imggetir()
        {
            conn.Open();
            com1 = new SqlCommand("SELECT soru_photo,soru_cevap  from soru_tbl where ID=@id", conn);
            com1.Parameters.AddWithValue("@id", soru[x]);
            DataTable table = new DataTable();
            da = new SqlDataAdapter(com1);
            da.Fill(table);
            
            Byte[] img = (Byte[])table.Rows[0][0];
            MemoryStream ms = new MemoryStream(img);
            pictureBox1.Image = Image.FromStream(ms);
            conn.Close();
            conn.Open();
            com2 = new SqlCommand("SELECT soru_cevap  from soru_tbl where ID=@id", conn);
            com2.Parameters.AddWithValue("@id", soru[x]);
            secencevap = (string)com2.ExecuteScalar();
            conn.Close();
            x++;
            RadioButunSifirla();


        }

        private void nextbutton_Click(object sender, EventArgs e)
        {
            if (x < 10)
            {
               // MessageBox.Show(secencevap);
                if (cevapA.Checked)
                {
                    if (cevapA.Text == secencevap)
                    {
                        dogru_soru_sayisi++;
                    }
                    else 
                    { 
                        yanlis_soru_sayisi++;
                    }
                }
                else if (cevapB.Checked)
                {
                    if (cevapB.Text == secencevap)
                    {
                        dogru_soru_sayisi++;
                    }
                    else
                    {
                        yanlis_soru_sayisi++; 
                    }
                }
                else if (cevapC.Checked)
                {
                    if (cevapC.Text == secencevap)
                    {
                        dogru_soru_sayisi++;
                    }
                    else 
                    {
                        yanlis_soru_sayisi++; 
                    }
                }
                else if (cevapD.Checked)
                {
                    if (cevapD.Text == secencevap)
                    {
                        dogru_soru_sayisi++;
                    }
                    else
                    {
                        yanlis_soru_sayisi++; 
                    }
                }
                else
                {
                    bos_soru_sayisi++;
                }
                toplam_puan = dogru_soru_sayisi * 10;




                //imggetir();
                conn.Open();
                com1 = new SqlCommand("SELECT soru_photo,soru_cevap  from soru_tbl where ID=@id", conn);
                com1.Parameters.AddWithValue("@id", soru[x]);
                DataTable table = new DataTable();
                da = new SqlDataAdapter(com1);
                da.Fill(table);

                Byte[] img = (Byte[])table.Rows[0][0];
                MemoryStream ms = new MemoryStream(img);
                pictureBox1.Image = Image.FromStream(ms);
                conn.Close();
                conn.Open();
                com2 = new SqlCommand("SELECT soru_cevap  from soru_tbl where ID=@id", conn);
                com2.Parameters.AddWithValue("@id", soru[x]);
                secencevap = (string)com2.ExecuteScalar();
                conn.Close();
                x++;
               // MessageBox.Show("x=" + x.ToString());
                RadioButunSifirla();



            }
            //comm = new SqlCommand("INSERT INTO sonuc(ogrenci_id,doğru_soru_sayisi,yanlis_soru_sayisi,bos_soru_sayisi,toplam_puan) VALUES (@oid,@dogru,@yanlis,@bos,@puan)  ");
            else
            {
                sinavbitir();
                
                
            }
        }


        public void sinavbitir()
        {
            result();
            sonuc son = new sonuc();
            son.Show();
            this.Hide();

        }
        


        public  void result()
        {
            conn.Open();
            string rez = "INSERT INTO sonuc(ogrenci_id,dogru_soru_sayisi,yanlis_soru_sayisi,bos_soru_sayisi,toplam_puan) VALUES (@oid,@dogru,@yanlis,@bos,@puan)";

            comm = new SqlCommand(rez, conn);
            comm.Parameters.AddWithValue("@oid", sinav_ogr_id);
            comm.Parameters.AddWithValue("@dogru", dogru_soru_sayisi);
            comm.Parameters.AddWithValue("@yanlis", yanlis_soru_sayisi);
            comm.Parameters.AddWithValue("@bos", bos_soru_sayisi);
            comm.Parameters.AddWithValue("@puan", toplam_puan);


            comm.ExecuteNonQuery();
            conn.Close();

        }
        public void  RadioButunSifirla()
        {
            cevapA.Checked = false;
            cevapB.Checked = false;
            cevapC.Checked = false;
            cevapD.Checked = false;

        }
    }
}
