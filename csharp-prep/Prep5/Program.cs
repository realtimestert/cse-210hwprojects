using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();

        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        int squaredNumber = SquareNumber(userNumber);
        DisplayResult(userName, squaredNumber);

        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        }       

        static string PromptUserName()
        {
            Console.Write("What is your name? ");
            string userName = Console.ReadLine();
            return userName;
        }   

        static int PromptUserNumber()
        {
            int number = -1;
            Console.Write("What is your favorite number? ");
            number = int.Parse(Console.ReadLine());
            return number;
        }

        static int SquareNumber(int number)
        {
            int square = number*number;
            return square;
        }

        static void DisplayResult(string name, int square)
        {
            Console.WriteLine($"{name}, the square of your number is {square}");
        }
    }
}