using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the string: ");
            string str = Console.ReadLine();

            checkPalindrome(str);
            Console.ReadLine();
        }

        public static void checkPalindrome(string str)
        {
            string result= string.Empty;
            for(int i=str.Length-1; i>=0; i--)
            {
                result += str[i];
            }

            if(result == str)
            {
                Console.WriteLine("String is Palindrome");
            }
            else
            {
                Console.WriteLine("String is not Palindrome");
            }
        }
    }
}
