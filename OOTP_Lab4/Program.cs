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
            List<int> list = new List<int>();
            list += 2;
            list.InsertTail(3);
            list.InsertHead(1);

            Console.WriteLine($"{list}");

            Console.WriteLine($"Сумма элментов: {list.Sum()}");
            Console.WriteLine($"Разность между максимальным и минимальным: {list.MinMaxDiff()}");
            Console.WriteLine($"Количество элементов: {list.ElementCount()}");
            string not = list ? "" : "не ";
            Console.WriteLine($"Список {not}упорядочен");

            List<string> list1 = new List<string>();
            list1 += "word1";
            list1 += null;
            list1 += "";
            list1 += "word1 word2 word3";
            Console.WriteLine($"Список строк: {list1}");
            Console.WriteLine($"Количество слов: {list1.WordCount()}");
            Console.WriteLine($"Есть ли нулевые элементы: {list1.HasNullElements()}");
        }
    }
}
