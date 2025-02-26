//Отдельный файл
/*interface IPrinter
{
    void Print();
}*/
class Product : IPrinter
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

    public void Print()
    {
        Console.WriteLine($"Тип: {Type}, Наименование: {Name}, Цена: {Price}");
    }
}
