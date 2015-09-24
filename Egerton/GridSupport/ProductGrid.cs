using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Egerton.GridSupport
{
	public class ProductGrid
	{
		public ProductGrid(int size)
		{
			Cells = new int[size, size];

			int[] primes = { 2, 3, 5, 7, 11 };
			for (int column = 0; column < size; column++)
			{
				if (primes.Length >= size)
				{
					Cells[0, column] = primes[column];
				}
			}
		}

		public int[,] Cells { get; set; }
	}
}
