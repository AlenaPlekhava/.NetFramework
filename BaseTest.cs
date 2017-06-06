using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnit.Test
{
	public class BaseTest
	{
		protected CSharpCalculator.Calculator calculator;

		[TestFixtureSetUp]
		public void TestSetup()
		{
			calculator = new CSharpCalculator.Calculator();
		}

		[TestFixtureTearDown]
		public void TestTearDown()
		{
			calculator = null;
		}
	}
}
