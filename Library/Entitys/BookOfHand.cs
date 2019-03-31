using Library.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Entitys
{
    public class BookOfHand : BaseEntity
    {
        public virtual long reader_id { get; set; }
        public virtual long book_id { get; set; }
    }
}
