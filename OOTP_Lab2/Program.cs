using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOTP_Lab2
{
    class Program
    {
        
        public static void Task1a()
        {
            bool vbool = true;
            byte vbyte = 255;
            sbyte vsbyte = 127;
            char vchar = 'z';
            decimal vdecimal = 2.0m;
            double vdouble = 2.0d;
            float vfloat = 2.0f;
            short vshort = 1;
            ushort vushort = 12;
            int vint = 123;
            uint vuint = 1234;
            nint vnint = 12345;
            nuint vnuint = 123456;
            long vlong = 1234567;
            ulong vulong = 12345678;
            string vstring = "string";

            Console.WriteLine(vbool);
            Console.WriteLine(vbyte);
            Console.WriteLine(vsbyte);
            Console.WriteLine(vchar);
            Console.WriteLine(vdecimal);
            Console.WriteLine(vdouble);
            Console.WriteLine(vfloat);
            Console.WriteLine(vshort);
            Console.WriteLine(vushort);
            Console.WriteLine(vint);
            Console.WriteLine(vuint);
            Console.WriteLine(vnint);
            Console.WriteLine(vnuint);
            Console.WriteLine(vlong);
            Console.WriteLine(vulong);
            Console.WriteLine(vstring);

            Console.Write("bool ");
            vbool = Convert.ToBoolean(Console.ReadLine());
            Console.Write("byte ");
            vbyte = Convert.ToByte(Console.ReadLine());
            Console.Write("sbyte ");
            vsbyte = Convert.ToSByte(Console.ReadLine());
            Console.Write("char ");
            vchar = Convert.ToChar(Console.ReadLine());
            Console.Write("decimal ");
            vdecimal = Convert.ToDecimal(Console.ReadLine());
            Console.Write("double ");
            vdouble = Convert.ToDouble(Console.ReadLine());
            Console.Write("float ");
            vfloat = Convert.ToSingle(Console.ReadLine());
            Console.Write("short ");
            vshort = Convert.ToInt16(Console.ReadLine());
            Console.Write("ushort ");
            vushort = Convert.ToUInt16(Console.ReadLine());
            Console.Write("int ");
            vint = Convert.ToInt32(Console.ReadLine());
            Console.Write("uint ");
            vuint = Convert.ToUInt32(Console.ReadLine());
            Console.Write("nint ");
            vnint = (nint)Convert.ToInt64(Console.ReadLine());
            Console.Write("nuint ");
            vnuint = (nuint)Convert.ToUInt64(Console.ReadLine());
            Console.Write("long ");
            vlong = Convert.ToInt64(Console.ReadLine());
            Console.Write("ulong ");
            vulong = Convert.ToUInt64(Console.ReadLine());
            Console.Write("string ");
            vstring = Console.ReadLine();

            Console.WriteLine(vbool);
            Console.WriteLine(vbyte);
            Console.WriteLine(vsbyte);
            Console.WriteLine(vchar);
            Console.WriteLine(vdecimal);
            Console.WriteLine(vdouble);
            Console.WriteLine(vfloat);
            Console.WriteLine(vshort);
            Console.WriteLine(vushort);
            Console.WriteLine(vint);
            Console.WriteLine(vuint);
            Console.WriteLine(vnint);
            Console.WriteLine(vnuint);
            Console.WriteLine(vlong);
            Console.WriteLine(vulong);
            Console.WriteLine(vstring);
        }

        public static void Task1b()
        {
            int vint = 5;

            byte vbyte = (byte)vint;
            sbyte vsbyte = (sbyte)vint;
            short vshort = (short)vint;
            ushort vushort = (ushort)vint;
            uint vuint = (uint)vint;

            byte vbyte1 = 123;

            short vshort1 = vbyte1;
            ushort vushort1 = vbyte1;
            int vint1 = vbyte1;
            uint vuint1 = vbyte1;
            long vlong1 = vbyte1;

        }

        public static void Task1c()
        {
            // упаковка
            int a = 123;
            object o = a;

            o = 100;

            // распаковка
            a = (int)o;
        }

        public static void Task1d()
        {
            var e = 0;
            e++;
            e -= 5;
            Console.WriteLine(e);
        }

        public static void Task1e()
        {
            bool? test = false;
            test = null;
            if (test.HasValue)
            {
                Console.WriteLine("Initialized");
            }
            else
            {
                Console.WriteLine("Not initialized");
            }
        }

        public static void Task1f()
        {
            var b = "test";
            b = 1.ToString();
        }

        public static void Task2a()
        {
            if ("abc".Equals("bcd"))
            {
                Console.WriteLine("hell freezed over");
            }
        }

        public static void Task2b()
        {
            String s1 = "Hello", s2 = "world", s3 = "the qck brown fox jumps over lazy dog";
            String s4 = s1 + " " + s2;
            // s3 = s1;
            char[] vs = new char[12];
            s2.CopyTo(0, vs, 0, 4);
            s2.Substring(1);

            s3.Insert(31, "the ");
            String[] sp = s3.Split(' ');
            s3.Replace("qck", "quick");

            const double pi = Math.PI;
            Console.WriteLine($"pi = {pi}");

            var date = DateTime.Now;
            Console.WriteLine($"Сегодня {date.DayOfWeek}");
        }

        public static void Task2c()
        {
            String empty = "";
            String zero = null;

            if (string.IsNullOrEmpty(empty) && string.IsNullOrEmpty(zero))
            {
                Console.WriteLine("Обе строки пустые или null!");
            }
        }

        public static void Task2d()
        {
            StringBuilder builder = new("1");
            builder.Append("23");
            Console.WriteLine(builder.ToString());
        }

        public static void Task3a()
        {
            int[,] matrix = new int[5, 5];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = i + j;
                }
            }

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i, j]} ");
                }
                Console.WriteLine();
            }
        }

        public static void Task3b()
        {
            string[] arrayOfStrings = { "string 1", "string 2", "string 3" };
            for (int i = 0; i < arrayOfStrings.GetLength(0); i++)
            {
                Console.Write($"{arrayOfStrings[i]} ");
            }
            Console.WriteLine($"\nДлина массива: {arrayOfStrings.GetLength(0)}");
            Console.Write("Номер строки для изменения: ");
            arrayOfStrings[Convert.ToInt32(Console.ReadLine())] = Console.ReadLine();
            for (int i = 0; i < arrayOfStrings.GetLength(0); i++)
            {
                Console.Write($"{arrayOfStrings[i]} ");
            }
            Console.WriteLine();
        }

        public static void Task3c()
        {
            double[][] floatArray = new double[3][];
            for (int i = 0; i < floatArray.Length; i++)
            {
                floatArray[i] = new double[2 + i];
            }
            Console.WriteLine("Значения ступенчатого массива: ");

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < i + 2; j++)
                {
                    floatArray[i][j] = Convert.ToDouble(Console.ReadLine());
                }
            }
        }

        public static void Task4a()
        {
            (int vint, string vstring1, char vchar, string vstring2, ulong vulong) cortage = 
                (vint: 1, vstring1: "str1", vchar: 'c', vstring2: "str2", vulong: 123);
            Console.WriteLine(cortage);
        }

        public static void Task4b()
        {
            (int vint, string vstring1, char vchar, string vstring2, ulong vulong) cortage =
                (vint: 1, vstring1: "str1", vchar: 'c', vstring2: "str2", vulong: 123);
            Console.WriteLine(cortage);
            Console.WriteLine(cortage.Item1);
            Console.WriteLine(cortage.Item3);
            Console.WriteLine(cortage.Item4);
        }

        public static void Task4c()
        {
            (var _, var b, var _, var _, var _) =
                (1, "str1", 'c', "str2", 123);
            Console.WriteLine(b);

            var c = ("test", 1).Item1;
            Console.WriteLine(c);
        }

        public static void Task4d()
        {
            if (("cortage 1", 1).Equals(("cortage 1", 1)))
            {
                Console.WriteLine("Кортежи равны");
            }
            else
            {
                Console.WriteLine("Кортежи не равны");
            }
        }

        static void Main(string[] args)
        {
            (int min, int max, char str) Task5(int[] arr, string str)
            {
                return (arr.Min(), arr.Max(), str.ToCharArray()[0]);
            }

            void Task6Checked()
            {
                checked
                {
                    int test = int.MaxValue;
                    test++;
                    Console.WriteLine(test);
                }
            }

            void Task6Unchecked()
            {
                unchecked
                {
                    int test = int.MaxValue;
                    test++;
                    Console.WriteLine(test);
                }
            }

            while (true)
            {
                Console.Write("Задание: ");
                string task = Console.ReadLine();

                switch (task)
                {
                    case "1a":
                        Task1a();
                        break;
                    case "1b":
                        Task1b();
                        break;
                    case "1c":
                        Task1c();
                        break;
                    case "1d":
                        Task1d();
                        break;
                    case "1e":
                        Task1e();
                        break;
                    case "1f":
                        Task1f();
                        break;
                    case "2a":
                        Task2a();
                        break;
                    case "2b":
                        Task2b();
                        break;
                    case "2c":
                        Task2c();
                        break;
                    case "2d":
                        Task2d();
                        break;
                    case "3a":
                        Task3a();
                        break;
                    case "3b":
                        Task3b();
                        break;
                    case "3c":
                        Task3c();
                        break;
                    case "4a":
                        Task4a();
                        break;
                    case "4b":
                        Task4b();
                        break;
                    case "4c":
                        Task4c();
                        break;
                    case "4d":
                        Task4d();
                        break;

                    case "5":
                        int[] arr = { 1, 2, 3, 4, 5 };
                        string str = "F is going to be returned";
                        Console.WriteLine(Task5(arr, str));
                        break;

                    case "6u":
                        Task6Unchecked();
                        break;
                    case "6c":
                        Task6Checked();
                        break;
                }
            }




        }
    }
}
