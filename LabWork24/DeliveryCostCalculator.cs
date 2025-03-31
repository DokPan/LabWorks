// Вспомогательный класс для расчета доставки
public static class DeliveryCostCalculator
{
    private const double FreeDeliveryThreshold = 3000;
    private const double FixDeliveryThreshould = 1000;
    private const double FixDeliveryCost = 230;

    public static double CalculateDeliveryCost(Order order)
    {
        if (order.Total < FixDeliveryThreshould)
            return order.Total;

        if (order.Total < FreeDeliveryThreshold)
            return FixDeliveryCost;

        return 0;
    }
}
