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
            "mystify", "menumonic", "phlegm", "caliph", "buxom", "haphazard", "voyeurism", "zodiac", "wyvern", "jovial"
        };

        public static string[] Hard =
        {
            "naphtha", "buckaroo", "stymied", "galvanise", "pneumonia", "plasmophobia", "arachnophobia", "agoraphobia",
            "aichmophobia", "amaxophobia", "androphobia"
        };

        public static string GenerateWord(string word)
        {
            var rand = new Random();
            string randomeasywords = Easy[rand.Next(Easy.Length)];
            string randommediumwords = Medium[rand.Next(Medium.Length)];
            string randomhardwords = Hard[rand.Next(Hard.Length)];
            var choice = word;
            if (choice == "easy") ;
            {
                choice = randomeasywords;
            }
            if (choice == "medium") ;
            {
                choice = randommediumwords;
            }
            if (choice == "hard") ;
            {
                choice = randomhardwords;
            }
            return choice;
        }
    }
}