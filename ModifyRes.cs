using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Project_Portfolio
{
    public partial class ModifyRes : Form
    {
        public ModifyRes()
        {
            InitializeComponent();
        }

        private void ModifyRes_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hotel_ProjDataSet.Reservations' table. You can move, or remove it, as needed.
            this.reservationsTableAdapter.Fill(this.hotel_ProjDataSet.Reservations);

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
