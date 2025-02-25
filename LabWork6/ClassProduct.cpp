class Product
{
    private string type;
    private string name;
    private int price;

    public Product():this("Не указан","Не указано",0){}

    public Product(string type, string name, int price)
    {
        this.type = type;
        this.name = name;
        this.price = price;
    }

    public object? this[string index]
    {
        get
        {
            return index.ToLower() switch
            {
                "type" => type,
                "name" => name,
                "price" => price,
                _=> null
            };
        }
    }

    public char? this[int index]
    {
        get
        {
            if (index >= 0 && index < type.Length)
                return type[index];
            return null;
        }
    }

    public void PrintFullInfo()
       => Console.WriteLine($"Тип: {type}, Наименование: {name}, Цена: {price}");
}
