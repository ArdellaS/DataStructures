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

            Reverse(word);
            //Console.WriteLine(Reverse(""));

            //string word = GetString("Please enter a word you would like to revsere: ");

        }

        static string Reverse(string str)
        {
            string word = str;

            Stack<char> letters = new Stack<char>();

            while (word is string)
            {
                foreach (var letter in word)
                {
                    letters.Push(letter);
                }

            }

            return letters.ToString();
        }
    }

}

