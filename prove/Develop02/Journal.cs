using System;
using System.Collections.Generic;
using System.IO;

public class Journal{
    //This file: list will hold the journal entries of the inputter.
    private List<Entry> _entries;

    //Instantiate initializes the list of entries
    public Journal()
    {
        _entries = new List<Entry>();
    }

    //Method to add a new entry into the journal
    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }
    
    //Method displaying all journal entries
    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    //Method to save the journal entries to a file.  I will be using StreamWriter: quickly takes the users entry and saves it in a file
    public void SaveToFile(string file)
    {
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (Entry entry in _entries)
            {
                //It will save each entry as a line in the order of: date/prompt/entry
                outputFile.WriteLine($"{entry._date} | {entry._promptText} | {entry._entryText}");
            }
        }
    }

    //Method to load the entries when chose in the menu item #4.
    public void LoadFromFile(string file)
    {
        _entries.Clear(); //Makes room for new entries to be loaded.
        string[] lines = File.ReadAllLines(file);

        foreach (string line in lines)
        {
            string[] parts = line.Split('|');
            Entry loadedEntry = new Entry(parts[1], parts[2]);
            _entries.Add(loadedEntry);
        } 
    }

}