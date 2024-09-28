using System;
using System.Collections.Generic;

public class PromptGenerator
{
    //A list of prompts for the journal entries
    private List<string> _prompts;
    //Instantiate initializes the list of prompts
    public PromptGenerator()
    {
        _prompts = new List<string>
        {
            "Who was the most interesting person I einteracted with today?",
            "What was the best part of my day?", 
            "How did i see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over otday, what would it be?",
            "How am I feeling today? How do you want to feel?",
            "What is going well in my life right now? What worries me the most currently?",
            "What is one thing I deeply desire? What steps can I take tomorrow toward achieving it?"
        };
    }

    //Method that randomly selects and returns a prompt
    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index =random.Next(_prompts.Count);
        return _prompts[index];
    }
}