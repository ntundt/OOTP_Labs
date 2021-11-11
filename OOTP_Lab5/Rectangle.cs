using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOTP_Lab5.Exceptions;

namespace OOTP_Lab5
{
    abstract class Rectangle : Shape
    {
        private double xSize;
        private double ySize;
        public double XSize
        {
            get => this.xSize;
            set
            {
                if (value > 0)
                {
                    this.xSize = value;
                    this.RecalculateArea();
                }
                else if (value <= 0)
                {
                    throw new IncorrectSizeException(value);
                }
            }
        }
        public double YSize
        {
            get => this.ySize;
            set
            {
                if (value > 0)
                {
                    this.ySize = value;
                    this.RecalculateArea();
                }
                else if (value <= 0)
                {
                    throw new IncorrectSizeException(value);
                }
            }
        }
        protected void RecalculateArea()
        {
            this.Area = this.XSize * this.YSize;
        }
        public override double Area { get; protected set; }
        public Rectangle(double xSize, double ySize)
        {
            this.XSize = xSize;
            this.YSize = ySize;
        }
        public abstract void SomeMethod();
    }
}
