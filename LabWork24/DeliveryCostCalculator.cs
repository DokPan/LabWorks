// Вспомогательный класс для расчета стоимости доставки
public static class DeliveryCostCalculator
{
    private const double FreeDeliveryThreshold = 3000;
    private const double SmallOrderDeliveryCost = 230;

    public static double CalculateDeliveryCost(Order order)
    {
        if (order.Total < 1000) return order.Total;
        if (order.Total < FreeDeliveryThreshold) return SmallOrderDeliveryCost;
        return 0;
    }
}
