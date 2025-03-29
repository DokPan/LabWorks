using System.Threading;
var cts = new CancellationTokenSource(TimeSpan.FromSeconds(2));
try
{
    await ReadFileWithCancelAsync("numbers.txt", cts.Token);
}
catch (OperationCanceledException)
{
    Console.WriteLine("Операция была отменена.");
}
catch (Exception ex)
{
    Console.WriteLine($"Неожиданная ошибка: {ex.Message}");
}

static async Task ReadFileWithCancelAsync(string fileName, CancellationToken token)
{
    Console.WriteLine($"Чтение {fileName} начато.");

    try
    {
        using StreamReader reader = new(fileName);
        string line;

        while ((line = await reader.ReadLineAsync()) != null)
        {
            token.ThrowIfCancellationRequested();

            await Task.Delay(700);
            Console.WriteLine($"{fileName}: {line}");
        }

        Console.WriteLine($"Чтение {fileName} закончено.");
    }
    catch (OperationCanceledException)
    {
        Console.WriteLine($"Чтение {fileName} отменено.");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Ошибка при чтении {fileName}: {ex.Message}");
    }
}
