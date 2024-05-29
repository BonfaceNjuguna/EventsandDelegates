namespace ProductFactory
{
	internal class ProductFactory
	{
		public event EventHandler<IProduct>? ProductCreatedEvent;

		public T CreateProduct<T>() where T : IProduct, new()
		{
			T product = new T();
			product.ShowInfo();
			OnProductCreated(product);
			return product;
		}

		protected virtual void OnProductCreated(IProduct product)
		{
			ProductCreatedEvent?.Invoke(this, product);
		}
	}
}
