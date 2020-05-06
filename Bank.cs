using System;

namespace CSharpAssignment
{
    public class Bank
    {
        private int Balance = 500;

        public int MyBalance()
        {
            return Balance;
        }

        public bool Withdraw(int amount)
        {
            if (amount >= Balance)
            {
                return false;
            }

            Balance -= amount;
            return true;
        }

        public bool Deposit(int amount)
        {
            Balance += amount;
            return true;
        }
    }
}