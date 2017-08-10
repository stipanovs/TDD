using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using ClassToTest;
using NUnit.Framework;

namespace UnitTestProject1
{
    [TestFixture]
    public class MoqTest
    {
                     
        [Test]
        public void DebitWhenAmountLessZeroMoq()
        {
            var mock = new Mock<IBankAccount>();

            mock.Setup(foo => foo.Debit(-520)).Throws<ArgumentOutOfRangeException>();
        }

    }


}
