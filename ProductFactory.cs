namespace ProductFactory
{
	internal class ProductFactory
	{
		private readonly Action<IProduct> _productCreated;

		public ProductFactory(Action<IProduct> productCreated)
		{
			_productCreated = productCreated;
		}

		public T CreateProduct<T>() where T : IProduct, new()
		{
			T product = new T();
			product.ShowInfo();
			_productCreated?.Invoke(product);
			return product;
		}
	}
}
