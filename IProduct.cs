﻿namespace ProductFactory
{
	internal interface IProduct
	{
		void ShowInfo();
		double Price { get; set; }
	}
}
