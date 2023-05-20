using System;

partial class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Goal Setting Program!");

        int menuUserInput = 0;

        //Goal.GetPoints();

    List<string> menu = new List<string>()
    {
        "Select one of the numbers listed below",
        "1. Create a new goal",
        "2. Show goals",
        "3. Save goals",
        "4. Load goals",
        "5. Record events that lead to goal progress",
        "6. Delete goal from list",
        "7. Exit",
        "Please choose an option"
    };

    while (menuUserInput != 6)
    {
        foreach (string menuItem in menu)
        {
            Console.WriteLine(menuItem);
        }

        try
        {
            menuUserInput = Convert.ToInt32(Console.ReadLine());
        }
        catch(FormatException)
        {
            Console.WriteLine("Please select a number from the list.");
            continue;
        }

        switch (menuUserInput)
        {
            case 1:
                Goal.SetGoalValues();
                break;

            case 2:
                Goal.DisplayGoals();
                break;

            case 3:
                Goal.SaveGoals();
                break;

            case 4:
                Goal.LoadGoals();
                break;

            case 5:
                Goal.RecordEvents();
                break;

            case 6:
                Goal.DeleteGoal();
                break;

            case 7:
                Console.WriteLine("Goodbye");
                break;

            default:
                Console.WriteLine("Please enter a number between 1 and 7.");
                break;
        }
    }
    }
}