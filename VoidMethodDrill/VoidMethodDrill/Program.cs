using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoidMethodDrill
{
    class Program
    {
        static void Main(string[] args)
        {
            Number number = new Number();
            number.AddNum(56, 78);

            number.AddNum(num1: 36, num2: 44);
        }
    }
}
