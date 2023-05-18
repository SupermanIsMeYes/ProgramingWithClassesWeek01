namespace develop02 {
    class ReferenceDatabase
    {
        
        public List<string> scriptureText = new List<string>{
            ""
        };
        public List<string> scriptureReference = new List<string>{
            ""
        };

        public string getScripture(int index)
        {
            return scriptureText[index];
        }
        
        public string getReference(int index)
        {
            return scriptureReference[index];
        }
        
    }
}