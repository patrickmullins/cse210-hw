using System.Numerics;

class Word
{
    private string _text;
    private bool _isHidden;
    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }
    public void Hide()
    {
        _isHidden = true;
    }
    public bool IsHidden()
    {
    return _isHidden;
    }
    
    public string GetDisplayText()
    {
        // if statement to check if the word is hidden by reading the length of the full text 
        if (_isHidden)
        {
            return new string('_', _text.Length);
        }
        else
        {
           return _text;
        }
    }
}