abstract class SimpleGoal : Goal
{
    private bool _goalComplete;
    string _goalType = "Simple goal";

    public SimpleGoal(string _goalName, int _goalPoints, string _goalDescription, int _setGoalValues, bool goalComplete) : base(_goalName, _goalPoints, _goalDescription, _setGoalValues, goalComplete)
    {
        goalComplete = false;
    }

    public override void DisplayGoals()
    {
        if (_goalComplete)
        {
            _checkmark = "X";
        }
        Console.WriteLine($"{_checkmark} {_goalName} {_goalDescription}");
    }

    public int RecordEvents(int score)
    {
        _goalComplete = true;
        return score += _setGoalValues;
    }

    public override string stringGoal()
    {
        return $"{_goalName}: {_goalDescription} \n{_goalPoints} {_goalComplete} ";
    }
}