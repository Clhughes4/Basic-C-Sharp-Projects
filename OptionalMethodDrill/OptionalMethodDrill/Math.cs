using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptionalMethodDrill
{
    class Math
    {
        public int Add(int num, out int number, int num1 = 7)
        {
            int result = (num + num1) * 86;
            number = 0;

            return result;
        }
    }
}
