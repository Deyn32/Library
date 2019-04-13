namespace Library
{
    partial class ReturnBooksForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbFio = new System.Windows.Forms.ComboBox();
            this.btnReturnBooks = new System.Windows.Forms.Button();
            this.dgvReturnBooks = new System.Windows.Forms.DataGridView();
            this.btnRefrash = new System.Windows.Forms.Button();
            this.colAuthor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReturnBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ФИО";
            // 
            // cbFio
            // 
            this.cbFio.FormattingEnabled = true;
            this.cbFio.Location = new System.Drawing.Point(102, 37);
            this.cbFio.Name = "cbFio";
            this.cbFio.Size = new System.Drawing.Size(338, 28);
            this.cbFio.TabIndex = 1;
            // 
            // btnReturnBooks
            // 
            this.btnReturnBooks.Location = new System.Drawing.Point(608, 40);
            this.btnReturnBooks.Name = "btnReturnBooks";
            this.btnReturnBooks.Size = new System.Drawing.Size(170, 34);
            this.btnReturnBooks.TabIndex = 2;
            this.btnReturnBooks.Text = "Вернуть книги";
            this.btnReturnBooks.UseVisualStyleBackColor = true;
            this.btnReturnBooks.Click += new System.EventHandler(this.BtnReturnBooks_Click);
            // 
            // dgvReturnBooks
            // 
            this.dgvReturnBooks.AllowUserToAddRows = false;
            this.dgvReturnBooks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvReturnBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReturnBooks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colAuthor,
            this.colName,
            this.colId});
            this.dgvReturnBooks.Location = new System.Drawing.Point(2, 95);
            this.dgvReturnBooks.Name = "dgvReturnBooks";
            this.dgvReturnBooks.RowTemplate.Height = 28;
            this.dgvReturnBooks.Size = new System.Drawing.Size(795, 351);
            this.dgvReturnBooks.TabIndex = 3;
            // 
            // btnRefrash
            // 
            this.btnRefrash.Location = new System.Drawing.Point(476, 40);
            this.btnRefrash.Name = "btnRefrash";
            this.btnRefrash.Size = new System.Drawing.Size(112, 34);
            this.btnRefrash.TabIndex = 4;
            this.btnRefrash.Text = "Обновить";
            this.btnRefrash.UseVisualStyleBackColor = true;
            this.btnRefrash.Click += new System.EventHandler(this.BtnRefrash_Click);
            // 
            // colAuthor
            // 
            this.colAuthor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colAuthor.DataPropertyName = "Author";
            this.colAuthor.HeaderText = "Автор";
            this.colAuthor.Name = "colAuthor";
            this.colAuthor.Width = 92;
            // 
            // colName
            // 
            this.colName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colName.DataPropertyName = "Name";
            this.colName.HeaderText = "Название";
            this.colName.Name = "colName";
            // 
            // colId
            // 
            this.colId.DataPropertyName = "id";
            this.colId.HeaderText = "Column1";
            this.colId.Name = "colId";
            this.colId.Visible = false;
            // 
            // ReturnBooksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRefrash);
            this.Controls.Add(this.dgvReturnBooks);
            this.Controls.Add(this.btnReturnBooks);
            this.Controls.Add(this.cbFio);
            this.Controls.Add(this.label1);
            this.Name = "ReturnBooksForm";
            this.Text = "Возврат книги";
            this.Load += new System.EventHandler(this.ReturnBooksForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReturnBooks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbFio;
        private System.Windows.Forms.Button btnReturnBooks;
        private System.Windows.Forms.DataGridView dgvReturnBooks;
        private System.Windows.Forms.Button btnRefrash;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAuthor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
    }
}