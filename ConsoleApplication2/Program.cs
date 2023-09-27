using System;
using ConsoleApplication2;

namespace Hangman
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello");
            string input = Console.ReadLine();
            string chosenumber = NamesGenerator.GenerateWord(input);
            Console.WriteLine(chosenumber);
        }
    }
}