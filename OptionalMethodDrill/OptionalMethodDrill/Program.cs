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
            bool check = true;


            do
            {
                try
                {
                    Console.WriteLine("Now enter you second number:\n");
                    string input2 = Console.ReadLine();
                    if (input2 == "")
                    {
                        Console.WriteLine();
                        Console.WriteLine(math.Add(input) + "\n");
                        check = false;
                    }
                    else
                    {
                        int newInput = Convert.ToInt32(input2);
                        Console.WriteLine(math.Add(input, newInput));
                        check = false;
                        break;

                    }

                }
                catch (FormatException)
                {
                    Console.WriteLine("Press Enter and input a whole number.\n");
                    continue;
                }
            }
            while (check);
                        
                    


        }
    }
}
