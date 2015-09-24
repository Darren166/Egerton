using Egerton.GridSupport;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Egerton
{
	class Program
	{
		static void Main(string[] args)
		{
			int size = 1;
			while (size != 0)
			{
				Console.WriteLine();
				Console.WriteLine("Type a size for the grid and press return, 0 or non number to exit");
				int.TryParse(Console.ReadLine(), out size);
				Console.WriteLine();
	
				var productGrid = new ProductGrid(size);
				for (int row = 0; row < productGrid.Cells.GetLength(0); row++)
				{
					for (int column = 0; column < productGrid.Cells.GetLength(1); column++)
					{
						Console.Write(productGrid.Cells[row, column].ToString().PadLeft(8));
					}
					Console.WriteLine();
				}
			}
		}
	}
}
