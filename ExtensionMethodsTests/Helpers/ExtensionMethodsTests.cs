using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ExtensionMethods.Helpers;

namespace ExtensionMethodsTests.Helpers
{
	[TestFixture]
	public class ExtensionMethodsTests
	{
		[Test]
		public void Combine_ShouldCombine()
		{
			var value = "ian";
			var newValue = value.Combine();
			Assert.That(newValue, Is.EqualTo("ian appended"));
		}
	}
}
