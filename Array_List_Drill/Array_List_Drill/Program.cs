using System;
using System.Collections.Generic;
using System.Linq;


class Program
{
    static void Main()
    {
        string[] stringArray = { "Christmas", "is", "the", "most", "wonderful", "time", "of", "the", "year" };


        for (int i = 0; i < stringArray.Length; i++) //Go through the whole array
        {
            Console.WriteLine($"{i} = {stringArray[i]}");
            //Console.WriteLine(stringArray[i] + " = " + i); // Output the string and the index
        }

        bookMark:               // Created a book mark 
        Console.WriteLine();
        Console.WriteLine("Type an index of 0-8 next to the word.\n");
        int userSelect = Convert.ToInt32(Console.ReadLine());

        if (userSelect > 8 || userSelect < 0)
        {
            Console.WriteLine("Please choose a valid index of 0-8");
            goto bookMark;          // Instead of terminating the program if the user selects an index out of the array, than it will go back to the book mark
        }
        else
            Console.WriteLine("You chose: " + stringArray[userSelect] + "\n");

        

        int[] numArray = { 234, 25, 846, 30, 7879, 18, 616 };

        for (int n = 0; n < numArray.Length; n++)
        {        //Console.WriteLine("You chose: " + stringArray[userSelect] + "\n");    // User selection is the index which is chosen
            Console.WriteLine($"{n} = {numArray[n]}");
        }

        bookMark2:
        Console.WriteLine();
        Console.WriteLine("Choose an index 0-6 next to the number\n");
        int userSelect2 = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine("You chose: " + numArray[userSelect2] + "\n");
        if (userSelect2 > 6 || userSelect2 < 0)
        {
            Console.WriteLine("Please choose a valid index of 0-6");
            goto bookMark2;
        }
        else
            Console.WriteLine("You chose: " + numArray[userSelect2] + "\n");


        List<string> listString = new List<string>() { "I", "have", "four", "chidren" };

        for (int l = 0; l < listString.Count; l++)
        {
            Console.WriteLine($"{l} = {listString[l]}");
        }

        bookMark3:
        Console.WriteLine();
        Console.WriteLine("Choose an index of 0-3 next to the word\n");
        int userSelect3 = Convert.ToInt32(Console.ReadLine());
        if (userSelect3 > 3 || userSelect3 < 0)
        {
            Console.WriteLine("Please choose a valid index of 0-3");
            goto bookMark3;
        }
        else
            Console.WriteLine("You chose: " + listString[userSelect3] + "\n");






    }
}

