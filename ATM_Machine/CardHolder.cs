using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_Machine
{
    internal class CardHolder
    {
        private string firstName;
        private string lastName;
        private string cardNumber;
        private string pin;
        private double balance;
        public CardHolder(string firstName, string lastName, string cardNumber, string pin,double balance=0) { 
            this.firstName = firstName;
            this.lastName = lastName;
            this.cardNumber = cardNumber;
            this.pin = pin;
            this.balance = balance;
        }
        public double getBalance()
        {
            return balance; 
        }
        public string getCardHolderName() { 
            return firstName + " " + lastName;
        }
        public string getCardNumber()
        {
            return cardNumber;
        }
        public string getPin()
        {
            return pin;
        }
        public void withdraw(double amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Please enter a valid number");
                return;
            }
            if (amount > balance)
            {
                Console.WriteLine("Balance is not enough");
            }
            else
            {
                balance -= amount;
                Console.WriteLine("Withdraw success!");
            }
        }

        public void deposit(double amount) {
            if (amount <= 0)
            {
                Console.WriteLine("Please enter a valid number");
                return;
            }
            balance += amount;
        }

        public void checkBalance()
        {

            Console.WriteLine($"Current balance is ${formattedNumber(balance)}");
        }
        string formattedNumber(double number)
        {
            string formatted=number.ToString("F2");
            return formatted;
        }
    }
}
