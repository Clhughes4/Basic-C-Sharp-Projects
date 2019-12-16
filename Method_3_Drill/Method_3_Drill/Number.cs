using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_3_Drill
{
    class Number
    {
        public int Integar(int a)
        {
            int num = 50;
            return  a + num;

        }
        public decimal Integar(decimal a)
        {
            decimal num = Convert.ToInt32(17);
            return a * num;
        }

        public int Integar(string a)
        {
            int num = 406;
            int newNum = Convert.ToInt32(a);
            int div = num / newNum;
            return div;
        }

    }
}
