using System.IO;
using System;

class Program
{
    static void Main(string[] args)
    {

        bool loop = true;
        while (loop == true)
        {
            Console.WriteLine("Please choose one of the following choices: ");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.WriteLine("What would you like to do? ");

            string userinput = Console.ReadLine() ?? "";





            if (userinput == "1")
            {
                Entry entry = new Entry();
                entry.Add();
            }
            else if (userinput == "2")
            {
                Console.WriteLine("You have selected number 2");
            }
            else if (userinput == "3")
            {
                Console.WriteLine("You have selected number 3");
            }
            else if (userinput == "4")
            {
                Console.WriteLine("You have selected number 4");
            }
            else
            {
                loop = false;
            }
        }
    }







    class Journal

    {
        public void Save(string fileName)
        {

            using (StreamWriter outputFile = new StreamWriter(fileName))
            {
                // You can add text to the file with the WriteLine method
                outputFile.WriteLine("This will be the first line in the file.");


            }
        }

        public void Load(string fileName)
        {

            string[] lines = System.IO.File.ReadAllLines(fileName);

            foreach (string line in lines)
            {
                string[] parts = line.Split(",");

                string firstName = parts[0];
                string lastName = parts[1];
            }
        }
        public void Display()
        {
            DateTime theCurrentTime = DateTime.Now;
            Console.ReadLine();


        }

    }
}