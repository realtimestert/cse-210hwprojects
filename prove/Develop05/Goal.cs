using System;

public abstract class Goal
{
    public string _goalName;
    public int _goalPoints;
    public string _goalDescription;

    public int setGoalValues;

    List<string> goals = new List<string>();


    public Goal(string _goalName, int _goalPoints, string _goalDescription, int _setGoalValues)
    {

    }

        public string GetPoints(int goalPoints)
    {
        return $"You have {goalPoints} points";
    }

    public void SetGoalPoints()
    {
        int _shownGoalPoints = shownGoalPoints;
    }

    public void DisplayGoals()
    {
        foreach (string goal in goals)
        {
            Console.WriteLine(goal);
        }
        }
    }
    
}