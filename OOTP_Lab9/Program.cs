using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace OOTP_Lab9
{
    class User 
    {
        public delegate void upgrade(string description);
        public event upgrade Upgrade;

        public delegate void work();
        public event work Work;
        public void AddRAM(int gigs)
        {
            this.Upgrade($"Added {gigs} GB of RAM");
        }
        public void ReplaceHDDwithSSD() {
            this.Upgrade("Replaced HDD with SSD");
        }
        public void StartWorking()
        {
            this.Work();
        }
        public string Name { get; set; }
        public User(string name)
        {
            this.Name = name;
        }
    }
    class SoftwareTool
    {
        public string Name { get; set; }
        public SoftwareTool(string name, User user)
        {
            this.Name = name;
            user.Upgrade += (string description) => Console.WriteLine($"{this.Name}: {description}");
            user.Work += () => Console.WriteLine($"{this.Name}: Пользователь работает за компьютером");
        }
    }
    delegate string StringProcessor(ref string x);
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User("Vlad");
            SoftwareTool word = new SoftwareTool("Word", user);
            SoftwareTool visualStudio = new SoftwareTool("Visual Studio", user);
            SoftwareTool chrome = new SoftwareTool("Chrome", user);

            user.StartWorking();
            user.AddRAM(8);
            user.ReplaceHDDwithSSD();
            StringProcessor stringProcessor;
            stringProcessor = (ref string x) => x = x.ToLower();
            stringProcessor += (ref string x) => x = x.Trim();
            stringProcessor += (ref string x) =>
            {
                Regex regex = new Regex("\\s+");
                return x = regex.Replace(x, " ");
            };
            stringProcessor += (ref string x) =>  x = x.Replace(",", "").Replace(".", "");
            stringProcessor += (ref string x) =>
            {
                Regex regex = new Regex("[^\n]^");
                return x = regex.Replace(x, "\n");
            };
            string test = "    TEST, Test, test.   ";
            Console.WriteLine(stringProcessor(ref test));
        }
    }
}
