// Исключение для заказов
public class OrderException : Exception
{
    public OrderException(string message) : base(message) { }
}
