using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeBornDrill
{
    class Program
    {
        static void Main(string[] args)
        {

            bool legit = false;
            while (!legit)
            {
                try 
                { 
                    Console.WriteLine("What is your age?");
                    int age = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();
                    if (age < 0 || age == 0 || age > 100)
                    {
                            Console.WriteLine("Please enter a valid age");
                    }
                    else
                    {
                        var today = DateTime.Today;
                        var yearBorn = today.Year - age;
                        Console.WriteLine("You were born in {0}", yearBorn);
                        legit = true;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please enter a whole number");

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
