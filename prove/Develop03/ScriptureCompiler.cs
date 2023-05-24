namespace develop03
{
    class ScriptureCompiler
    {
        int[] randomNumList = new int[10];
        public List<string> addFalses(List<string> boolList)
        {
            Random rand = new Random();
            for (int i = 0; i < 3; i++)
            {
                randomNumList[i] = rand.Next(0, boolList.Count);
            }
            int index = boolList.Count;

            for (int z = 0; z < index; z++)
            {
                if (randomNumList.Contains(z))
                {
                    boolList.Insert(z, "false");
                }
            }
            return boolList;
        }


        public string[] combineStrings(List<string> scriptureList, List<string> boolList)
            {
                int index = Math.Min(scriptureList.Count, boolList.Count); // Get the minimum size
                for (int i = 0; i < index; i++)
                {
                    if (boolList[i] == "false")
                    {
                        int index1 = scriptureList[i].Length;
                        List<string> temp = new List<string>();
                        for (int x = 0; x < index1; x++)
                        {
                            temp.Add("_");
                        }
                        string result = String.Join("", temp);
                        scriptureList.RemoveAt(i);
                        scriptureList.Insert(i, result);
                    }
                }
                return scriptureList.ToArray();
            }

    }
}