using System;

public abstract class Goal
{
    public string _goalName;
    public int _goalPoints;
    public string _goalDescription;

    public int _setGoalValues;

    List<string> goals = new List<string>();

    public Goal(string _goalName, int _goalPoints, string _goalDescription, int _setGoalValues)
    {
        //_goalName = goalName;
        //_goalPoints = goalPoints;
        //_goalDescription = goalDescription;
        //_setGoalValues = setGoalValues;
    }
    public string GetPoints(int goalPoints)
    {
        return $"You have {goalPoints} points";
    }

    public void SetGoalPoints()
    {
        int shownGoalPoints = _shownGoalPoints;
    }

    public void DisplayGoals()
    {
        foreach (string goal in goals)
        {
            Console.WriteLine(goal);
        }
    }

    public int SaveGoals()
    {
        return 1;
    }    
}