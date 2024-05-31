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
using Encrypt;

namespace Eventix
{
    public partial class Admin : Form
    {
        public Parent farent;
        public Tambah_Admin tambah;
        string id;
        public Admin()
        {
            InitializeComponent();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            View_DataGirdView.View_DataGrid_User(dataGridView1, "admin","");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["Hapus"].Index && e.RowIndex >= 0)
            {
                string id = dataGridView1.Rows[e.RowIndex].Cells["ID_"].Value.ToString();

                var confirmResult = MessageBox.Show("Apakah Anda yakin ingin menghapus data ini?", "Konfirmasi Penghapusan", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    All_data.Hapus("pengguna",CaesarCipher.Encrypt(id),false);
                    View_DataGirdView.View_DataGrid_User(dataGridView1, "admin", "");
                }
            }
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            View_DataGirdView.View_DataGrid_User(dataGridView1, "admin", "");
        }

        private void Tambah_Click(object sender, EventArgs e)
        {
            if(tambah == null)
            {
                tambah = new Tambah_Admin
                {
                    admin = this
                };
            }
            tambah.Show();
        }
    }
}
