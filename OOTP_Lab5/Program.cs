using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOTP_Lab5.Exceptions;

namespace OOTP_Lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<ControlElement> buttons = new List<ControlElement> {
                new Button("OK"),
                new Button("Cancel")
            };

            List<ControlElement> controls = new List<ControlElement> {
                new Button("Test"),
                new Window(),
                new Menu(new List<ControlElement> { new Menu(buttons) })
            };

            SoftwareTool softwareTool = new SoftwareTool(controls);
            SoftwareToolController softwareToolController = new SoftwareToolController(softwareTool);
            foreach (Button button in softwareToolController.Buttons)
            {
                Console.WriteLine(button);
            }
            foreach (Menu menu in softwareToolController.GetMenusOfLevel(1))
            {
                Console.WriteLine(menu);
            }
            Console.WriteLine($"Свободная площадь: {softwareToolController.FreeArea}");

            Logger log = new ConsoleLogger();
            log.Info("Test");

            try
            {
                log = new FileLogger();
                log.Info("This line will throw NoFileOpenedException");
            } 
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                log = null;
            }

            try
            {
                int[] arr = new int[0];
                arr[1] = 1;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            try
            {
                Menu menu = new Menu(new List<ControlElement> { });
                menu.XSize = -1;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            try
            {
                Object obj = null;
                Debug.Assert(obj != null, "object is null");
                obj.ToString();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            try
            {
                try
                {
                    int b = 0;
                    int a = 2 / b;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Generalized exception was thrown");
                    throw;
                }
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("DivideByZeroException was thrown");
                Console.WriteLine(e);
            }

            if (Debugger.IsAttached)
            {
                Console.WriteLine("Debugger is attached");
            }
            else
            {
                Console.WriteLine("Debugger is not attached");
            }


            
        }
    }
}
