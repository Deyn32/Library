namespace Library
{
    partial class LibrarianForm
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
            this.menuLibraryan = new System.Windows.Forms.MenuStrip();
            this.контрольToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiHandOverBook = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiConditionBook = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiOrderBook = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLibraryan.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuLibraryan
            // 
            this.menuLibraryan.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuLibraryan.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.контрольToolStripMenuItem,
            this.tsmiOrderBook});
            this.menuLibraryan.Location = new System.Drawing.Point(0, 0);
            this.menuLibraryan.Name = "menuLibraryan";
            this.menuLibraryan.Size = new System.Drawing.Size(1200, 33);
            this.menuLibraryan.TabIndex = 0;
            this.menuLibraryan.Text = "menuStrip1";
            // 
            // контрольToolStripMenuItem
            // 
            this.контрольToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiHandOverBook,
            this.tsmiConditionBook});
            this.контрольToolStripMenuItem.Name = "контрольToolStripMenuItem";
            this.контрольToolStripMenuItem.Size = new System.Drawing.Size(102, 29);
            this.контрольToolStripMenuItem.Text = "Контроль";
            // 
            // tsmiHandOverBook
            // 
            this.tsmiHandOverBook.Name = "tsmiHandOverBook";
            this.tsmiHandOverBook.Size = new System.Drawing.Size(223, 30);
            this.tsmiHandOverBook.Text = "Сдача книг";
            this.tsmiHandOverBook.Click += new System.EventHandler(this.tsmiHandOverBook_Click);
            // 
            // tsmiConditionBook
            // 
            this.tsmiConditionBook.Name = "tsmiConditionBook";
            this.tsmiConditionBook.Size = new System.Drawing.Size(223, 30);
            this.tsmiConditionBook.Text = "Состояние книг";
            this.tsmiConditionBook.Click += new System.EventHandler(this.tsmiConditionBook_Click);
            // 
            // tsmiOrderBook
            // 
            this.tsmiOrderBook.Name = "tsmiOrderBook";
            this.tsmiOrderBook.Size = new System.Drawing.Size(110, 29);
            this.tsmiOrderBook.Text = "Заказ книг";
            // 
            // LibrarianForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.menuLibraryan);
            this.MainMenuStrip = this.menuLibraryan;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "LibrarianForm";
            this.Text = "Библиотека";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LibrarianForm_FormClosing);
            this.menuLibraryan.ResumeLayout(false);
            this.menuLibraryan.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuLibraryan;
        private System.Windows.Forms.ToolStripMenuItem контрольToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiHandOverBook;
        private System.Windows.Forms.ToolStripMenuItem tsmiConditionBook;
        private System.Windows.Forms.ToolStripMenuItem tsmiOrderBook;
    }
}