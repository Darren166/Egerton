using Egerton.GridSupport;
using NUnit.Framework;
using System;

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

	}
}
