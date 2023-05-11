using System;
using System.Collections.Generic;

namespace develop02 {
    /// <summary>
    /// The responsibility of an entry is to record
    /// </summary>


    public class Entry
    {
        public string prompt;
        public string response;
        public string date;

        public string GetAsSting()
        {
            return $"{date}\n{prompt}\n{response}\n";
        }

        public void Store(string prompt, string response, string date)
        {
            this.prompt = prompt;
            this.response = response;
            this.date = date;
            
        }


    }

}