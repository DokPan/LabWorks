class Product
{
    private string type;
    private string name;
    private int price;

    public Product() : this("Не указан", "Не указано", 0) { }

    public Product(string type, string name, int price)
    {
        this.type = type;
        this.name = name;
        this.price = price;
    }

    public override string ToString()
    {
        return $"Тип: {type}, Наименование: {name}, Цена: {price}";
    }

    public override bool Equals(object obj)
    {
        if (obj == null || GetType() != obj.GetType())
            return false;
        Product other = (Product)obj;
        return type == other.type &&
               name == other.name &&
               price == other.price;
    }

    public void PrintFullInfo()
       => Console.WriteLine($"Тип: {type}, Наименование: {name}, Цена: {price}");
}
