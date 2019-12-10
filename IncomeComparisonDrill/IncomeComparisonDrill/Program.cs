using System;


namespace IncomeComparisonDrill
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Anonymous Income Comparison Program ---" + "\n\n");

            Console.WriteLine("Person 1:" + "\n");
            int hourRate1 = 34;
            Console.WriteLine("Hourly Rate:" + "\n" + hourRate1 + "\n");
            int hoursWorked1 = 40;
            Console.WriteLine("Hours Worked" + "\n" + hoursWorked1 + "\n");
            int salary1 = hourRate1 * hoursWorked1;

            Console.ReadLine();

            Console.WriteLine("Person 2:" + "\n");
            int hourRate2 = 27;
            Console.WriteLine("Hourly Rate:" + "\n" + hourRate2 + "\n");
            int hoursWorked2 = 40;
            Console.WriteLine("Hours Worked:" + "\n" + hoursWorked2 + "\n");
            int salary2 = hourRate2 * hoursWorked2;

            Console.ReadLine();

            Console.WriteLine("Weekly Salary of Person 1:" + "\n" + salary1 + "\n");
            Console.WriteLine("Weekly Salary of Person 2:" + "\n" + salary2 + "\n");
            bool compare = salary1 > salary2;
            Console.WriteLine("Does Person 1 make more than Person 2?" + "\n" + compare + "\n");

            
        }
    }
}
