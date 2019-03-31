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
        }

        private void btnSaveList_Click(object sender, EventArgs e)
        {
            if (textFio.Text.Equals(""))
            {
                MessageBox.Show("Поле ФИО читателя не заполнено!");
            }
            String[] strs = textFio.Text.Split(' ');
            if(strs.Length == 3)
            {
                Readers reader = new Readers();
                reader.lastName = strs[0];
                reader.name = strs[1];
                reader.patronymic = strs[2];
                //Тогда сохраняем
                SaveTakeBooks(dgvListTakeBooks.Rows, reader);
            }
            else
            {
                MessageBox.Show("Не верно заполнено поле ФИО читателя!");
            }
        }

        private void SaveTakeBooks(DataGridViewRowCollection rows, Readers reader)
        {
            SessionSQLService.Create();
            Readers readers = SessionSQLService.FindReader(reader);
            //Найти пользователя и взять id

        }
    }
}
