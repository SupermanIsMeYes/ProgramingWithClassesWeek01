namespace develop02 {

    public class Menu
    {
        public string PrintMenu()
        {
            Console.WriteLine("Please select one of the following: ");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do?  ");
            Input tempInput1 = new Input();
            string tempInput = tempInput1.inputSting();
            return tempInput;
        }


    }

}