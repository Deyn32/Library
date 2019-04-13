namespace Library
{
    partial class TakeForm
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
            this.btnSaveList = new System.Windows.Forms.Button();
            this.dgvListTakeBooks = new System.Windows.Forms.DataGridView();
            this.colAuthor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbFIO = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListTakeBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "ФИО читателя";
            // 
            // btnSaveList
            // 
            this.btnSaveList.Location = new System.Drawing.Point(467, 37);
            this.btnSaveList.Name = "btnSaveList";
            this.btnSaveList.Size = new System.Drawing.Size(211, 37);
            this.btnSaveList.TabIndex = 2;
            this.btnSaveList.Text = "Сохранить список";
            this.btnSaveList.UseVisualStyleBackColor = true;
            this.btnSaveList.Click += new System.EventHandler(this.btnSaveList_Click);
            // 
            // dgvListTakeBooks
            // 
            this.dgvListTakeBooks.AllowUserToAddRows = false;
            this.dgvListTakeBooks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvListTakeBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListTakeBooks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colAuthor,
            this.colId,
            this.colName});
            this.dgvListTakeBooks.Location = new System.Drawing.Point(2, 110);
            this.dgvListTakeBooks.Name = "dgvListTakeBooks";
            this.dgvListTakeBooks.RowTemplate.Height = 28;
            this.dgvListTakeBooks.Size = new System.Drawing.Size(795, 336);
            this.dgvListTakeBooks.TabIndex = 3;
            // 
            // colAuthor
            // 
            this.colAuthor.DataPropertyName = "Author";
            this.colAuthor.HeaderText = "Автор";
            this.colAuthor.Name = "colAuthor";
            this.colAuthor.Width = 200;
            // 
            // colId
            // 
            this.colId.DataPropertyName = "id";
            this.colId.HeaderText = "Column1";
            this.colId.Name = "colId";
            this.colId.Visible = false;
            // 
            // colName
            // 
            this.colName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colName.DataPropertyName = "Name";
            this.colName.HeaderText = "Название";
            this.colName.Name = "colName";
            // 
            // cbFIO
            // 
            this.cbFIO.FormattingEnabled = true;
            this.cbFIO.Location = new System.Drawing.Point(176, 39);
            this.cbFIO.Name = "cbFIO";
            this.cbFIO.Size = new System.Drawing.Size(264, 28);
            this.cbFIO.TabIndex = 4;
            // 
            // TakeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbFIO);
            this.Controls.Add(this.dgvListTakeBooks);
            this.Controls.Add(this.btnSaveList);
            this.Controls.Add(this.label1);
            this.Name = "TakeForm";
            this.Text = "Взять книги";
            this.Load += new System.EventHandler(this.TakeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListTakeBooks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSaveList;
        private System.Windows.Forms.DataGridView dgvListTakeBooks;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAuthor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.ComboBox cbFIO;
    }
}