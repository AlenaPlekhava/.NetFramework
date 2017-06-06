using NUnit.Framework;
using NUnit.Test;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nunit.Test
{
    [TestFixture]
    public class SqrtCalculatorTest : BaseTest
    {
        [Test]
        public void SqrtValue()
        {
            double expectedResult = calculator.Sqrt(2);
            Assert.True(expectedResult == 4);
        }
    }
}
