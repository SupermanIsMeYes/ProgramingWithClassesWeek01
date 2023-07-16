class Loader{

        public List<List<string>> LoadTransactions(string filename)
    {
        List<List<string>> transactions = new List<List<string>>();

        if (File.Exists(filename))
        {
            using (StreamReader reader = new StreamReader(filename))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    List<string> transaction = new List<string>(line.Split(','));
                    transactions.Add(transaction);
                }
            }
        }

        return transactions;
    }
}