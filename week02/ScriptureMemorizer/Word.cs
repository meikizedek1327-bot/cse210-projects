using System.Text;

public class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    public bool IsHidden
    {
        get { return _isHidden; }
    }

    public void Hide()
    {
        _isHidden = true;
    }

    public string GetDisplayText()
    {
        if (!_isHidden)
        {
            return _text;
        }

        StringBuilder display = new StringBuilder();
        foreach (char character in _text)
        {
            if (char.IsLetter(character))
            {
                display.Append('_');
            }
            else
            {
                display.Append(character);
            }
        }

        return display.ToString();
    }
}
