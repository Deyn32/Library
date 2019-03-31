using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class LibrarianForm : Form
    {
        public LibrarianForm()
        {
            InitializeComponent();
        }

        private void LibrarianForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form frm = Application.OpenForms[0];
            frm.Show();
        }
    }
}
