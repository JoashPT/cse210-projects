public class Word
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

    public void Show()
    {
        _isHidden = false;
    }

    public bool isHidden()
    {
        return _isHidden;
    }

    public string GetDisplayText()
    {
        List<char> specialChar = new List<char>();
        specialChar.Add(':');
        specialChar.Add(';');
        specialChar.Add(',');
        specialChar.Add('.');
        specialChar.Add('-');

        if (_isHidden == true)
        {
            foreach (char letter in _text)
            {
                if (specialChar.Contains(letter))
                {
                    continue;
                }
                else
                {
                    _text = _text.Replace(letter, '_');
                }
            }
        }

        return _text;
    }
}