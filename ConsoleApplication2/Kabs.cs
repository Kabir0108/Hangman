using System;
using System.Collections;
using System.Collections.Generic;

namespace Hangman_personal
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string gLettersTemp = "fit";
            string guessWord = "cyclotron";
            Console.WriteLine(updateString(word: guessWord, gLetters: gLettersTemp));
        }

        public static string updateString(string word, string gLetters)
        {
            string upWord = "";
            for (int i = 0; i < word.Length; i++)
            {
                for (int j = 0; j < gLetters.Length; j++)
                {
                    if (word[i] == gLetters[j])
                    {
                        upWord = upWord + gLetters[j];
                        break;
                    }
                    else
                    {

                        if (j == gLetters.Length -1)
                        {
                            upWord = upWord + "_";
                            break;

                        }
                    }
                }
            }
            return upWord;
        }
    }   
}