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
    public partial class Pengguna : Form
    {
        public Parent farent;

        public Pengguna()
        {
            InitializeComponent();
        }

        private void Pengguna_Load(object sender, EventArgs e)
        {
            View_DataGirdView.View_DataGrid_User(dataGridView1, "user","");
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            View_DataGirdView.View_DataGrid_User(dataGridView1, "user", "");

        }
    }
}
