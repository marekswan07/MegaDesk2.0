namespace MegaDesk3_MarekSwan
{
    partial class SearchQuoteForm
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
            this.btnSearchQuoteExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSearchQuoteExit
            // 
            this.btnSearchQuoteExit.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchQuoteExit.Location = new System.Drawing.Point(127, 76);
            this.btnSearchQuoteExit.Name = "btnSearchQuoteExit";
            this.btnSearchQuoteExit.Size = new System.Drawing.Size(122, 41);
            this.btnSearchQuoteExit.TabIndex = 0;
            this.btnSearchQuoteExit.Text = "Exit";
            this.btnSearchQuoteExit.UseVisualStyleBackColor = true;
            this.btnSearchQuoteExit.Click += new System.EventHandler(this.btnSearchQuoteExit_Click);
            // 
            // SearchQuoteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 190);
            this.Controls.Add(this.btnSearchQuoteExit);
            this.Name = "SearchQuoteForm";
            this.Text = "Search Quote";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSearchQuoteExit;
    }
}