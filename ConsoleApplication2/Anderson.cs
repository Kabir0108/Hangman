using System;

namespace ConsoleApplication2
{
    public class Anderson
    {

    }

    public class NamesGenerator
    {
        public static string[] Easy =
            { "lovely", "youthful", "yummy", "kazoo", "jiujitsu", "jaywalk", "jawbreaker", "wellspring", "xylophone" };

        public static string[] Medium =
        {
            "mystify", "mneumonic", "phlegm", "caliph", "buxom", "haphazard", "voyeurism", "zodiac", "wyvern", "jovial"
        };

        public static string[] Hard =
        {
            "naphtha", "buckaroo", "stymied", "galvanise", "pneumonia", "plasmophobia", "arachnophobia", "agoraphobia",
            "aichmophobia", "amaxophobia", "androphobia"
        };

        public static string GenerateWord(string word)
        {
            var rand = new Random();
            string choice = "";
            if (word == "easy")
            {
                choice = Easy[rand.Next(Easy.Length)];
            }
            else if (word == "medium")
            {
                choice = Medium[rand.Next(Medium.Length)];
            }
            else if (word == "hard")
            {
                choice = Hard[rand.Next(Hard.Length)];
            }

            return choice;
        }
    }
}