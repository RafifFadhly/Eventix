using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using MySql.Data.MySqlClient;
using Eventix;
using Guna;
using Microsoft.Web.WebView2.WinForms;
using Guna.UI2.WinForms;
using System.Management.Instrumentation;
using Encrypt;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static Mysqlx.Notice.Warning.Types;
using System.Collections;
using Microsoft.Extensions.Logging;
using Org.BouncyCastle.Asn1.Cms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using K4os.Compression.LZ4.Streams;
using Microsoft.AspNetCore.Routing;

namespace Database
{
    public class database_String
    {
        public static string connectionString = "server=localhost;user=root;password=;database=Eventix;";
    }
    public static class Profil
    {
        public static string tampilkan = "SELECT * FROM pengguna ";
        public static void View_Profil_Mini(string ID, Guna2PictureBox profil, Label nama, Label Wa)
        {
            using (MySqlConnection conn = new MySqlConnection(database_String.connectionString))
            {
                conn.Open();
                MySqlCommand penggunaCmd = new MySqlCommand(tampilkan + " WHERE ID = @ID", conn);
                penggunaCmd.Parameters.AddWithValue("@ID", CaesarCipher.Encrypt(ID));

                using (MySqlDataReader penggunaReader = penggunaCmd.ExecuteReader())
                {
                    if (penggunaReader.Read())
                    {
                        if (!penggunaReader.IsDBNull(penggunaReader.GetOrdinal("Foto")))
                        {
                            byte[] imageBytes = (byte[])penggunaReader["Foto"];
                            if (imageBytes.Length > 0)
                            {
                                using (MemoryStream ms = new MemoryStream(imageBytes))
                                {
                                    profil.Image = Image.FromStream(ms);
                                }
                            }
                        }
                        string[] words = CaesarCipher.Decrypt(penggunaReader["Nama"].ToString()).Split(' ');
                        nama.Text = words[0];
                        if (Wa != null) Wa.Text = CaesarCipher.Decrypt(penggunaReader["Wa"].ToString());
                    }
                }
            }
        }
        public static bool Login(string email, string password, Login_Form login)
        {
            using (MySqlConnection conn = new MySqlConnection(database_String.connectionString))
            {
                conn.Open();
                MySqlCommand penggunaCmd = new MySqlCommand(tampilkan + "WHERE Email = @email", conn);
                penggunaCmd.Parameters.AddWithValue("@email", CaesarCipher.Encrypt(email));

                using (MySqlDataReader penggunaReader = penggunaCmd.ExecuteReader())
                {
                    if (penggunaReader.Read())
                    {
                        login.id = CaesarCipher.Decrypt(penggunaReader["ID"].ToString());
                        login.role = CaesarCipher.Decrypt(penggunaReader["Level"].ToString());
                        if (password == CaesarCipher.Decrypt(penggunaReader["Password"].ToString()))
                        {
                            login.password_signin = CaesarCipher.Decrypt(penggunaReader["Password"].ToString());
                            login.nama_signin = CaesarCipher.Decrypt(penggunaReader["Nama"].ToString());
                            login.email_signin = CaesarCipher.Decrypt(penggunaReader["Email"].ToString());
                            login.Wa_signin = CaesarCipher.Decrypt(penggunaReader["Wa"].ToString());
                            return true;
                        }
                        else return false;
                    }
                    else return false;
                }
            }
        }

