namespace MegaDesk3_MarekSwan
{
    partial class NewQuoteForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnNewQuoteExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNewQuoteExit
            // 
            this.btnNewQuoteExit.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewQuoteExit.Location = new System.Drawing.Point(179, 88);
            this.btnNewQuoteExit.Name = "btnNewQuoteExit";
            this.btnNewQuoteExit.Size = new System.Drawing.Size(75, 23);
            this.btnNewQuoteExit.TabIndex = 0;
            this.btnNewQuoteExit.Text = "Exit";
            this.btnNewQuoteExit.UseVisualStyleBackColor = true;
            this.btnNewQuoteExit.Click += new System.EventHandler(this.btnNewQuoteExit_Click);
            // 
            // NewQuoteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 201);
            this.Controls.Add(this.btnNewQuoteExit);
            this.Name = "NewQuoteForm";
            this.Text = "New Quote";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNewQuoteExit;
    }
}