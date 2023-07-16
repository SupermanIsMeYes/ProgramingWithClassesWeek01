class Saver{
        public void SaveTransactions(string filename, List<List<string>> transactions)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (List<string> transaction in transactions)
            {
                string line = string.Join(",", transaction);
                writer.WriteLine(line);
            }
        }
        Console.WriteLine();
        Console.WriteLine("Transactions saved");
        Console.WriteLine();
    }
}