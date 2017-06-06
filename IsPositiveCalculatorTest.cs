using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnit.Test
{
	[TestFixture]
	public class IsPositiveCalculatorTest : BaseTest
	{
		[Test]
		public void NegativeNumbers()
		{
			bool expectedResult1 = calculator.isPositive(-54);
			Assert.True(expectedResult1 == false);
		}

		[Test]
		public void PositiveNumbers()
		{
			bool expectedResult2 = calculator.isPositive(4D);
			Assert.True(expectedResult2 == true);
		}

		[Test]
		public void StringNumbers()
		{
			bool expectedResult3 = calculator.isPositive(q);
			Assert.True(expectedResult3 == "Not valid for string values");
		}
	}
}
