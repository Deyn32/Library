using Library.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Entitys
{
    public class Books: BaseEntity
    {
        public virtual String Author { get; set; } 
        public virtual String Name { get; set; }
        public virtual String ISBN { get; set; }
        public virtual bool Condition { get; set; }
    }
}
