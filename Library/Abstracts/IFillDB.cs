using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Abstracts
{
    public interface IFillDB
    {
        void FillBooksTable();
        void FillReadersTable();
    }
}
