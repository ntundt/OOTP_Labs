using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOTP_Lab5
{
    class Printer
    {
        public static void IAmPrinting(Shape shape)
        {
            Console.WriteLine(shape.ToString());
        }
    }
}
