using System;

class Program
{
    static void Main(string[] args)
    {
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        }
        DisplayWelcome();

        static void PromtUserName()
        {
            Console.Write("What is your name? ");
            string userName = Console.ReadLine();
        }
        PromtUserName();
    }
}