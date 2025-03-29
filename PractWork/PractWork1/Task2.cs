//Запись текста в файл
using System.Text;

Console.Write("Введите имя файла: ");
string writeFileName = Console.ReadLine();

if (!File.Exists(writeFileName))
    Console.WriteLine("Файл не найден. Будет создан новый файл.");
else
    Console.WriteLine("Файл открыт для дозаписи.");

Console.WriteLine("Введите строки (для завершения введите 'end'):");
string input;
StringBuilder stringBuilder = new();
while (true)
{
    input = Console.ReadLine();
    if (input.ToLower() == "end")
        break;
    stringBuilder.AppendLine(input);
}

File.AppendAllText(writeFileName, stringBuilder.ToString()); 
Console.WriteLine("Данные записаны в файл.");
