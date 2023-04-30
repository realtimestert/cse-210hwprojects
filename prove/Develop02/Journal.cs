class Journal
{
    public List<Entry> Entries;
    public PromptGenerator PromptGenerator;
    public Journal(PromptGenerator promptGenerator)
    {
        Entries = new List<Entry>();
        PromptGenerator = promptGenerator;
    }
}