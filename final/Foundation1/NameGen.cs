using System;
using System.IO;

public class NameGen
{
    public List<string> _names;
    public NameGen()
    {
        _names = new List<string>()
        {
            "klackerz",
            "Terastal1008",
            "diseasedrat8813",
            "bingewatcher92000",
            "MST3K",
            "therealBigfoot",
            "Sasquatch12",
            "omicronperseii8",
            "inferno52",
            "CarmenSandiegoNDakota",
            "realtimestu"
        };
    }

    public string ChooseName()
    {
        Random rand = new Random();
        int index = rand.Next(_names.Count);
        return _names[index];
    }
}