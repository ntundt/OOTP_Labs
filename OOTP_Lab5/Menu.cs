using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOTP_Lab5
{
    class Menu : ControlElement
    {
        protected List<ControlElement> elements;
        public Menu(ControlElement[] elements) : base(100, 100)
        {
            this.elements = new List<ControlElement>(elements);
        }
        public Menu(List<ControlElement> elements): base(100, 100)
        {
            this.elements = elements;
        }
        public List<Button> Buttons
        {
            get
            {
                List<Button> result = new List<Button>();
                foreach (ControlElement element in this.elements)
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
        public List<Menu> GetMenusOfLevel(int required, int level = 0, List<Menu> result = null)
        {
            if (result == null)
            {
                result = new List<Menu>();
            }
            if (level == required)
            {
                result.Add(this);
            }
            else
            {
                foreach (ControlElement element in this.elements)
                {
                    if (element is Menu)
                    {
                        (element as Menu).GetMenusOfLevel(required, ++level, result);
                    }
                }
            }
            return result;
        }
        public override string ToString()
        {
            StringBuilder elements = new StringBuilder();
            elements.Append('\t');
            foreach (Button element in this.Buttons)
            {
                elements.Append(element.ToString());
                elements.Append("\n");
            }
            elements.Replace("\n", "\n\t");
            return $"{this.GetType()}\n" +
                $"\tbuttons: [\n{elements}]";
        }
    }
}
