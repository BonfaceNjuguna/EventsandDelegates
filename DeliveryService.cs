using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsandDelegates
{
	public class DeliveryService
	{
		public void DeliverArticles(object sender, EventArgs e)
		{
			Console.WriteLine("Articles are being delivered");
		}
	}
}
