Product defaultProduct = new Product();
Console.WriteLine("Объект, созданный конструктором по умолчанию:");
defaultProduct.PrintFullInfo();
Console.WriteLine();
Product parametrProduct = new Product("Электроника", "Чайник", 3500);
Console.WriteLine("Объект, созданный конструктором:");
parametrProduct.PrintFullInfo();
Console.WriteLine();
Product correctProduct = new Product("Продовольственное", "Булочка", 150);
Console.WriteLine("Объект, с корректными значениями:");
correctProduct.PrintFullInfo();
Console.WriteLine();
Product _ = new Product("", "", -81732);
Console.WriteLine();

Product[] products =
[
    new("Продовольственное", "Булочка", 150),
    new("Продовольственное", "Пышка", 220),
    new("Электроника", "Чайник", 3500),
    new("Электроника", "Кофеварка", 15000),
    new("Химия", "Стклоотчиститель", 450)
];
Console.WriteLine("Список всех товаров: ");
foreach (Product product in products)
    product.PrintFullInfo();
Console.WriteLine();

Console.WriteLine("Введите тип товара для поиска:");
string searchType = Console.ReadLine();
Console.WriteLine($"Товар(ов) типа {searchType} найден(о): ");
foreach (Product product in products)
{
    if (product.Type == searchType)
        product.PrintFullInfo();
}
Console.WriteLine();

Console.WriteLine("Введите минимальную и максимальную цену: ");
int minPrice = int.Parse(Console.ReadLine());
int maxPrice = int.Parse(Console.ReadLine());
Console.WriteLine($"Товар(ов) по цене от {minPrice} руб. до {maxPrice} руб. найден(о):");
foreach (Product product in products)
{
    if (product.Price >= minPrice && product.Price <= maxPrice)
        product.PrintFullInfo();
}
