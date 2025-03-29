// Поиск и вывод списка файлов на экран
Console.Write("Введите путь к папке: ");
string folderPath = Console.ReadLine();
DirectoryInfo directory = new(folderPath);
if (!directory.Exists)
{
    Console.WriteLine("Указанная папка не существует.");
    return;
}

Console.Write("Введите часть имени файла для поиска: ");
string searchPattern = Console.ReadLine();

FileInfo[] files = directory.GetFiles($"*{searchPattern}*", SearchOption.AllDirectories);

if (files.Length == 0)
{
    Console.WriteLine("Файлы не найдены.");
    return;
}

Console.WriteLine("Найденные файлы:");
for (int i = 0; i < files.Length; i++)
{
    Console.WriteLine($"{files[i].Name} - {files[i].Length} байт");
}
