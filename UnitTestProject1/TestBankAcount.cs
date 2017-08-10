using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassToTest;



namespace UnitTestProject1
{
    
    [TestClass]
    public class TestBank
    {
        [TestMethod]
        public void DebitWithValidAmount_UpdatesBalance()
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
        public void CreditWithValidAmount_UpdatesBalance()
        {
            // arrange  
            double beginningBalance = 0.00;
            double creditAmount = 500.00;
            double expected = 500.00;
            BankAcount account = new BankAcount("Stipanov Sergiu", beginningBalance);

            // act  
            account.Credit(creditAmount);

            // assert  
            double actual = account.Balance;
            Assert.AreEqual(expected, actual, 0.01, "Account not credit correctly");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void DebitGetExceptionWhenAmountIsLessZero()
        {
            // arrange  
            double beginningBalance = 560.00;
            double debitAmount = -178.00;
            BankAcount account = new BankAcount("Stipanov Sergiu", beginningBalance);

            // act 
            account.Credit(debitAmount);

            // assert  is handled ExpectedException

        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void CreditGetExceptionWhenAmountIsLessZero()
        {
            // arrange  
            double beginningBalance = 123.00;
            double creditAmount = -250.00;
            //double expected = 500.00;
            BankAcount account = new BankAcount("Stipanov Sergiu", beginningBalance);

            // act 
            account.Credit(creditAmount);
           
            // assert  is handled ExpectedException
           
        }

        [TestMethod]
        public void DebitWhenAmountIsMoreThanBalance_ShouldThrowArgumentOutOfRange()
        {
            // arrange  
            double beginningBalance = 267;
            double debitAmount = 301;
            BankAcount account = new BankAcount("Stipanov Sergiu", beginningBalance);

            // act  
            try
            {
                account.Debit(debitAmount);
            }
            catch (ArgumentOutOfRangeException e)
            {
                // assert  
                StringAssert.Contains(e.Message, BankAcount.DebitAmountExceedsBalanceMessage);
            }
           
        }




    }
}
