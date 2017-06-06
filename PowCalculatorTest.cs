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
    public class PowCalculatorTest : BaseTest
    {
        [Test]
        public void PowNumbers()
        {
            double expectedResult = calculator.Pow(2, 3);
            Assert.True(expectedResult == 8);
        }
    }
}
