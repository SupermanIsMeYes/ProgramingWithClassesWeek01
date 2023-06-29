class FileManager : Goal
{

        public static void WriteList(List<List<string>> goals, string filename)
        {
            using (StreamWriter sw = new StreamWriter(filename))
            {
                foreach (List<string> list in goals)
                {
                    sw.WriteLine(string.Join("~", list));
                }
            }
        }



public static List<List<string>> ReadList(string filename)
{
    List<List<string>> goals = new List<List<string>>();
    
    using (StreamReader sr = new StreamReader(filename))
    {
        string line;
        while ((line = sr.ReadLine()) != null)
        {
            List<string> list = new List<string>();
            foreach (string item in line.Split('~'))
            {
                list.Add(item);
            }
            goals.Add(list);
        }
    }
    
    return goals;
}
}