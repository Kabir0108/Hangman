using System;

namespace ConsoleApplication2
{
    public class Anderson
    {
        
    }
    public class NamesGenerator
    {
        public static string[] Easy = { "John", "George", "Ethan", "Mclaren", "Ringo", "Paul" };

        public static string[] Medium =
            { "Liang", "Wong", "Tsang", "Chen", "Harjabrada", "Garlack the Anihallator" };

        public static string[] Hard = {"reyhani"};

        public static string GenerateWord(string word)
        {
            var rand = new Random();
            string randomeasywords = Easy[rand.Next(Easy.Length)];
            string randommediumwords = Medium[rand.Next(Medium.Length)];
            string randomhardwords = Hard[rand.Next(Hard.Length)];
            var choice = word;
            if (choice == "easy");
            {
                choice = randomeasywords;
            }
            if (choice == "medium");
            {
                choice = randommediumwords;
            }
            if (choice == "hard");
            {
                choice = randomhardwords;
            }
            return choice;
        }
    }
}
Console.WriteLine("Hello");
string input = Console.ReadLine();
string chosenumber = NamesGenerator.GenerateWord(input);
Console.WriteLine(chosenumber);