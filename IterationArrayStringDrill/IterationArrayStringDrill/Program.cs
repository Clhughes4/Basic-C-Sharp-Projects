using System;
using System.Collections.Generic;
using System.Linq;



class Program
{
    static void Main(string[] args)

    {
        string[] names = { "Clint", "Aly", "Gabe", "Lilly", "Jaxson", "Dex" };

        Console.WriteLine("Type in some text.");
        string text = Console.ReadLine();

        while ("Clint" == "Clint")
        {
            Console.WriteLine("Clint");
            break;
        }
        Console.WriteLine("\n");
        for (int a = 0; a < names.Length; a++)
        {
            Console.WriteLine(names[a]+ ' ' + text);
            
        }
        Console.WriteLine("\n");
        for (int a = 0; a < names.Length; a++)
        {
            Console.WriteLine(names[a]);
        }
        Console.WriteLine("\n");
        for (int a = 0; a <= names.Length-1; a++)
        {
            Console.WriteLine(names[a]);
        }
        Console.ReadLine();



        List<string> fruits = new List<string>() { "apple", "banana", "coconut", "dragon fruit", "elderberry" };
        Console.WriteLine("Choose an item from the list:\n" );
        for (int f = 0; f <fruits.Count; f++)
        {
            Console.WriteLine(fruits[f]);
        }
        string input = Console.ReadLine();

        foreach (string fruit in fruits)
        {
            if (fruit == input)
            {
                Console.WriteLine(fruit + " = " + fruits.IndexOf(fruit)); // use the IndexOf method to display the index of the user input
                break;
            }
            else if (input != fruit)
            {
                Console.WriteLine("Please choose a valid fruit from the list");
            }
        }
        
        Console.ReadLine();

        List<string> animals = new List<string>() { "cheetah", "lion", "cheetah", "hiena", "leapord" };
        Console.WriteLine("Select an item from the list:\n");
        for (int i = 0; i < animals.Count; i++)
        {
            Console.WriteLine($"{animals[i]}");
        }
        Console.WriteLine("\n");
        string animalChosen = Console.ReadLine();       
        int j = 0;      // This method is used to used to utilize the index within the foreach loop
        foreach (string animal in animals)
        {
            if (animal == animalChosen)
            {
                Console.WriteLine("Your search term was found at index: " + j);
            }
            j++;    // The incrementing needs to happen at the end of the loop
            //else { }
            //Console.WriteLine();
        }
        Console.WriteLine("\n");


        Console.WriteLine("\n");
        List<string> flavors = new List<string>() { "sweet", "salty", "bitter", "sweet", "sour" };
        List<string> newList = new List<string>();

        foreach (string flavor in flavors)
        {
            if (newList.Contains(flavor))
            {
                Console.WriteLine(" --" + flavor + "-- Has already occured. \n");   // This stating if the value of the index has occured alreday
            }
            else
            {
                Console.WriteLine(flavor + " Has not yet occured. \n");     // If the value of the index has occured then it will print the message next to each index
                newList.Add(flavor);        // This will add the indexs if they havent occured and print them to the list

            }
        }
        Console.ReadLine();

    }
}

