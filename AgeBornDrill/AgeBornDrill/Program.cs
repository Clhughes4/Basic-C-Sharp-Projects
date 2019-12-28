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
            bookMark:
            try
            {
                Console.WriteLine("What is your age?");
                int age = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                if (age < 0 || age == 0 || age > 100 )
                {
                    while (age < 0 || age == 0 || age > 100)
                    {
                        Console.WriteLine("Please enter a valid age");
                        break;
                    }
                        goto bookMark;

                }
                else
                {
                    var today = DateTime.Today;
                    var yearBorn = today.Year - age;
                    Console.WriteLine("You were born in {0}", yearBorn);
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter a whole number");
                //return;
                goto bookMark;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                //return;
                goto bookMark;
            }
            

        }

    }
}
