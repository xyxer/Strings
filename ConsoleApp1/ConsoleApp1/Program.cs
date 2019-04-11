using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Reverse string
            string str;
            string reverseString = String.Empty;
            str = Console.ReadLine();
            Console.WriteLine(str);
            char[] chars = str.ToCharArray();

            for (int i = chars.Length - 1; i > -1; i--)
                reverseString += chars[i];
            

            Console.WriteLine("\n"+reverseString);

            Console.ReadKey();
            */

            //Check if Palindrome

            string pali = String.Empty;
            string str = Console.ReadLine();
            Console.WriteLine(str);
        
            char[] chars = str.ToCharArray();

            for (int i = chars.Length - 1; i > -1; i--)
                pali += chars[i];

            if (pali == str)
                Console.WriteLine("it is a palindrome");
            else
                Console.WriteLine("it isn't a palindrome");

            Console.ReadKey();


             //Pig Latin example banana --> anana-bay

            Console.WriteLine("Enter a sentence to convert to PigLatin:");
            string sentence = Console.ReadLine();
            string pigLatin = ToPigLatin(sentence);
            Console.WriteLine(pigLatin);

            Console.ReadKey(); 



        }
        static string ToPigLatin(string sentence)
        {
            string firstLetter,
                   restOfWord,
                   vowels = "AEIOUaeio";
            int currentLetter;

            foreach (string word in sentence.Split())
            {
                firstLetter = sentence.Substring(0, 1);
                restOfWord = sentence.Substring(1, sentence.Length - 1);
                currentLetter = vowels.IndexOf(firstLetter);

                if (currentLetter == -1)
                {
                    sentence = restOfWord + firstLetter + "ay";
                }
                else
                {
                    sentence = word + "way";
                }
            }
            return sentence;
        }
        
    }
}
