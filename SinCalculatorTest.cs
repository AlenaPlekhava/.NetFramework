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
    public class SinCalculatorTest : BaseTest
    {
        [Test]
        public void SinValue()
        {
            double expectedResult = calculator.Sin(90.0);
            Assert.True(expectedResult == 1);
        }
    }
}