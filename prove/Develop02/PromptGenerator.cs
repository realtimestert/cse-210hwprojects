using System;
using System.IO;

class PromptGenerator
{
    public List<string> _questions;
    public PromptGenerator()
    {        
        _questions = new List<string>()
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?",
            "What am I grateful for today?",
            "What is the current problem or challenge I am facing?",
            "How can I work with others to find a solution?",
            "What activity do I love doing right now?",
            "How can I take care of my health?",
            "What inspires my creativity?",
            "What can I do to push myself this week?",
            "What is a new hobby that I would be interested in pursuing?"
        };
    }

    public string ChoosePrompt()
    {
        Random rand = new Random();
        int index = rand.Next(_questions.Count);
        return _questions[index];
    }
}

