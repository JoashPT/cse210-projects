public class Reference
{
    private string _book;
    private int _chapter;
    private int _startverse;
    private int _endVerse;
    private string _gospel;

    public Reference(string gospelLine)
    {
        string[] parts = gospelLine.Split("~||~");

        _book = parts[0];
        _chapter = int.Parse(parts[1]);
        string verses = parts[2];
        string[] verseSplit = verses.Split("#^#");
        _startverse = int.Parse(verseSplit[0]);
        _endVerse = int.Parse(verseSplit[1]);
        _gospel = parts[3];
        
    }

    public string GetDisplayText()
    {
        if (_endVerse == 0)
        {
            return $"{_book} {_chapter}:{_startverse}";
        }
        else
        {
        return $"{_book} {_chapter}:{_startverse}-{_endVerse}";
        }
    }

    public string GetGospel()
    {
        return _gospel;
    }

    public string GetOriginalText()
    {
        if (_endVerse == 0)
        {
            return $"{_book} {_chapter}:{_startverse}\n{_gospel}";
        }
        else
        {
        return $"{_book} {_chapter}:{_startverse}-{_endVerse}\n{_gospel}";
        }
    }
}