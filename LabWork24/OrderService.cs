// Сервис для работы с заказами
public class OrderService
{
    private List<Order> Orders { get; set; } = [];

    public void AddOrder(Order order) => Orders.Add(order);

    public void PrintOrderDetails(int orderId)
    {
        var order = Orders.FirstOrDefault(o => o.Id == orderId);
        if (order == null)
        {
            Console.WriteLine("Указанный заказ не найден.");
            return;
        }
        PrintOrder(order);
    }

    private void PrintOrder(Order order)
    {
        Console.WriteLine($"Order Id: {order.Id}");
        Console.WriteLine($"Стоимость заказа: {order.Total}");
        Console.WriteLine($"Адрес: {order.Address}");
        Console.WriteLine($"Экспресс-доставка: {(order.IsExpress ? "Yes" : "No")}");
    }
}
