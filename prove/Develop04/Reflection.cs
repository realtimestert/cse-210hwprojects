using System;

public class Reflection : Activity
{
    public Reflection(int activityTime, string activityName, string activityDescription) :base(activityName, activityDescription, activityTime)
    {
        //null?
    }
        List<string> reflectionPrompts = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };
        List<string> questions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };

        public void RandomReflectionPrompt()
        {
            Random rand = new Random();
            int index = rand.Next(reflectionPrompts.Count);
            string prompt = reflectionPrompts[index];
            Console.WriteLine($"{prompt}");
        }

        public void RandomQuestion()
        {
            Random rand = new Random();
            int index = rand.Next(questions.Count);
            string question = questions[index];
            Console.WriteLine($"{question}");
        }

        public void RunReflection(int seconds)
        {
            RandomReflectionPrompt();
            DateTime startTime = DateTime.Now;
            DateTime endTime = ActivityLength();
            while (startTime < endTime)
            {
                Spinner();
                RandomQuestion();
            }
            EndingMessage();
        }
}