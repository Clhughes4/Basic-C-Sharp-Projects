using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method
{
   static class Program
    {
        static void Main(string[] args)
        {
            Math math = new Math();
            Console.WriteLine("Enter a number.");
            int input = Convert.ToInt32(Console.ReadLine());
            math.Divide(input, out input);

            Console.WriteLine("The answer is: {0}\n", input);

            Console.WriteLine(" 77 * 32 = " + math.Multiply(77, 32) + "\n");
            Console.WriteLine(" 45 * 23 = " + math.Multiply(45) + "\n");
        }
    }
}
