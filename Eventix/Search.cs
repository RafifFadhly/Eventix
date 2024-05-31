using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Hosting;
using System.Windows.Forms;
using Database;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Eventix
{
    public partial class Search : Form
    {

        public Parent farent;
        string input;
        public Search()
        {
            InitializeComponent();
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            flowLayoutPanel1.Width = this.Width - SideBar.Width;
            Event.View_Event_Content("", flowLayoutPanel1,farent);
            Clear();
        }
        private void lokasi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Cari_Click(object sender, EventArgs e)
        {
            search();
        }
        public void search()
        {
            input = "WHERE Nama LIKE '%" + farent.Cari.Text + "%'";
            if(konser_musik.Checked) input += "AND Kategori LIKE '%Konser Musik%'";
            if (Pekan_Olahraga.Checked) input += "AND Kategori LIKE '%Pekan Olahraga%'";
            if (Seminar.Checked) input += "AND Kategori LIKE '%Seminar%'";
            if (Pemran_Seni.Checked) input += "AND Kategori LIKE '%Pameran Seni%'";
            if(lokasi.Text != null || lokasi.Text != "")input += "AND Alamat LIKE '%"+lokasi.Text+"'";
            Event.View_Event_Content(input, flowLayoutPanel1, farent);
        }
        public void Clear()
        {
            lokasi.Text = null;
            konser_musik.Checked = false;
            Pekan_Olahraga.Checked = false;
            Seminar.Checked = false;
            Pemran_Seni.Checked = false;
        }

    }
}
