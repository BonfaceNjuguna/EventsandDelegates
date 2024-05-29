namespace ProductFactory
{
	internal class Program
	{
		private static void Main()
		{
			IProduct spoon = ProductFactory.CreateProduct<Spoon>();
			spoon.Price = 10.0;

			IProduct fork = ProductFactory.CreateProduct<Fork>();
			fork.Price = 20.0;

			if(spoon.IsCheaperThan(fork))
			{
				Console.WriteLine("The spoon is cheaper");
			}
			else
			{
				Console.WriteLine("The fork is cheaper");
			}
		}
	}
}
