namespace develop03 {
    class ReferenceDatabase
    {
        
        private List<string> scriptureText = new List<string>{
            "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.",
            "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.",
            "Trust in the LORD with all thine heart; and lean not unto thine own understanding."
        };
        private List<string> scriptureReference = new List<string>{
            "John 3:16",
            "proverbs 3:5-6",
            "Proverbs 3:5"
            
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