using System;

class Entry
{
    public string Prompt {get; set; }
    public string Response {get; set; }
    public DateTime Date {get; set; }

    public Entry(string response, DateTime date)
    {
        //Prompt = prompt;
        Response = response;
        Date = date;
    }

    public void DisplayEntry()
    {
        Console.WriteLine($"{Date}: {Prompt}\n{Response}");
    }

    public string GetEntryAsCsv()
    {
        return $"{Date}|{Prompt}|{Response}";
    }
}