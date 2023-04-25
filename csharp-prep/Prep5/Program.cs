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

        static string PromtUserName()
        {
            Console.Write("What is your name? ");
            string userName = Console.ReadLine();
            Console.WriteLine($"Hello {userName}");
            return userName;
        }
        PromtUserName();

        static int PromptUserNumber()
        {
            int number = -1;
            Console.Write("What is your favorite number? ");
            number = int.Parse(Console.ReadLine());
            Console.WriteLine($"Your favorite number is {number}");
            return number;
        }
        PromptUserNumber();

        
        
    }
}