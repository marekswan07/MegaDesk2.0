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

        private void txtboxWidth_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!ValidInput(txtboxWidth.Text))
            {
                // Cancel the event and select the text to be corrected by the user.
                txtboxWidth.Select(0, txtboxWidth.Text.Length);
            }

            else
                btnSubmit.Enabled = true;
        }

        public bool ValidInput(string userInput)
        {
            // Confirm that the user Input string is not empty.
            if (userInput.Length == 0)
            {
                lblErrorMessages.Text = "Please enter a value";
                lblErrorMessages.ForeColor = Color.Red;
                lblErrorMessages.Visible = true;
                btnSubmit.Enabled = false;
                return false;
            }

            // Confirm that the values are within limits (min 24" - max 96")
            //String will not cast, therefore Convert function is needed
            int measurement = Convert.ToInt32(userInput);

            if (measurement < 24 || measurement > 96)
            {
                lblErrorMessages.ForeColor = Color.Red;
                lblErrorMessages.Text = "Please enter a value between 24 and 96";
                lblErrorMessages.Visible = true;
                btnSubmit.Enabled = false;
                return false;
            }

            else
                lblErrorMessages.Visible = false;
                return true;
        }


        private void btnNewQuoteExit_Click(object sender, EventArgs e)
        {
            var mainForm = (MainForm)Tag;
            mainForm.Show();
            Close();
        }



        private void Depth_KeyPress(object sender, KeyPressEventArgs e)
        {

            //Pressing Enter
            if (e.KeyChar == (char)Keys.Enter)
            {
                
                if (string.IsNullOrWhiteSpace(txtboxDepth.Text))
                {
                    lblErrorMessages.ForeColor = Color.Red;
                    lblErrorMessages.Text = "Please enter a value between 12 and 48";
                    lblErrorMessages.Visible = true;
                    btnSubmit.Enabled = false;
                }

                else if (Char.IsDigit(txtboxDepth.Text, 0) == true && (Char.IsDigit(txtboxDepth.Text, 1)) == true)
                {
                    int value = Convert.ToInt32(txtboxDepth.Text);

                    if (value < 12 || value > 48)
                    {
                        lblErrorMessages.ForeColor = Color.Red;
                        lblErrorMessages.Text = "Please enter a value between 12 and 48";
                        lblErrorMessages.Visible = true;
                        btnSubmit.Enabled = false;
                    }

                    else
                    {
                        btnSubmit.Enabled = true;
                        lblErrorMessages.Visible = false;
                    }
                }

                else if (Char.IsDigit(txtboxDepth.Text, 0) == false || (Char.IsDigit(txtboxDepth.Text, 1)) == false)
                {
                    lblErrorMessages.Text = "Please enter numeric values";
                    lblErrorMessages.ForeColor = Color.Red;
                    lblErrorMessages.Visible = true;
                }

                else
                {
                    lblErrorMessages.Text = "Please enter numeric values";
                    lblErrorMessages.ForeColor = Color.Red;
                    lblErrorMessages.Visible = true;
                }

            }    
            
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            
        }
    }
}
