using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Database;
using Guna.UI2.WinForms;

namespace Eventix
{
    public partial class Profil_Edit : Form
    {
        public Parent farent;
        string nama;
        public Profil_Edit()
        {
            InitializeComponent();
        }
        private void Profil_Edit_Load(object sender, EventArgs e)
        {
            refresh();
            if (farent.login.role == "penyelenggara")
            {
                Wa.Visible = true;
                wa_no.Visible = true;
            }
            else
            {
                wa_no.Visible = false;
                Wa.Visible = false;
            }
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            farent.Hide();
            Login_Form login = new Login_Form();
            login.Show();
        }

        private void Hapus_Click(object sender, EventArgs e)
        {
            All_data.Hapus("pengguna",farent.login.id,false);
            farent.Hide();
            Login_Form login = new Login_Form();
            login.Show();
        }

        void refresh()
        {
            Foto.Image =  farent.profil.Image;
            Nama_title.Text = nama;
            role.Text = farent.login.role;
            Nama.Text = farent.login.nama_signin;
            PW.Text = farent.login.password_signin;
            Email.Text = farent.login.email_signin;
            Wa.Text = farent.login.Wa_signin;
        }

        private void Simpan_Click(object sender, EventArgs e)
        {
            byte[] imageBytes = ConvertPictureBoxImageToByteArray(Foto);

            if (imageBytes != null)
            {
                try
                {
                    Profil.Update(imageBytes, farent.login.id, Nama.Text, PW.Text, Email.Text, Wa.Text);

                    Profil.Login(farent.login.email_signin, PW.Text, farent.login);
                    refresh();
                    farent.Parent_Load(sender, e);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Terjadi kesalahan: " + ex.Message);
                }
            }
        }
        private byte[] ConvertPictureBoxImageToByteArray(PictureBox pictureBox)
        {
            if (pictureBox.Image != null)
            {
                using (Bitmap bmp = new Bitmap(pictureBox.Image))
                {
                    // Buat objek ImageConverter
                    ImageConverter converter = new ImageConverter();

                    // Konversi gambar menjadi byte array
                    return (byte[])converter.ConvertTo(bmp, typeof(byte[]));
                }
            }
            else
            {
                MessageBox.Show("Tidak ada gambar yang dipilih.");
                return null;
            }
        }

        private void Edit_Foto_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "File Gambar|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog1.Title = "Pilih Gambar";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Memuat gambar yang dipilih ke dalam PictureBox
                    Foto.Image = Image.FromFile(openFileDialog1.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Terjadi kesalahan saat memuat gambar: " + ex.Message);
                }
            }
        }

        private void tampilkan_password_2_CheckedChanged(object sender, EventArgs e)
        {
            if (tampilkan_password_2.Checked) PW.PasswordChar = '\0';
            else PW.PasswordChar = '*';
        }
    }
}
