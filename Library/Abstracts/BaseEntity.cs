using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Abstracts
{
    public abstract class BaseEntity
    {
        public virtual Int64 id { get; protected set; }
    }
}
