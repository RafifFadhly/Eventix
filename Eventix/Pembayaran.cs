using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Database;
using Microsoft.Extensions.Logging;
using MySql.Data.MySqlClient;

namespace Eventix
{
    public partial class Pembayaran : Form
    {
        public Parent farent;
        public string nama_event;
        public string jenis;
        public int Jml;
        public string tiket_id;
        public string event_id;
        public string penyelenggara_id;
        public int Total, Harga;
        public Pembayaran()
        {
            InitializeComponent();
        }

        public void Pembayaran_Load(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(database_String.connectionString))
            {
                string query = "SELECT * FROM tiket WHERE ID = @id";
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", farent.detail.tiket);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {   

                        foto.Image = farent.detail.foto.Image;
                        Nama_Event.Text = farent.detail.Nama.Text;
                        harga.Text = "Rp. " + reader["Harga"].ToString();
                        Harga = Convert.ToInt32(reader["Harga"]);

                        Jenis.Text = farent.detail.jenis;
                        total.Text = "Rp. " + (Convert.ToInt32(reader["Harga"].ToString()) * farent.detail.jml).ToString();
                        jml.Text = farent.detail.jml.ToString();
                        tiket_id = farent.detail.tiket;
                    }
                }
            }
        }


        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if(Nama.Text != null && NIK.Text != null && Method.Text != null && Wallet.Text != null && Email.Text != null && Wa != null)
            {
                var confirmResult = MessageBox.Show("Apakah Anda yakin ingin membeli tiket ini?", "Konfirmasi", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    Add_Recap();
                    if(farent.proses == null)
                    {
                        farent.proses = new Proses();
                        farent.proses.farent = farent;
                    }
                    farent.proses.rekening.Text = farent.detail.rekening;
                    farent.MDI(farent.proses);
                }
            }
            else
            {
                MessageBox.Show("Isi data dengan lengkap");
            }
        }

        public void Add_Recap()
        {
            using (MySqlConnection conn = new MySqlConnection(database_String.connectionString))
            {
                conn.Open();
                string penggunaQuery = "INSERT INTO rekap_tiket (id, event_id,nama, tiket_id, pengguna_id, tanggal, email, Wa, penyelenggara_id, status, metode, nik, jumlah, total) " +
                                       "VALUES (@id, @event_id,@nama, @tiket_id, @pengguna_id, @tanggal, @email, @Wa, @penyelenggara_id, @status, @metode, @nik, @jml, @total)";
                MySqlCommand cmd = new MySqlCommand(penggunaQuery, conn);

                // Pastikan bahwa All_data.make_id, farent.detail, farent.login, Email, Wa, NIK, jml, total, dan Wallet terdefinisi dan diinisialisasi dengan benar
                cmd.Parameters.AddWithValue("@id", All_data.make_id("rekap_tiket", tiket_id+ farent.login.id));
                cmd.Parameters.AddWithValue("@event_id", farent.detail.id);
                cmd.Parameters.AddWithValue("@nama", Nama.Text);
                cmd.Parameters.AddWithValue("@tiket_id", farent.detail.tiket);
                cmd.Parameters.AddWithValue("@pengguna_id", farent.login.id);
                cmd.Parameters.AddWithValue("@tanggal", DateTime.Now);
                cmd.Parameters.AddWithValue("@email", Email.Text);
                cmd.Parameters.AddWithValue("@Wa", Wa.Text);
                cmd.Parameters.AddWithValue("@penyelenggara_id", farent.detail.Penyelenggara);
                cmd.Parameters.AddWithValue("@status", "belum bayar");
                cmd.Parameters.AddWithValue("@metode", Wallet.Text); // Pastikan Wallet.Text terdefinisi dan diinisialisasi
                cmd.Parameters.AddWithValue("@nik", NIK.Text);
                cmd.Parameters.AddWithValue("@jml", Convert.ToInt32(jml.Text));
                cmd.Parameters.AddWithValue("@total", Convert.ToInt32(total.Text.Replace("Rp.", "").Replace(",", "").Trim()));

                cmd.ExecuteNonQuery();
            }

        }

        private void Method_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Method.Text == "Transfer Bank")
            {
                Wallet.Items.Clear();
                Wallet.Items.Add("BRI");
                Wallet.Items.Add("BNI");
                Wallet.Items.Add("BCA");
                Wallet.Items.Add("Mandiri");

            }
            if (Method.Text == "E-wallet")
            {
                Wallet.Items.Clear();
                Wallet.Items.Add("Q-ris");
                Wallet.Items.Add("Gopay");
                Wallet.Items.Add("ShopeePay");
            }
        }
    }
}
