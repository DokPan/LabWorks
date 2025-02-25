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

    public static Product operator ++(Product product)
    {
        return new Product(product.type, product.name, product.price + 1);
    }

    public static Product operator +(Product product1, Product product2)
    {
        return new Product(product1.type, product1.name, product1.price + product2.price);
    }

    public static bool operator ==(Product product1, Product product2)
    {
        return product1.type == product2.type &&
            product1.name == product2.name && 
            product1.price == product2.price;
    }

    public static bool operator !=(Product product1, Product product2)
    {
        return product1.type != product2.type ||
            product1.name != product2.name || 
            product1.price != product2.price;
    }

    public static bool operator true(Product product)
    {
        return product.price >= 0;
    }

    public static bool operator false(Product product)
    {
        return product.price < 0;
    }

    public void PrintFullInfo()
       => Console.WriteLine($"Тип: {type}, Наименование: {name}, Цена: {price}");
}
