using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOTP_Lab5
{
    class SoftwareTool : ControlElement
    {
        public List<ControlElement> controlElements { get; set; }
        public SoftwareTool()
        {
            this.controlElements = new List<ControlElement>();
            this.XSize = 1920;
            this.YSize = 1080;
        }
        public SoftwareTool(List<ControlElement> controlElements)
        {
            this.controlElements = controlElements;
            this.XSize = 1920;
            this.YSize = 1080;
        }
        public void Add(ControlElement element)
        {
            this.controlElements.Add(element);
        }
        public void Delete(ControlElement element)
        {
            this.controlElements.Remove(element);
        }
        public void Print()
        {
            foreach (ControlElement element in this.controlElements) {
                Console.WriteLine(element);
            }
        }
    }
}
