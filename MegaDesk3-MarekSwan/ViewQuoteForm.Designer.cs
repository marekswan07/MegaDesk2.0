namespace MegaDesk3_MarekSwan
{
    partial class ViewQuoteForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CustName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colWidth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDepth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDraws = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaterial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRushSpeed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CustName,
            this.colWidth,
            this.colDepth,
            this.colDraws,
            this.colMaterial,
            this.colRushSpeed,
            this.colPrice});
            this.dataGridView1.Location = new System.Drawing.Point(12, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(742, 296);
            this.dataGridView1.TabIndex = 1;
            // 
            // CustName
            // 
            this.CustName.HeaderText = "Customer Name";
            this.CustName.Name = "CustName";
            // 
            // colWidth
            // 
            this.colWidth.HeaderText = "Width";
            this.colWidth.Name = "colWidth";
            // 
            // colDepth
            // 
            this.colDepth.HeaderText = "Depth";
            this.colDepth.Name = "colDepth";
            // 
            // colDraws
            // 
            this.colDraws.HeaderText = "Number of Draws";
            this.colDraws.Name = "colDraws";
            // 
            // colMaterial
            // 
            this.colMaterial.HeaderText = "Surface Material";
            this.colMaterial.Name = "colMaterial";
            // 
            // colRushSpeed
            // 
            this.colRushSpeed.HeaderText = "Speed";
            this.colRushSpeed.Name = "colRushSpeed";
            // 
            // colPrice
            // 
            this.colPrice.HeaderText = "Total Quote";
            this.colPrice.Name = "colPrice";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(765, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadFileToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // loadFileToolStripMenuItem
            // 
            this.loadFileToolStripMenuItem.Name = "loadFileToolStripMenuItem";
            this.loadFileToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.loadFileToolStripMenuItem.Text = "Load File";
            // 
            // ViewQuoteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 335);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ViewQuoteForm";
            this.Text = "View Quotes";
            this.Load += new System.EventHandler(this.loadCSVFile);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colWidth;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDepth;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDraws;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaterial;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRushSpeed;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrice;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadFileToolStripMenuItem;
    }
}