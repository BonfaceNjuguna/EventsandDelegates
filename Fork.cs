namespace ProductFactory
{
	internal class Fork : IProduct
	{
		public double Price { get; set; }
		public void ShowInfo()
		{
			Console.WriteLine("This is a fork.");
		}
	}
}
