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

namespace MegaDesk3_MarekSwan
{
    public partial class SearchQuoteForm : Form
    {

        public SearchQuoteForm()
        {
            InitializeComponent();


            //Some propeties for the form to use
            var materials = new List<Desk.SurfaceMaterials>();
            materials = Enum.GetValues(typeof(Desk.SurfaceMaterials))
                        .Cast<Desk.SurfaceMaterials>()
                        .ToList();

            comboSurface.DataSource = materials;

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var mainForm = (MainForm)Tag;
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

        public void sortedSearch(object sender, EventArgs e)
        {
            try
            {
                const string filename = "quotes.txt";
                string[] deskqoutes = File.ReadAllLines(filename);
                dataGridView1.Rows.Clear();

                foreach (string deskquote in deskqoutes)
                {
                    string[] arrRow = deskquote.Split(new char[] { ',' });

                    if (arrRow[4] == comboSurface.SelectedIndex.ToString())
                    {
                        arrRow[4] = comboSurface.SelectedText;
                        dataGridView1.Rows.Add(arrRow);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Unexpected error");
            }

        }
    }
}
