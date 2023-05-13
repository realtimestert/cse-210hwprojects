using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop04 World!");
        Console.WriteLine("Wellness program.");

        int menuUserinput = 0;

        List<string> menu = new List<string>
        {
            "Please choose one of the activities below. Press 4 to quit: ",
            "1. Breathing Activity",
            "2. Reflection Activity",
            "3. Listing Activity",
            "4. Quit"
        };

        while (menuUserinput != 4)
        {
            switch (menuUserinput)
            {
                case 1:
                    Breathing.RunBreathing();
                    break;

                case 2:
                    Reflection.RunReflection();
                    break;

                case 3:
                    Listing.RunListing();
                    break;

                case 4:
                    Console.WriteLine("Thank you for using the program. Remember to do this tomorrow.");
                    break;

                default:
                    Console.WriteLine("Invalid input. Choose a number between 1 and 4 to continue: ");
                    break;
            }
        }
    }
}