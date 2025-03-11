List<string> cars = ["Лого", "Фольцваген", "Мерседес"];
Console.WriteLine("Введите количество добовляемых элементов в список");
int carsCount = int.Parse(Console.ReadLine());
for (int i = 0; i < carsCount; i++)
{
    Console.WriteLine("Введите продукт для добавления в список");
    cars.Add(Console.ReadLine());
}
for (int i = 0; i < cars.Count; i++)
{
    Console.WriteLine($"\n{i + 1}-{cars[i]}");
}
Console.WriteLine($"Всего элементов в списке {cars.Count}");

Dictionary<int, string> dictionary = new()
{
    {1,"Мыло" },
    {2,"Шампунь" },
    {3,"Гель" },
    {4,"Мочалка" },
};
Console.WriteLine("\nВведите количество добовляемых элементов в словарь");
int productsCount = int.Parse(Console.ReadLine());
for (int i = 0; i < productsCount; i++)
{
    Console.WriteLine("Введите ключ");
    int key = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите значение");
    string value = Console.ReadLine();
    dictionary[key] = value;
}
foreach (var part in dictionary)
{
    Console.WriteLine($"{part.Key}:{part.Value}");
}
Console.WriteLine($"\nВсего элементов в словаре {dictionary.Count}");

Console.WriteLine("\nВведите ключ");
int searchKey = int.Parse(Console.ReadLine());
if (dictionary.ContainsKey(searchKey))
{
    Console.WriteLine($"Ключ найден. Значение {dictionary[searchKey]}");
}
else
{
    Console.WriteLine($"\nЭтого ключа нет в словаре");
}
Console.WriteLine("\nВведите значение для поиска");
string searchValue = Console.ReadLine();
int count = 0;
foreach (var product in dictionary.Values)
{
    if (product.Equals(searchValue))
        count++;
}
Console.WriteLine($"\nКолличество совпадений значения{count}");

Console.WriteLine("\nВведите ключ для удаления");
int deleteKey = int.Parse(Console.ReadLine());
if (dictionary.Remove(deleteKey))
{
    Console.WriteLine("\nЭлемент удалён");
}
else
{
    Console.WriteLine("\nКлюч не найден");
}
foreach (var part in dictionary)
{
    Console.WriteLine($"{part.Key}:{part.Value}");
}
Console.WriteLine($"\nВсего элементов в словаре {dictionary.Count}");

Console.WriteLine("\nВведите количество добовляемых элементов в список");
string deleteValue = Console.ReadLine();
cars.RemoveAll(car => car.Equals(deleteValue));
for (int i = 0; i < cars.Count; i++)
{
    Console.WriteLine($"\n{i + 1}-{cars[i]}");
}
