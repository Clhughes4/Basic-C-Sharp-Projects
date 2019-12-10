using System;


namespace BasicApprovalDrill
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?");
            string ageInput = Console.ReadLine();
            int age = Convert.ToInt16(ageInput + "\n");
            bool ageB = age > 15;

            Console.WriteLine("Have you ever had a DUI? Please answer true or false.");
            string duiAnswer = Console.ReadLine();
            bool hadDui = Convert.ToBoolean(duiAnswer + "\n");

            Console.WriteLine("How many speeding tickets do you have?");
            string ticketInput = Console.ReadLine();
            int tickets = Convert.ToInt16(ticketInput + "\n");
            bool ticketsB = tickets < 3;

            Console.WriteLine("Qualified?");
            bool qualified = ageB == true && hadDui == false && ticketsB == true;
            Console.WriteLine(qualified);


            Console.ReadLine();


        }
    }
}
