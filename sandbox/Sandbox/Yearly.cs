class Yearly : Totals{

private double totalAmount = 0;

public string getYearly(string year,LayoutBuilder layoutBuilder)
{

    foreach (List<string> list in layoutBuilder.transactions)
    {
        if (list[0].Substring(0, 4) == year)
        {
            double amount = double.Parse(list[2]);
            totalAmount += amount;
        }
    }

    return totalAmount.ToString("0.00").PadLeft(20);

}
}