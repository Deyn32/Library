using Library.Classes;
using Library.Entitys;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Services
{
    public static class BindingService
    {
        public static BindingList<TableBooksBinding> BindingReaderTable(List<Book> books)
        {
            BindingList<TableBooksBinding> bindings = new BindingList<TableBooksBinding>();
            foreach(Book b in books)
            {
                TableBooksBinding tbb = new TableBooksBinding();
                tbb.Author = b.Author;
                tbb.Name = b.Name;
                bindings.Add(tbb);
            }
            return bindings;
        }
    }
}
