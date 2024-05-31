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
    public partial class Tambah_Admin : Form
    {
        public Admin admin;
        public Tambah_Admin()
        {
            InitializeComponent();
        }

        private void batal_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void tambah_Click(object sender, EventArgs e)
        {
            Profil.Tambah(Nama.Text, PW.Text, Email.Text,"admin");
            View_DataGirdView.View_DataGrid_User(admin.dataGridView1, "admin", "");
            this.Hide();
        }

        private void Tambah_Admin_Load(object sender, EventArgs e)
        {
            Nama.Clear();
            PW.Clear();
            Email.Clear();
        }
    }
}
