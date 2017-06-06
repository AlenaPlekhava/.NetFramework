using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnit.Test
{
	[TestFixture]
	public class AbsCalculatorTest : BaseTest
	{
		[Test]
		public void AbsPositiveNumber()
		{
			double expectedResult1 = calculator.Abs(5D);
			Assert.True(expectedResult1 == 5D);
		}

		[Test]
		public void AbsNegativeNumber()
		{
			double expectedResult2 = calculator.Abs(-4);
			Assert.True(expectedResult2 == 4);
		}

		[Test]
		public void AbsString()
		{
			string expectedResult3 = calculator.Abs(qwrt);
			Assert.True(expectedResult3 == "Not valid for string values");
		}
	}
}