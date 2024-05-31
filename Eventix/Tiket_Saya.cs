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
    public partial class Tiket_Saya : Form
    {
        public Parent farent;
        public Tiket_Saya()
        {
            InitializeComponent();
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            View_DataGirdView.View_DataGrid_Rekap(dataGridView1, farent.login.role, " where pengguna_id = '" + farent.login.id + "'");
        }

        private void Tiket_Saya_Load(object sender, EventArgs e)
        {
            View_DataGirdView.View_DataGrid_Rekap(dataGridView1, farent.login.role, " where pengguna_id = '" + farent.login.id + "'");
        }

        private void back_Click(object sender, EventArgs e)
        {
            farent.MDI(farent.search);
        }
    }
}
