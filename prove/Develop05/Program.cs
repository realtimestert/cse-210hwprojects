using System;
using System.IO;

class Program
{
    public static List<Goal> GoalList = new List<Goal>();
    public static int score = 0;
    public static string filname;
    static void Main(string[] args)
    {
        int menuUserInput = 0;
        Console.WriteLine($"You have {points} points.");
        Goal.GetPoints();

        List<string> menu = new List<string>()
        {
            "Menu Options",
            "1. Create new goal",
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
                Console.Write("Please select a number from the list.");
                continue;
            }

            switch (menuUserInput)
            {
                int typeofGoals = 0;
                List<string> menu2 = new List<string>;
                case 1:
                    Console.WriteLine("Select a choice from the menu:");
                    Console.Write("The types of Goals are: ");
                    typeofGoals = Console.ReadLine();
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