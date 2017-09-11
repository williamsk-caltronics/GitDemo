using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program will add numbers together");
            Console.WriteLine("Enter a number");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter another number");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"The sum of the two numbers is {a + b}");
            Console.Read();
        }
    }
}
