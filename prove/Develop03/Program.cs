using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create a new scripture object
        Scripture scripture = new Scripture("Proverbs 3:5-6", "Trust in the Lord with all your heart and lean not on your own understanding; in all your ways submit to him, and he will make your paths straight.");

        // Clear the console screen and display the complete scripture
        Console.Clear();
        scripture.Display();

        // Prompt the user to press the enter key or type quit
        Console.WriteLine("Press Enter to hide a word or type 'quit' to end the program.");
        string input = Console.ReadLine();

        // Hide random words until all words are hidden or the user types 'quit'
        while (input != "quit" && scripture.HideRandomWord())
        {
            // Clear the console screen and display the scripture again
            Console.Clear();
            scripture.Display();

            // Prompt the user to press the enter key or type quit
            Console.WriteLine("Press Enter to hide another word or type 'quit' to end the program.");
            input = Console.ReadLine();
        }
    }
}


