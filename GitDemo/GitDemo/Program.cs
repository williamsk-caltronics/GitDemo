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
            Add(a, b);
            Average(a, b);
        }

        static void Add(int a, int b)
        {
            Console.WriteLine($"The sum of the two numbers is {a + b}");
        }

        static void Average(int a, int b)
        {
            Console.Write("Average: ");
            Console.WriteLine((a + b) / 2 * 42);
            Console.Read();
        }
    }
}
