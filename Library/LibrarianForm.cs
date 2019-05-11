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

        private void tsmiHandOverBook_Click(object sender, EventArgs e)
        {
            HandOverForm hof = new HandOverForm();
            hof.Show();
        }

        private void tsmiConditionBook_Click(object sender, EventArgs e)
        {
            ConditionBookForm cbf = new ConditionBookForm();
            cbf.Show();
        }
    }
}
