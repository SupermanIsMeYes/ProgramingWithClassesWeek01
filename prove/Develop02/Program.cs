using System;
using System.Collections.Generic;


namespace develop02 {
    class Program
    {
        static void Main(string[] args)
        {
            int input = 0;
            Journal journal = new Journal();
            while (input != 5) 
            {
                Menu tempMenu = new Menu();
                string menu = tempMenu.PrintMenu();
                Int32.TryParse(menu, out input);

                if (input == 1) 
                {
                    Prompts tempString = new Prompts();
                    Entry myEntry = new Entry();
                    Input tempInput = new Input();
                    string prompt = tempString.GetRandomPrompt();
                    Console.WriteLine($"{prompt}");
                    myEntry.Store($" - Prompt: {prompt}\n ", $"Entry: {tempInput.inputSting()}\n", $"Date: {DateTime.Now.ToString("M/d/yyyy")}");

                    journal.StoreEntry(myEntry);
                }
                if (input == 2) {

                    List<Entry> entries = journal.GetAllEntries();
                    foreach (Entry entry in entries)
                    {
                        string message = entry.GetAsSting();
                        Console.WriteLine(message);
                    }
                }
                if (input == 3) {
                    Console.Write("Load what file name?  ");
                    string fileName = Console.ReadLine();

                    using(StreamReader readtext = new StreamReader(fileName))
                    {
                        string readText = readtext.ReadToEnd();
                        Console.WriteLine(readText);
                        Entry oldEntry = new Entry();
                        oldEntry.Store(readText, "","");
                        journal.StoreEntry(oldEntry);

                    }
                }
                if (input == 4) {
                    Console.Write("Save as what file name?  ");
                    string fileName = Console.ReadLine();

                    using(StreamWriter writetext = new StreamWriter(fileName))
                    {
                        List<Entry> entries = journal.GetAllEntries();
                        foreach (Entry entry in entries)
                        {
                            string message = entry.GetAsSting();
                            writetext.WriteLine(message);
                        }
                    }
                }


            }
        }
    }

}