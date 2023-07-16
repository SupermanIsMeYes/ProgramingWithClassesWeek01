
class LayoutBuilder {

    public List<List<string>> transactions = new List<List<string>>();

    public List<List<string>> totals = new List<List<string>>();


    private int numberOfYears = 0;
    
 


    public void BuildLayout(List<List<string>> transactions)
    {
        numberOfYears = totals.Count;

        Console.WriteLine("");
        Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -");
        Console.WriteLine("|    Date    |I/E|   Amount   |     Discription     |   Card    |");
      
        foreach (List<string> list in transactions)
                {
                    Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -");
                    Console.WriteLine($"| {list[0]} | {list[1]} | {list[2]} | {list[3]} | {list[4]} |");
                }
        Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -");
        foreach (List<string> list in totals)
        {
                Console.WriteLine("");
                Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -");
                Console.WriteLine($"| Year Total: {list[12]}                             |");
                Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -");
                Console.WriteLine($"| Jan: {list[0]} | Feb: {list[1]} | Mar: {list[2]} |");
                Console.WriteLine($"| Apr: {list[3]} | May: {list[4]} | Jun: {list[5]} |");
                Console.WriteLine($"| Jul: {list[6]} | Aug: {list[7]} | Sep: {list[8]} |");
                Console.WriteLine($"| Oct: {list[9]} | Nov: {list[10]} | Dec: {list[11]} |");
                Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -");
        }

    }
}