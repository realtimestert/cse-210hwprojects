using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");

        string response;

        do
        {
            Console.Write("Do you want to continue? ");
            response = Console.ReadLine();
        } while (response == "yes");

        for (int i = 2; i < 20; i = i+2)
        {
            Console.WriteLine(i);
        }

        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 11);
    }
}