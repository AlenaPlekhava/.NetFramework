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
    public class CosCalculatorTest : BaseTest
    {
        [Test]
        public void CosValue()
        {
            double expectedResult = calculator.Cos(180.0);
            Assert.True(expectedResult == 1);
        }
    }
}
