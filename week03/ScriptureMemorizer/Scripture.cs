public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        string[] textWords = text.Split(' ');
        foreach (string item in textWords)
        {
            _words.Add(new Word(item));
        }
    }

    public string GetDisplayText()
    {
        List<string> displayWords = new List<string>();
        foreach (Word word in _words)
        {
            displayWords.Add(word.GetDisplayText());
        }

        return $"{_reference.GetDisplayText()}\n{string.Join(" ", displayWords)}";
    }

    public bool HideNextWord()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden)
            {
                word.Hide();
                return true;
            }
        }

        return false;
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden)
            {
                return false;
            }
        }

        return true;
    }

    public string GetProgress()
    {
        int totalWords = _words.Count;
        int hiddenWords = 0;

        foreach (Word word in _words)
        {
            if (word.IsHidden)
            {
                hiddenWords++;
            }
        }

        int percent = totalWords == 0 ? 100 : (hiddenWords * 100) / totalWords;
        return $"{hiddenWords}/{totalWords} words hidden ({percent}%)";
    }
}
