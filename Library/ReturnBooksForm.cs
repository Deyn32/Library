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
    public partial class ReturnBooksForm : Form
    {
        private BindingList<TableBooksBinding> bindingList;
        public ReturnBooksForm()
        {
            InitializeComponent();
        }

        private void ReturnBooksForm_Load(object sender, EventArgs e)
        {
            cbFio.Items.AddRange(CreateService.CreateListBox());
        }

        private void BtnRefrash_Click(object sender, EventArgs e)
        {
            Refrash();
        }

        private void Refrash()
        {
            SessionSQLService.Create();
            Readers reader = CreateService.CreateReaders(cbFio.Text);
            List<BookOfHand> bookOfHands = SessionSQLService.findBooksOfHand(reader.id);
            List<Books> listBooks = new List<Books>();
            foreach (var boh in bookOfHands)
            {
                listBooks.Add(SessionSQLService.findBook(boh.book_id));
            }
            SessionSQLService.Close();
            bindingList = BindingService.BindingReaderTable(listBooks);
            dgvReturnBooks.DataSource = bindingList;
        }

        private void BtnReturnBooks_Click(object sender, EventArgs e)
        {
            DeleteBooks();
            Refrash();
        }

        private void DeleteBooks()
        {
            var rows = dgvReturnBooks.SelectedRows;
            SessionSQLService.Create();
            Readers reader = CreateService.CreateReaders(cbFio.Text);
            foreach (DataGridViewRow row in rows)
            {
                SessionSQLService.DeleteBook((long)row.Cells["colId"].Value, reader.id);
            }
            SessionSQLService.Close();
            MessageBox.Show("Книги возвращены");
        }
    }
}
