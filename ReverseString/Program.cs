using System;
using System.Text;

namespace ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            bool End = true;
            do
            {
                Console.WriteLine("Please type into the console");
                string Word = Console.ReadLine();

                if (Word == "end")
                {
                    End = false;
                }
                else if (Word == "help" || Word == "h")
                {
                    Console.Write("Type in the word you want reversed. \r\nTo end the program type \"end\" into console. \r\n");
                    Console.ReadLine();
                    Console.Clear();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(Reverse(Word));
                    Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Clear();
                }
                
            } while (End);
        }

        static string Reverse(string word)
        {
            StringBuilder NewWord = new StringBuilder();
            for (int i = word.Length; i > 0; i--)
            {
                NewWord.Append(word[i - 1]);
            }
            return NewWord.ToString();
        }
    }
}
