using System.Collections.Concurrent;

public class Scripture
{
    private Reference _reference;
    private List<Word> _word = new List<Word>();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        string[] textSplit = text.Split(' ');
        foreach (string word in textSplit)
        {
            Word newWord = new Word(word);
            _word.Add(newWord);
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        List<int> visibleWordIndex = new List<int>();
        foreach (Word word in _word)
        {
            if (word.isHidden() == false)
            {
                visibleWordIndex.Add(_word.IndexOf(word));
            }
        }

        for (int i = 0; i < numberToHide; i++)
        {
            if (visibleWordIndex.Count == 0)
                break;
            Random randomNum = new Random();
            int indexPick = randomNum.Next(0, visibleWordIndex.Count - 1);
            _word[visibleWordIndex[indexPick]].Hide();
            visibleWordIndex.RemoveAt(indexPick);
        }
    }

    public string GetDisplayText()
    {
        Console.Clear();
        string gospel = "";
        foreach (Word word in _word)
        {
            gospel += $" {word.GetDisplayText()}";
        }
        return $"{_reference.GetDisplayText()} >{gospel}";
    }

    public bool IsCompletelyHIdden()
    {
        foreach (Word text in _word)
        {
            if (text.isHidden() == true)
            {
                continue;
            }
            else
            {
                return false;

            }
        }
        return true;
    }
}