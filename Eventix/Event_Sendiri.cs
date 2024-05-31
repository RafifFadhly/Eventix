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
    public partial class Event_Sendiri : Form
    {
        public Parent farent;
        public Event_Sendiri()
        {
            InitializeComponent();
        }

        public void Event_Sendiri_Load(object sender, EventArgs e)
        {
            Event.View_Event_Content(" WHERE ID_Penyelenggara = '"+ farent.login.id+"'", flowLayoutPanel1, farent);
        }

        private void back_Click(object sender, EventArgs e)
        {
            farent.MDI(farent.make_event);
        }
    }
}
