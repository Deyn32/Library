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
            SessionSQLService.Create();
            Readers reader = new Readers();
            String[] str = cbFio.Text.Split(' ');
            reader.lastName = str[0];
            reader.name = str[1];
            reader.patronymic = str[2];
            reader = SessionSQLService.FindReader(reader);
            List<BookOfHand> bookOfHands = SessionSQLService.findBooksOfHand(reader.id);
            List<Books> listBooks = new List<Books>();
            foreach(var boh in bookOfHands)
            {
                listBooks.Add(SessionSQLService.findBook(boh.book_id));
            }
            SessionSQLService.Close();
            bindingList = BindingService.BindingReaderTable(listBooks);
            dgvReturnBooks.DataSource = bindingList;
        }

        private void BtnReturnBooks_Click(object sender, EventArgs e)
        {
            var rows = dgvReturnBooks.SelectedRows;
            SessionSQLService.Create();
            Readers reader = 
            foreach(var row in rows)
            {
                
            }
        }
    }
}
