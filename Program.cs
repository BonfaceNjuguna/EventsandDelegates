namespace ProductFactory
{
	internal class Program
	{
		private static void Main()
		{
			IProduct spoon = ProductFactory.CreateProduct<Spoon>();
			IProduct fork = ProductFactory.CreateProduct<Fork>();
		}
	}
}
