using System;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        int randomNumber = random.Next();
        int x = randomNumber;
        int y = randomNumber;
        int z = randomNumber;
        if (x>y)
        {
            Console.WriteLine("X is greater than y");
        }
        else if (x>z)
        {
            Console.WriteLine("x is greater than z");
        }
        else
        {
            Console.WriteLine("Less than both");
        }
        Console.Write("What is your favorite number? ");
        string userInput = Console.ReadLine();
        int number = int.Parse(userInput);
        Console.WriteLine($"Your favorite number is {number}");

        Console.Write("What is your grade percentage? ");
        string grade = Console.ReadLine();
        int percent = int.Parse(grade);

        string letter = "";

        if (percent >= 90)
        {
            letter = "A";
        }
        else if (percent >= 80)
        {
            letter = "B";
        }
        else if (percent >= 70)
        {
            letter = "C";
        }
        else if (percent >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"You have a {letter}.");

        if (percent >= 70)
        {
            Console.WriteLine("You passed!");
        }
        else
        {
            Console.WriteLine("You failed.");
        }
    }
}