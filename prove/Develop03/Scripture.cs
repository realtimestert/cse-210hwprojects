using System;

public class Scripture
{
    private List<Word> words;
    private Reference scriptureReference;

    public Scripture (Reference _scriptureReference, string _scriptureText)
    {
        scriptureReference = _scriptureReference;
        words = new List<Word>();
        CreateWords(_scriptureText);
    }
    
    private void CreateWords(string _scriptureText)
    {

    }

    public string GetScripture()
    {
        string scriptureText = "";
        return scriptureText;
        //placeholder
    }

    public bool HasWordsLeft()
    {
        bool returnValue = false;
        foreach (Word word in words)
        {
            if (word.GetIsHidden() == false)
            {
                returnValue = true;
            }
        }
        return returnValue;
        //more placeholder
    }

    public void RemoveWords()
    {
        //placeholder
    }
}