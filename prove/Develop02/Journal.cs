using System.Collections.Generic;

public class Journal
{
    private List<Entry> _entries = new List<Entry>();
    
    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void ChangeEntry(int entryNum)
    {
        int index = entryNum - 1;
        _entries[index].Display();
        Console.WriteLine("Enter new response");
        _entries[index]._response = Console.ReadLine();
    }

    public void SaveToFile(string fileName)
    {
        Console.WriteLine("Saving journal...");
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (Entry savedEntry in _entries)
            {
                outputFile.WriteLine($"{savedEntry._date}~|{savedEntry._prompt}~|{savedEntry._response}");
            }
        }
        Console.WriteLine("Journal saved\n");
    }

    public void LoadFromFile(string fileName)
    {
        Console.WriteLine("Loading journal...");
        string[] lines = System.IO.File.ReadAllLines(fileName);
        foreach (string line in lines)
        {
            string[] parts = line.Split("~|");
            
            Entry LoadedEntry = new Entry();
            LoadedEntry._date = parts[0];
            LoadedEntry._prompt = parts[1];
            LoadedEntry._response = parts[2];

            AddEntry(LoadedEntry);
        }
        Console.WriteLine("Journal loaded\n");

    }
    public void DisplayAll()
    {
        int count = 0;
        foreach (Entry entry in _entries)
        {
            count++;
            Console.Write(count);
            entry.Display();
        }
    }

}