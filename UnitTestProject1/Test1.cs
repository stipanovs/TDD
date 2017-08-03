using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PersonClass;


namespace UnitTestProject1
{
    
    [TestClass]
    public class TestBank
    {
        [TestMethod]
        public void Debit_WithValidAmount_UpdatesBalance()
        {
            // arrange  
            double beginningBalance = 1000.00;
            double debitAmount =300.00;
            double expected = 700.00;
            BankAcount account = new BankAcount("Stipanov Sergiu", beginningBalance);

            // act  
            account.Debit(debitAmount);

            // assert  
            double actual = account.Balance;
            Assert.AreEqual(expected, actual, 0.01, "Account not debited correctly");
        }

        [TestMethod]
        public void StringSameTest()
        {
            string a = "Sergiu";
            string b = "Sergiu";
            Assert.AreSame(a, b);
        }

        [TestMethod]
        public void IntegerSameTest()
        {
            int a = 33;
            int b = 33;
            Assert.AreNotSame(a, b, "{0} Should not be the same as {1}", a, b);
        }


    }
}
