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

            string choice = "";
            if (word == "easy")
            {
                List<string> lineseasy = new List<string>();
                StreamReader sr1 = new StreamReader(@" C:\Users\daone\RiderProjects\Hangman\ConsoleApplication2\easy.txt"); //relative file path
                line = sr1.ReadLine();
                lineseasy.Add(line);
                while (line != null) //loops while there are still unread lines in the textfile
                {
                    line = sr1.ReadLine(); lineseasy.Add(line); ;
                }
                sr1.Close();
                choice = lineseasy[rand.Next(lineseasy.Count)]; //generates the random word from lineseasy
            }
            else if (word == "medium") //repeated for difficulty medium
            {
                List<string> linesmedium = new List<string>();
                StreamReader sr2 = new StreamReader(@" C:\Users\daone\RiderProjects\Hangman\ConsoleApplication2\easy.txt");
                line = sr2.ReadLine();
                linesmedium.Add(line);
                while (line != null)
                {
                    line = sr2.ReadLine(); linesmedium.Add(line);
                }
                sr2.Close();
                choice = linesmedium[rand.Next(linesmedium.Count)];

            }
            else if (word == "hard") //repeated for difficulty hard
            {
                List<string> lineshard = new List<string>();
                StreamReader sr = new StreamReader(@" C:\Users\daone\RiderProjects\Hangman\ConsoleApplication2\easy.txt");
                line = sr.ReadLine();
                lineshard.Add(line);
                while (line != null) { line = sr.ReadLine(); lineshard.Add(line); }
                sr.Close();
                choice = lineshard[rand.Next(lineshard.Count)];
            }
            else //make sure there's no funny buisness (defaults to hard)
            {
                List<string> lineshard = new List<string>();
                StreamReader sr = new StreamReader(@" C:\Users\daone\RiderProjects\Hangman\ConsoleApplication2\easy.txt");
                line = sr.ReadLine();
                lineshard.Add(line);
                while (line != null)
                {
                    line = sr.ReadLine(); lineshard.Add(line);
                }
                sr.Close();
                choice = lineshard[rand.Next(lineshard.Count)];
            }

            return choice;
        }
    }
}