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
    }
}
