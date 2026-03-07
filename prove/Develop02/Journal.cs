class Journal
{
      
    public List<Entry> Entries { get; set;} = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        Entries.Add(newEntry);
    }
    public void DisplayAll()
    {
        foreach (Entry CurrentEntry in Entries)
        {
        Console.WriteLine($"Date:  {CurrentEntry.Date} - Prompt: {CurrentEntry.PromptText}");
        Console.WriteLine($"{CurrentEntry.UserJournalWritten}");
        Console.WriteLine();
        }
    }

}