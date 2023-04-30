using System;

class Entry
{
    public string Prompt;
    public string Response;  
    private string Date;
    public Entry(string _date, string _prompt, string _response)
    {
        this.Prompt = _prompt;
        this.Response = _response;
        Date = _date;
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