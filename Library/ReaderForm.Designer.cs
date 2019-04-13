namespace Library
{
    partial class ReaderForm
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
            this.txtFind = new System.Windows.Forms.TextBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.dgvListBooks = new System.Windows.Forms.DataGridView();
            this.colAuthor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnTake = new System.Windows.Forms.Button();
            this.btnPass = new System.Windows.Forms.Button();
            this.btnRefrash = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFind
            // 
            this.txtFind.Location = new System.Drawing.Point(58, 46);
            this.txtFind.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(367, 26);
            this.txtFind.TabIndex = 0;
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(494, 43);
            this.btnFind.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(112, 35);
            this.btnFind.TabIndex = 1;
            this.btnFind.Text = "Поиск";
            this.btnFind.UseVisualStyleBackColor = true;
            // 
            // dgvListBooks
            // 
            this.dgvListBooks.AllowUserToAddRows = false;
            this.dgvListBooks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvListBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListBooks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colAuthor,
            this.colId,
            this.colName});
            this.dgvListBooks.Location = new System.Drawing.Point(-3, 106);
            this.dgvListBooks.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvListBooks.Name = "dgvListBooks";
            this.dgvListBooks.ReadOnly = true;
            this.dgvListBooks.Size = new System.Drawing.Size(1203, 582);
            this.dgvListBooks.TabIndex = 2;
            // 
            // colAuthor
            // 
            this.colAuthor.DataPropertyName = "Author";
            this.colAuthor.HeaderText = "Автор";
            this.colAuthor.Name = "colAuthor";
            this.colAuthor.ReadOnly = true;
            this.colAuthor.Width = 300;
            // 
            // colId
            // 
            this.colId.DataPropertyName = "id";
            this.colId.HeaderText = "Column1";
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            this.colId.Visible = false;
            // 
            // colName
            // 
            this.colName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colName.DataPropertyName = "Name";
            this.colName.HeaderText = "Название";
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            // 
            // btnTake
            // 
            this.btnTake.Location = new System.Drawing.Point(767, 46);
            this.btnTake.Name = "btnTake";
            this.btnTake.Size = new System.Drawing.Size(75, 35);
            this.btnTake.TabIndex = 3;
            this.btnTake.Text = "Взять";
            this.btnTake.UseVisualStyleBackColor = true;
            this.btnTake.Click += new System.EventHandler(this.btnTake_Click);
            // 
            // btnPass
            // 
            this.btnPass.Location = new System.Drawing.Point(861, 46);
            this.btnPass.Name = "btnPass";
            this.btnPass.Size = new System.Drawing.Size(75, 35);
            this.btnPass.TabIndex = 4;
            this.btnPass.Text = "Сдать";
            this.btnPass.UseVisualStyleBackColor = true;
            this.btnPass.Click += new System.EventHandler(this.btnPass_Click);
            // 
            // btnRefrash
            // 
            this.btnRefrash.Location = new System.Drawing.Point(623, 43);
            this.btnRefrash.Name = "btnRefrash";
            this.btnRefrash.Size = new System.Drawing.Size(75, 35);
            this.btnRefrash.TabIndex = 5;
            this.btnRefrash.Text = "Обновить";
            this.btnRefrash.UseVisualStyleBackColor = true;
            this.btnRefrash.Click += new System.EventHandler(this.btnRefrash_Click);
            // 
            // ReaderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.btnRefrash);
            this.Controls.Add(this.btnPass);
            this.Controls.Add(this.btnTake);
            this.Controls.Add(this.dgvListBooks);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.txtFind);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ReaderForm";
            this.Text = "Библиотека";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ReaderForm_FormClosed);
            this.Load += new System.EventHandler(this.ReaderForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListBooks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFind;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.DataGridView dgvListBooks;
        private System.Windows.Forms.Button btnTake;
        private System.Windows.Forms.Button btnPass;
        private System.Windows.Forms.Button btnRefrash;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAuthor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
    }
}