using System;
using System.Collections.Generic;

namespace develop03 {
    class Program
    {
        static void Main(string[] args)
        {
            //WordSpliter test = new WordSpliter();
            //string[] test1 = test.getSplitScripture(0);
            //List<string> test1List = new List<string>(test1);
            //foreach (string word in test1List)
            //    {
            //        Console.WriteLine(word);
            //    }
//
            //string scripture = String.Join(" ", test1List);
            //Console.WriteLine(scripture);
//
            //WordSpliter test2 = new WordSpliter();
            //string[] test3 = test2.getStringBool(test1);
            //List<string> test3List = new List<string>(test3);
            //foreach (string word in test3List)
            //    {
            //        Console.WriteLine(word);
            //    }
            ////List<string> test2List = new List<string>(test3);
//
            //ScriptureCompiler test5 = new ScriptureCompiler();
            //List<string> test2List = new List<string>(test3);
            //List<string> test6List = test5.addFalses(test2List);
            //List<string> test6List1 = test5.addFalses(test6List);
            //string[] test6 = test6List.ToArray();
//
            //ScriptureCompiler test7 = new ScriptureCompiler();
            //string test8 = test7.combineStrings(test1List,test6List);
           //
//
            ////foreach (string word in test6)
            ////    {
            ////        Console.WriteLine(word);
            ////    }
            //Console.WriteLine(test8);
            int scriptureNum = 0;
            Console.WriteLine("what number is you scripture in the list? ");
            scriptureNum = Convert.ToInt32(Console.ReadLine());
            string continueIt = "";
            WordSpliter scriptureSplit = new WordSpliter();
            string[] scripture = scriptureSplit.getSplitScripture(scriptureNum);
            List<string> scriptureList = new List<string>(scripture);
            WordSpliter scriptureBool = new WordSpliter();
            string[] boolString = scriptureBool.getStringBool(scripture);
            List<string> boolList = new List<string>(boolString);
            ReferenceDatabase reference = new ReferenceDatabase();
            string referenceScripture = reference.getReference(scriptureNum);

            while (continueIt != "quit")
            {
                Console.Write(referenceScripture + " ");
                ScriptureCompiler compile = new ScriptureCompiler();
                Console.WriteLine(String.Join(" ", (compile.combineStrings(scriptureList, boolList))));
                Console.WriteLine();
                Console.WriteLine("Press enter to continue or type 'quit' to finish:");
                continueIt = Console.ReadLine();
                

                if (continueIt == "")
                {
                    ScriptureCompiler addFalseBool = new ScriptureCompiler();
                    boolList = addFalseBool.addFalses(boolList);

                }
                Console.Clear();


            }
            

            
        }
    }
}