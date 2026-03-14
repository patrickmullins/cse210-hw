class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();
    

    // created scripture class to store reference and text strings.
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        // takes the text of the scripture and puts it into an array
        string[] splitText = text.Split(' ');
        //loop to read the words in the array and put it into a string list.
        foreach(string line in splitText)
        {
           _words.Add(new Word(line));             
        }
    }
    public string GetDisplayText()
    {
        
        string scriptureText = "";
        // created loop to get the words within the list to display later
        foreach(Word currentWord in _words)
        {
        scriptureText += currentWord.GetDisplayText() + " ";
        }
        return $"{_reference.GetDisplayText()} {scriptureText}";
    }
    public void HideRandomWords(int numberHidden)
    {
        Random rnd = new Random();
        for (int i = 0; i < numberHidden; i++)
        {
            List<Word> unhiddenWords = _words.Where(w => w.IsHidden() == false).ToList();
            if (unhiddenWords.Count == 0)
            {
                break;
            }
            int randomIndex = rnd.Next(unhiddenWords.Count);
            unhiddenWords[randomIndex].Hide();
        }
    }
    public bool IsCompletelyHidden()
    {
        return _words.All(w => w.IsHidden());
    }
}