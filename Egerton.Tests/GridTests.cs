﻿using Egerton.GridSupport;
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

		[TestCase(1, new int[] { 2 })]
		[TestCase(15, new int[] { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47 })]
		[TestCase(20, new int[] { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71 })]
		public void First_Row_In_Grid_Contains_Primes(int size, int[] expectedPrimes)
		{
			// Given a grid
			ProductGrid productGrid = new ProductGrid(size);

			// When the first row is extracted
			int[] actualValues = Enumerable.Range(0, size).Select(index => productGrid.Cells[0, index]).ToArray();

			// Then they should be sequential primes
			Assert.AreEqual(actualValues, expectedPrimes);
		}

		[TestCase(1, new int[] { 2 })]
		[TestCase(15, new int[] { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47 })]
		[TestCase(20, new int[] { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71 })]
		public void First_Column_In_Grid_Contains_Primes(int size, int[] expectedPrimes)
		{
			// Given a grid
			ProductGrid productGrid = new ProductGrid(size);

			// When the first row is extracted
			int[] actualValues = Enumerable.Range(0, size).Select(index => productGrid.Cells[index, 0]).ToArray();

			// Then they should be sequential primes
			Assert.AreEqual(actualValues, expectedPrimes);
		}

		[TestCase(5, 1, 3)]
		[TestCase(15, 11, 3)]
		[TestCase(15, 3, 11)]
		[TestCase(55, 23, 33)]
		public void Non_Header_Cells_Are_Multiples_Of_Their_First_Row_And_Column(int size, int rowIndex, int columnIndex)
		{
			// Given a grid
			ProductGrid productGrid = new ProductGrid(size);

			// When a particular cell is extracted
			int actualCellValue = productGrid.Cells[rowIndex, columnIndex];

			// Then it is a product of the first column and row
			int expectedValue = productGrid.Cells[0, columnIndex] * productGrid.Cells[rowIndex, 0];
			Assert.AreEqual(expectedValue, actualCellValue);
		}

	}
}
