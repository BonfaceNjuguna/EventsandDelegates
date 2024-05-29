namespace ProductFactory
{
	//declare delegate outside of the class
	internal delegate void ProductCreated<T>(T product) where T : IProduct;

	internal interface IProduct
	{
		void ShowInfo();
		double Price { get; set; }
		string Description { get; set; }
	}
}
