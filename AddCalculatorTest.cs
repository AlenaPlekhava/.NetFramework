using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace NUnit.Test
{
	[TestFixture]
	public class AddCalculatorTest : BaseTest
	{
		[Test]
		public void AddTwoPositiveNumbers()
		{
			double expectedResult1 = calculator.Add(5D, 6D);
			Assert.True(expectedResult1 == 11);
		}

		[Test]
		public void AddTwoNegativeNumbers()
		{
			double expectedResult2 = calculator.Add(-4D, -3D);
			Assert.True(expectedResult2 == -7);
		}

		[Test]
		public void AddTwoStrings()
		{
			string expectedResult3 = calculator.Add(q, r);
			Assert.True(expectedResult3 == "Not valid for string values");
		}
	}
}
// Not working for other numeric types, the method Add uses only the value double
