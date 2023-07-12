
class LayoutBuilder {

    public List<List<string>> transactions = new List<List<string>>();

    public List<string> totals = new List<string>();

    public List<List<string>> monthlys = new List<List<string>>();

    private int numberOfYears = 0;
    
 


    public void BuildLayout(List<List<string>> transactions, int numberOfYears, List<string> totals, List<List<string>> monthlys)
    {
        numberOfYears = totals.Count;

        Console.WriteLine("");
        Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -");
        Console.WriteLine("|    Date    |I/E|   Amount   |     Discription     |   Card    |");
      
        foreach (List<string> list in transactions)
                {
                    Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -");
                    Console.WriteLine($"| {2023/01/01} | {1} | {10} | {14} | {9} |");
                }
        Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -");
        Console.WriteLine("");
        foreach (List<string> list in transactions)
        {
                Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -");
                Console.WriteLine($"| Year Total: {20}                             |");
                Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -");
                Console.WriteLine($"| Jan: {13} | Feb: {13} | Mar: {13} |");
                Console.WriteLine($"| Apr: {13} | May: {13} | Jun: {13} |");
                Console.WriteLine($"| Jul: {13} | Aug: {13} | Sep: {13} |");
                Console.WriteLine($"| Oct: {13} | Nov: {13} | Dec: {13} |");
                Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -");
        }

    }
}