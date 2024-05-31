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
    public partial class Pembeli : Form
    {
        public Parent farent;
        public Pembeli()
        {
            InitializeComponent();
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            View_DataGirdView.View_DataGrid_Rekap(dataGridView1, farent.login.role,"");
        }

        private void belum_CheckedChanged(object sender, EventArgs e)
        {
            if(belum.Checked)
            {
                View_DataGirdView.View_DataGrid_Rekap(dataGridView1, farent.login.role, " where status = 'belum bayar'");
            }
            else
            {
                View_DataGirdView.View_DataGrid_Rekap(dataGridView1, farent.login.role, "");
            }
        }

        private void Pembeli_Load(object sender, EventArgs e)
        {
            View_DataGirdView.View_DataGrid_Rekap(dataGridView1, farent.login.role, "");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["status"].Index && e.RowIndex >= 0)
            {
                string id = dataGridView1.Rows[e.RowIndex].Cells["Tiket_Event"].Value.ToString();

                var confirmResult = MessageBox.Show("Apakah akun ini sudah benar benar membayar ini?", "Konfirmasi", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    Rekap_tiket.Table_Recap(id);
                }
            }
        }
    }
}
