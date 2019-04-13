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
            Domain domain = new Domain();
            domain.Init();
            _sessionSQL = domain.currentSession;
        }

        public static List<Books> FindAllBooks()
        {
            var query = _sessionSQL.CreateQuery("from Books b where b.Condition = 0");
            var types = (List<Books>)query.List<Books>();
            return types;

        }

        public static Readers FindReader(Readers readerFio)
        {
            return _sessionSQL.QueryOver<Readers>().Where(n => n.lastName == readerFio.lastName)
                                                   .Where(n => n.name == readerFio.name)
                                                   .Where(n => n.patronymic == readerFio.patronymic)
                                                   .List().FirstOrDefault();
        }

        public static List<Readers> FindAll()
        {
            return (List<Readers>)_sessionSQL.QueryOver<Readers>().List();
        }

        public static List<BookOfHand> findBooksOfHand(long idReader)
        {
            return (List<BookOfHand>)_sessionSQL.QueryOver<BookOfHand>().Where(n => n.reader_id == idReader).List();
        }

        public static Books findBook(long id)
        {
            return _sessionSQL.QueryOver<Books>().Where(n => n.id == id).List().FirstOrDefault();
        }

        public static void DeleteBook(long idBook, long idReader)
        {
            BookOfHand bookOfHand = _sessionSQL.QueryOver<BookOfHand>().Where(n => n.book_id == idBook)
                                                                       .Where(n => n.reader_id == idReader)
                                                                       .List().FirstOrDefault();
            _sessionSQL.Delete(bookOfHand);
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
