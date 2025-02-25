class Product
{
    private string type;
    private string name;
    private int price;

    public Product():this("Не сказано","Не сказано",0){}

    public Product(string type, string name, int price)
    {
        this.type = type;
        this.name = name;
        this.price = price;
    }

    public string Type
    {
        get => type;
        set
        {
            if (string.IsNullOrEmpty(value))
                Console.WriteLine("Ошибка, тип не может быть пустым");
            else
                type = value;
        }
    }

    public string Name
    {
        get => name;
        set
        {
            if (string.IsNullOrEmpty(value))
                Console.WriteLine("Ошибка, имя не может быть пустым");
            else
                name = value;
        }
    }

    public int Price
    {
        get => price;
        set
        {
            if (value < 0)
                Console.WriteLine("Ошибка, цена не может быть меньше нуля");
            else
                price = value;
        }
    }

    public void PrintFullInfo()
        => Console.WriteLine($"Тип: {Type}, Наименование: {Name}, Цена: {Price}");
}
