using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Microsoft.VisualBasic.FileIO;

namespace MegaDesk3_MarekSwan
{
    public partial class ViewQuoteForm : Form
    {
        public ViewQuoteForm()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            Close();
        }


        public void loadCSVFile(object sender, EventArgs e)
        {
            try
            {
                const string filename = "quotes.txt";
                string[] deskqoutes = File.ReadAllLines(filename);

                foreach (string deskquote in deskqoutes)
                {
                    string[] arrRow = deskquote.Split(new char[] { ',' });
                    dataGridView1.Rows.Add(arrRow);
                }
            }
            catch
            {
                MessageBox.Show("Unexpected error");
            }
            
        }


    }
}
