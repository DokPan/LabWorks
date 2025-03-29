await CalculatePowerAsync(3, 3);
await CalculatePowerAsync(6, 2);
await CalculatePowerAsync(9, 1);
Console.WriteLine();

var task1 = CalculatePowerAsync(13, 3);
var task2 = CalculatePowerAsync(16, 2);
var task3 = CalculatePowerAsync(19, 1);
await Task.WhenAll(task1, task2, task3);
Console.WriteLine();

static async Task CalculatePowerAsync(double a, int x)
{
    await Task.Run(() => CalculatePower(a, x));
}

static void CalculatePower(double a, int x)
{
    Console.WriteLine($"{a}^{x}={Math.Pow(a, x)}");
}
