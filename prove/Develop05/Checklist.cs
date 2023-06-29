class Checklist : Goal
{
    public static List<List<string>> recordEventChecklist(List<List<string>> goals, string number)
    {
        int point = 0;
        int total = 0;
        int numberOf = 0;
        List<List<string>> newList = new List<List<string>>(goals);
        numberOf = int.Parse(newList[int.Parse(number) - 1][4]);
        newList[int.Parse(number) - 1][4] = (numberOf + 1).ToString();

        if (newList[int.Parse(number) - 1][4] == newList[int.Parse(number) - 1][5]){
            newList[int.Parse(number) - 1][3] = "X";
            point = int.Parse(newList[int.Parse(number) - 1][7]);
            total = int.Parse(newList[0][8]);
            newList[0][8] = (total + point).ToString();
        }
        point = int.Parse(newList[int.Parse(number) - 1][6]);
        total = int.Parse(newList[0][8]);
        newList[0][8] = (total + point).ToString();
        return newList;
    }

}