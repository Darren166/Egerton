using System;
using Egerton.GridSupport;
using NUnit.Framework;

namespace Egerton.Tests
{
	[TestFixture]
	public class PrimeTests
	{
		[TestCase(1, new int[] { 2 })]
		[TestCase(5, new int[] { 2, 3, 5, 7, 11 })]
		[TestCase(11, new int[] { 2, 3, 5, 7, 11 })]
		[TestCase(27, new int[] { 2, 3, 5, 7, 11 })]
		public void Generating_A_Sequence_Of_5_Primes_Returns_Correctly(int size, int[] expectedPrimes)
		{
			int[] actuaPrimes = Primes.GenerateSequence(size);

			CollectionAssert.AreEqual(expectedPrimes, actuaPrimes);
		}
	}
}
