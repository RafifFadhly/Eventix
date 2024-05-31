using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Database;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;
using System.Net.Http;

namespace Eventix
{
    public partial class Login_Form : Form
    {
        public byte[] imageBytes;
        public string id;
        public string nama_signin;
        public string email_signin;
        public string password_signin;
        public string Wa_signin;
        public string kode;
        public string role;

        public Login_Form()
        {
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {
            Sigin_panel.Visible = false;
            verifikasi_panel.Visible = false;
            Login_Panel.Visible = true;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        private void tampilkan_password_2_CheckedChanged(object sender, EventArgs e)
        {
            if (tampilkan_password_2.Checked) password_sign.PasswordChar = '\0';
            else password_sign.PasswordChar = '*';
        }

        private void tampilkan_password_CheckedChanged(object sender, EventArgs e)
        {
            if (tampilkan_password.Checked) password.PasswordChar = '\0';
            else password.PasswordChar = '*';
        }

        private void login_Click(object sender, EventArgs e)
        {
            if(Profil.Login(email.Text, password.Text,this)) Masuk();
            else MessageBox.Show("email atau password salah");
        }

        private void label7_Click(object sender, EventArgs e)
        {

            Sigin_panel.Visible = false;
            Login_Panel.Visible = true;
        }
        private void daftar_panitia_Click(object sender, EventArgs e)
        {
            role = "penyelenggara";
            Sigin_panel.Visible = true;
            Login_Panel.Visible = false;
        }

        private void daftar_Click(object sender, EventArgs e)
        {
            role = "user";
            Sigin_panel.Visible = true;
            Login_Panel.Visible = false;
        }
        private async void Lanjut_btn_Click(object sender, EventArgs e)
        {
            nama_signin = nama_sign.Text;
            password_signin = password_sign.Text;
            email_signin = email_sign.Text;
            if (Profil.Chek_email(this))
            {
                Make_Kode();
            }
        }
        private void Verifikasi_Click(object sender, EventArgs e)
        {
            if (Verifikasi_Txt.Text == kode)
            {
                verifikasi_panel.Visible=false;
                Berhasil_panel.Visible = true;
            }
            else
            {
                MessageBox.Show("Kode Salah");
            }
        }

        private void kirim_ulang_Click(object sender, EventArgs e)
        {
            Make_Kode();
        }

        private void Masuk_btn_Click(object sender, EventArgs e)
        {
            Profil.Tambah(nama_signin,password_signin,email_signin, role);
            Masuk();
        }

        void Masuk()
        {
            Parent parent = new Parent();
            Profil.Update_masuk(id);
            parent.login = this;
            parent.Show();
            this.Hide();
        }


        void Make_Kode()
        {
            Random random = new Random();
            int randomCode = random.Next(1000, 10000);
            SendEmail(email_signin,"Eventix : Verifikasi Akun Google","Your Code : " + randomCode);
            kode = randomCode.ToString();
        }
        public void SendEmail(string toEmail, string subject, string body)
        {
            string fromEmail = "therfas4@gmail.com"; // Ganti dengan email Anda
            string fromPassword = "llle owvr dxni tneb"; // Ganti dengan password email Anda
            string smtpHost = "smtp.gmail.com"; // Ganti dengan host SMTP email Anda (misal: smtp.gmail.com)
            int smtpPort = 587; // Biasanya port untuk SMTP (misal: 587 untuk TLS atau 465 untuk SSL)

            try
            {
                // Membuat objek MailMessage
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress(fromEmail);
                mail.To.Add(toEmail);
                mail.Subject = subject;
                mail.Body = body;
                mail.IsBodyHtml = true; // Jika ingin mengirim email dengan format HTML

                // Konfigurasi SMTP client
                SmtpClient smtpClient = new SmtpClient(smtpHost, smtpPort);
                smtpClient.Credentials = new NetworkCredential(fromEmail, fromPassword);
                smtpClient.EnableSsl = true; // Mengaktifkan SSL

                // Mengirim email
                smtpClient.Send(mail);
                MessageBox.Show("Email berhasil dikirim.");
                Sigin_panel.Visible = false;
                verifikasi_panel.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal mengirim email: " + ex.Message);
            }
        }

    }
}
