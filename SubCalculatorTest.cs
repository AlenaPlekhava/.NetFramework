using NUnit.Framework;
using NUnit.Test;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nunit.test
{
	[TestFixture]
	public class SubCalculatorTest : BaseTest
	{
		[Test]
		public void SubductTwoPositiveNumbers()
		{
			double expectedResult1 = calculator.Sub(10, 3);
			Assert.True(expectedResult1 == 7);
		}

		[Test]
		public void SubductTwoNegativeNumbers()
		{
			double expectedResult2 = calculator.Sub(-10, -3);
			Assert.True(expectedResult2 == -13);
		}

		[Test]
		public void SubductTwoStrings()
		{
			string expectedResult3 = calculator.Sub(w, y);
			Assert.True(expectedResult3 == "Not valid for string values");
		}
		
	}
}
