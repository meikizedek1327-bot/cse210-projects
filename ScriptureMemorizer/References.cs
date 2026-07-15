public class Reference
{
    private string _book;
    private int _chapter;
    private List<int> _verses;

    public Reference(string book, int chapter, params int[] verses)
    {
        _book = book;
        _chapter = chapter;
        _verses = new List<int>(verses);
    }

    public string GetDisplayText()
    {
        if (_verses.Count == 0)
        {
            return $"{_book} {_chapter}";
        }

        if (_verses.Count == 1)
        {
            return $"{_book} {_chapter}:{_verses[0]}";
        }

        return $"{_book} {_chapter}:{string.Join(",", _verses)}";
    }
}
