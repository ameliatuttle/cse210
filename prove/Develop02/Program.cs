using System;

namespace Develop02 
{
    public class Program
    {
        static void Main(string[] args)
        {
            // add some test entries
            Entry myEntry = new Entry();
            Prompt myPrompt = new Prompt();
            string thisPrompt = myPrompt.SelectPrompt();
            Console.Write(thisPrompt);
            string response = Console.ReadLine();
            myEntry.StorePrompt($"{thisPrompt} ");
            myEntry.StoreResponse(response);
            string date = DateTime.Now.ToString("dd MMMM yyyy");
            myEntry.StoreDate(date);

            // create a journal to test
            Journal journal = new Journal();
            journal.StoreEntry(myEntry);

            // show the journal contents
            List<Entry> entries = journal.GetEntries();
            foreach (Entry entry in entries)
            {
                string message
                    = $"\n{entry.GetDate()}\n{entry.GetPrompt()}\n{entry.GetResponse()}\n";
                Console.WriteLine(message);
            }
        }
    }
}