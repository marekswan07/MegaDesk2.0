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
    public partial class SearchQuoteForm : Form
    {
        public SearchQuoteForm()
        {
            InitializeComponent();
        }

        private void btnSearchQuoteExit_Click(object sender, EventArgs e)
        {
            var mainForm = (MainForm)Tag;
            mainForm.Show();
            Close();
        }
    }
}
