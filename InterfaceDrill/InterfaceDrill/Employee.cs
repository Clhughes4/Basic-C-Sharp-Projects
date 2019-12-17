using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDrill
{
    public class Employee : Person, IQuittable
    {
        public override void SayName()
        {
            Console.WriteLine("The Student is the: \n\n  {0} {1}", firstName, lastName);

        }
        public void Quit()
        {
            Console.WriteLine("This method was succesful printing to the console.\n");

        }
    }
}
