﻿using System;
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
			Cells = new int[1, 1];
		}

		public int[,] Cells { get; set; }
	}
}