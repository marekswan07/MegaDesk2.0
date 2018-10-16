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
    public partial class CalculatetedQuoteForm : Form
    {
        public DeskQuote quote { get; set; }

        public CalculatetedQuoteForm(DeskQuote quote)
        {
            InitializeComponent();
            this.quote = quote;
        }


        private void display_Quote(object sender, EventArgs e)

        {
            //left coloumn
            lblCustName.Text = quote.CustName;
            lblWidth.Text = quote.Desk.Width.ToString();
            lblDepth.Text = quote.Desk.Depth.ToString();
            lblNumOfDraws.Text = quote.Desk.NumOfDraws.ToString();
            lblSurfaceMaterial.Text = quote.SurfaceNme;
            lblRushSpeed.Text = quote.RushString;

            //Right Coloumn
            lblSurfaceAreaPrice.Text = quote.SurfaceAreaPrice.ToString();
            lblRushPrice.Text = quote.RushPrice.ToString();
            lblDrawPrices.Text = (quote.Desk.NumOfDraws * quote.DrawPrice).ToString();
            lblSMPrice.Text = quote.SurfacePrice.ToString();
            lblRushPrice.Text = quote.RushPrice.ToString();

            //Total Price
            lblTotalQuote.Text = quote.QuotePrice.ToString();
            

        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            var newQuote = (NewQuoteForm)Tag;
            newQuote.Close();

            MainForm mainForm = new MainForm();
            mainForm.Show();

            Close();
        }

        //Goes back and allows for modification of Quotes
        private void button3_Click(object sender, EventArgs e)
        {
            var quoteForm = (NewQuoteForm)Tag;
            quoteForm.Show();
            Close();
        }

        //allows for quick easy access to other forms
        private void btn_view_Click(object sender, EventArgs e)
        {
            ViewQuoteForm newViewForm = new ViewQuoteForm();
            newViewForm.Show();
            Close();
        }

        //allows for quick easy access to other forms
        private void btn_Search_Click(object sender, EventArgs e)
        {
            SearchQuoteForm newSearchForm = new SearchQuoteForm();
            newSearchForm.Show();
            Close();
        }
    }
}
