using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaEmployeeDrill
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Employee> employeeList = new List<Employee>()
            // Below are two ways of creating a list and adding those objects to the list
            {
                /*employeeList.Add(*/new Employee { FirstName = "Clint", LastName = "Smith", ID = 777 },
                /*employeeList.Add(*/new Employee { FirstName = "Amber", LastName = "Diamond", ID = 674 },
                /*employeeList.Add(*/new Employee { FirstName = "Gabe", LastName = "Hughes", ID = 896 },
                /*employeeList.Add(*/new Employee { FirstName = "Brielle", LastName = "Erickson", ID = 342 },
                /*employeeList.Add(*/new Employee { FirstName = "Joe", LastName = "Jones", ID = 676 },
                /*employeeList.Add(*/new Employee { FirstName = "Lilly", LastName = "Price", ID = 814 },
                /*employeeList.Add(*/new Employee { FirstName = "Liam", LastName = "Christenson", ID = 937 },
                /*employeeList.Add(*/new Employee { FirstName = "Camillie", LastName = "Flowers", ID = 212 },
                /*employeeList.Add(*/new Employee { FirstName = "Joe", LastName = "Stone", ID = 514 },
                /*employeeList.Add(*/new Employee { FirstName = "Jordan", LastName = "Zundel", ID = 845 }

            };

            List<Employee> newList = employeeList.Where(x => x.FirstName == "Joe").ToList();
            List<Employee> idList = employeeList.Where(x => x.ID > 500).ToList();

            Console.WriteLine("Here is a count of all the items in each list:");
            Console.WriteLine(employeeList.Count());
            Console.WriteLine(idList.Count());
            Console.WriteLine(newList.Count);
            Console.ReadLine();
            Console.WriteLine("This prints out the employees named Joe:");
            foreach (Employee employee in employeeList)
            {
                if (employee.FirstName == "Joe")
                {
                    newList.Add(employee);
                    Console.WriteLine($"{employee.FirstName} {employee.LastName}");
                }
            }
            Console.WriteLine();
            Console.WriteLine("Here is a list of the First Names and IDs\n");
            foreach (Employee employee in idList)
            {
                Console.WriteLine($"{employee.FirstName}: {employee.ID}");
            }
            Console.ReadLine();
        }
    }
}
