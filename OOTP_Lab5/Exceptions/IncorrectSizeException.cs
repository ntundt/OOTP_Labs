using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOTP_Lab5.Exceptions
{
    class IncorrectSizeException : Exception
    {
        public IncorrectSizeException(double size)
        {
            this.Data.Add("size", size);
        }
    }
}
