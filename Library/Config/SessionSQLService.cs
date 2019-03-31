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
            var query = _sessionSQL.CreateQuery("from Readers r where r.lastName = :{0} and r.name = :{1} and r.{2} = :patronymic");
            query.SetParameter(0, readerFio.lastName); //Возможно не правильно записал параметры
            query.SetParameter(1, readerFio.name);
            query.SetParameter(2, readerFio.patronymic);
            var types = (List<Readers>)query.List<Readers>();
            return types[0];
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
