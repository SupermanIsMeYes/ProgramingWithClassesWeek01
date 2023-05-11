using System;
using System.Collections.Generic;


namespace develop02 {
    class Program
    {
        static void Main(string[] args)
        {
            Entry myEntry = new Entry();
            myEntry.Store("What is your name?", "Mattew Manley", "8 May 2023");

            Entry yourEntry = new Entry();
            yourEntry.Store("Do you like Cats?","Yes","9 may 2023");

            Journal journal = new Journal();
            journal.StoreEntry(myEntry);
            journal.StoreEntry(yourEntry);


            List<Entry> entries = journal.GetAllEntries();
            foreach (Entry entry in entries)
            {
                string message = entry.GetAsSting();
                Console.WriteLine(message);

            }
        }
    }

}