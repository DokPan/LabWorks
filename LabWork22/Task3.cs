var task1 = ReadFileAsync("numbers1.txt");
var task2 = ReadFileAsync("numbers2.txt");
var task3 = ReadFileAsync("numbers3.txt");
await Task.WhenAll(task1, task2, task3); 

static async Task ReadFileAsync(string fileName)
{
    Console.WriteLine($"Чтение из файла {fileName} начато.");

    using StreamReader reader = new(fileName);
    string line;
    while ((line = await reader.ReadLineAsync()) != null)
        Console.WriteLine($"{fileName}: {line}");

    Console.WriteLine($"Чтение из файла {fileName} закончено.");
}
