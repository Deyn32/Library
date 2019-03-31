using Library.Classes;
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
    public partial class TakeForm : Form
    {
        public BindingList<TableBooksBinding> dtBooks { get; set; }

        public TakeForm()
        {
            InitializeComponent();
        }

        private void TakeForm_Load(object sender, EventArgs e)
        {
            dgvListTakeBooks.DataSource = dtBooks;
        }

        private void btnSaveList_Click(object sender, EventArgs e)
        {

        }
    }
}
