using System;


namespace ShippingQuote
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Package Express.\n\n" +
                "Please follow the directions below " + "\n\n");

            Console.WriteLine("What is the weight of your package?");
            int packageWeight = Convert.ToInt32(Console.ReadLine());

     

            if (packageWeight > 50)
            {
                Console.WriteLine("The package is too heavy to be shipped via Package Express.\n" +
                "Have a nice day.\n");
            }
            else if (packageWeight < 50)
            {
                Console.WriteLine("What is the width of your package?");
                int packageWidth = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("What is the height of your package?");
                int packageHeight = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("What is the length of your package");
                int packageLength = Convert.ToInt32(Console.ReadLine());
                int dimensionsTotal = packageWidth + packageHeight + packageLength;
                if (dimensionsTotal > 50)
                {
                    Console.WriteLine("The package is too big to be shipped via Package Express");
                }
                else
                {
                    float quote = (dimensionsTotal * packageWeight) / 100.00f;
                    Console.Write("Your estimated total is for shiipping this package is: " + "$" + quote +
                        "\n" + "Thank you.");
                    Console.ReadLine();
                }

            }

            /* ---This was another way I tried to execute the same code, but was getting an error after the weight was more than
             * 50lbs, because there was no instruction given to end the program...other than that the program worked.*/

            //string weightResult = packageWeight < 50 ? "What is the width of your package" : "The package is too heavy to be shipped via Package Express.\n" +
            //    "Have a nice day.";
            //Console.WriteLine(weightResult);
            //int packageWidth = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("What is the height of your package?");
            //int packageHeight = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("What is the length of your package");
            //int packageLength = Convert.ToInt32(Console.ReadLine());

            //if (dimensionsTotal > 50)
            //{
            //    Console.WriteLine("The package is too big to be shipped via Package Express");
            //}
            //else
            //{
            //    float quote = (dimensionsTotal * packageWeight) / 100f;
            //    Console.Write("Your estimated total is for shiipping this package is: " + "$" + quote +
            //        "\n" + "Thank you.");
            //}


           
        }
    }
}
