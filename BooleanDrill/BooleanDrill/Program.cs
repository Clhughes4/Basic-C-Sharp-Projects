using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanDrill
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose a number?");
            int number = Convert.ToInt32(Console.ReadLine());
            bool numberLarger = false;

            do
            {
                switch (number)
                {
                    case 34:
                        Console.WriteLine("Your number is smaller...");
                        Console.WriteLine("Guess again");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 67:
                        Console.WriteLine("Still smaller...");
                        Console.WriteLine("Guess again");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 112:
                        Console.WriteLine("You are really hot...");
                        Console.WriteLine("Guess again");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 152:
                        Console.WriteLine("Your number is larger than 125, congratulations!");
                        numberLarger = true;
                        Console.ReadLine();

                        Console.WriteLine("Guess an animal in the jungle who can climb trees, but spends a lot of time on the ground?");
                        string animal = Console.ReadLine();
                        bool animalGuessed = false;


                        while (animalGuessed == false)
                        {
                            switch (animal)
                            {


                                case "ocelot":
                                    Console.WriteLine("Your guess is close with Ocelot, but think bigger!");
                                    break;

                                case "monkey":
                                    Console.WriteLine("You guesed monkey...colder");
                                    break;

                                case "snake":
                                    Console.WriteLine("This animal has legs...");
                                    break;

                                case "jaguar":
                                    Console.WriteLine("That is the correct animal, awesome job!");
                                    animalGuessed = true;
                                    break;

                                default:
                                    Console.WriteLine("Not even close, try again.");
                                    break;

                            }
                            if (animal != "jaguar")
                            {
                                Console.WriteLine("Guess again...");
                                animal = Console.ReadLine();
                            }
                        }
                        Console.ReadLine();
                        //Console.WriteLine("Now guess an animal in the jungle.");
                        break;
                    default:
                        Console.WriteLine("Guess again");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;

                }

            }
            while (numberLarger == false);
            
           
        }
    }
}
