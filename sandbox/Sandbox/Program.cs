class Program
{
    static void Main(string[] args)
    {

        string filename = "transactions.txt";
        Saver S = new Saver();
        Loader L = new Loader();

        // Load transactions from file or create a new list
        //List<List<string>> transactions = L.LoadTransactions(filename) ?? new List<List<string>>();

        LayoutBuilder LB = new LayoutBuilder();
        Monthly M = new Monthly();
        //LB.transactions = transactions;

        IncomeTransaction IT = new IncomeTransaction();
        //IT.newTransaction(LB);

        ExpenseTransaction ET = new ExpenseTransaction();
        //ET.newTransaction(LB);

        //M.getMonthly(LB);


        //S.SaveTransactions(filename, LB.transactions);

        bool continueit = true;
        while (continueit)
            {
            
            string input = "0"; 
            Console.WriteLine("Menu Opitons:");
            Console.WriteLine(" 1. Record Expense Transaction");
            Console.WriteLine(" 2. Record Income Transaction");
            Console.WriteLine(" 3. Save Transactions to File");
            Console.WriteLine(" 4. Load Transaction from File");
            Console.WriteLine(" 5. Build Report");
            Console.WriteLine(" 6. Quit");
            Console.Write("Type a number to select a item from the menu. ");
            input = Console.ReadLine();
            Console.WriteLine();

            switch (input)
            {
                case "1":
                ET.newTransaction(LB);

                break;
                case "2":
                IT.newTransaction(LB);

                break;
                case "3":
                S.SaveTransactions(filename, LB.transactions);

                break;
                case "4":
                List<List<string>> transactions = L.LoadTransactions(filename) ?? new List<List<string>>();
                LB.transactions = transactions;

                break;
                case "5":
                M.getMonthly(LB);
                LB.BuildLayout(LB.transactions);

                break;
                case "6":
                continueit = false;

                break;
                default:
                Console.WriteLine("Invalid input try again.");
                break;
                
            }

            Console.WriteLine();

            }



    }
}