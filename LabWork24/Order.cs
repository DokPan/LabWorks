// Класс заказа
public class Order
{
    private double total;
    private string address;
    const double TaxRate = 0.2;
    const double DiscountThreshold = 10000;
    const double Discount = 0.1;

    public double Total
    {
        get => total;
        set
        {
            if (value < 0)
                throw new ArgumentException("Стоимость заказа не может быть отрицательной");
            total = value;
        }
    }

    public string Address
    {
        get => address;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Адрес не может быть пустым");
            address = value;
        }
    }

    public int Id { get; set; }

    public bool IsExpress { get; set; }

    public double CalculateTotalPrice()
    {
        double discount = Total > DiscountThreshold ? Total * Discount : 0;
        double deliveryCost = DeliveryCostCalculator.CalculateDeliveryCost(this);

        return Total - discount + Total * TaxRate + deliveryCost;
    }
}
