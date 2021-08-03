using Library.Abstracts;
using Library.Config;
using Library.Entitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Services
{
    public class FillDBService : IFillDB
    {
        public void FillBooksTable()
        {
            /*SessionSQLService.Create();
            for(int i = 0; i < 6; i++)
            {
                Book book = new Book();
                book.Author = "Толкин";
                book.Condition = false;
                book.Name = "Властелин колец, книга " + (i + 1);
                book.ISBN = "1213451022";
                SessionSQLService.sessionSQL.Save(book);
            }
            SessionSQLService.Close();*/
        }

        public void FillReadersTable()
        {
            throw new NotImplementedException();
        }
    }
}
