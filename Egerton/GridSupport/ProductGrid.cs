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
			gridSize = size;
			Cells = new int[size, size];
			SetHeaderCells();

		}

		public int[,] Cells { get; set; }

		private int gridSize;

		private void SetHeaderCells() {
			int[] primes = { 2, 3, 5, 7, 11 };
			for (int index = 0; index < gridSize; index++)
			{
				if (primes.Length >= gridSize)
				{
					Cells[0, index] = primes[index];
					Cells[index, 0] = primes[index];
				}
			}
		}
	}
}
