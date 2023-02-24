using System;

class Program
{
    static void Main(string[] args)
    {
        Reference _ref = new Reference("John", 11, 35);
        Scripture scripture = new Scripture(_ref, "Jesus Wept.");
        Reference _ref2 = new Reference("1 Nephi", 2, 15);
        Scripture scripture1 = new Scripture(_ref2, "And my father dwelt in a tent.");
        Reference _ref3 = new Reference("John", 3, 16);
        Scripture scripture2 = new Scripture(_ref3, "For God so loved the world, that he game his only begotten son, that whosever believeth in him should not perish, but have everlasting life.");
        Reference _ref4 = new Reference("Matthew", 5, 3);
        Scripture scripture3 = new Scripture(_ref4, "Blessed are the poor in spirit: for theirs is the kingdom of heaven.");
        Reference _ref5 = new Reference("Proverbs", 3, 5 - 6);
        Scripture scripture4 = new Scripture(_ref5, "Trust in the Lord with all thine heart; and lean not unto thine own understanding,\n In all thy ways acknowledge him, and he sall direct thy paths.\n");

        while (true)
        {
            Console.Write("Enter a command (or 'quit' to exit): ");
            string input = Console.ReadLine();

            if (input == "quit")
            {
                break;
            }

            // Handle the input command here
        }
    }


}