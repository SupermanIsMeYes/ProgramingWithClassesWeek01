
class Monthly
{
    private int i = 0;

    private string year = "";

    private List<string> nothing = new List<string>{"         0.00","         0.00","         0.00","         0.00","         0.00","         0.00","         0.00","         0.00","         0.00","         0.00","         0.00","         0.00"};

    private double jan = 0;private double feb = 0;private double mar = 0;
    private double apr = 0;private double may = 0;private double jun = 0;
    private double jul = 0;private double aug = 0;private double sep = 0;
    private double oct = 0;private double nov = 0;private double dec = 0;

    public void getMonthly(LayoutBuilder layoutBuilder)
    {

        foreach (List<string> list in layoutBuilder.transactions)
        {
            year = list[0].Substring(0, 4);

            foreach (List<string> list2 in layoutBuilder.transactions)
            {
                if (list2[0].Substring(0, 4) == year)
                {
                    double totalAmount = 0;
                    double amount = double.Parse(list2[2]);
                    totalAmount += amount;
                    string month = list2[0].Substring(5, 2);

                    switch (month)
                    {
                        case "01":
                            // Code for January
                            jan += totalAmount;
                            break;
                        case "02":
                            // Code for February
                            feb += totalAmount;
                            break;
                        case "03":
                            // Code for March
                            mar += totalAmount;
                            break;
                        case "04":
                            // Code for April
                            apr += totalAmount;
                            break;
                        case "05":
                            // Code for May
                            may += totalAmount;
                            break;
                        case "06":
                            // Code for June
                            jun += totalAmount;
                            break;
                        case "07":
                            // Code for July
                            jul += totalAmount;
                            break;
                        case "08":
                            // Code for August
                            aug += totalAmount;
                            break;
                        case "09":
                            // Code for September
                            sep += totalAmount;
                            break;
                        case "10":
                            // Code for October
                            oct += totalAmount;
                            break;
                        case "11":
                            // Code for November
                            nov += totalAmount;
                            break;
                        case "12":
                            // Code for December
                            dec += totalAmount;
                            break;
                        default:
                            // Code for handling an invalid month
                            break;
                        }
                }
            }

            string yearlyTotal = "";
            Yearly GY = new Yearly();
            yearlyTotal = GY.getYearly(year,layoutBuilder);

            List<string> monthlyTotals = new List<string> { jan.ToString("0.00").PadLeft(13), feb.ToString("0.00").PadLeft(13), mar.ToString("0.00").PadLeft(13), apr.ToString("0.00").PadLeft(13), may.ToString("0.00").PadLeft(13), jun.ToString("0.00").PadLeft(13), jul.ToString("0.00").PadLeft(13), aug.ToString("0.00").PadLeft(13), sep.ToString("0.00").PadLeft(13), oct.ToString("0.00").PadLeft(13), nov.ToString("0.00").PadLeft(13), dec.ToString("0.00").PadLeft(13), yearlyTotal};
            
            if (!layoutBuilder.totals.Any(totalsList => totalsList.SequenceEqual(monthlyTotals)))
            {
                layoutBuilder.totals.Add(monthlyTotals);
            }

            jan = 0; feb = 0; mar = 0;
            apr = 0; may = 0; jun = 0;
            jul = 0; aug = 0; sep = 0;
            oct = 0; nov = 0; dec = 0;

            i += 1;

        }
    }
}
