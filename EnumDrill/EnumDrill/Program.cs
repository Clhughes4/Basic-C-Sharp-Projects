using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumDrill
{
    class Program
    {
        static void Main(string[] args)
        {
            bookMark:
            try
            {
                Console.WriteLine("Enter the current day of the week...ex \"Tuesday\"\n" +
                    "Make sure to start with a capital letter.");
                string input = Console.ReadLine();
                Console.WriteLine();

                Days day = (Days)Enum.Parse(typeof(Days), input);
                foreach (string d in Enum.GetNames(typeof(Days)))
                {
                    Console.WriteLine("{1:D} = {0}  ", d, Enum.Parse(typeof(Days), d));
                }
                if (Enum.TryParse(input, out day))
                {
                    Console.WriteLine("You chose: {0} ", day);
                }
                Console.WriteLine();
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter an acual day of the week.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("You didn't enter a day of the week beginning with a capital letter");
                goto bookMark;
            }

        }
        
    }
}
