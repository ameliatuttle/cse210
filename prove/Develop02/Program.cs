using System;

namespace Develop02 
{
    public class Program
    {
        static void Main(string[] args)
        {
            // add some test entries
            Entry myEntry = new Entry();
            myEntry.StorePrompt("What is your name?");
            myEntry.StoreResponse("Mathew Manley");
            myEntry.StoreDate("8 May 2023");

            // create a journal to test
            Journal journal = new Journal();
            journal.StoreEntry(myEntry);

            // show the journal contents
            List<Entry> entries = journal.GetEntries();
            foreach (Entry entry in entries)
            {
                string message
                    = $"{entry.GetDate()}\n{entry.GetPrompt()}\n{entry.GetResponse()}\n";
                Console.WriteLine(message);
            }
        }
    }
}