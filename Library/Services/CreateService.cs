using Library.Config;
using Library.Entitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class CreateService
    {
        public static String[] CreateListBox()
        {
            SessionSQLService.Create();
            List<Readers> readers = SessionSQLService.FindAll();
            SessionSQLService.Close();
            String[] result = new String[readers.Count];
            for (int i = 0; i < readers.Count; i++)
            {
                String str = readers[i].lastName + " " + readers[i].name + " " + readers[i].patronymic;
                result[i] = str;
            }
            return result;
        }

        public static Readers CreateReaders(String text)
        {
            SessionSQLService.Create();
            Readers reader = new Readers();
            String[] str = text.Split(' ');
            reader.lastName = str[0];
            reader.name = str[1];
            reader.patronymic = str[2];
            reader = SessionSQLService.FindReader(reader);
            SessionSQLService.Close();
            return reader;
        }
    }
}
