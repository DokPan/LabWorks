//Построчное чтение файла
Console.Write("Введите имя файла: ");
string fileName = Console.ReadLine();

if (!File.Exists(fileName))
{
    Console.WriteLine("Файл не найден.");
    return;
}

Console.Write("Введите текст для поиска: ");
string searchText = Console.ReadLine();

string[] lines = File.ReadAllLines(fileName);
Console.WriteLine("Найденные строки:");
for (int i = 0; i < lines.Length; i++)
{
    if (lines[i].Contains(searchText, StringComparison.OrdinalIgnoreCase))
        Console.WriteLine($"{i + 1}: {lines[i]}");
}
