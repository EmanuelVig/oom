using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Airplane airplane = new Airplane(40, "phönix");
            airplane.TakeOf();
            Console.WriteLine("airplane {0} {1} have take of {2}", airplane.Name, airplane.Length, airplane.GetFlyStatus());
            airplane.land();
            Console.WriteLine("airplane {0} {1} have take of {2}", airplane.Name, airplane.Length, airplane.GetFlyStatus());
            Console.ReadLine();
        }
    }
}
