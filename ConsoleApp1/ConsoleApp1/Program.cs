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





        }
    }
}
