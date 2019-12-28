using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace NumberLogDrill
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            using (StreamWriter file = new StreamWriter(@"C:\Users\Clint-Aly\Logs\log.txt", true))
            {
                Console.WriteLine("Please enter in a number.");

                int number = Convert.ToInt32(Console.ReadLine());
                file.WriteLine("\t" + number);
            }
            using (StreamReader sr = new StreamReader(@"C:\Users\Clint-Aly\Logs\log.txt"))
            {
                string line = sr.ReadToEnd();
                Console.WriteLine("\n" + line);
            }


        }
    }
}
