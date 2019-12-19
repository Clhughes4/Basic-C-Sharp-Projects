using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDrill
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<string> employee = new Employee<string>();
            employee.Things = new List<string> { "Clint", "Gabe", "Jaxson", "Dexley" };
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(employee.Things[i] );
            }
            Console.WriteLine();
            Employee<int> number = new Employee<int>();
            number.Things = new List<int> { 8, 4, 7, 3, 9, 2 };
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(number.Things[i]);
            }
            Console.WriteLine();

        }
    }
}
