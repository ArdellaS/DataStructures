using System;
using System.Collections.Generic;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the MirrorVerse! | !esrseVrorriM eht ot emocleW");

            Console.Write("Please eter a word you would like to reverse: ");
            string word = Console.ReadLine();

            Stack<char> letters = new Stack<char>();

            
                foreach (var letter in word)
                {
                    letters.Push(letter);
                }

            Console.Write($"{ word} :");
            for (int i = 0; i < word.Length; i++)
            {
            Console.Write($" {letters.Pop()}");
            }

        }

        
    }

}

