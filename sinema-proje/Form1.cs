using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sinema_proje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string baglanti = "Server=localhost;Database=sinema_veritabani;Uid=root;Pwd='';";
        string hedefDosya = "";

        void ResimSec()
        {
            OpenFileDialog dosya = new OpenFileDialog();
            dosya.Filter = "Resim Dosyası |*.jpg;*.nef;*.png| Video|*.avi| Tüm Dosyalar |*.*";
            dosya.Title = "Dosya Seçiniz";

            if (dosya.ShowDialog() == DialogResult.OK)
            {
                string kaynakDosya = dosya.FileName;
                hedefDosya = Path.Combine("resimler", Guid.NewGuid() + ".jpg");

                //MessageBox.Show(hedefDosya);

                if (!Directory.Exists("resimler"))
                {
                    Directory.CreateDirectory("resimler");
                }


                File.Copy(kaynakDosya, hedefDosya);

            }
        }

        private void VeriGetir()
        {
            using (MySqlConnection con = new MySqlConnection(baglanti))
            {

                string sql = "SELECT *FROM filmler";
                con.Open();

                MySqlCommand cmd = new MySqlCommand(sql, con);

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                DataTable dt = new DataTable();

                da.Fill(dt);

                dgvListe.DataSource = dt;
                dgvListe.Invalidate();
                dgvListe.Refresh();

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            VeriGetir();
        }

        private void dgvListe_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            lblFilmAd.Text = dgvListe.CurrentRow.Cells["filmad"].Value.ToString();
            lblYil.Text = dgvListe.CurrentRow.Cells["yil"].Value.ToString();
            lblTur.Text = dgvListe.CurrentRow.Cells["tur"].Value.ToString();
            lblImdb.Text = dgvListe.CurrentRow.Cells["imdb_puan"].Value.ToString();
            txtOzet.Text = dgvListe.CurrentRow.Cells["ozet"].Value.ToString() ;
            pbPoster.ImageLocation = dgvListe.CurrentRow.Cells[5].Value.ToString();
        }

        private void btnEklePoster_Click(object sender, EventArgs e)
        {
            ResimSec();
            pbEklePoster.ImageLocation = hedefDosya;
            pbEklePoster.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            using (MySqlConnection con = new MySqlConnection(baglanti))
            {

                string sql = "INSERT INTO filmler (filmad,tur,yil,imdb_puan,film_posteri,ozet) VALUES (@filmad,@tur,@yil,@imdb,@poster,@ozet);";

                con.Open();



                MySqlCommand cmd = new MySqlCommand(sql, con);

                cmd.Parameters.AddWithValue("@filmad", txtEkleFilmAd.Text);
                cmd.Parameters.AddWithValue("@tur", cmbEkleTur.Text);
                cmd.Parameters.AddWithValue("@yil", txtEkleYil.Text);
                cmd.Parameters.AddWithValue("@imdb", txtEklePuan.Text);
                cmd.Parameters.AddWithValue("@poster", hedefDosya);
                cmd.Parameters.AddWithValue("@ozet", txtEkleOzet.Text);
                cmd.Parameters.AddWithValue("@id", id);



                DialogResult result = MessageBox.Show("Film eklensin mi?", "Film Ekle", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    cmd.ExecuteNonQuery();

                    txtEkleFilmAd.Clear();
                    txtEkleOzet.Clear();
                    txtEklePuan.Clear();
                    txtEkleYil.Clear();
                    cmbEkleTur.SelectedIndex = -1;
                    pbEklePoster.Image = null;
                }

                VeriGetir();

            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            using (MySqlConnection con = new MySqlConnection(baglanti))
            {
                string sql = "DELETE FROM filmler WHERE id=@id";
                int secilenId = Convert.ToInt32(dgvListe.CurrentRow.Cells["id"].Value);

                con.Open();

                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@id", secilenId);

                DialogResult result = MessageBox.Show("Film silinsin mi?", "Film Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    cmd.ExecuteNonQuery();
                    VeriGetir();
                }
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (MySqlConnection con = new MySqlConnection(baglanti))
            {

                string sql = "UPDATE filmler SET filmad=@filmad,tur=@tur,yil=@yil,imdb_puan=@imdb,film_posteri=@poster,ozet=@ozet WHERE id=@id";

                con.Open();



                MySqlCommand cmd = new MySqlCommand(sql, con);

                cmd.Parameters.AddWithValue("@filmad", txtGuncelleFilmAd.Text);
                cmd.Parameters.AddWithValue("@tur",cmbGuncelleTur.Text);
                cmd.Parameters.AddWithValue("@yil", Convert.ToInt32(txtGuncelleYil.Text));
                cmd.Parameters.AddWithValue("@imdb", Convert.ToDecimal(txtGuncellePuan.Text));
                cmd.Parameters.AddWithValue("@poster", hedefDosya);
                cmd.Parameters.AddWithValue("@ozet", txtGuncelleOzet.Text);
                //cmd.Parameters.AddWithValue("@id", secimId);



                DialogResult result = MessageBox.Show("Film eklensin mi?", "Film Ekle", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    cmd.ExecuteNonQuery();

                }

                VeriGetir();


            }
        }
    }
}
