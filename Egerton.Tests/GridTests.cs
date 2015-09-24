using Egerton.GridSupport;
using NUnit.Framework;
using System;

namespace Egerton.Tests
{
	[TestFixture]
	public class GridTests
	{
		[TestCase(1, 1)]
		[TestCase(3, 9)]
		[TestCase(7, 49)]
		[TestCase(10, 100)]
		public void New_Grid_Returns_Correct_Number_Of_Cells(int size, int expectedNumberOfCells)
		{
			ProductGrid productGrid = new ProductGrid(size);
			Assert.AreEqual(productGrid.Cells.Length, expectedNumberOfCells);
		}

		[Test]
		public void New_Grid_Has_Correct_Number_Of_Rows() {
			ProductGrid productGrid = new ProductGrid(5);
			Assert.AreEqual(productGrid.Cells.GetLength(0), 5);
		}
	}
}
