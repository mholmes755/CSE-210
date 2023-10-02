using System.Text;

public class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
    }

    public void Hide()
    {
        _isHidden = true;
    
        StringBuilder stringBuilder = new StringBuilder(_text);
        for (int i = 0; i < stringBuilder.Length; i++)
        {
            if (stringBuilder[i] != ' ')
            {
                stringBuilder[i] = '_';
            }
        }
        _text = stringBuilder.ToString();
            }
                     

    public void Show()
    {
        
    }

    public bool IsHidden()
    {
        return true;
    }

    public string GetDisplayText()
    {
        if (_isHidden)
        {
            return "_";
        }
        else
        {
            return _text;
        }
    }
}