using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodDrill
{
    class Program
    {
        
        static void Main(string[] args)
        {
            bookMark:
            try
            {
                
                Console.WriteLine("Please choose a number:");
                int userInput = Convert.ToInt32(Console.ReadLine());
                Math math = new Math();
                

                Console.WriteLine("Your number ran through the Divide Method is = " + math.Divide(userInput) + "\n");

                Console.WriteLine("Your number ran through the Subtract Method is = " + math.Multiply(userInput) + "\n");

                Console.WriteLine("Your number ran the through Multiply Method is = " + math.Subtract(userInput) + "\n");
            }
            catch (FormatException)
            {
                Console.WriteLine("Please choose a whole number."); // This catch will run even if it is an empty or null value
                goto bookMark;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                goto bookMark;
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}
