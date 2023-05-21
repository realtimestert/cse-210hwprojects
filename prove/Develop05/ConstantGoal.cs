using System;

abstract class ConstantGoal : Goal
{
    public ConstantGoal(string _goalName, string _goalDescription, int _shownGoalPoints, int _pointTracker) : base(_goalName, _goalDescription, _shownGoalPoints, _pointTracker)
    {
        
    }
}