using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOTP_Lab5
{
    class Button : ControlElement
    {
        string Text { get; set; }
        public Button(string text) : base(100, 10)
        {
            this.Text = text;
        }
        public override string ToString()
        {
            return $"{this.GetType()}\n" +
                $"\txSize: {this.XSize}\n" +
                $"\tySize: {this.YSize}\n" +
                $"\tText: \"{this.Text}\"";
        }
    }
}
