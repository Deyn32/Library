using Library.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Entitys
{
    public class ListOfOrders : BaseEntity
    {
        public virtual long book_id { get; set; }
    }
}
