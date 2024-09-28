using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGen = new PromptGenerator();
        string userChoice = "";

        // Menu to chose from loop
        while (userChoice != "5")
        {
            Console.WriteLine("Please select one of the following options:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");

            //User input
            userChoice = Console.ReadLine(); //Corrcting my loop that went on forever and ever and ever.

            if (userChoice =="1")
            {
                //New journal entry to write
                string prompt = promptGen.GetRandomPrompt();
                Console.WriteLine($"\nPrompt: {prompt}");
                Console.Write("Your response: ");
                string response = Console.ReadLine();

                Entry newEntry = new Entry(prompt, response);
                journal.AddEntry(newEntry);
            }
            else if (userChoice == "2")
            {
                //All journal entries are displayed
                journal.DisplayAll();
            }

            else if (userChoice == "3")
            {
                //Saving the the journal
                Console.Write("Enter filename to save: ");
                string fileName = Console.ReadLine();
                journal.SaveToFile(fileName);
                Console.WriteLine("Journal saved.");
            }
            else if (userChoice == "4")
            {
                //Loading your journal
                Console.Write("Enter filename to load: ");
                string fileName = Console.ReadLine();
                journal.LoadFromFile(fileName);
                Console.WriteLine("Journal loaded.");

                //I actually want to see the journal entry I saved and typed after it is loaded.  Here is the correction.
                journal.DisplayAll();
            }
        }

    }
}