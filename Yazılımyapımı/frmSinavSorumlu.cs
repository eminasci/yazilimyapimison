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
    public partial class frmSinavSorumlu : Form
    {
        public frmSinavSorumlu()
        {
            InitializeComponent();
        }
        static string constring = ("Data Source=.;Initial Catalog=yazılımyapımı;Integrated Security=True;");
        SqlConnection baglan = new SqlConnection(constring);
        string imgeLocation = "";
        string cevap = "";
        OpenFileDialog dialog = new OpenFileDialog();

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButtonA.Checked)
            {
                cevap = "A";
            }
            else if (radioButtonB.Checked)
            {
                cevap = "B";
            }
            else if (radioButtonC.Checked)
            {
                cevap = "C";
            }
            else { cevap = "D"; }

            Byte[] images = null;
            FileStream stream = new FileStream(imgeLocation, FileMode.Open, FileAccess.Read);
            BinaryReader brs = new BinaryReader(stream);
            images = brs.ReadBytes((int)stream.Length);
            try
            {
                if (baglan.State == ConnectionState.Closed)
                {
                    baglan.Open();
                    string Rez = "INSERT INTO  soru_tbl(soru_photo,soru_cevap,soru_puan,konu_adi) Values(@photo,@cevap,@puan,@konu)";

                    SqlCommand komut1 = new SqlCommand(Rez, baglan);
                    komut1.Parameters.AddWithValue("@photo", @images);
                    komut1.Parameters.AddWithValue("@cevap", cevap);
                    komut1.Parameters.AddWithValue("@puan", textBoxpuan.Text);
                    komut1.Parameters.AddWithValue("@konu", comboBox1.SelectedItem);


                    komut1.ExecuteNonQuery();

                    MessageBox.Show("Kaydınız yapılmıştır.");
                    sil();
                    baglan.Close();
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show("hata" + hata.Message);

            }
        }

        public void sil()
        {
            textBoxpuan.Clear();
            imgeLocation = "";
            comboBox1.SelectedIndex = -1;
            radioButtonA.Checked = false;
            radioButtonB.Checked = false;
            radioButtonC.Checked = false;
            radioButtonD.Checked = false;
            pictureBox1.Invalidate();
            pictureBox1.Image = null;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            dialog.Filter = "png files (*.png)|*.png|jpg files(*.jpg)|*.jpg|All file (*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imgeLocation = dialog.FileName.ToString();
                pictureBox1.ImageLocation = imgeLocation;

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmSinavSorumlu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'yazılımyapımıDataSet1.soru_tbl' table. You can move, or remove it, as needed.
            this.soru_tblTableAdapter.Fill(this.yazılımyapımıDataSet1.soru_tbl);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
                
                
            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            byte [] imagData =(byte[]) dataGridView1.Rows[e.RowIndex].Cells[2].Value;
            MemoryStream ms = new MemoryStream(imagData);
            pictureBox2.Image = Image.FromStream(ms);





        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
    }
}
