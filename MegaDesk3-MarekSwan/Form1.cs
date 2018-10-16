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
            NewQuoteForm addNewQuoteForm = new NewQuoteForm();
            addNewQuoteForm.Tag = this;
            addNewQuoteForm.Show(this);
            Hide();
        }

        private void btnViewQuotes_Click(object sender, EventArgs e)
        {
            ViewQuoteForm newViewForm = new ViewQuoteForm();
            newViewForm.Tag = this;
            newViewForm.Show(this);
            Hide();
        }

        private void btnSearchQuotes_Click(object sender, EventArgs e)
        {
            
            SearchQuoteForm newSearchForm = new SearchQuoteForm();
            newSearchForm.Tag = this;
            newSearchForm.Show(this);
            Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //custom event created for displaying a date in a specified form, event activated on form load
        private void display_Date(object sender, EventArgs e)

        {
            DateTime currentDate = DateTime.Now;
            lblCurrentDateTime.Text = (currentDate.ToString("MMMM dd, yyyy") + ".");
        }

    }
}
