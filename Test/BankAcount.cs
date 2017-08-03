using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonClass

{
    public class BankAcount
    {
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
                throw new ArgumentOutOfRangeException("amount");
            }
            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException("amount");
            }
            _balance -= amount;
        }
    }
}
