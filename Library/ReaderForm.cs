using Library.Classes;
using Library.Config;
using Library.Entitys;
using Library.Services;
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
    public partial class ReaderForm : Form
    {
        private BindingList<TableBooksBinding> dtBooks;

        public ReaderForm()
        {
            InitializeComponent();
        }

        private void ReaderForm_Load(object sender, EventArgs e)
        {
            dgvListBooks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            StartForm();
        }

        private void StartForm()
        {
            this.WindowState = FormWindowState.Maximized;
            List<Books> books = SessionSQLService.FindAllBooks();
            dtBooks = BindingService.BindingReaderTable(books);
            dgvListBooks.DataSource = dtBooks;
        }

        private void ReaderForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form frm = Application.OpenForms[0];
            frm.Show();
        }

        private void btnRefrash_Click(object sender, EventArgs e)
        {
            StartForm();
        }

        private void btnTake_Click(object sender, EventArgs e)
        {
            TakeForm takeForm = new TakeForm();
            takeForm.dtBooks = new BindingList<TableBooksBinding>();
            foreach (DataGridViewRow row in dgvListBooks.SelectedRows)
            {
                takeForm.dtBooks.Add((TableBooksBinding)row.DataBoundItem);
            }
            takeForm.Show();
        }

        private void btnPass_Click(object sender, EventArgs e)
        {
            ReturnBooksForm returnBooksForm = new ReturnBooksForm();
            returnBooksForm.Show();
        }
    }
}
