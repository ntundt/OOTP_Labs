using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOTP_Lab3
{
    partial class Train
    {

        private static int instancesCount = 0;

        public static void WriteInfo()
        {
            Console.WriteLine($"Количество экземпляров класса Train: {Train.instancesCount}");
        }

        private int id;
        private int number;
        private string destination;
        private int compartmentSeats;
        private TimeSpan departure;
        private int reservedSeats;
        private int vipSeats;

        public int Number { get => this.number; set => this.number = value; }
        public string Destination { get => this.destination; set => this.destination = value; }
        public TimeSpan Departure { get => this.departure; set => this.departure = value; }
        public int CompartmentSeats { 
            get => this.compartmentSeats; 
            set
            {
                if (value >= 0 && value < 1000)
                {
                    this.compartmentSeats = value;
                }
                else
                {
                    throw new IndexOutOfRangeException();
                }
            }
        }
        public int ReservedSeats
        {
            get => this.reservedSeats;
            set
            {
                if (value >= 0 && value < 1000)
                {
                    this.reservedSeats = value;
                }
                else
                {
                    throw new IndexOutOfRangeException();
                }
            }
        }
        public int VipSeats
        {
            get => this.vipSeats;
            set
            {
                if (value >= 0 && value < 1000)
                {
                    this.vipSeats = value;
                }
                else
                {
                    throw new IndexOutOfRangeException();
                }
            }
        }
        public int Seats
        {
            get
            {
                return this.CompartmentSeats + this.ReservedSeats + this.VipSeats;
            }
        }

        private Train() { Console.WriteLine("Private constructor called"); }

        public Train(int number, string destination, string departure, int compartmentSeats = 0, int reservedSeats = 0, int vipSeats = 0)
        {
            this.Number = number;
            this.Destination = destination;

            int[] fractions = departure.Split(':').Select(str => Convert.ToInt32(str)).ToArray();
            this.Departure = new TimeSpan(fractions[0], fractions[1], 0);

            this.CompartmentSeats = compartmentSeats;
            this.ReservedSeats = reservedSeats;
            this.VipSeats = vipSeats;

            this.id = Train.instancesCount;
            Train.instancesCount++;
        }

        public Train(int number, string destination, TimeSpan departure, int compartmentSeats = 0, int reservedSeats = 0, int vipSeats = 0)
        {
            this.Number = number;
            this.Destination = destination;

            this.Departure = departure;

            this.CompartmentSeats = compartmentSeats;
            this.ReservedSeats = reservedSeats;
            this.VipSeats = vipSeats;

            this.id = Train.instancesCount;
            Train.instancesCount++;
        }

        public Train(int number)
        {
            this.Number = number;
            this.Destination = "";
            this.Departure = new TimeSpan(0, 0, 0);
            this.CompartmentSeats = 0;
            this.ReservedSeats = 0;
            this.VipSeats = 0;

            this.id = Train.instancesCount;
            Train.instancesCount++;
        }

        public override bool Equals(Object anotherObject)
        {
            return anotherObject.GetType() == this.GetType() && anotherObject.GetHashCode() == this.GetHashCode();

        }

        public override int GetHashCode()
        {
            return this.id;
        }

        public override string ToString()
        {
            return $"{this.id}\t{this.number}\t{this.departure}\t{this.compartmentSeats}\t{this.reservedSeats}\t{this.vipSeats}";
        }

    }
}
