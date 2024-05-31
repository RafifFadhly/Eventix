using Guna.UI2.WinForms;
using Microsoft.Extensions.Logging;
using Org.BouncyCastle.Tls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eventix
{
    public partial class Details : Form
    {
        public string id;
        public string id_tiket_regular;
        public string id_tiket_vip;
        public string Penyelenggara;
        public string tiket;
        public string jenis;
        public int jml;
        public string rekening;

        public Parent farent;
        public Details()
        {
            InitializeComponent();
        }

        public void Details_Load(object sender, EventArgs e)
        {
            if (farent.login.role == "user")
            {
                tgl_buat_pic.Visible = false;
                tgl_buat_title.Visible = false;
                tgl_buat_title.Visible = false;
                beli_tiket.Visible = true;
            }
            else if (farent.login.role == "penyelenggara")
            {
                tgl_buat_title.Visible = true;
                beli_tiket.Visible = false;
                tgl_buat_pic.Visible = true;
            }
            else
            {
                tgl_buat_title.Visible = true;
                beli_tiket.Visible = false;
                tgl_buat_pic.Visible = true;

            }
            content.Height = Height;
            Panel_Aktif(Deskripsi_Btn, Deskripsi_Panel);

            Deskripsi_Panel.Height = flow_des.Height;
        }


        private void back_Click(object sender, EventArgs e)
        {
            if (farent.login.role == "user")
            {
                farent.MDI(farent.search);
                farent.search.Form1_Load(sender, e);
            }
            else if (farent.login.role == "admin")
            {
                farent.MDI(farent.Event);
            }
            else if (farent.login.role == "penyelenggara")
            {
                farent.MDI(farent.Event_panitia);
            }
        }

        private void Deskripsi_Btn_Click(object sender, EventArgs e)
        {
            Panel_Aktif(Deskripsi_Btn, Deskripsi_Panel);
        }

        private void Tiket_Btn_Click(object sender, EventArgs e)
        {
            Panel_Aktif(Tiket_Btn, Tiket_Panel);
        }

        private void Talent_Btn_Click(object sender, EventArgs e)
        {
            Panel_Aktif(Talent_Btn, Talent_Panel);
        }

        void Panel_Aktif(Guna2Button button_aktif, Panel panel_aktif)
        {
            Guna2Button[] button = { Deskripsi_Btn, Tiket_Btn, Talent_Btn };
            Panel[] panel = { Deskripsi_Panel, Tiket_Panel, Talent_Panel };

            for (int i = 0; i < button.Length; i++)
            {
                button[i].ForeColor = Color.Blue;
                button[i].FillColor = Color.White;
                panel[i].Visible = false;
            }
            button_aktif.ForeColor = Color.White;
            button_aktif.FillColor = Color.Blue;
            panel_aktif.Visible = true;
        }

        private void beli_tiket_Click(object sender, EventArgs e)
        {
            Panel_Aktif(Tiket_Btn, Tiket_Panel);
        }

        private void pilih_regular_Click(object sender, EventArgs e)
        {
            tiket = id_tiket_regular;
            jenis = "regular";
            jml = (int)jml_regular.Value;
            beli(sender, e);
        }

        private void pilih_vip_Click(object sender, EventArgs e)
        {
            tiket = id_tiket_vip;
            jenis = "vip";
            jml = (int)jml_vip.Value;
            beli(sender, e);
        }

        void beli(object sender, EventArgs e)
        {
            if(jml_regular.Value == 0 || jml_vip.Value ==0)
            {
                if (farent.bayar == null)
                {
                    farent.bayar = new Pembayaran();
                    farent.bayar.farent = farent;
                }
                farent.MDI(farent.bayar);
                farent.bayar.Pembayaran_Load(sender, e);
                farent.detail.Hide();
            }
        }
        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
