using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOTP_Lab5
{
    abstract class Shape
    {
        private double area = 0;
        public virtual double Area { 
            get => this.area;
            protected set {
                if (value > 0)
                {
                    this.area = value;
                }
            }
        }
    }
}
