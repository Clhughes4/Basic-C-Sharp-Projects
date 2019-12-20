using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructDrill
{
    class Program
    {
        static void Main(string[] args)
        {
            Number number = new Number();
            number.Amount = 84;
            Number number2 = new Number();
            number2.Amount = 36;
            Console.WriteLine("The amount is: {0} and {1}", number.Amount, number2.Amount);
        }
    }
}
