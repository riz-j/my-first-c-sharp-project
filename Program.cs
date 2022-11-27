// See https://aka.ms/new-console-template for more information
using System;

namespace HelloWorld
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Hello! What's your name?");
            string input = Console.ReadLine();
            Console.WriteLine($"Your name is {input}");
        }
    }
}