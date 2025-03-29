OrderService orderService = new();

var order = new Order { Id = 1, Total = 1200, IsExpress = true, Address = "Папанина, 24" };
orderService.AddOrder(order);

orderService.PrintOrderDetails(order.Id);

Console.WriteLine("Полная стоимость: " + order.CalculateTotalPrice());
