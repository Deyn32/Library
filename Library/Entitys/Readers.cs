using Library.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Entitys
{
    public class Readers : BaseEntity
    {
        public virtual String name { get; set; }
        public virtual String lastName { get; set; }
        public virtual String patronymic { get; set; }
        public virtual String phone { get; set; }
        public virtual DateTime dateOfTaking { get; set; }
    }
}
