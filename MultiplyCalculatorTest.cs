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
	public class MultiplyCalculatorTest : BaseTest
	{
		[Test]
		public void MultiplyTwoPositiveNumbers()
		{
			double expectedResult1 = calculator.Multiply(3, 4);
			Assert.True(expectedResult1 == 12);
		}

		[Test]
		public void MultiplyTwoNegativeNumbers()
		{
			double expectedResult2 = calculator.Multiply(-5, -3);
			Assert.True(expectedResult2 == 15);
		}

		[Test]
		public void MultiplyTwoStrings()
		{
			string expectedResult3 = calculator.Multiply(q, t);
			Assert.True(expectedResult3 == "Not valid for string values");
		}
	}
}
