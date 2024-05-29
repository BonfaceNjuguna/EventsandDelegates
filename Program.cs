namespace ProductFactory
{
	internal class Program
	{
		private static void Main()
		{
			ProductFactory productFactory = new ProductFactory();
			productFactory.ProductCreatedEvent += OnProductCreated;

			IProduct spoon = productFactory.CreateProduct<Spoon>();
			spoon.Price = 10.0;
			spoon.Description = "This is a spoon used for eAting";
			int spoonVowelCount = spoon.Description.CountVowels();
			Console.WriteLine($"The spoon description has {spoonVowelCount} vowels");

			IProduct fork = productFactory.CreateProduct<Fork>();
			fork.Price = 20.0;
			fork.Description = "This is a fork used for eating";
			int forkVowelCount = fork.Description.CountVowels();
			Console.WriteLine($"The fork description has {forkVowelCount} vowels");

			if(spoon.IsCheaperThan(fork))
			{
				Console.WriteLine("The spoon is cheaper");
			}
			else
			{
				Console.WriteLine("The fork is cheaper");
			}
		}

		private static void OnProductCreated(object? sender, IProduct product)
		{
			Console.WriteLine($"Product created: {product.GetType().Name}");
		}
	}
}
