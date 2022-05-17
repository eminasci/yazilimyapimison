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
    public partial class frmOgrenciSonucEkrani : Form
    {
        public frmOgrenciSonucEkrani()
        {
            InitializeComponent();
        }
        public ogrenci ogr_sin_sonuc = new ogrenci();

        private void frmOgrenciSonucEkrani_Load(object sender, EventArgs e)
        {
            MessageBox.Show();
            //SqlConnection conn = new SqlConnection("Data Source =.; Initial Catalog = yazılımyapımı; Integrated Security = True;");
            //SqlCommand comm= com1 = new SqlCommand("SELECT soru_photo,soru_cevap  from soru_tbl where ID=@id", conn);
            //com1.Parameters.AddWithValue("@id", soru[x]);
        }
    }
}
