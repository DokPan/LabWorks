/*
enum Category { Food, Drinks, Electronics } // В отдельном файле
*/
struct Product
{
    private string name;
    private string type;
    private double price;
    public Category Category;

    public Product(string name, string type, double price)
    {
        Name = name;
        Type = type;
        Price = price;
        Category = Category.Food;
    }

    public string Name
    {
        get { return name; }
        set
        {
            if (value.Length >= 1)
                name = value;
            else
                Console.WriteLine("Ошибка. Название не может быть пустым.");
        }
    }

    public string Type
    {
        get { return type; }
        set
        {
            if (value.Length >= 1)
                type = value;
            else
                Console.WriteLine("Ошибка. Тип не может быть пустым.");
        }
    }

    public double Price
    {
        get { return price; }
        set
        {
            if (value >= 0)
                price = value;
            else
                Console.WriteLine("Ошибка. Цена не может быть меньше нуля.");
        }
    }

    public void PrintFullInfo()
    {
        Console.WriteLine($"Название: {name} Тип: {type} Цена: {price}");
    }
    public void PrintCategoryInfo()
    {
        Console.WriteLine($"Название: {name} Тип: {type} Цена: {price} Категория: {Category}");
    }
}
