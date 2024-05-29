namespace ProductFactory
{
	internal class ProductFactory
	{
		private readonly ProductCreated<IProduct> _productCreated;

		public ProductFactory(ProductCreated<IProduct> productCreated)
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
