using Library.Entitys;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Config
{
    public class SessionSQLService
    {
        private static ISession _sessionSQL;

        public static ISession sessionSQL
        {
            get { return _sessionSQL; }
        }

        public static void Create()
        {
            Domain.Domain domain = new Domain.Domain();
            domain.Init();
            _sessionSQL = domain.currentSession;
        }

        public static List<Books> FindAllBooks()
        {
            Create();
            var query = _sessionSQL.CreateQuery("from Books b where b.Condition = 0");
            var types = (List<Books>)query.List<Books>();
            Close();
            return types;

        }

        public static Readers FindReader(Readers readerFio)
        {
            Create();
            Readers reader = _sessionSQL.QueryOver<Readers>().Where(n => n.lastName == readerFio.lastName)
                                                   .Where(n => n.name == readerFio.name)
                                                   .Where(n => n.patronymic == readerFio.patronymic)
                                                   .List().FirstOrDefault();
            Close();
            return reader;
        }

        public static List<Readers> FindAll()
        {
            Create();
            List<Readers> readers = (List<Readers>)_sessionSQL.QueryOver<Readers>().List();
            Close();
            return readers;
        }

        public static List<BookOfHand> findBooksOfHand(long idReader)
        {
            Create();
            List<BookOfHand> list = (List<BookOfHand>)_sessionSQL.QueryOver<BookOfHand>().Where(n => n.reader_id == idReader).List();
            Close();
            return list;
        }

        public static Books findBook(long id)
        {
            Create();
            Books book = _sessionSQL.QueryOver<Books>().Where(n => n.id == id).List().FirstOrDefault();
            Close();
            return book;
        }

        public static void DeleteBook(long idBook, long idReader)
        {
            Create();
            BookOfHand bookOfHand = _sessionSQL.QueryOver<BookOfHand>().Where(n => n.book_id == idBook)
                                                                       .Where(n => n.reader_id == idReader)
                                                                       .List().FirstOrDefault();
            string test = _sessionSQL.Connection.Database;
            _sessionSQL.Delete(bookOfHand);
            Close();
        }

        public static void Close()
        {
            if (_sessionSQL.IsOpen)
            {
                _sessionSQL.Close();
            }
        }
    }
}
