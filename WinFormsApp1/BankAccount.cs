using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp1
{
    public class BankAccount
    {
        public string Owner { get; set; }
        public Guid AccountNumber { get; set; }
        public decimal Balance { get;private set; }
        public BankAccount(String owner)
        {
            Owner = owner;
            AccountNumber = Guid.NewGuid();
            Balance = 0;


        }
        public string Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                return "You can deposit " + amount;

            }
            if (amount > 20000)
            {
                return "AML Deposit limit Reached.";
            }
            Balance += amount;
            return "Deposit Completed Succesfully.";
        }
        public string Withdraw(decimal amount)
        {
            if (amount <= 0)
            {
                return "Cant Withdraw " + amount;
            }
            if (amount > 8000)
            {
                return "Unable to withdraw more than 8000";
            }
            if (amount > Balance)
            {
                return "Balance is insufficent ";
            }
            Balance -= amount;
            return "Withdraw ok " + amount;
        }
    }
   





    
}
