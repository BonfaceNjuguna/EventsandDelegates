using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductFactory
{
	internal static class ProductExtensions
	{
		public static bool IsCheaperThan(this IProduct product, IProduct otherProduct)
		{
			return product.Price < otherProduct.Price;
		}
	}
}
