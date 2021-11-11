using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOTP_Lab7
{
    class ConsoleLogger : Logger
    {
        public override void Write(string message)
        {
            Console.WriteLine(message);
        }
    }
}
