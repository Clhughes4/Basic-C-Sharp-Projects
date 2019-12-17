using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptionalMethodDrill
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input two numbers, or choose only one number:\n" +
                "Enter your first number.\n");
            int input = Convert.ToInt32(Console.ReadLine() + "\n");
            Math math = new Math();
            bookMark:
            try
            {
                Console.WriteLine("Now enter you second number:\n");
                int input2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine(math.Add(input, out input2) + "\n");
            }
            catch (FormatException)
            {
                Console.WriteLine("Please choose a whole number or enter a zero to no number.");
                goto bookMark;
            }

        }
    }
}
