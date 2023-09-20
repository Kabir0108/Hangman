using System;
using ConsoleApplication2;

namespace Hangman
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("What difficulty would you want: easy, medium or hard?");
            string input = Console.ReadLine();
            var chosenword = NamesGenerator.GenerateWord(input);
            Console.WriteLine(chosenword);
        }
    }
}