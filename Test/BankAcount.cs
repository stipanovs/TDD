using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassToTest

{
    public interface IBankAccount
    {
        void Debit(double amount);
        void Credit(double amount);
    }

    public class BankAcount : IBankAccount
    {

        public const string DebitAmountExceedsBalanceMessage = "Debit amount exceeds balance";
        public const string DebitAmountLessThanZeroMessage = "Debit amount less than zero";
        public const string CreditAmountLessThanZeroMessage = "Credit amount less than zero";
        private double _balance;
        private string _ownerName;
        public double Balance { get { return _balance; } }

        public BankAcount(string ownerName, double initialBalance)
        {
            _ownerName = _ownerName;
            _balance = initialBalance;
        }

        public void Debit(double amount)
        {
            if (amount > _balance)
            {
                throw new ArgumentOutOfRangeException("amount", amount, DebitAmountExceedsBalanceMessage);
            }
            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException("amount", amount, DebitAmountLessThanZeroMessage);
            }
            _balance -= amount;
        }

        public void Credit(double amount)
        {
            
            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException("amount", amount, CreditAmountLessThanZeroMessage);
            }

            _balance += amount;
        }
    }
}
