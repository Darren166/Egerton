using Egerton.GridSupport;
using NUnit.Framework;
using System;

namespace Egerton.Tests
{
	[TestFixture]
	public class GridTests
	{
		[Test]
		public void New_Grid_Returns_Correct_Number_Of_Cells()
		{
			ProductGrid productGrid = new ProductGrid(5);
			Assert.AreEqual(productGrid.Cells.Length, 25);
		}
	}
}
