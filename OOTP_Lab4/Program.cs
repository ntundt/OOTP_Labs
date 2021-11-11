using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OOTP_Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });
            list.Insert(11);
            list.Insert(12);
            list.Find(x => x % 2 == 0, Console.WriteLine);

            List<int> list1 = new List<int>("Test.txt");
            list1.Find(x => true, Console.WriteLine);

            List<Color> list2 = new List<Color>(new Color[] { new Color(0, 0, 0), new Color(255, 255, 255) });
            list2.Find(x => true, Console.WriteLine);
            list2.SaveToFile("Colors.txt");

            List<int> list3 = new List<int>(new int[] { });
            try
            {
                list3.RemoveLastElement();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            finally
            {
                list3 = null;
            }
        }
    }
}
