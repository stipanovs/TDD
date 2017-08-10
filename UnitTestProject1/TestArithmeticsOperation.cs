using System;
using ClassToTest;
using NUnit.Framework;


namespace UnitTestProject1
{
    [TestFixture]
    public class SimpleArithmeticTests
    {

        ArithmeticOperation operation;

        [TestFixtureSetUp] 
        public void Init()
        {
            
            operation = new ArithmeticOperation();
        }


        [Test]
        [TestCase(5,3,8)]
        [TestCase(2, 4, 6)]
        [TestCase(15, 7, 22)]
        [TestCase(11, 3, 14)]
        public void TestAddition(int a, int b, decimal res)
        {
                    
            Assert.AreEqual(res, operation.Addition(a, b));
        }

        [Test]
        public void TestSubtraction()
        {
            
            Assert.IsTrue(operation.Subtraction(10, 5) == 5);
        }

        [Test]
        public void TestMultiplication()
        {
            
            Assert.IsTrue(operation.Multiplication(20, 2) == 40);
        }

        [Test]
        public void TestDivision()
        {
            

            Assert.IsTrue(operation.Division(8, 2) == 4);
        }

        [Test]
        public void TestDivisionByZero()
        {
            void CheckDivisionByZero()
            {
                operation.Division(2, 0);
            }
            
            Assert.Throws(typeof(DivideByZeroException), CheckDivisionByZero);

        }

        [TestFixtureTearDown]
        public void CleanUp()
        {
            operation = null;
        }

        
    }
}
