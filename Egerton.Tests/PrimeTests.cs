using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Egerton.GridSupport;

namespace Egerton.Tests
{
	[TestClass]
	public class PrimeTests
	{
		[TestMethod]
		public void Generating_A_Sequence_Of_Primes_Returns_Correctly()
		{
			int[] primes = Primes.GenerateSequence(5);

			CollectionAssert.AreEqual(new int[] { 2, 3, 5, 7, 11 }, primes);
		}
	}
}
