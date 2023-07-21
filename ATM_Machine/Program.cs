using System;

namespace ATM_Machine
{
    class ATM
    {
        public static void Main(string[] args)
        {
            CardHolder obj1 = new CardHolder("John", "Cena", "123456789", "000000");
            CardHolder obj2 = new CardHolder("Lean", "Jolyn","246781357", "111111");
            int numberOfErrors=0;
            Dictionary<String, CardHolder> cardHolderDict= new Dictionary<String, CardHolder>();
            cardHolderDict.Add(obj1.getCardNumber(), obj1);
            cardHolderDict.Add(obj2.getCardNumber(), obj2);
            CardHolder currUser;
            while (true)
            {
                Console.WriteLine("Enter your card number");
                string enteredCard=Console.ReadLine();
                if (numberOfErrors >= 3)
                {
                    Console.WriteLine("Too many times error. Enter any key to leave");
                    Environment.Exit(0);
                }
                if (!cardHolderDict.ContainsKey(enteredCard))
                {
                    Console.WriteLine("Wrong card number, please try again");
                    numberOfErrors++;
                    continue;
                }
                currUser = cardHolderDict[enteredCard];
                break;
            }
            
            numberOfErrors = 0;
            while (true)
            {
                Console.WriteLine("Enter your pin");
                string enteredPin = Console.ReadLine();
                if (numberOfErrors >= 3)
                {
                    Console.WriteLine("Too many times error. Enter any key to leave");
                    Environment.Exit(0);
                }
                if (enteredPin != currUser.getPin())
                {
                    Console.WriteLine("Wrong pin number, please try again");
                    numberOfErrors++;
                    continue;
                }
                break;
            }
            while (true)
            {
                Console.WriteLine($"Welcome {currUser.getCardHolderName()} ! What can I help you today?");
                Console.WriteLine("1. Check Balance");
                Console.WriteLine("2. Withdraw");
                Console.WriteLine("3. Deposit");
                Console.WriteLine("4. Leave");
                int option=Int32.Parse(Console.ReadLine());
                double amount = 0;
                string input;
                switch (option)
                {
                    case 1:
                        currUser.checkBalance();
                        break;
                    case 2:
                        Console.WriteLine("Please Enter amount you want to withdraw");
                        input= Console.ReadLine();
                        if (input!=null)
                        {
                            amount= Convert.ToDouble(input);
                        }
                        currUser.withdraw(amount);
                        break;
                    case 3:
                        Console.WriteLine("Please Enter amount you want to withdraw");
                        input = Console.ReadLine();
                        if (input != null)
                        {
                            amount = Convert.ToDouble(input);
                        }
                        currUser.deposit(amount);
                        break;
                    case 4:
                        Environment.Exit(0);
                        break;
                    default:
                        break;
                
                }
            }
        }
    }
}