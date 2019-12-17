using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method
{
    class Math
    {
        public void Divide(int num)
        {
            int answer = num / 2;
            Console.WriteLine("The answer is: {0}\n", answer);
        }

        public decimal Multiply(decimal num, decimal num1)
        {
            decimal result = num * num1;
            return result;
        }

        public int Multiply(int num)
        {
            int a = 23;
            int result = num * a;

            return result;
        }
    }
}
