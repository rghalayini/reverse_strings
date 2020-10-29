using System;
using System.Dynamic;
using System.Collections.Generic;

namespace Stacks_reverse_string
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert a string or a small sentence:");
            string input = Convert.ToString(Console.ReadLine());
            string[] inputSplit = input.Split(" ");
            
            Stack<string> StackedWord = new Stack<string>();


            foreach (var item in inputSplit)
            {
                StackedWord.Push(item);
            }

            Console.WriteLine();
            Console.WriteLine("Current Stack:");
            foreach (string item in StackedWord)
            {
                Console.Write(item +" ");
            }

            Console.WriteLine();

            Console.WriteLine();
            Console.WriteLine("reversed stack");

            char[] wordArray;

            Stack<string> reversed = new Stack<string>(StackedWord.ToArray());
            
            foreach (string item in StackedWord)
            {
                wordArray = item.ToCharArray();
                Array.Reverse(wordArray);
                Console.Write(wordArray);
                Console.Write(" ");
            }
            Console.ReadLine();
        }
    }
}
