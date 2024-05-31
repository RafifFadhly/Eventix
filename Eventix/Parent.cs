using Database;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Eventix
{
    public partial class Parent : Form
    {
        public Dashboard dashboard;
        public Form Form;
        public Search search;
        public Details detail;
        public Login_Form login;
        public Pembayaran bayar;
        public Admin admin;
        public Pengguna pengguna;
        public Penyelenggara Penyelenggara;
        public Event_Admin Event;
        public Profil_Edit Profil_edit;
        public Proses proses;
        public Event_Sendiri Event_panitia; 
        public Buat_Event make_event;
        public Pembeli pembeli;
        public Tiket_Saya mytic;
        public Parent()
        {
            InitializeComponent();
        }

        public void Parent_Load(object sender, EventArgs e)
        {
            Profil.View_Profil_Mini(login.id, profil, nama, null);
            if(login.role == "user")
            {
                if (search == null)
                {
                    search = new Search();
                    search.farent = this;
                }
                sidebar.Visible = false;
                MDI(search);
                resize(sender, e);
            }
            if(login.role == "admin" ||  login.role == "penyelenggara")
            {
                Dashboard_btn_Click(sender, e);
                Cari.Visible = false;
                tiket_saya.Visible = false;
                sidebar.Visible = true;
                button();
                if(login.role == "admin")
                {
                    Admin_btn.Visible = true;
                    Penyelenggara_btn.Visible = true;
                    Pengguna_btn.Visible = true;
                    Event_btn.Visible = true;
                }
                if(login.role == "penyelenggara")
                {
                    buat_event_btn.Visible = true;
                    Pembeli_btn.Visible = true;
                }


            }
            Panel_Aktif(Dashboard_btn);
        }
        public void MDI(Form form)
        {
            if (Form != null) Form.Hide();
            Form = form;
            form.MdiParent = this;
            form.Dock = DockStyle.Fill;
            form.Show();
        }

        private void resize(object sender, EventArgs e)
        {
            if (Form != null)
            {
                MDI(Form);
                if (Form == search) search.Form1_Load(sender, e);
                if (Form == detail) detail.Details_Load(sender, e);
            }
            Cari.Width = Width / 4 ;
        }

        private void Back_Click(object sender, EventArgs e)
        {
            if(Form == detail)
            {
                MDI(search);
                search.Form1_Load(sender, e);
            }
        }

        private void Cari_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if(login.role == "user")
                {
                    MDI(search);
                    search.Form1_Load(sender, e);
                    search.search();
                }
                else
                {

                }
            }
        }

        private void Parent_FormClosing(object sender, FormClosingEventArgs e)
        {
            Profil.Update_keluar(login.id);
            Environment.Exit(0);
        }

        private void Admin_btn_Click(object sender, EventArgs e)
        {
            if (admin == null)
            {
                admin = new Admin();
                admin.farent = this;
            }
            MDI(admin);
            Panel_Aktif(Admin_btn);
        }

        private void Penyelenggara_btn_Click(object sender, EventArgs e)
        {
            if (Penyelenggara == null)
            {
                Penyelenggara = new Penyelenggara();
                Penyelenggara.farent = this;
            }
            MDI(Penyelenggara);
            Panel_Aktif(Penyelenggara_btn);
        }

        private void Pengguna_btn_Click(object sender, EventArgs e)
        {
            if (pengguna == null)
            {
                pengguna = new Pengguna();
                pengguna.farent = this;
            }
            MDI(pengguna);
            Panel_Aktif(Pengguna_btn);
        }

        private void Event_btn_Click(object sender, EventArgs e)
        {
            if (Event == null)
            {
                Event = new Event_Admin();
                Event.farent = this;
            }
            MDI(Event);
            Panel_Aktif(Event_btn);
        }

        void Panel_Aktif(Guna2Button button_aktif)
        {
            Guna2Button[] button = { Dashboard_btn, Admin_btn, Penyelenggara_btn, Pengguna_btn, Event_btn, buat_event_btn, Pembeli_btn };

            for (int i = 0; i < button.Length; i++)
            {
                button[i].ForeColor = Color.White;
                button[i].FillColor = Color.Blue;
            }
            if (button_aktif != null)
            {
                button_aktif.ForeColor = Color.Blue;
                button_aktif.FillColor = Color.White;
            }
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            if (Profil_edit == null)
            {
                Profil_edit = new Profil_Edit();
                Profil_edit.farent = this;
            }
            MDI(Profil_edit);
            Panel_Aktif(null);
        }

        void button()
        {
            Guna2Button[] button = { Admin_btn, Penyelenggara_btn, Pengguna_btn, Event_btn, buat_event_btn,Pembeli_btn };

            for (int i = 0; i < button.Length; i++)
            {
                button[i].Visible = false;
            }
        }

        private void buat_event_btn_Click(object sender, EventArgs e)
        {
            if (make_event == null)
            {
                make_event = new Buat_Event();
                make_event.farent = this;
            }
            MDI(make_event);
            Panel_Aktif(buat_event_btn);
            make_event.Buat_Event_Load(sender, e);
        }

        private void Pembeli_btn_Click(object sender, EventArgs e)
        {
            if (pembeli == null)
            {
                pembeli = new Pembeli();
                pembeli.farent = this;
            }
            MDI(pembeli);
            Panel_Aktif(Pembeli_btn);
        }

        private void Dashboard_btn_Click(object sender, EventArgs e)
        {
            if (dashboard == null)
            {
                dashboard = new Dashboard();
                dashboard.farent = this;
            }
            MDI(dashboard);
            Panel_Aktif(Dashboard_btn);
        }

        private void tiket_saya_Click(object sender, EventArgs e)
        {
            if (mytic == null)
            {
                mytic = new Tiket_Saya();
                mytic.farent = this;
            }
            MDI(mytic);
        }
    }
}
