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
    public partial class NewQuoteForm : Form
    {
        public NewQuoteForm()
        {
            InitializeComponent();
            btnSubmit.Enabled = false;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
   

            bool validInput = ComboBox_Validating();

            lblErrorMessages.Text = "Please provide surface material and delivery speed";
            lblErrorMessages.ForeColor = Color.Red;
            lblErrorMessages.Visible = true;

            if (validInput == true)
            {
                lblErrorMessages.Visible = false;
            }
            
        }

        private void ValidateCustomerName(object sender, EventArgs e)
        {

            // Confirm that the custName txtbox isn't empty

            if (String.IsNullOrEmpty(txtCustName.Text))

            {
                lblErrorMessages.Text = "Please enter a customer name";
                lblErrorMessages.ForeColor = Color.Red;
                lblErrorMessages.Visible = true;
                lblCustName.ForeColor = Color.Red;
                btnSubmit.Enabled = false;

            }

            else
            {
                btnSubmit.Enabled = true;
                lblCustName.ForeColor = Color.Black;
                lblErrorMessages.Visible = false;
            }
        }

        private void btnNewQuoteExit_Click(object sender, EventArgs e)
        {
            var mainForm = (MainForm)Tag;
            mainForm.Show();
            Close();
        }

        //this will check if both dropdowns have a selected value before continuing with the submit
        private bool ComboBox_Validating()
        {
            if (comboSpeed.SelectedIndex < 1 || comboSurface.SelectedIndex < 1)
            {
                // Cancel the event and select the text to be corrected by the user.
                if(comboSpeed.SelectedIndex < 1)
                {
                    comboSpeed.Select();
                }

                else
                {
                    comboSurface.Select();
                }

                return false;
            }

            else
                return true;
        }


    }
}
