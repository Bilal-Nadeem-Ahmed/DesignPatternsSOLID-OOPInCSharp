using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsSOLID_OOPInCSharp.OopPrinciples.Encapsulation
{
    public class BankAccount
    {
        private decimal _balance;
        public BankAccount( decimal balance) 
        {
           Deposit(balance);
        }

        public void Deposit(decimal balance)
        {
            if (balance <= 0)
            {
                throw new ArgumentException("Demosit must be over 0");
            }
           
            this._balance += balance;
            
        }
        public decimal GetBalance()
        {
            return _balance; 
        }

        public void Withdraw(decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Withdrawal amount should be more than zero");
            }
            if(amount > _balance)
            {
                throw new InvalidOperationException("Insufficient funds");
            }

            this._balance -= amount;
        }

    }
}
