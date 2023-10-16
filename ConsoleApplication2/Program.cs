using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using ConsoleApplication2;

namespace Hangman
{
    internal class Program
    {
        public static void Main(string[] args)
        {

            var rands = new Random();

            int i = rands.Next(10);

            ConsoleColor[] colors = (ConsoleColor[])ConsoleColor.GetValues(typeof(ConsoleColor));


            Console.ForegroundColor = colors[i];


            int guesses = 0;
            Console.WriteLine("What difficulty? easy/medium/hard - case sensitive (or else defaults to hard mode)");
            string chosenword = NamesGenerator.GenerateWord(Console.ReadLine());

            List<char> guessedLetterses;

            
            guessedLetterses = new List<char>();
            
            string yuhuh = chosenword;
            string word = "";
            
         

            while (guesses <= 9)
            {

                Console.WriteLine("Letter: 1 letter");

                i = rands.Next(10);

                Console.ForegroundColor = colors[i];

                char guessed_letter = ' ';

                try { 
                    guessed_letter = Convert.ToChar(Console.ReadLine());
                }
                catch(Exception e)
                {
                    Console.WriteLine("not a letter");
                    return;
                }

                Console.WriteLine("\n\n\n\n");

                guessedLetterses.Add(Convert.ToChar(guessed_letter));
                
                List<string> vals = updateString(chosenword, guessedLetterses, guessed_letter);

                Console.WriteLine(vals[0]);


                if (vals[0] == chosenword)
                {
                    WinCondition();
                    Console.ReadLine();
                    return;
                }


                Console.WriteLine(word);

                yuhuh = word;

                if (vals[1] == "0")
                {
                    guesses++;
                }
                
                Console.WriteLine(Gallows(guesses));
                Console.WriteLine("\n\n\n\n");

                guessedLetterses.Add( Convert.ToChar(guessed_letter));
            }
            LoseCondition();
            Console.ReadLine();
            return;
        }

   

        public static List<string> updateString(string word, List<char> gLetters, char news)
        {
            string upWord = "";
            string found = "0";
            for (int i = 0; i < word.Length; i++)
            {
                for (int j = 0; j < gLetters.Count; j++)
                {
                    if (word[i] == gLetters[j])
                    {
                        upWord = upWord + gLetters[j];
                        if (news == gLetters[j])
	                    {
                            found = "1";
	                    }
                    
                        break;
                    }
                    else
                    {

                        if (j == gLetters.Count - 1)
                        {
                            upWord = upWord + "_";
                            break;

                        }
                    }
                }
            }
            return new List<string> { upWord, found };
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
    
        public static void WinCondition()
        {
            Console.Clear(); 
            Console.WriteLine("YOU WON!! CONGRATS");
        }

        public static void LoseCondition()
        {
            Console.Clear();
            Console.WriteLine("You lost!! I hope you remember this on your deathbed.");
        }
    }
}