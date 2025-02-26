class Product : IComparable, IComparable<Product>, IEquatable<Product>,ICloneable
{
    public string Type;
    public string Name;
    public int Price;

    public Product(string type, string name, int price)
    {
        Type = type;
        Name = name;
        Price = price;
    }

    public int CompareTo(object? obj)
    {
        return Price.CompareTo(obj);
    }

    public int CompareTo(Product? other)
    {
        return Price.CompareTo(other?.Price);
    }

    public bool Equals(Product? product)
    {
        if (product == null)
            return false;
        return Type == product.Type && Name == product.Name && Price == product.Price;
    }

    public object Clone()
    {
        return new Product(Type, Name, Price);
    }

    public void PrintFullInfo()
       => Console.WriteLine($"Тип: {Type}, Наименование: {Name}, Цена: {Price}");
}
