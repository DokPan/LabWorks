List<string> cars = ["Лого", "Фольцваген", "Мерседес"];
Console.WriteLine("Введите количество добавляемых элементов в список: ");
int carsCount = int.Parse(Console.ReadLine());
for (int i = 0; i < carsCount; i++)
{
    Console.WriteLine("Введите продукт для добавления в список: ");
    cars.Add(Console.ReadLine());
}
for (int i = 0; i < cars.Count; i++)
{
    Console.WriteLine($"{i + 1}-{cars[i]}");
}
Console.WriteLine($"Всего элементов в списке: {cars.Count}");

Dictionary<int, string> dictionary = new()
{
    {1,"Мыло" },
    {2,"Шампунь" },
    {3,"Гель" },
    {4,"Мочалка" },
};
Console.WriteLine("Введите количество добавляемых элементов в словарь: ");
int productsCount = int.Parse(Console.ReadLine());
for (int i = 0; i < productsCount; i++)
{
    Console.WriteLine("Введите ключ:");
    int key = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите значение:");
    string value = Console.ReadLine();
    dictionary[key] = value;
}
foreach (var part in dictionary)
{
    Console.WriteLine($"{part.Key}:{part.Value}");
}
Console.WriteLine($"Всего элементов в словаре : {dictionary.Count}");

Console.WriteLine("Введите ключ:");
int searchKey = int.Parse(Console.ReadLine());
if (dictionary.ContainsKey(searchKey))
{
    Console.WriteLine($"Ключ найден. Значение: {dictionary[searchKey]}");
}
else
{
    Console.WriteLine($"Этого ключа нет в словаре");
}
Console.WriteLine("Введите значение для поиска:");
string searchValue = Console.ReadLine();
int count = 0;
foreach (var product in dictionary.Values)
{
    if (product.Equals(searchValue))
        count++;
}
Console.WriteLine($"Количество совпадений значения:{count}");

Console.WriteLine("Введите ключ для удаления");
int deleteKey = int.Parse(Console.ReadLine());
if (dictionary.Remove(deleteKey))
{
    Console.WriteLine("Элемент удалён");
}
else
{
    Console.WriteLine("Ключ не найден");
}
foreach (var part in dictionary)
{
    Console.WriteLine($"{part.Key}:{part.Value}");
}
Console.WriteLine($"Всего элементов в словаре {dictionary.Count}");

Console.WriteLine("Введите количество добавляемых элементов в список:");
string deleteValue = Console.ReadLine();
cars.RemoveAll(car => car.Equals(deleteValue));
for (int i = 0; i < cars.Count; i++)
{
    Console.WriteLine($"{i + 1}-{cars[i]}");
}
