using Egerton.GridSupport;
using NUnit.Framework;
using System;
using System.Linq;

namespace Egerton.Tests
{
	[TestFixture]
	public class GridTests
	{
		[TestCase(1)]
		[TestCase(3)]
		[TestCase(7)]
		[TestCase(10)]
		public void New_Grid_Returns_Correct_Number_Of_Cells(int size)
		{
			// Given a size
			// When a new grid is created
			ProductGrid productGrid = new ProductGrid(size);

			// Then the number of cells should be the square of the size
			int expectedNumberOfCells = size * size;
			Assert.AreEqual(productGrid.Cells.Length, expectedNumberOfCells);
		}

		[TestCase(1)]
		[TestCase(57)]
		[TestCase(1000)]
		public void New_Grid_Has_Correct_Number_Of_Rows(int size)
		{
			// Given a size
			// When a new grid is created
			ProductGrid productGrid = new ProductGrid(size);
			
			// Then the number of rows should equal the size
			Assert.AreEqual(productGrid.Cells.GetLength(0), size);
		}

		[Test]
		public void First_Row_In_Size_5_Grid_Contains_Primes() {
			// Given a grid of size 5
			int[] primes = { 2, 3, 5, 7, 11 };
			ProductGrid productGrid = new ProductGrid(5);
			
			// When the first row is extracted
			int[] actualValues = Enumerable.Range(0,5).Select(index=>productGrid.Cells[0,index]).ToArray();
			
			// Then they should be sequential primes
			Assert.AreEqual(actualValues, primes);
		}

		[Test]
		public void First_Column_In_Size_5_Grid_Contains_Primes()
		{
			// Given a grid of size 5
			int[] primes = { 2, 3, 5, 7, 11 };
			ProductGrid productGrid = new ProductGrid(5);

			// When the first row is extracted
			int[] actualValues = Enumerable.Range(0, 5).Select(index => productGrid.Cells[index, 0]).ToArray();

			// Then they should be sequential primes
			Assert.AreEqual(actualValues, primes);
		}

	}
}
