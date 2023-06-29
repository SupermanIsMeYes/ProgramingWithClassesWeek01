
class Simple : Goal
{
    public static List<List<string>> recordEventSimple(List<List<string>> goals, string number)
    {
        int point = 0;
        int total = 0;
        List<List<string>> newList = new List<List<string>>(goals);
        newList[int.Parse(number) - 1][3] = "X";
        point = int.Parse(newList[int.Parse(number) - 1][6]);
        total = int.Parse(newList[0][8]);
        newList[0][8] = (total + point).ToString();
        return newList;
    }

}