await WriteRandomNumbersAsync("numbers.txt", 250000);
Console.WriteLine("Конец программы.");

static async Task WriteRandomNumbersAsync(string fileName, int numbersCount)
{
    Console.WriteLine($"Запись в файл {fileName} начата.");

    Random random = new();
    using StreamWriter writer = new(fileName, false);

    for (int i = 1; i <= numbersCount; i++)
        await writer.WriteLineAsync($"Число {i}: {random.Next(1, 10_000)}");

    Console.WriteLine($"Запись в файл {fileName} закончена.");
}
