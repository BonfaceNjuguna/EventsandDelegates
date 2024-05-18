namespace ProductFactory
{
	internal static class ProductFactory
	{
		public static T CreateProduct<T>() where T : IProduct, new()
		{
			T product = new T();
			product.ShowInfo();
			return product;
		}
	}
}
