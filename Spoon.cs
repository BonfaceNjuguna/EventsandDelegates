namespace ProductFactory
{
	internal class Spoon : IProduct
	{
		public double Price { get; set; }
		public void ShowInfo()
		{
			Console.WriteLine("This is a spoon.");
		}
	}
}