        public static void Update_masuk(string id)
        {
            using (MySqlConnection conn = new MySqlConnection(database_String.connectionString))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("UPDATE pengguna SET Masuk = @Masuk WHERE ID = @ID;", conn);
                cmd.Parameters.AddWithValue("@ID", CaesarCipher.Encrypt(id));
                cmd.Parameters.AddWithValue("@Masuk", DateTime.Now);
                cmd.ExecuteNonQuery();
            }
        }
        public static void Update_keluar(string id)
        {
            using (MySqlConnection conn = new MySqlConnection(database_String.connectionString))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("UPDATE pengguna SET Keluar = @Keluar WHERE ID = @ID;", conn);
                cmd.Parameters.AddWithValue("@ID", CaesarCipher.Encrypt(id));
                cmd.Parameters.AddWithValue("@Keluar", DateTime.Now);
                cmd.ExecuteNonQuery();
            }
        }
        public static void Tambah(string nama, string pw, string email, string level)
        {
            using (MySqlConnection conn = new MySqlConnection(database_String.connectionString))
            {
                conn.Open();
                string id = All_data.make_id("pengguna", nama);
                MySqlCommand penggunaCmd = new MySqlCommand("INSERT INTO pengguna (Nama, Password, ID,Email,Level,Login,Masuk)VALUES (@nama, @password, @id, @email,@Level,@Login,@Masuk);", conn);

                penggunaCmd.Parameters.AddWithValue("@nama", CaesarCipher.Encrypt(nama));
                penggunaCmd.Parameters.AddWithValue("@password", CaesarCipher.Encrypt(pw));
                penggunaCmd.Parameters.AddWithValue("@id", CaesarCipher.Encrypt(id));
                penggunaCmd.Parameters.AddWithValue("@email", CaesarCipher.Encrypt(email));
                penggunaCmd.Parameters.AddWithValue("@Level", CaesarCipher.Encrypt(level));
                penggunaCmd.Parameters.AddWithValue("@Login", DateTime.Now);
                penggunaCmd.Parameters.AddWithValue("@Masuk", DateTime.Now);
                penggunaCmd.ExecuteNonQuery();
            }
        }
        public static void Update(byte[] picture, string id, string nama, string pw, string email, string wa)
        {
            using (MySqlConnection conn = new MySqlConnection(database_String.connectionString))
            {
                conn.Open();
                MySqlCommand penggunaCmd = new MySqlCommand("UPDATE pengguna SET Foto = @foto, Nama = @nama, Wa = @wa, Password = @pw, Email = @email WHERE ID = @id", conn);

                penggunaCmd.Parameters.AddWithValue("@foto", picture);
                penggunaCmd.Parameters.AddWithValue("@nama", CaesarCipher.Encrypt(nama));
                penggunaCmd.Parameters.AddWithValue("@wa", CaesarCipher.Encrypt(wa));
                penggunaCmd.Parameters.AddWithValue("@pw", CaesarCipher.Encrypt(pw));
                penggunaCmd.Parameters.AddWithValue("@id", CaesarCipher.Encrypt(id));
                penggunaCmd.Parameters.AddWithValue("@email", CaesarCipher.Encrypt(email));

                penggunaCmd.ExecuteNonQuery();
            }
        }

        public static bool Chek_email(Login_Form login)
        {
            using (MySqlConnection conn = new MySqlConnection(database_String.connectionString))
            {
                conn.Open();

                MySqlCommand cmd = new MySqlCommand(tampilkan + "WHERE Email = @email", conn);
                cmd.Parameters.AddWithValue("@email", CaesarCipher.Encrypt(login.email_signin));

                using (MySqlDataReader penggunaReader = cmd.ExecuteReader())
                {
                    if (penggunaReader.Read())
                    {
                        MessageBox.Show("Email sudah di gunakan");
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
            }
        }

    }
    public static class Event
    {
        public static string tampilkan = "SELECT * FROM Event ";
        public static void View_Talent(string ID, FlowLayoutPanel Parent_panel)
        {
            string penggunaQuery;
            using (MySqlConnection conn = new MySqlConnection(database_String.connectionString))
            {
                conn.Open();
                penggunaQuery = "SELECT * FROM talent WHERE ID_Event = @ID";
                MySqlCommand cmd = new MySqlCommand(penggunaQuery, conn);
                cmd.Parameters.AddWithValue("@ID", ID);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    Parent_panel.Controls.Clear();
                    while (reader.Read())
                    {
                        Panel panel = new Panel();
                        panel.Padding = new Padding(2);
                        panel.BackColor = SystemColors.Control;
                        panel.ForeColor = Color.Black;
                        panel.Height = 55;
                        panel.Width = 300;

                        FlowLayoutPanel flowPanel = new FlowLayoutPanel
                        {
                            FlowDirection = FlowDirection.LeftToRight,
                            Width = panel.Width,
                            Height = panel.Height,
                            BackColor = Color.White,
                            Padding = new Padding(2)
                        };

                        Guna2PictureBox foto = new Guna2PictureBox();
                        foto.Width = panel.Width * 1 / 6;
                        foto.Height = foto.Width;
                        foto.SizeMode = PictureBoxSizeMode.StretchImage;
                        foto.BorderRadius = 25;
                        if (!reader.IsDBNull(reader.GetOrdinal("Foto_Talent")))
                        {
                            byte[] imageBytes = (byte[])reader["Foto_Talent"];
                            using (MemoryStream ms = new MemoryStream(imageBytes))
                            {
                                foto.Image = Image.FromStream(ms);
                            }
                        }

                        Label nama = new Label();
                        nama.Width = panel.Width * 4 / 6;
                        nama.Font = new Font("Montserrat", panel.Width / 25, FontStyle.Bold);
                        if (!reader.IsDBNull(reader.GetOrdinal("Nama_Talent")))
                        {
                            nama.Text = reader["Nama_Talent"].ToString();
                        }

                        flowPanel.Controls.Add(foto);
                        flowPanel.Controls.Add(nama);

                        panel.Controls.Add(flowPanel);
                        Parent_panel.Controls.Add(panel);
                    }
                }
            }
        }
        public static void View_Event_Content(string query_Tambahan, FlowLayoutPanel flowLayoutPanel1, Parent parent)
        {
            using (MySqlConnection conn = new MySqlConnection(database_String.connectionString))
            {
                conn.Open();
                string ID = "";
                MySqlCommand cmd = new MySqlCommand(tampilkan + query_Tambahan, conn);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    flowLayoutPanel1.Controls.Clear();
                    while (reader.Read())
                    {
                        Guna2CustomGradientPanel panel = new Guna2CustomGradientPanel();
                        if (parent.login.role == "penyelenggara")
                        {
                            if (flowLayoutPanel1.Width >= 850)
                            {
                                panel.Width = flowLayoutPanel1.Width * 25 / 105;
                                panel.Height = flowLayoutPanel1.Width * 30 / 105;
                            }
                            else
                            {
                                panel.Width = flowLayoutPanel1.Width * 25 / 60;
                                panel.Height = flowLayoutPanel1.Width * 30 / 60;
                            }
                        }
                        else
                        {
                            if (flowLayoutPanel1.Width >= 850)
                            {
                                panel.Width = flowLayoutPanel1.Width * 25 / 105;
                                panel.Height = flowLayoutPanel1.Width * 26 / 105;
                            }
                            else
                            {
                                panel.Width = flowLayoutPanel1.Width * 25 / 60;
                                panel.Height = flowLayoutPanel1.Width * 40 / 60;
                            }
                        }
                        string id = reader["ID"].ToString();
                        if (parent.login.role == "penyelenggara")
                        {
                            Guna2Button delete = new Guna2Button()
                            {
                                Dock = DockStyle.Top,
                                Width = panel.Width,
                                Height = panel.Height / 9,
                                BackColor = Color.White,
                                Text = "🗑️ Hapus Event",
                                FillColor = Color.Blue,
                                ForeColor = Color.White,
                                BorderRadius = 20
                            };
                            delete.Click += (s, e) => OnButtonDelete(parent,id);
                            panel.Controls.Add(delete);
                        }

                        panel.BorderRadius = 20;
                        panel.Padding = new Padding(10);
                        panel.BackColor = SystemColors.Control;
                        panel.FillColor = Color.White;
                        panel.ForeColor = Color.Blue;

                        FlowLayoutPanel flowPanel = new FlowLayoutPanel
                        {
                            FlowDirection = FlowDirection.LeftToRight,
                            Dock = DockStyle.Top,
                            Width = panel.Width,
                            Height = panel.Height / 8,
                            BackColor = Color.White
                        };


                        Label tiket = new Label();
                        tiket.Width = panel.Width * 3 / 5;
                        tiket.Height = flowPanel.Height;
                        tiket.TextAlign = ContentAlignment.MiddleLeft;
                        tiket.Padding = new Padding(panel.Width / 70);
                        tiket.Font = new Font("Montserrat", panel.Width / 30, FontStyle.Bold);
                        tiket.Text = "Rp." + Tiket(ID = reader["ID"].ToString(), "regular", false) + ",00";


                        Guna2Button button = new Guna2Button();
                        button.Width = panel.Width * 1 / 4;
                        button.Height = flowPanel.Height - flowPanel.Height / 5;
                        if (parent.login.role == "user") button.Text = "Beli Tiket";
                        else button.Text = "Detail";
                        button.FillColor = Color.Blue;
                        button.BorderRadius = 5;
                        button.ForeColor = Color.White;
                        button.Font = new Font("Montserrat", panel.Width / 40, FontStyle.Bold);

                        button.Click += (s, e) => OnButtonClick(parent, id);
                        flowPanel.Controls.Add(tiket);
                        flowPanel.Controls.Add(button);

                        panel.Controls.Add(flowPanel);

                        Label ket = new Label();
                        ket.Width = panel.Width;
                        ket.Height = panel.Height / 7;
                        ket.Dock = DockStyle.Top;
                        DateTime tanggal_mulai = (DateTime)reader["Tanggal_mulai"];
                        DateTime tanggal_selesai; string tanggal;
                        if (!reader.IsDBNull(reader.GetOrdinal("Tanggal_selesai")))
                        {
                            if ((DateTime)reader["Tanggal_selesai"] == (DateTime)reader["Tanggal_mulai"])
                            {
                                tanggal_selesai = (DateTime)reader["Tanggal_selesai"];
                                tanggal = tanggal_mulai.ToString("dd MMMM yyyy") + " - " + tanggal_selesai.ToString("dd MMMM yyyy");
                            }
                            else{
                                tanggal = tanggal_mulai.ToString("dd MMMM yyyy");

                            }
                        }
                        else
                        {
                            tanggal = tanggal_mulai.ToString("dd MMMM yyyy");
                        }
                        ket.Text = "📅 " + tanggal + Environment.NewLine + "📌 " + reader["Alamat"].ToString();
                        ket.TextAlign = ContentAlignment.MiddleLeft;
                        ket.Font = new Font("Montserrat", panel.Width / 30, FontStyle.Bold);
                        ket.Padding = new Padding(panel.Width / 70);
                        ket.BackColor = Color.White;

                        panel.Controls.Add(ket);

                        Label nama = new Label();
                        nama.Width = panel.Width;
                        nama.Height = panel.Height * 5 / 30;
                        nama.TextAlign = ContentAlignment.MiddleLeft;
                        nama.Dock = DockStyle.Top;
                        nama.Text = reader["Nama"].ToString();
                        nama.Font = new Font("Montserrat", panel.Width / 25, FontStyle.Bold);
                        nama.Padding = new Padding(panel.Width / 70);
                        nama.BackColor = Color.White;

                        panel.Controls.Add(nama);

                        ID = reader["ID"].ToString();
                        Guna2PictureBox pictureBox = new Guna2PictureBox();
                        byte[] imageBytes = (byte[])reader["Foto"];
                        using (MemoryStream ms = new MemoryStream(imageBytes))
                        {
                            pictureBox.Image = Image.FromStream(ms);
                        }
                        pictureBox.Dock = DockStyle.Top;
                        pictureBox.BackColor = Color.Black;
                        pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBox.Width = panel.Width;
                        pictureBox.Height = panel.Height * 4 / 10;
                        pictureBox.BackColor = Color.White;
                        pictureBox.BorderRadius = 20;
                        panel.Controls.Add(pictureBox);
                        flowLayoutPanel1.Controls.Add(panel);
                    }
                }
            }
        }

        public static void View_Event_Detail(string ID_Event, Details detail)
        {
            string id_penyelenggara = "";
            using (MySqlConnection conn = new MySqlConnection(database_String.connectionString))
            {
                conn.Open();
                MySqlCommand eventCmd = new MySqlCommand(tampilkan + "WHERE ID = @ID", conn);
                eventCmd.Parameters.AddWithValue("@ID", ID_Event);

                using (MySqlDataReader eventReader = eventCmd.ExecuteReader())
                {
                    if (eventReader.Read())
                    {
                        byte[] imageBytes = (byte[])eventReader["Foto"];
                        using (MemoryStream ms = new MemoryStream(imageBytes))
                        {
                            detail.foto.Image = Image.FromStream(ms);
                        }

                        detail.Nama.Text = eventReader["Nama"].ToString();
                        DateTime waktu_mulai = (DateTime)eventReader["Waktu_Mulai"];
                        DateTime waktu_selesai = (DateTime)eventReader["Waktu_Selesai"];
                        DateTime tanggal_mulai = (DateTime)eventReader["Tanggal_mulai"];
                        DateTime tanggal_selesai = (DateTime)eventReader["Tanggal_mulai"]; ;
                        if (!eventReader.IsDBNull(eventReader.GetOrdinal("Tanggal_selesai")))
                        {
                            tanggal_selesai = (DateTime)eventReader["Tanggal_selesai"];
                            detail.Tanggal.Text = tanggal_mulai.ToString("dd MMMM yyyy") + " - " + tanggal_selesai.ToString("dd MMMM yyyy");
                        }
                        else
                        {
                            detail.Tanggal.Text = tanggal_mulai.ToString("dd MMM yyyy");
                        }

                        detail.Waktu.Text = waktu_mulai.ToString("HH:mm") + " - " + waktu_selesai.ToString("HH:mm");
                        detail.Lokasi.Text = eventReader["Alamat"].ToString();
                        if (!eventReader.IsDBNull(eventReader.GetOrdinal("Deskripsi")))
                        {
                            string originalString = eventReader["Deskripsi"].ToString();
                            char separator = '^';
                            string[] splitStrings = originalString.Split(new char[] { separator }, 2);

                            if (splitStrings.Length == 2)
                            {
                                detail.Deskripsi.Text = Environment.NewLine + splitStrings[0];
                                detail.Syarat.Text = Environment.NewLine + splitStrings[1];
                            }
                        }
                        if (!eventReader.IsDBNull(eventReader.GetOrdinal("Link_Maps")))
                            detail.Maps.Source = new Uri(eventReader["Link_Maps"].ToString());
                        id_penyelenggara = eventReader["ID_Penyelenggara"].ToString();

                        detail.H_Tiket_reguler.Text = "Rp." + Tiket(eventReader["ID"].ToString(), "regular", false) + ",00";
                        detail.H_Tiket_vip.Text = "Rp." + Tiket(eventReader["ID"].ToString(), "vip", false) + ",00";

                        detail.id_tiket_regular = Tiket(eventReader["ID"].ToString(), "regular", true);
                        detail.id_tiket_vip = Tiket(eventReader["ID"].ToString(), "vip", true);

                        detail.tgl_buat.Text = eventReader["Tanggal_Buat"].ToString();
                        View_Talent(eventReader["ID"].ToString(), detail.Talent_flow);
                        detail.id = eventReader["ID"].ToString();
                        detail.Penyelenggara = eventReader["ID_Penyelenggara"].ToString();
                        detail.rekening = eventReader["Rekening"].ToString();

                        if (detail.farent.login.role == "user")
                        {
                            detail.tiket_sisa_relgular.Visible = false;
                            detail.tiket_sisa_vip.Visible = false;
                            detail.tiket_terjual_regular.Visible = false;
                            detail.tiket_terjual_vip.Visible = false;
                        }
                        else
                        {
                            detail.tiket_sisa_relgular.Text = "Jumlah Tiket Teresisa " + view_admin.Tiket(detail.id_tiket_regular, "regular", true);
                            detail.tiket_terjual_regular.Text = "Jumlah Tiket Terjual " + view_admin.Tiket(detail.id_tiket_regular, "regular", false);
                            detail.tiket_sisa_vip.Text = "Jumlah Tiket Teresisa " + view_admin.Tiket(detail.id_tiket_vip, "vip", true);
                            detail.tiket_terjual_vip.Text = "Jumlah Tiket Terjual " + view_admin.Tiket(detail.id_tiket_vip, "vip", false);
                            detail.jml_regular.Visible = false;
                            detail.jml_vip.Visible = false;
                        }
                        if (Convert.ToInt32(view_admin.Tiket(detail.id_tiket_regular, "regular", true)) <= 0)
                        {
                            detail.status_regular.FillColor = Color.Red;
                            detail.status_regular.ForeColor = Color.White;
                            detail.status_regular.Text = "Sold out";
                        }
                        if (Convert.ToInt32(view_admin.Tiket(detail.id_tiket_vip, "vip", true)) <= 0)
                        {
                            detail.status_vip.FillColor = Color.Red;
                            detail.status_vip.ForeColor = Color.White;
                            detail.status_vip.Text = "Sold out";
                        }
                    }
                }
            }
            Profil.View_Profil_Mini(id_penyelenggara, detail.Profil, detail.penyelenggara, detail.Wa);
        }

        private static void OnButtonDelete(Parent parent, string id)
        {
            All_data.Hapus("event", id, false);

            using (MySqlConnection connection = new MySqlConnection(database_String.connectionString))
            {
                connection.Open();
                string sql = "DELETE FROM tiket WHERE id_Event = @id";
                MySqlCommand command = new MySqlCommand(sql, connection);
                command.Parameters.AddWithValue("@id", id);
                command.ExecuteNonQuery();
            }
            using (MySqlConnection connection = new MySqlConnection(database_String.connectionString))
            {
                connection.Open();
                string sql = "DELETE FROM Talent WHERE id_Event = @id";
                MySqlCommand command = new MySqlCommand(sql, connection);
                command.Parameters.AddWithValue("@id", id);
                command.ExecuteNonQuery();
            }

            View_Event_Content(" WHERE ID_Penyelenggara = '" + parent.login.id + "'", parent.Event_panitia.flowLayoutPanel1, parent);
        }

        public static void View_Event_Tiket(Pembayaran bayar, string id)
        {
            using (MySqlConnection conn = new MySqlConnection(database_String.connectionString))
            {
                conn.Open();
                MySqlCommand eventCmd = new MySqlCommand(tampilkan + "WHERE ID = @ID", conn);
                eventCmd.Parameters.AddWithValue("@ID", CaesarCipher.Encrypt(id));

                using (MySqlDataReader eventReader = eventCmd.ExecuteReader())
                {
                    if (eventReader.Read())
                    {
                        if (!eventReader.IsDBNull(eventReader.GetOrdinal("Foto")))
                        {
                            byte[] imageBytes = (byte[])eventReader["Foto"];
                            using (MemoryStream ms = new MemoryStream(imageBytes))
                            {
                                bayar.foto.Image = Image.FromStream(ms);
                            }
                        }

                        bayar.Nama.Text = eventReader["Nama"].ToString();
                    }
                }
            }
        }
        private static void OnButtonClick(Parent parent, string id)
        {
            if (parent.detail == null)
            {
                parent.detail = new Details();
                parent.detail.farent = parent;
            }
            Details detail = parent.detail;
            parent.detail = detail;
            parent.MDI(detail);

            View_Event_Detail(id, detail);
        }
        public static void Tambah_Update(Buat_Event Event)
        {
            string ID = "";
            using (MySqlConnection conn = new MySqlConnection(database_String.connectionString))
            {
                string query = "INSERT INTO event (ID,Nama,Foto,Deskripsi,Alamat,Link_Maps,Kategori,Waktu_Mulai,Waktu_Selesai,Tanggal_mulai,Tanggal_selesai,Tanggal_buat,Bank,Rekening,ID_Penyelenggara) " +
                               "VALUES (@ID,@Nama,@Foto,@Deskripsi,@Alamat,@Link_Maps,@Kategori,@Waktu_Mulai,@Waktu_Selesai,@Tanggal_mulai,@Tanggal_selesai,@Tanggal_dibuat,@Bank,@Rekening,@ID_Penyelenggara)";

                conn.Open();
                MySqlCommand penggunaCmd = new MySqlCommand(query, conn);

                string ID_ = All_data.make_id("event", Event.Nama.Text);
                ID = ID_;
                penggunaCmd.Parameters.AddWithValue("@ID", ID_);
                penggunaCmd.Parameters.AddWithValue("@Tanggal_dibuat", DateTime.Now);
                penggunaCmd.Parameters.AddWithValue("@ID_Penyelenggara", Event.farent.login.id); // Fixed parameter name to match query
                penggunaCmd.Parameters.AddWithValue("@Nama", Event.Nama.Text);
                penggunaCmd.Parameters.AddWithValue("@Foto", ConvertPictureBoxImageToByteArray(Event.thumbnail));
                penggunaCmd.Parameters.AddWithValue("@Deskripsi", Event.Deskripsi.Text + "'^'" + Event.syarat.Text);
                penggunaCmd.Parameters.AddWithValue("@Alamat", Event.Alamat.Text);
                penggunaCmd.Parameters.AddWithValue("@Link_Maps", Event.Linkmaps.Text);
                penggunaCmd.Parameters.AddWithValue("@Kategori", Event.kategori.Text);
                penggunaCmd.Parameters.AddWithValue("@Waktu_Mulai", Event.waktu_mulai);
                penggunaCmd.Parameters.AddWithValue("@Waktu_Selesai", Event.waktu_selesai);
                penggunaCmd.Parameters.AddWithValue("@Tanggal_mulai", Event.tgl_mulai.Value);
                penggunaCmd.Parameters.AddWithValue("@Tanggal_selesai", Event.tgl_selesai.Value);
                penggunaCmd.Parameters.AddWithValue("@Bank", Event.bank.Text);
                penggunaCmd.Parameters.AddWithValue("@Rekening", Event.rekening.Text);

                penggunaCmd.ExecuteNonQuery();
            }

            foreach (Talent Talent in Event.list)
            {
                Tambah_talent(ID, Talent.foto, Talent.nama);
            }

            Event.id_regular = Tambah_tiket(ID, "regular", (int)Event.harga_tiket_reguler.Value, (int)Event.jml_tiket_regular.Value);
            Event.id_vip = Tambah_tiket(ID, "vip", (int)Event.harga_tiket_vip.Value, (int)Event.jml_tiket_vip.Value);
        }
        public static string Tambah_tiket(string id, string jenis, int harga, int Jml)
        {
            using (MySqlConnection conn = new MySqlConnection(database_String.connectionString))
            {
                string query = "INSERT INTO tiket (ID, ID_Event,Harga,Kategori,Jml) VALUES (@ID,@Id_Event ,@Harga,@Kategori,@Jml)";
                conn.Open();
                MySqlCommand penggunaCmd = new MySqlCommand(query, conn);

                penggunaCmd.Parameters.AddWithValue("@ID", jenis + "_" + id);
                penggunaCmd.Parameters.AddWithValue("@ID_Event", id);
                penggunaCmd.Parameters.AddWithValue("@Harga", harga);
                penggunaCmd.Parameters.AddWithValue("@Kategori", jenis);
                penggunaCmd.Parameters.AddWithValue("@Jml", Jml);

                penggunaCmd.ExecuteNonQuery();

                return jenis + "_" + id;
            }
        }
        public static void Tambah_talent(string id, Image foto, string nama)
        {
            using (MySqlConnection conn = new MySqlConnection(database_String.connectionString))
            {
                string query = "INSERT INTO talent (ID_Event,Foto_Talent,nama_Talent) VALUES (@Id_Event ,@foto,@nama)";
                conn.Open();
                MySqlCommand penggunaCmd = new MySqlCommand(query, conn);
                penggunaCmd.Parameters.AddWithValue("@ID_Event", id);
                penggunaCmd.Parameters.AddWithValue("@foto", ConvertPictureBoxImageToByteArray(foto));
                penggunaCmd.Parameters.AddWithValue("@nama", nama);

                penggunaCmd.ExecuteNonQuery();
            }
        }

        public static void Update_tiket(string id, int harga, int Jml, int Jml_Sould)
        {
            using (MySqlConnection conn = new MySqlConnection(database_String.connectionString))
            {
                string query = "UPDATE tiket SET Harga = @Harga, Jml = @Jml WHERE ID = @ID";
                if (Jml_Sould != 0) query = "UPDATE tiket SET Harga = @Harga, Jml = @Jml, Jml_Sould = @Jml_Sould WHERE ID = @ID";
                conn.Open();
                MySqlCommand penggunaCmd = new MySqlCommand(query, conn);

                penggunaCmd.Parameters.AddWithValue("@ID", id);
                penggunaCmd.Parameters.AddWithValue("@Harga", harga);
                penggunaCmd.Parameters.AddWithValue("@Jml", Jml);
                if (Jml_Sould != 0) penggunaCmd.Parameters.AddWithValue("@Jml_Should", Jml_Sould);

                penggunaCmd.ExecuteNonQuery();
            }
        }

        public static string Tiket(string ID, string kategori, bool get_id)
        {
            string Tiket = "0";

            using (MySqlConnection conn = new MySqlConnection(database_String.connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM tiket WHERE ID_Event = @ID && Kategori = @kategori";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ID", ID);
                cmd.Parameters.AddWithValue("@kategori", kategori);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        if (!reader.IsDBNull(reader.GetOrdinal("Harga")) && !get_id)
                        {
                            Tiket = reader["Harga"].ToString();
                        }
                        if (get_id)
                        {
                            Tiket = reader["ID"].ToString();
                        }
                    }
                }
            }
            return Tiket;
        }
        private static byte[] ConvertPictureBoxImageToByteArray(Image foto)
        {
            if (foto != null)
            {
                using (Bitmap bmp = new Bitmap(foto))
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
    }

    public static class Rekap_tiket
    {
        public static void Table_Recap(string ID)
        {
            int jml = 0;

            // Koneksi pertama untuk mengupdate status dan mendapatkan jumlah tiket
            using (MySqlConnection conn = new MySqlConnection(database_String.connectionString))
            {
                conn.Open();

                // Update status di tabel rekap_tiket
                string updateRekapQuery = "UPDATE rekap_tiket SET status = @status WHERE tiket_id = @ID";
                MySqlCommand updateCmd = new MySqlCommand(updateRekapQuery, conn);
                updateCmd.Parameters.AddWithValue("@ID", ID);
                updateCmd.Parameters.AddWithValue("@status", "sudah bayar");
                updateCmd.ExecuteNonQuery();

                // Mendapatkan jumlah tiket dari tabel rekap_tiket
                string selectRekapQuery = "SELECT Jumlah FROM rekap_tiket WHERE tiket_id = @ID";
                MySqlCommand selectRekapCmd = new MySqlCommand(selectRekapQuery, conn);
                selectRekapCmd.Parameters.AddWithValue("@ID", ID);

                using (MySqlDataReader reader = selectRekapCmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        jml = reader.GetInt32(reader.GetOrdinal("Jumlah"));
                    }
                }
            }

            // Koneksi kedua untuk mengupdate jumlah tiket di tabel tiket
            using (MySqlConnection conn = new MySqlConnection(database_String.connectionString))
            {
                conn.Open();

                // Mendapatkan nilai Jml dan Jml_Sould saat ini dari tabel tiket
                string selectTiketQuery = "SELECT Jml, Jml_Sould FROM tiket WHERE id = @ID";
                MySqlCommand selectTiketCmd = new MySqlCommand(selectTiketQuery, conn);
                selectTiketCmd.Parameters.AddWithValue("@ID", ID);

                int currentJml = 0;
                int currentJmlSould = 0;

                using (MySqlDataReader reader = selectTiketCmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        currentJml = reader.GetInt32(reader.GetOrdinal("Jml"));
                        currentJmlSould = reader.GetInt32(reader.GetOrdinal("Jml_Sould"));
                    }
                }

                // Update tabel tiket dengan nilai baru
                string updateTiketQuery = "UPDATE tiket SET Jml = @Jml, Jml_Sould = @Jml_Sould WHERE ID = @ID";
                MySqlCommand updateTiketCmd = new MySqlCommand(updateTiketQuery, conn);
                updateTiketCmd.Parameters.AddWithValue("@ID", ID);
                updateTiketCmd.Parameters.AddWithValue("@Jml", currentJml - jml);
                updateTiketCmd.Parameters.AddWithValue("@Jml_Sould", currentJmlSould + jml);
                updateTiketCmd.ExecuteNonQuery();
            }
        }

    }
    public static class View_DataGirdView
    {
        public static void View_DataGrid_User(DataGridView dataGridView1, string role, string ex_query)
        {
            string query = "SELECT * FROM Pengguna WHERE Level = '" + CaesarCipher.Encrypt(role) + "'" + ex_query;
            using (MySqlConnection connection = new MySqlConnection(database_String.connectionString))
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(query, connection);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    dataGridView1.Rows.Clear();

                    while (reader.Read())
                    {
                        string id = CaesarCipher.Decrypt(reader["ID"].ToString());
                        string pw = reader["Password"].ToString();
                        string nama = CaesarCipher.Decrypt(reader["Nama"].ToString());
                        string masuk = reader["Masuk"].ToString();
                        string keluar = reader["Keluar"].ToString();
                        string riwayat = CaesarCipher.Decrypt(reader["Riwayat"].ToString());
                        string email = CaesarCipher.Decrypt(reader["Email"].ToString());
                        string wa = CaesarCipher.Decrypt(reader["Wa"].ToString());
                        string login = reader["Login"].ToString();

                        string[] row = new string[] { };
                        if (role == "admin") row = new string[] { id, email, pw, nama, masuk };
                        if (role == "user") row = new string[] { id, email, pw, nama, masuk, keluar, riwayat };
                        if (role == "penyelenggara") row = new string[] { id, email, pw, nama, wa, login };
                        dataGridView1.Rows.Add(row);
                    }
                }
            }
        }
        public static void View_DataGrid_Rekap(DataGridView dataGridView1, string role, string ex_query)
        {
            string query = "SELECT * FROM rekap_tiket " + ex_query;
            using (MySqlConnection connection = new MySqlConnection(database_String.connectionString))
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(query, connection);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    dataGridView1.Rows.Clear();

                    while (reader.Read())
                    {
                        string id = reader["ID"].ToString();
                        string eventid = reader["event_id"].ToString();
                        string nama = reader["nama"].ToString();
                        string tiketid = reader["tiket_id"].ToString();
                        string pengguna_id = reader["pengguna_id"].ToString() ;
                        string tanggal = reader["tanggal"].ToString();
                        string email = reader["email"].ToString();
                        string Wa = reader["Wa"].ToString();
                        string penyelenggara_id = reader["penyelenggara_id"].ToString();
                        string status = reader["status"].ToString();
                        string metode = reader["metode"].ToString();
                        string nik = reader["nik"].ToString();
                        string jumlah = reader["jumlah"].ToString();
                        string total = reader["total"].ToString();

                        string[] row = new string[] { };
                        if (role == "user") row = new string[] { id, nama, eventid,tanggal,total,tiketid,status};
                        if (role == "penyelenggara") row = new string[] { id, email, nama, tiketid, tanggal,jumlah,total,metode,status };
                        dataGridView1.Rows.Add(row);
                    }
                }
            }
        }
    }
    public static class All_data
    {
        public static void Hapus(string tabel, string id, bool id_event)
        {
            using (MySqlConnection connection = new MySqlConnection(database_String.connectionString))
            {
                connection.Open();
                string sql = "DELETE FROM " + tabel + " WHERE id = @id";
                if (id_event) sql = "DELETE FROM " + tabel + " WHERE ID_Event = @id";
                MySqlCommand command = new MySqlCommand(sql, connection);
                command.Parameters.AddWithValue("@id",id);
                command.ExecuteNonQuery();
            }
        }
        public static string make_id(string tabel, string nama)
        {
            string baseId = nama.Replace(" ", "_");
            string id = $"{baseId}_{Guid.NewGuid().ToString()}";

            using (MySqlConnection conn = new MySqlConnection(database_String.connectionString))
            {
                conn.Open();

                bool idExists = true;
                while (idExists)
                {
                    MySqlCommand penggunaCmd = new MySqlCommand($"SELECT COUNT(*) FROM {tabel} WHERE ID = @id", conn);
                    penggunaCmd.Parameters.AddWithValue("@id", id);

                    int count = Convert.ToInt32(penggunaCmd.ExecuteScalar());
                    idExists = count > 0;

                    if (idExists)
                    {
                        id = $"{baseId}_{Guid.NewGuid().ToString()}";
                    }
                }
            }
            return id;
        }


    }
    public static class view_admin
    {
        public static int Tiket(string ID, string kategori, bool sisa)
        {
            int Tiket = 0;

            using (MySqlConnection conn = new MySqlConnection(database_String.connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM tiket WHERE ID = @ID AND Kategori = @kategori";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ID", ID);
                cmd.Parameters.AddWithValue("@kategori", kategori);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {

                        if (sisa)
                        {
                            Tiket = Convert.ToInt32(reader["Jml"].ToString());
                        }
                        else
                        {
                            Tiket = Convert.ToInt32(reader["Jml_Sould"].ToString());
                        }
                    }
                }
                return Tiket;
            }
        }
        public static void View_DataGrid_Talent(Buat_Event detail, string id)
        {
            string query = "SELECT * FROM Talent WHERE ID_Event = @id";
            using (MySqlConnection connection = new MySqlConnection(database_String.connectionString))
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@id", id);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    detail.dataGridView1.Rows.Clear();
                    detail.list.Clear(); // Clear the list to prevent duplicates

                    while (reader.Read())
                    {
                        Talent talent = new Talent();
                        if (!reader.IsDBNull(reader.GetOrdinal("Foto_Talent")))
                        {
                            byte[] imageBytes = (byte[])reader["Foto_Talent"];
                            using (MemoryStream ms = new MemoryStream(imageBytes))
                            {
                                talent.foto = Image.FromStream(ms);
                            }
                        }

                        talent.nama = reader["Nama_Talent"].ToString();

                        // Menambahkan data ke DataGridView
                        DataGridViewRow row = new DataGridViewRow();
                        row.CreateCells(detail.dataGridView1);
                        row.Cells[0].Value = talent.foto; // Assuming first column is for the image
                        row.Cells[1].Value = talent.nama; // Assuming second column is for the name
                        detail.dataGridView1.Rows.Add(row);

                        // Menambahkan data ke list
                        detail.list.Add(talent);
                    }
                }
            }
        }

    }
}
