using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadOperatorDrill
{
    public class Employee: Person
    {
        public int ID { get; set; }

        public static bool operator ==(Employee employee1, Employee employee2)
        {
            bool status = false;
            if (employee1.ID == employee2.ID)
            {
                status = true;
            }
            return (status);
        }

        public static bool operator !=(Employee employee1, Employee employee2)
        {
            return !(employee1 == employee2);
        }
    }


}
