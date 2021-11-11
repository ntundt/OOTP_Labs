using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOTP_Lab7
{
    abstract class Logger
    {
        abstract public void Write(string message);
        virtual public void Info(string message)
        {
            this.Write($"[{DateTime.Now.ToString("HH:mm:ss")}] INFO: {message}");
        }
    }
}
