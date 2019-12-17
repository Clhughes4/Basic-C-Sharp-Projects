using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDrill
{
    class Program
    {
        static void Main(string[] args)
        {
            IQuittable person = new Employee();
            person.Quit();
            ((Employee)person).firstName = "Gabe";
            ((Employee)person).lastName = "Hughes";
            ((Employee)person).SayName();
        }
    }
}
