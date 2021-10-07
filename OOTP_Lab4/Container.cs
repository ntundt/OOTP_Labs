using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOTP_Lab4
{
    class Container<T>
    {
        public T value;
        public Container<T> next { get; set; } = null;
        public Container<T> prev { get; set; } = null;
        public Container(T value) {
            this.value = value;
        }
    }
}
