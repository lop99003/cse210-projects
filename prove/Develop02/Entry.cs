using System;

//Class for journal entry
public class Entry
{
    //Atttributes for this class
    public string _date;
    public string _promptText;
    public string _entryText;

    //Instantiate to initialize the entry with the prompt and the response
    public Entry(string prompt, string text)
    {
        _date = DateTime.Now.ToShortDateString(); //Holds the current date of entry
        _promptText = prompt; //Stores the prompt that was given
        _entryText = text; //Stores the user's response
    }
    //Method to display the entry
    public void Display()
    {
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt: {_promptText}");
        Console.WriteLine($"Response: {_entryText}\n");
    }
}