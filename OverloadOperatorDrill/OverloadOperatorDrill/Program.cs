using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadOperatorDrill
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.FirstName = "Leonidis";
            employee.LastName = "Pascoli";
            employee.ID = 94175;

            Employee employee2 = new Employee();
            employee2.FirstName = "Jacobee";
            employee2.LastName = "Damascus";
            employee2.ID = 94179;

            
            Console.WriteLine(employee == employee2);
                

        }
       
    }   
}
