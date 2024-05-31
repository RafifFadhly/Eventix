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

namespace Eventix
{
    public partial class Buat_Event : Form
    {
        public Parent farent;
        public List<Talent> list = new List<Talent>();
        public string id;
        public Image thumbnail;
        public DateTime waktu_mulai;
        public DateTime waktu_selesai;
        public string id_regular;
        public string id_vip;
        public Buat_Event()
        {
            InitializeComponent();
        }

        private void buat_event_btn_Click(object sender, EventArgs e)
        {
            id = "";
            waktu_mulai = new DateTime(1, 1, 1, (int)jam_mulai.Value, (int)menit_mulai.Value, 0);
            waktu_selesai = new DateTime(1, 1, 1, (int)jam_selesai.Value, (int)menit_selesai.Value, 0);

            Event.Tambah_Update(this);
            Buat_Event_Load(sender, e);
            guna2Button1_Click(sender, e);
        }


        private void pilih_thumbnail_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "File Gambar|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog1.Title = "Pilih Gambar";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Memuat gambar yang dipilih ke dalam PictureBox
                    thumbnail = Image.FromFile(openFileDialog1.FileName);
                    file_thumbnail.Text = thumbnail.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Terjadi kesalahan saat memuat gambar: " + ex.Message);
                }
            }
        }

        private void batal_Click(object sender, EventArgs e)
        {
            Buat_Event_Load(sender,e);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["Hapus"].Index && e.RowIndex >= 0)
            {
                var confirmResult = MessageBox.Show("Apakah Anda yakin ingin menghapus data ini?", "Konfirmasi Penghapusan", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    dataGridView1.Rows.RemoveAt(e.RowIndex);
                    list.RemoveAt(e.RowIndex);
                }
            }
        }

        public void Buat_Event_Load(object sender, EventArgs e)
        {
            id = "";
            Nama.Clear();
            dataGridView1.Rows.Clear();
            Deskripsi.Clear();
            syarat.Clear();
            bank.Text = "";
            rekening.Clear();
            talent_name.Clear();
            Alamat.Clear();
            Linkmaps.Clear();
            jml_tiket_regular.Value = 0;
            jml_tiket_vip.Value = 0;
            harga_tiket_reguler.Value = 0;
            harga_tiket_vip.Value = 0;
            jam_mulai.Value = 0;
            jam_selesai.Value = 0;
            menit_mulai.Value=0;
            menit_selesai.Value=0;
        }

        public Image foto;
        public string nama;

        private void talent_pilih_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "File Gambar|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog1.Title = "Pilih Gambar";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Memuat gambar yang dipilih ke dalam PictureBox
                    foto = Image.FromFile(openFileDialog1.FileName);
                    file_talent.Text = foto.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Terjadi kesalahan saat memuat gambar: " + ex.Message);
                }
            }
        }

        private void tambah_talent_Click(object sender, EventArgs e)
        {
            if (foto != null || talent_name.Text != "")
            {
                Talent Talent = new Talent();
                Talent.nama = talent_name.Text;
                Talent.foto = foto;
                list.Add(Talent);
                dataGridView1.Rows.Add(Talent.foto,Talent.nama);
            }

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Buat_Event_Load(sender, e);
            if(farent.Event_panitia == null)
            {
                farent.Event_panitia = new Event_Sendiri();
                farent.Event_panitia.farent = farent;
            }
            farent.MDI(farent.Event_panitia);
            farent.Event_panitia.Event_Sendiri_Load(sender, e);
        }
    }

}

    public class Talent
    {
        public Image foto;
        public string nama;
    }