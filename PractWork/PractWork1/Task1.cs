//Чтение данныых из файла
Console.Write("Введите имя файла: ");
string readFileName = Console.ReadLine();

if (File.Exists(readFileName))
{
    string content = File.ReadAllText(readFileName);
    Console.WriteLine("Содержимое файла:");
    Console.WriteLine(content);
}
else
    Console.WriteLine("Файл не найден.");
