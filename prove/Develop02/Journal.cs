public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach (Entry record in _entries)
        {
            record.Display();
            Console.WriteLine("");
        }
    }

    public void SaveToFile(string file)
    {
        using (StreamWriter outputFile = File.AppendText(file))
        {
            foreach (Entry line in _entries)
            outputFile.WriteLine($"{line._date}~||~{line._promptText}~||~{line._entryText}");
        }
        _entries.Clear();
    }

    public void LoadFromFile(string file)
    {
        string[] lines = System.IO.File.ReadAllLines(file);

        foreach (string line in lines)
        {
            string[] parts = line.Split("~||~");

            Entry oldEntry = new Entry();
            oldEntry._date = parts[0];
            oldEntry._promptText = parts[1];
            oldEntry._entryText = parts[2];

            _entries.Add(oldEntry);
        }
    }
}