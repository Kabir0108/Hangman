using System;
using System.Collections.Generic;
using ConsoleApplication2;

namespace Hangman
{
    internal class Program
    {
        public static void Main(string[] args)
        {

            string chosenumber = NamesGenerator.GenerateWord("easy");

            Console.WriteLine(chosenumber);


            char guessed_letter = Convert.ToChar(Console.ReadLine());

            List<int> addresses = CheckLetter(chosenumber, guessed_letter);

            for (int i = 0;i < addresses.Count; i++)
            {
                Console.WriteLine(addresses[i]);
            }
            Console.ReadLine();


        }

        public static string Gallows(int guesses)
        {
            switch (guesses)
            {
                case 0:
                    return "";
                case 1:
                    return @"______";
                case 2:
                    return @"   

  |     
  |      
  |      
  |       
  |      
  |
__|_______";
                case 3:
                    return @"   
    
  |/       
  |      
  |      
  |       
  |     
  |
__|_______";
                case 4:
                    return @"   
  __________
  |/     
  |      
  |      
  |       
  |       
  |
__|_______";
                case 5:
                    return @"   
  __________
  |/       |
  |      
  |      
  |       
  |       
  |
__|_______";
                case 6:
                    return @"   
  __________
  |/       |
  |        O
  |        
  |       
  |       
  |
__|_______";
                case 7:
                    return @"   
  __________
  |/       |
  |        O
  |        |
  |        |
  |       
  |
__|_______";
                case 8:
                    return @"   
  __________
  |/       |
  |        O
  |      \ | /
  |        |
  |       
  |
__|_______";
                case 9:
                    return @"   
  __________
  |/       |
  |        O
  |      \ | /
  |        |
  |       / \
  |
__|_______";
                default:
                    return "";

            }

        }

        public static void Display(string guessed_letters, string unveiled_word, string gallow)
        {
            Console.Clear();
            Console.WriteLine(gallow);
            Console.WriteLine("\n\n" + unveiled_word);
            Console.WriteLine("\n\nThe guessed letters so far, are: " + guessed_letters);
        }

        public static List<int> CheckLetter(string secret_word, char guessed_letter)
        {
            List<int> instances = new List<int>();
            for (int i = 0; i < secret_word.Length; i++)
            {
                if (secret_word[i] == guessed_letter)
                {
                    instances.Add(i);
                }
            }
            return instances;
        }
    }
}