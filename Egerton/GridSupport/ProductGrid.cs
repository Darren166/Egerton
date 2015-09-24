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
			SetNonHeaderCells();
		}

		public int[,] Cells { get; set; }

		private int gridSize;

		private void SetHeaderCells() {
			int[] primes = Primes.GenerateSequence(gridSize);
			for (int index = 0; index < gridSize; index++)
			{
				if (primes.Length >= gridSize)
				{
					Cells[0, index] = primes[index];
					Cells[index, 0] = primes[index];
				}
			}
		}

		private void SetNonHeaderCells() 
		{
			for (int row = 1; row < gridSize; row++)
			{
				for (int column = 1; column < gridSize; column++)
				{
					Cells[row, column] = Cells[row, 0] * Cells[0, column];
				}
			}
		}
	}
}
