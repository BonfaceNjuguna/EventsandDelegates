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

		public static int CountVowels(this string str)
		{
			if(str == null) return 0;
			char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U'};
			return str.Count(c => vowels.Contains(c));
		}
	}
}
