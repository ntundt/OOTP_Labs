using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOTP_Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            Train train0 = new Train(5);
            Train train1 = new Train(1, "Moscow", "10:00", 100, 50, 10);
            Train train2 = new Train(2, "Kyiv", new TimeSpan(15, 0, 0), 120, 60, 15);

            Console.WriteLine($"train0.Equals(train1): {train0.Equals(train2)}");
            Console.WriteLine($"train1.ToString(): {train1}");
            Console.WriteLine($"train2.GetHashCode(): {train2.GetHashCode()}");

            Train[] trains = new Train[6];
            trains[0] = new Train(3, "Vilnius", "11:25", 100, 100, 10);
            trains[1] = new Train(4, "Brest", "13:10", 100, 100, 10);
            trains[2] = new Train(6, "Vitsiebsk", "15:15", 100, 100, 10);
            trains[3] = new Train(8, "Hrodna", "19:19", 100, 100, 10);
            trains[4] = new Train(9, "Hrodna", "15:17", 100, 100, 10);
            trains[5] = new Train(10, "Vitsiebsk", "17:33", 100, 100, 10);

            while (true)
            {
                Console.WriteLine("1 — список поездов, следующих до заданного пункта назначения");
                Console.WriteLine("2 — список поездов, отправляющихся после заданного часа");
                int choise = Convert.ToInt32(Console.ReadLine());
                switch (choise)
                {
                    case 1:
                        {
                            Console.Write("Пункт назначения: ");
                            string destination = Console.ReadLine();
                            Console.WriteLine("id\t№\tотправл.\tкупе\tплац.\tVIP");
                            foreach (Train train in trains)
                            {
                                if (train.Destination == destination)
                                {
                                    Console.WriteLine($"{train}");
                                }
                            }
                        }
                        break;
                    case 2:
                        {
                            Console.Write("Пункт назначения: ");
                            string destination = Console.ReadLine();
                            Console.Write("Минимальный час отправления: ");
                            TimeSpan departure = new TimeSpan(Convert.ToInt32(Console.ReadLine()), 0, 0);
                            Console.WriteLine("id\t№\tотправл.\tкупе\tплац.\tVIP");
                            foreach (Train train in trains)
                            {
                                if (train.Destination == destination && departure < train.Departure)
                                {
                                    Console.WriteLine($"{train}");
                                }
                            }
                        }
                        break;
                }
            }
        }
    }
}
