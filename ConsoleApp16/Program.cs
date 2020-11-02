using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{

    public class Cat
    {
        public Cat(string name, DateTime birthday)
        {
            Name = name;
            BirthDay = birthday;
        }
        public string Name
        {
            get;
            set;
        }
        public void MakeNoise()
        {
            Console.WriteLine($"{Name} мяукает");
        }

        public DateTime BirthDay
        {
            get; set;
        }
        public int GetAge()
        {
            return (DateTime.Today - BirthDay).Days / 365;
        }
    }
    class Program
    {


        static void Main(string[] args)
        {
            Cat c = new Cat("Vladik", new DateTime(2020, 05, 25));
            c.MakeNoise();
            Console.WriteLine($"Кошка по имени {c.Name} уже {c.GetAge()} лет");
        }
    }
    
}
