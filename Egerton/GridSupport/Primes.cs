using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Egerton.GridSupport
{
	public class Primes
	{
		public static int[] GenerateSequence(int size)
		{
			int[] primes = Enumerable.Range(2, Int32.MaxValue - 1)
								.Where(number => Enumerable.Range(2, (int)Math.Sqrt(number) - 1)
								.All(divisor => number % divisor != 0))
								.Take(size)
								.ToArray();

			return primes;
		}
	}
}
