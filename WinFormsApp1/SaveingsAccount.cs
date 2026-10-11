using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp1
{
    public class SaveingsAccount :BankAccount
    {
        public decimal InterestRate {  get; set; }
        public SaveingsAccount(string owner,decimal interestrate) : base(owner)
        {
            InterestRate = interestrate;
        }



    }
}
