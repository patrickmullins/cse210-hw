using System.IO;
class Journal
{
      // ccreated a list to store the date, prompt and user input to allow it to be displayed later.
    public List<Entry> Entries { get; set;} = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        Entries.Add(newEntry);
    }
    public void DisplayAll()
    {
        // created a loop to read and output to console using a public list of the date, prompttext and userjournalwritten from the Entry class. 
        foreach (Entry CurrentEntry in Entries)
        {
        Console.WriteLine($"Date: {CurrentEntry.Date} - Prompt: {CurrentEntry.PromptText}");
        Console.WriteLine($"{CurrentEntry.UserJournalWritten}");
        Console.WriteLine();
        }
    }
    public void SaveToFile(string file)
    {
        // using streamwriter class to output the date, prompt text and user input to a file for the journal program.
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (Entry CurrentEntry in Entries)
            {
                outputFile.WriteLine($"{CurrentEntry.Date}|{CurrentEntry.PromptText}|{CurrentEntry.UserJournalWritten}");
            }
        }
    }
    public void LoadFromFile(string file)
    {
        
        // added code to clear the entries when trying to load a new one so it only show the current data in the text file.
        // file.
        Entries.Clear();
        //string array to read the the entries from the text file
        string[] lines = File.ReadAllLines(file);
        foreach(string line in lines)
        {
            
            //string array logic to determine the delimiter that was previously set in the SaveToFile method.
            string[] parts = line.Split('|');
            Entry newEntry = new Entry();
            newEntry.Date = parts[0];
            newEntry.PromptText = parts[1];
            newEntry.UserJournalWritten = parts[2];
            AddEntry(newEntry);
        }
    }
}