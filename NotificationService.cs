using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsandDelegates
{
	public class NotificationService
	{
		public void NotifyCustomer(object sender, EventArgs eventArgs)
		{
			Console.WriteLine("Customer has been notified");
		}
	}
}
