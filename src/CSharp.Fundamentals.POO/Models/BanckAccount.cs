namespace CSharp.Fundamentals.POO.Models
{
    public class BanckAccount
    {
        private decimal balance;

        public void Deposit(decimal amount)
        {
            if (amount > 0)
                balance += amount;
        }

        public decimal GetBalance()
        {
            return balance;
        }
    }
}
