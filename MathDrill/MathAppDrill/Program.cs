using System;


namespace MathDrill
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 50;
            Console.WriteLine("Choose a number...");
            string numInput = Console.ReadLine();
            int newNum1 = Convert.ToInt32(numInput);
            Console.WriteLine("Your number x 50 = " + newNum1 * num1 + "\n");

            int num2 = 25;
            Console.WriteLine("Choose a number...");
            string numInput2 = Console.ReadLine();
            int newNum2 = Convert.ToInt16(numInput2);
            Console.WriteLine("Your number + 25 = " + (newNum2 + num2) + "\n");

            float num3 = 12.5f;
            Console.WriteLine("Choose a number...");
            string numInput3 = Console.ReadLine();
            double newNum3 = Convert.ToDouble(numInput3);
            Console.WriteLine("Your number divided by 12.5 = " + (newNum3 / num3) + "\n");

            int num4 = 50;
            Console.WriteLine("Choose a number...");
            string numInput4 = Console.ReadLine();
            int newNum4 = Convert.ToInt16(numInput4);
            bool compare = newNum4 > num4;
            Console.WriteLine("Your number is greater than 50" + "\nanswer = " + compare + "\n");

            int num5 = 7;
            Console.WriteLine("Choose a number...");
            string numInput5 = Console.ReadLine();
            int newNum5 = Convert.ToInt16(numInput5);
            int remainder = newNum5 % num5;
            Console.WriteLine("Your number divded by 7 \nThe remainder is: " + remainder);


        }
    }
}
