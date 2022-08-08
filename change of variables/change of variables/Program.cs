using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace change_of_variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Hamsford";
            string surname = "Kris";

            Console.WriteLine($"Привет, {name} {surname} ");

            string replaceName = name;
            name = surname;
            surname = replaceName;

            Console.Write($"Привет, {name} {surname} ");
            Console.ReadKey();
        }
    }
}
