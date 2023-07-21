using System;

namespace ATM_Machine
{
    class ATM
    {
        public static void Main(string[] args)
        {
            CardHolder obj1 = new CardHolder("John", "Cena", "123456789", "000000");
            int numberOfErrors=0;
            while (true)
            {
                Console.WriteLine("Enter your card number");
                string enteredCard=Console.ReadLine();
                if (numberOfErrors >= 3)
                {
                    Console.WriteLine("Too many times error. Enter any key to leave");
                    Environment.Exit(0);
                }
                if (enteredCard !=obj1.getCardNumber())
                {
                    Console.WriteLine("Wrong card number, please try again");
                    numberOfErrors++;
                    continue;
                }

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
                if (enteredPin != obj1.getPin())
                {
                    Console.WriteLine("Wrong pin number, please try again");
                    numberOfErrors++;
                    continue;
                }
                break;
            }
            while (true)
            {
                Console.WriteLine($"Welcome {obj1.getCardHolderName()} ! What can I help you today?");
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
                        obj1.checkBalance();
                        break;
                    case 2:
                        Console.WriteLine("Please Enter amount you want to withdraw");
                        input= Console.ReadLine();
                        if (input!=null)
                        {
                            amount= Convert.ToDouble(input);
                        }
                        obj1.withdraw(amount);
                        break;
                    case 3:
                        Console.WriteLine("Please Enter amount you want to withdraw");
                        input = Console.ReadLine();
                        if (input != null)
                        {
                            amount = Convert.ToDouble(input);
                        }
                        obj1.deposit(amount);
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