using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DateTimeDrill
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamWriter file = new StreamWriter(@"C:\Users\Clint-Aly\Logs\log.txt", true))
            {
                file.WriteLine(DateTime.Now);
                Console.WriteLine("Enter a number");
                int answer = Convert.ToInt32(Console.ReadLine());
                file.WriteLine("\t" + " {0}", answer);
            }

            using (StreamReader sr = new StreamReader(@"C:\Users\Clint-Aly\Logs\log.txt"))
            {
                string line = sr.ReadToEnd();
                Console.WriteLine("\n" +line);
            }



        }
    }
}
