﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractPersonDrill
{
    class Program
    {
        static void Main(string[] args)
        {
            //Person person = new Employee();

            Employee employee = new Employee();
            employee.firstName = "Sample";
            employee.lastName = "Student";
            employee.SayName();
        }
    }
}
