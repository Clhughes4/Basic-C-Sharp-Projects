using System;


namespace DailyReportDrill
{
    class Program
    {
        static void Main(string[] args)
        {
            // In Current code I am printing the users input received from the stored variable to the console -- just to show the input being stored and returning the correct data

            Console.WriteLine("The Tech Academy\n");
            Console.WriteLine("Student Daily Report\n");

            Console.WriteLine("What current course are you on?");
            string currentCourse = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Current Course is: " + "\n>>> " + currentCourse + "\n");

            Console.WriteLine("What page number?");
            string currentPage = Console.ReadLine();
            int inputPage = Convert.ToInt16(currentPage);
            Console.WriteLine();
            Console.WriteLine("Your current page is: " + "\n>>> " + inputPage + "\n");

            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\".");
            string anyHelp = Console.ReadLine();
            bool inputHelp = Convert.ToBoolean(anyHelp);
            Console.WriteLine();
            Console.WriteLine("Help Required: " + "\n>>> " + inputHelp + "\n");

            Console.WriteLine("Were there any positive experiences you would like to share? Please give specifics.");
            string specExperience = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Your answer is: " + "\n>>> " + specExperience + "\n");

            Console.WriteLine("Is there any feedback you would like to provide? Please be specific.");
            string feedBack = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Your feedback is: " + "\n>>> " + feedBack + "\n");

            Console.WriteLine("How many hours did you study today?");
            string hoursStudied = Console.ReadLine();
            int inputHours = Convert.ToInt16(hoursStudied);
            Console.WriteLine();
            Console.WriteLine("Hours studied = " + "\n>>> " + inputHours + "\n" );
            Console.ReadLine();
            Console.WriteLine("Thank-you for your answers. An Instructor will respond to you shortly." + "\n" + "Have a great day!" + "\n");










            
        }
    }
}
