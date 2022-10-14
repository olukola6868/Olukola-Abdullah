using System;
using System.Collections.Generic;
namespace Challenge
{
    class Program
    {

        public static void Main(string[] args)
        {
            // Console.WriteLine("Hello, World!");
            Console.WriteLine("Enter your wrod");
            string word = Console.ReadLine();
            ConvertWord(word);
        }
        static void ConvertWord(string word)
        {
            char[]charArray = word.ToCharArray();
            int length = charArray.Length;
            for(int i = 0;i < word.Length;i++)
            {
                int count = 0;
                count ++;
                Console.WriteLine(count);
            }
        }
    }
}