using System;
using System.Collections.Generic;

namespace develop02 {
    /// <summary>
    /// The responsibility of an Journal is to record
    /// </summary>


    public class Journal
    {
        public List<Entry> entries;

        public Journal()
        {
            entries = new List<Entry>();
        }

        public List<Entry> GetAllEntries()
        {
            return entries;
        }

        public void StoreEntry(Entry entry)
        {
            if (!entries.Contains(entry))
            {
                entries.Add(entry);
            }
        }


    }

}