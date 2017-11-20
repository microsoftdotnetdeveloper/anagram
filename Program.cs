using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrincipile
{
    class Program
    {
        static void Anagram()
        {
            Console.WriteLine("Enter Word 1");
            string word1 = Console.ReadLine();
            Console.WriteLine("Enter Word 2");
            string word2 = Console.ReadLine();
            char[] char1 = word1.ToCharArray();
            char[] char2 = word2.ToCharArray();
            Array.Sort(char1);
            Array.Sort(char2);
            string newword1 = new string(char1);
            string newword2 = new string(char2);
            Console.WriteLine(newword1 + "" + newword2);
        }
        static void Main(string[] args)
        {
            Anagram();
            Console.Read();
        }
    }
}
