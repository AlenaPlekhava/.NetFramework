using NUnit.Framework;
using NUnit.Test;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nunit
{
	[TestFixture]
	public class DivideCalculatorTest : BaseTest
	{
		[Test]
		public void DivideTwoPositiveNumbers()
		{
			double expectedResult1 = calculator.Divide(12, 3);
			Assert.True(expectedResult1 == 4);
		}

		[Test]
		public void SubductTwoNegativeNumbers()
		{
			double expectedResult2 = calculator.Divide(-12, -3);
			Assert.True(expectedResult2 == 4);
		}

		[Test]
		public void SubductTwoStrings()
		{
			string expectedResult3 = calculator.Divide(w, y);
			Assert.True(expectedResult3 == "Not valid for string values");
		}
	}
}
