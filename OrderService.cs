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
