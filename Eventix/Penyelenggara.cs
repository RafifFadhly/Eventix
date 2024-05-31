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
    public partial class Penyelenggara : Form
    {
        public Parent farent;
        public Penyelenggara()
        {
            InitializeComponent();
        }

        private void Penyelenggara_Load(object sender, EventArgs e)
        {
            View_DataGirdView.View_DataGrid_User(dataGridView1, "penyelenggara","");
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            View_DataGirdView.View_DataGrid_User(dataGridView1, "penyelenggara", "");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["Hapus"].Index && e.RowIndex >= 0)
            {
                string id = dataGridView1.Rows[e.RowIndex].Cells["ID"].Value.ToString();

                var confirmResult = MessageBox.Show("Apakah Anda yakin ingin menghapus data ini?", "Konfirmasi Penghapusan", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    All_data.Hapus("pengguna", CaesarCipher.Encrypt(id), false);
                    View_DataGirdView.View_DataGrid_User(dataGridView1, "admin", "");
                }
            }
        }
    }
}
