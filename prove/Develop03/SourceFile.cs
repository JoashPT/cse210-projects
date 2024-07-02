class SourceFile
{
    private List<string> _gospelList = new List<string>();
    private string _chosenLine;

    public SourceFile(string fileName)
    {
        string[] lines = System.IO.File.ReadAllLines(fileName);

        foreach (string line in lines)
        {
            _gospelList.Add(line);
        }
    }

    public string GetLine()
    {
        Random randomNum = new Random();
        int linePick = randomNum.Next(0, _gospelList.Count - 1);
        _chosenLine = _gospelList[linePick];
        return _chosenLine;
    }
}