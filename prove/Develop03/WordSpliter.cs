using System;
using System.Collections.Generic;


namespace develop03 {
    class WordSpliter
    {
        
        //ReferenceDatabase scriptureText = new ReferenceDatabase();
        //ReferenceDatabase scriptureReference = new ReferenceDatabase();

        public string[] getSplitScripture(int index)
        {
            ReferenceDatabase scriptureText = new ReferenceDatabase();
            string scripture = scriptureText.getScripture(index);
            string[] splitScripture = scripture.Split(' ');
            return splitScripture;
        }
        public string[] getStringBool(string[] splitScripture)
        {
            int index = splitScripture.Length;
            string[] boolList = new string[index];
            for (int i = 0; i < index;)
            {
                boolList[i] = "true";
                i = i + 1;
            }
            //Console.WriteLine(index);
            return boolList;
            
        }
        
        
    }
}