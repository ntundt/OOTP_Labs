using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOTP_Lab5
{
    abstract class ControlElement : Rectangle, Decorated
    {
        public Color BackgroundColor { get; set; }
        public Color BorderColor { get; set; }
        public Color TextColor { get; set; }
        public float TextSize { get; set; }
        public ControlElement() : base(100, 100) { }
        public ControlElement(int xSize, int ySize) : base(xSize, ySize) { }
    }
}
