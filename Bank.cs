namespace CSharpAssignment
{
    public class Bank
    {
        private int Balance = 500;
        private int MoneyInPocket = 0;

        public int MyBalance()
        {
            return Balance;
        }

        public int MyPocketMoney()
        {
            return MoneyInPocket;
        }

        public bool Withdraw(int amount)
        {
            if (amount >= Balance)
            {
                return false;
            }

            Balance -= amount;
            MoneyInPocket += amount;
            return true;
        }

        public bool Deposit(int amount)
        {
            Balance += amount;
            MoneyInPocket -= amount;
            return true;
        }
        
    }
}