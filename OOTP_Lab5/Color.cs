using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOTP_Lab5
{
    partial struct Color
    {
        public byte Red { get; set; }
        public byte Green { get; set; }
        public byte Blue { get; set; }

        public override string ToString()
        {
            return "#" + Convert.ToString(this.Red, 16) + Convert.ToString(this.Green, 16) + Convert.ToString(this.Blue, 16);
        }
    }
}
