using System.Text;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;

        //Split the text into words
        string[] words = text.Split(' ');

        // Create Word instances for each word in the text
        foreach(string word in words)
        {
            _words.Add(new Word(word));
        }
        Console.WriteLine($"{_reference} {text}");
    }


    public void HideRandomWords(int numberToHide)
    {
        var _randomWord = new Random();
        for (int i=0; i<numberToHide; i++)
        {
            int indexToHide = _randomWord.Next(_words.Count);
            _words[indexToHide].Hide();
        }
        // int count = _words.Count;
        // numberToHide = _randomWord.Next(count);
        // // numberToHide = _randomWord.Next(Math.Min(count, _words.Count));
        // _words[numberToHide].Hide();   
    }
    
    public string GetDisplayText()
    {
        // I need to print the text and make the hidden text a variable so that I can access it based on the "numberToHide" argument
        StringBuilder displayText = new StringBuilder();

        foreach (Word word in _words)
        {
            if(word.IsHidden())
            {
                displayText.Append("_");
            }
            else
            {
                displayText.Append(word.GetDisplayText());
            }
            displayText.Append(" ");
        }
        return displayText.ToString();
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
            else
            {
                return true;
            }
            
        }
        return false;
    }
}