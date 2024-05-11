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
