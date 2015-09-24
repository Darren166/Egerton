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
		[TestCase(11, new int[] { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31 })]
		[TestCase(25, new int[] { 2,3,5,7,11,13,17,19,23,29,31,37,41,43,47,53,59,61,67,71,73,79,83,89,97 })]
		public void Generating_A_Sequence_Of_5_Primes_Returns_Correctly(int size, int[] expectedPrimes)
		{
			int[] actuaPrimes = Primes.GenerateSequence(size);

			CollectionAssert.AreEqual(expectedPrimes, actuaPrimes);
		}
	}
}
