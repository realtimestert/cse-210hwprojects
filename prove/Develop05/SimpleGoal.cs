using System;

abstract class SimpleGoal : Goal
{
    private bool _goalComplete;

    public SimpleGoal(string _goalName, int _goalPoints, string _goalDescription, int _setGoalValues, bool goalComplete) : base(_goalName, _goalPoints, _goalDescription, _setGoalValues)
    {
        goalComplete = false;
    }

    //Pass the information along
    //public SimpleGoal(string)
}