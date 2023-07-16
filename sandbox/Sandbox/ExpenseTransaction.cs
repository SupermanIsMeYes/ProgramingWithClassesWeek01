

class ExpenseTransaction : Transactions{

        LayoutBuilder LB = new LayoutBuilder();

        public override void newTransaction(LayoutBuilder layoutBuilder){

            Console.WriteLine();

            string date = "";
            while (true)
            {
                Console.Write("Enter date (YYYY/MM/DD): ");
                date = Console.ReadLine();
                int len = date.Length;
                if (len == 10)
                {
                    break;
                }
                Console.WriteLine("Invaild input");
            }

            string amount;


            while (true)
            {
                Console.Write("Enter amount (max 999999.99): ");
                amount = Console.ReadLine();

                if (amount.Length <= 9)
                {
                    break;
                }

                Console.WriteLine("Amount should less then 999999.99.");
            }

            float floatNumber = float.Parse(amount);
            string formattedNumber = floatNumber.ToString("0.00");
            amount = "-" + formattedNumber;

            string description;

            while (true)
            {
                Console.Write("Enter description (<= 19 characters): ");
                description = Console.ReadLine();

                if (description.Length <= 19)
                {
                    break;
                }

                Console.WriteLine("Description should be 19 characters or less.");
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

            if (description.Length < 19)
            {
                description = description.PadLeft(19);
            }
            if (amount.Length < 10)
            {
                amount = amount.PadLeft(10);
            }

            List<string> entry = new List<string> { date, "E", amount, description, card };
            layoutBuilder.transactions.Add(entry);
            Console.WriteLine();

        }


}