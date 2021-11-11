using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOTP_Lab4
{
    interface ICollection<T>
    {
        void Insert(T element);
        void Delete(T element);
        void Find(Predicate<T> condition, Action<T> action);
    }
}
