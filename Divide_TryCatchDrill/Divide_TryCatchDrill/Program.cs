using System;
using System.Collections.Generic;
using System.Linq;



class Program
{
    static void Main(string[] args)
    {
        List<int> number = new List<int>() { 6, 8, 14, 21, 38, 4, 7, 12 };
        bookMark:
        Console.WriteLine("Choose a number to divide by.\n");
        //float divideBy = Convert.ToInt32(Console.ReadLine());

        try
        {
            float divideBy = Convert.ToSingle(Console.ReadLine());

            //int divideBy = Convert.ToInt32(Console.ReadLine());
            
            foreach (int num in number)
            {

                decimal answer = (decimal)num / (decimal)divideBy;
                decimal change = Convert.ToDecimal(String.Format("{0:0.00}", answer)); // Formating so the answer showing only 2 decimal places
                Console.WriteLine(" " + num + " / " + divideBy + " = " + change + "\n");

            }
            Console.WriteLine("The program moved on without any exception errors.");
            //Console.ReadLine();
        }
        /* When dividing an int by 0 == Unhandled Exception: System.DivideByZeroException: Attempted to divide by zero. 
           When dividing using double or a float as a data type-- returns the infinity symbol  ∞ */
        catch (DivideByZeroException)
        {
            Console.WriteLine("Please don't divide by zero.");
            goto bookMark;
        }
        /* --- When dividing by string ---Unhandled Exception: System.FormatException: Input string was not in a correct format. */
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

