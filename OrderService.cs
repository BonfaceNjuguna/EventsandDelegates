using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsandDelegates
{
	public class OrderService
	{
		public event EventHandler OrderPlaced;

		public void PlaceOrder()
		{
			OnOrderPlaced();
		}

		protected virtual void OnOrderPlaced()
		{
			OrderPlaced?.Invoke(this, EventArgs.Empty);
		}
	}
}
