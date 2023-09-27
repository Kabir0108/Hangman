using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace ConsoleApplication2
{
    internal class Datis
    {

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


    }
}

