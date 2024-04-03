using EventsandDelegates;

class Program
{
    static void Main(string[] args)
    {
		OrderService orderService = new OrderService();
		DeliveryService deliveryService = new DeliveryService();
		NotificationService notificationService = new NotificationService();

		orderService.OrderPlaced += deliveryService.DeliverArticles;
		orderService.OrderPlaced += notificationService.NotifyCustomer;

		orderService.PlaceOrder();
    }
}