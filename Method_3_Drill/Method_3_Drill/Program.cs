using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_3_Drill
{
    class Program
    {
        static void Main(string[] args)
        {
            Number add = new Number();
            Console.WriteLine(add.Integar(45));

            Number dec = new Number();
            decimal decNum = 34;
            Console.WriteLine(dec.Integar(decNum));

            Number str = new Number();
            string strConvert = Convert.ToString(str.Integar("88"));
            Console.WriteLine(strConvert);

        }
    }
}
