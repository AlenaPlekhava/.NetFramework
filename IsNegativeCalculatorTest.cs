using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnit.Test
{
	[TestFixture]
	public class IsNegativeCalculatorTest : BaseTest
	{
		[Test]
		public void NegativeNumbers()
		{
			bool expectedResult1 = calculator.isNegative(-54);
			Assert.True(expectedResult1 == true);
		}

		[Test]
		public void PositiveNumbers()
		{
			bool expectedResult2 = calculator.isNegative(4D);
			Assert.True(expectedResult2 == false);
		}

		[Test]
		public void StringNumbers()
		{
			bool expectedResult3 = calculator.isNegative(q);
			Assert.True(expectedResult3 == "Not valid for string values");
		}
	}
}
