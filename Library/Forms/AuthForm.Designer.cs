namespace Library.Forms

{
    partial class AuthForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuthForm));
            this.label1 = new System.Windows.Forms.Label();
            this.btnReader = new System.Windows.Forms.Button();
            this.btnLibrarian = new System.Windows.Forms.Button();
            this.btnSOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(155, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Пожалуйста, представтесь";
            // 
            // btnReader
            // 
            this.btnReader.Location = new System.Drawing.Point(159, 132);
            this.btnReader.Name = "btnReader";
            this.btnReader.Size = new System.Drawing.Size(250, 35);
            this.btnReader.TabIndex = 1;
            this.btnReader.Text = "Читатель";
            this.btnReader.UseVisualStyleBackColor = true;
            this.btnReader.Click += new System.EventHandler(this.btnReader_Click);
            // 
            // btnLibrarian
            // 
            this.btnLibrarian.Location = new System.Drawing.Point(159, 185);
            this.btnLibrarian.Name = "btnLibrarian";
            this.btnLibrarian.Size = new System.Drawing.Size(250, 35);
            this.btnLibrarian.TabIndex = 2;
            this.btnLibrarian.Text = "Библиотекарь";
            this.btnLibrarian.UseVisualStyleBackColor = true;
            this.btnLibrarian.Click += new System.EventHandler(this.btnLibrarian_Click);
            // 
            // btnSOK
            // 
            this.btnSOK.Location = new System.Drawing.Point(159, 245);
            this.btnSOK.Name = "btnSOK";
            this.btnSOK.Size = new System.Drawing.Size(252, 35);
            this.btnSOK.TabIndex = 3;
            this.btnSOK.Text = "Сотрудник отдела комплектации";
            this.btnSOK.UseVisualStyleBackColor = true;
            this.btnSOK.Click += new System.EventHandler(this.btnSOK_Click);
            // 
            // AuthForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 348);
            this.Controls.Add(this.btnSOK);
            this.Controls.Add(this.btnLibrarian);
            this.Controls.Add(this.btnReader);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AuthForm";
            this.Text = "Авторизация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnReader;
        private System.Windows.Forms.Button btnLibrarian;
        private System.Windows.Forms.Button btnSOK;
    }
}