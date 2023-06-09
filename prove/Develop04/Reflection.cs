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

        public void disPlayDescription()
        {
            Console.WriteLine("This activity is meant ot have you reflect on the good things you have done in the world. ");

        }
        public string SelectPrompt()
        {
            Random randomGenerator = new Random();
            int promptIndex = randomGenerator.Next(1,reflectionPrompts.Count);
            string selectedPrompt = reflectionPrompts[promptIndex];
            return selectedPrompt;
        }
        public void RunReflection()
        {
            Console.WriteLine("Here is a prompt for your consideration. \n");
            Console.WriteLine(SelectPrompt());
            Console.WriteLine("When you are ready, press enter to continue.");
            Console.ReadLine();
            Console.WriteLine("Now is the time for reflection: ");
            
            
            for (int i = 0; i <= 3; i++)
            {
                Console.Write($"You may begin in: {i}");
                Thread.Sleep(1000);
                Console.Write("\b\b\b\b\b\b\b\b\b\b\b\b");
                Console.Clear();
            }

            Console.WriteLine();
            DateTime startTime = DateTime.Now;
            DateTime futureTime = startTime.AddSeconds(activityTime);
            DateTime currentTime = DateTime.Now;
            int counter = 0;

            //make a new method here to have the user type in a response in 30 seconds

            while (currentTime < futureTime)
            {
                Console.Write("*");
                Console.ReadLine();
                currentTime = DateTime.Now;
                counter +=1;
            }

            Console.Clear();
            int questionDuration = activityTime/2;
            EndingMessage();
        }
}