using Library.Classes;
using Library.Config;
using Library.Entitys;
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
            createCbFIO();
        }

        private void createCbFIO()
        {
            cbFIO.Items.AddRange(CreateService.CreateListBox());
            
        }

        private void btnSaveList_Click(object sender, EventArgs e)
        {
            if (cbFIO.Text.Equals(""))
            {
                MessageBox.Show("Поле ФИО читателя не заполнено!");
            }
            Readers reader = CreateService.CreateReaders(cbFIO.Text);
            //Тогда сохраняем
            SaveTakeBooks(dgvListTakeBooks.Rows, reader);
        }

        private void SaveTakeBooks(DataGridViewRowCollection rows, Readers reader)
        {
            SessionSQLService.Create();
            List<BookOfHand> dgvListTakeBooks = new List<BookOfHand>();
            //Найти пользователя и взять id
            foreach(DataGridViewRow row in rows)
            {
                BookOfHand bookOfHand = new BookOfHand();
                bookOfHand.reader_id = reader.id;
                //Тут нужен id книги (добавить невидимые колонки в двух таблицах)
                bookOfHand.book_id = (long)row.Cells["colId"].Value;
                if(SessionSQLService.sessionSQL.IsOpen)
                    SessionSQLService.sessionSQL.Save(bookOfHand);
            }
            SessionSQLService.Close();
            MessageBox.Show("Сохранение прошло успешно!");
            this.Close();
        }
    }
}
