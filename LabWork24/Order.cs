// Класс заказа
public class Order
{
    private double total;
    private string address;

    public int Id { get; set; }

    public double Total
    {
        get => total;
        set
        {
            if (value < 0) throw new ArgumentException("Стоимость заказа не может быть отрицательной.");
            total = value;
        }
    }

    public bool IsExpress { get; set; }

    public string Address
    {
        get => address;
        set
        {
            if (string.IsNullOrWhiteSpace(value)) throw new ArgumentException("Адрес не может быть пустым.");
            address = value;
        }
    }

    public double CalculateTotalPrice()
    {
        const double TaxRate = 0.2;
        double discount = Total > 10000 ? Total * 0.1 : 0;
        double deliveryCost = DeliveryCostCalculator.CalculateDeliveryCost(this);

        return Total - discount + (Total * TaxRate) + deliveryCost;
    }
}
