using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOTP_Lab5
{
    class Menu : ControlElement
    {
        protected Button[] Buttons;
        public Menu(Button[] buttons) : base(100, 100)
        {
            this.Buttons = buttons;
        }
        public override string ToString()
        {
            StringBuilder buttons = new StringBuilder();
            foreach (Button button in this.Buttons)
            {
                buttons.Append(button.ToString());
                buttons.Append("\n");
            }
            return $"{this.GetType()}\n" +
                $"buttons: [\n{buttons}]";
        }
    }
}
