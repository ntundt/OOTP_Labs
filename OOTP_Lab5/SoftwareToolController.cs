using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOTP_Lab5
{
    class SoftwareToolController
    {
        private SoftwareTool container;
        public double FreeArea { 
            get 
            {
                double childArea = 0;
                foreach (ControlElement element in container.controlElements)
                {
                    childArea += element.Area;
                }
                return this.container.Area - childArea;
            }
        }
        public List<Button> Buttons
        {
            get
            {
                List<Button> result = new List<Button>();
                foreach (ControlElement element in container.controlElements)
                {
                    if (element is Button)
                    {
                        result.Add(element as Button);
                    }
                    else if (element is Menu)
                    {
                        foreach (ControlElement elem in (element as Menu).Buttons)
                        {
                            result.Add(elem as Button);
                        };
                    }
                }
                return result;
            }
        }
        public List<Menu> GetMenusOfLevel(int level) 
        {
            List<Menu> result = new List<Menu>();
            foreach (ControlElement element in this.container.controlElements)
            {
                if (element is Menu)
                {
                    foreach (Menu menu in (element as Menu).GetMenusOfLevel(level))
                    {
                        result.Add(menu);
                    }
                }
            }
            return result;
        }
        public void Add(ControlElement element)
        {
            this.container.Add(element);
        }
        public SoftwareToolController(SoftwareTool softwareTool)
        {
            this.container = softwareTool;
        }
        public SoftwareToolController()
        {
            this.container = new SoftwareTool();
        }
    }
}
