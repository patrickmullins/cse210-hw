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

}