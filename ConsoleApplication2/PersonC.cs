using System;
using System.Collections.Generic;


namespace ConsoleApplication2
{
    public class Person_C
    {

        
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
    
