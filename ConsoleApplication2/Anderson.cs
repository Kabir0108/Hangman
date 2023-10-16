using System;
using System.Collections.Generic;
using System.IO;

namespace ConsoleApplication2
{
    public class Anderson
    {

    }

    public class NamesGenerator
    {

        public static string GenerateWord(string word)
        {
            var rand = new Random();
            string line;

            List<string> lines = new List<string>();

            if((word != "easy") && (word != "medium") && (word != "hard")){
                word = "hard"; //make sure there's no funny business (defaults to hard)
            }

            string choice = "";
            
            StreamReader sr = new StreamReader("..\\..\\" + word + ".txt"); //relative file path
            line = sr.ReadLine();
            lines.Add(line);
            while (line != null) { line = sr.ReadLine(); lines.Add(line); }
            sr.Close();
            choice = lines[rand.Next(lines.Count)]; //generates the random word from lines


            return choice;
        }
    }
}