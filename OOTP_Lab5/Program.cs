using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOTP_Lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            Button[] buttons = { new Button("OK"), new Button("Cancel") };
            
            Window window = new Window();
            Console.WriteLine(window.ToString());
            Printer.IAmPrinting(window);

            ControlElement[] controls = { new Button(""), new Window(), new Menu(buttons) };
        }
    }
}
