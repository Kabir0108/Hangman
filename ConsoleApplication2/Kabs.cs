using System;
using System.Collections;
using System.Collections.Generic;

namespace ConsoleApplication2
{
    internal class Program
    {
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