

class IncomeTransaction : Transactions{

        LayoutBuilder LB = new LayoutBuilder();

        public override void newTransaction(){

            Console.WriteLine();
            Console.Write("Enter date (YYYY/MM/DD): ");
            string date = Console.ReadLine();
            string amount;

            while (true)
            {
                Console.Write("Enter amount (max 9999999.99): ");
                amount = Console.ReadLine();

                if (amount.Length <= 10)
                {
                    break;
                }

                Console.WriteLine("Amount should less then 9999999.99.");
            }

            string description;

            while (true)
            {
                Console.Write("Enter description (<= 14 characters): ");
                description = Console.ReadLine();

                if (description.Length <= 14)
                {
                    break;
                }

                Console.WriteLine("Description should be 14 characters or less.");
            }

            string card = "";

            Console.WriteLine("1. Discover");
            Console.WriteLine("2. Capital 1");
            Console.WriteLine("3. Bank");
            Console.WriteLine("4. Pay Pal");

            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    card = " Discover";
                    break;
                case "2":
                    card = "Capital 1";
                    break;
                case "3":
                    card = "     Bank";
                    break;
                case "4":
                    card = "  Pay Pal";
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }

            if (description.Length < 14)
            {
                description = description.PadLeft(14);
            }
            if (amount.Length < 10)
            {
                amount = amount.PadLeft(10);
            }

            List<string> entry = new List<string> { date, "I", amount, description, card };
            LB.transactions.Add(entry);
            Console.WriteLine();

        }


}