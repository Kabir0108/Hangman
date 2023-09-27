using System;

namespace ConsoleApplication2
{
    public class Person_C
    {
        char guessed_letter = Convert.ToChar(Console.ReadLine());
        
        Console.WriteLine(CheckLetter(secret_letter, guessed_letter));
        /* if (guessed_letter.Length == 1)
          {
              string guess = guessed_letter;
          }
          else
          {
              Console.WriteLine("That is an invalid input. Please make sure you type a single letter: ");
              guessed_letter = Console.ReadLine();
          }
          Console.WriteLine("You have guessed the letter " + guessed_letter);*/
    }
    public static List<int> CheckLetter(string secret_word, char guessed_letter )
    {
        List<int> instances = new List<int>();
        for (int i = 0; i<secret_word.Length; i++)
        {
            if (secret_word[i] == guessed_letter)
            {
                instances.Add(i);
            }
        }
        return instances;
    } 
}
    
