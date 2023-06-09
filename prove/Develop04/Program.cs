using System;

class Program
{
    static void Main(string[] args)
    {
        static void DisplayMenu()
        {
            Console.Clear();
            Console.WriteLine("Menu Options");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");
            Console.Write("Select a choice from the menu: ");
        }

        Console.WriteLine("Welcome to the mindfulness program. There are three activities to help you start on the path of becoming more mindful. ");

        int menuUserinput = 0;

        while (menuUserinput != 4)
        {
            DisplayMenu();
            string userSelect = Console.ReadLine();
            int activity = Int16.Parse(userSelect);

            switch (activity)
            {
                //Breathing Activity
                case 1:
                    Console.Clear();
                    Breathing breathing = new Breathing(20, "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.", "Breathing Activity");
                    breathing.RunBreathing(20);
                    break;

                // Reflection Activity
                case 2:
                    Console.Clear();
                    Reflection reflection1 = new Reflection(5, "Reflection Activity", "his activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
                    reflection1.RunReflection();
                    break;

                //Listing Activity
                case 3:
                    Console.Clear();
                    Listing listing = new Listing("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", 30);
                    listing.RunListing(30);
                    break;

                case 4:
                    Console.WriteLine("Thank you for using the program. Remember to do this tomorrow.");
                    menuUserinput = 4;
                    break;

                default:
                    Console.WriteLine("Invalid input. Choose a number between 1 and 4 to continue: ");
                    Console.Clear();
                    break;
            }
        }
    }
}