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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblErrorMessages = new System.Windows.Forms.Label();
            this.lblCustName = new System.Windows.Forms.Label();
            this.txtCustName = new System.Windows.Forms.TextBox();
            this.numUDWidth = new System.Windows.Forms.NumericUpDown();
            this.numUDDepth = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.numUDDraws = new System.Windows.Forms.NumericUpDown();
            this.comboSurface = new System.Windows.Forms.ComboBox();
            this.comboSpeed = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numUDWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDDepth)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUDDraws)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNewQuoteExit
            // 
            this.btnNewQuoteExit.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewQuoteExit.Location = new System.Drawing.Point(312, 292);
            this.btnNewQuoteExit.Name = "btnNewQuoteExit";
            this.btnNewQuoteExit.Size = new System.Drawing.Size(122, 40);
            this.btnNewQuoteExit.TabIndex = 0;
            this.btnNewQuoteExit.Text = "Exit";
            this.btnNewQuoteExit.UseVisualStyleBackColor = true;
            this.btnNewQuoteExit.Click += new System.EventHandler(this.btnNewQuoteExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Width:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Depth:";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(89, 292);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(115, 39);
            this.btnSubmit.TabIndex = 3;
            this.btnSubmit.Text = "Submit Quote";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblErrorMessages
            // 
            this.lblErrorMessages.AutoSize = true;
            this.lblErrorMessages.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorMessages.Location = new System.Drawing.Point(158, 261);
            this.lblErrorMessages.Name = "lblErrorMessages";
            this.lblErrorMessages.Size = new System.Drawing.Size(187, 18);
            this.lblErrorMessages.TabIndex = 4;
            this.lblErrorMessages.Text = "Will be blank unless showing";
            this.lblErrorMessages.Visible = false;
            // 
            // lblCustName
            // 
            this.lblCustName.AutoSize = true;
            this.lblCustName.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustName.Location = new System.Drawing.Point(82, 43);
            this.lblCustName.Name = "lblCustName";
            this.lblCustName.Size = new System.Drawing.Size(112, 18);
            this.lblCustName.TabIndex = 5;
            this.lblCustName.Text = "Customer Name:";
            // 
            // txtCustName
            // 
            this.txtCustName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustName.Location = new System.Drawing.Point(200, 39);
            this.txtCustName.Name = "txtCustName";
            this.txtCustName.Size = new System.Drawing.Size(257, 22);
            this.txtCustName.TabIndex = 6;
            this.txtCustName.Validated += new System.EventHandler(this.ValidateCustomerName);
            // 
            // numUDWidth
            // 
            this.numUDWidth.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numUDWidth.Location = new System.Drawing.Point(90, 32);
            this.numUDWidth.Maximum = new decimal(new int[] {
            96,
            0,
            0,
            0});
            this.numUDWidth.Minimum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.numUDWidth.Name = "numUDWidth";
            this.numUDWidth.Size = new System.Drawing.Size(93, 26);
            this.numUDWidth.TabIndex = 7;
            this.numUDWidth.Value = new decimal(new int[] {
            24,
            0,
            0,
            0});
            // 
            // numUDDepth
            // 
            this.numUDDepth.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numUDDepth.Location = new System.Drawing.Point(90, 68);
            this.numUDDepth.Maximum = new decimal(new int[] {
            48,
            0,
            0,
            0});
            this.numUDDepth.Minimum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numUDDepth.Name = "numUDDepth";
            this.numUDDepth.Size = new System.Drawing.Size(93, 26);
            this.numUDDepth.TabIndex = 8;
            this.numUDDepth.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numUDWidth);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.numUDDepth);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("OCR A Extended", 10.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(21, 91);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(199, 107);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Measurements";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(149, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 18);
            this.label3.TabIndex = 10;
            this.label3.Text = "Delivery Speed:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 18);
            this.label4.TabIndex = 11;
            this.label4.Text = "Surface Material:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 18);
            this.label5.TabIndex = 12;
            this.label5.Text = "Number of Draws:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.numUDDraws);
            this.groupBox2.Controls.Add(this.comboSurface);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Font = new System.Drawing.Font("OCR A Extended", 10.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(226, 91);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(264, 107);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Extras";
            // 
            // numUDDraws
            // 
            this.numUDDraws.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numUDDraws.Location = new System.Drawing.Point(138, 61);
            this.numUDDraws.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.numUDDraws.Name = "numUDDraws";
            this.numUDDraws.Size = new System.Drawing.Size(93, 26);
            this.numUDDraws.TabIndex = 14;
            // 
            // comboSurface
            // 
            this.comboSurface.Font = new System.Drawing.Font("Calibri", 10.25F);
            this.comboSurface.FormattingEnabled = true;
            this.comboSurface.Location = new System.Drawing.Point(137, 25);
            this.comboSurface.Name = "comboSurface";
            this.comboSurface.Size = new System.Drawing.Size(121, 25);
            this.comboSurface.TabIndex = 13;
            this.comboSurface.Text = "Choose an Option";
            // 
            // comboSpeed
            // 
            this.comboSpeed.Font = new System.Drawing.Font("Calibri", 10.75F);
            this.comboSpeed.FormattingEnabled = true;
            this.comboSpeed.Items.AddRange(new object[] {
            "No Rush (14 Days)",
            "3 Day Rush",
            "5 Day Rush",
            "7 Day Rush"});
            this.comboSpeed.Location = new System.Drawing.Point(261, 218);
            this.comboSpeed.Name = "comboSpeed";
            this.comboSpeed.Size = new System.Drawing.Size(121, 25);
            this.comboSpeed.TabIndex = 14;
            this.comboSpeed.Text = "Select a Speed";
            // 
            // NewQuoteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 378);
            this.Controls.Add(this.comboSpeed);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtCustName);
            this.Controls.Add(this.lblCustName);
            this.Controls.Add(this.lblErrorMessages);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnNewQuoteExit);
            this.Name = "NewQuoteForm";
            this.Text = "New Quote";
            ((System.ComponentModel.ISupportInitialize)(this.numUDWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDDepth)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUDDraws)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNewQuoteExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblErrorMessages;
        private System.Windows.Forms.Label lblCustName;
        private System.Windows.Forms.TextBox txtCustName;
        private System.Windows.Forms.NumericUpDown numUDWidth;
        private System.Windows.Forms.NumericUpDown numUDDepth;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown numUDDraws;
        private System.Windows.Forms.ComboBox comboSurface;
        private System.Windows.Forms.ComboBox comboSpeed;
    }
}