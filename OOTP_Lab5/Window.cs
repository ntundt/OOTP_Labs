using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOTP_Lab5
{
    class Window : ControlElement
    {
        protected Button minimize;
        protected Button maximize;
        protected Button close;
        protected Menu contents;
        protected WindowState state;
        public Window(Button minimize, Button maximize, Button close, Menu contents) : base(100, 110)
        {
            this.minimize = minimize;
            this.maximize = maximize;
            this.close = close;
            this.contents = contents;
            this.state = WindowState.Maximized;
        }
        public Window() : base(100, 110)
        {
            this.minimize = new Button("_");
            this.maximize = new Button("O");
            this.close = new Button("X");
            Button[] menuContents = { new Button("test") };
            this.contents = new Menu(menuContents);
            this.BackgroundColor = new Color(255, 255, 255);
            this.TextSize = 12;
            this.state = WindowState.Maximized;
        }
        public override string ToString()
        {
            return $"{this.GetType()}\n" +
                $"xSize: {this.XSize}\n" +
                $"ySize: {this.YSize}\n" +
                $"area: {this.Area}\n" +
                $"backgroundColor: {this.BackgroundColor}\n" +
                $"borderColor: {this.BorderColor}\n" +
                $"textColor: {this.TextColor}\n" +
                $"textSize: {this.TextSize}\n" +
                $"minimize: {this.minimize}\n" +
                $"maximize: {this.maximize}\n" +
                $"close: {this.close}\n" +
                $"contents: {this.contents}\n";
        }
    }
}
