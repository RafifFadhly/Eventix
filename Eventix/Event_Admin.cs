using Database;
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
    public partial class Event_Admin : Form
    {
        public Parent farent;
        public Event_Admin()
        {
            InitializeComponent();
        }

        private void Event_Load(object sender, EventArgs e)
        {
            if(farent.login.role == "admin") Event.View_Event_Content("", flowLayoutPanel1, farent);

            else Event.View_Event_Content("WHERE ID = '"+ farent.login.id +"'", flowLayoutPanel1, farent);
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            Event_Load( sender, e);
        }
    }
}
