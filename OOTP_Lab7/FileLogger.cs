using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOTP_Lab7
{
    class FileLogger : Logger
    {
        private StreamWriter writer;
        public override void Write(string message)
        {
            if (this.writer != null)
            {
                this.writer.WriteLine(message);
            }
            else
            {
                throw new Exception("No file opened");
            }
        }
        public void Open(string filename)
        {
            if (this.writer != null)
            {
                this.writer.Close();
            }
            this.writer = new StreamWriter(filename);
        }
        public FileLogger(string filename)
        {
            this.writer = new StreamWriter(filename);
        }
    }
}
