using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk3_MarekSwan
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        //custom event created for displaying a date in a specified form, event activated on form load

        private void display_Date(object sender, EventArgs e)

        {

            DateTime currentDate = DateTime.Now;

            lblCurrentDateTime.Text = (currentDate.ToString("MMMM dd, yyyy") + ".");

        }
    }
}
