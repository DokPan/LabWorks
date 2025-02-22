Console.Write("Введите основание (х): ");
if (!double.TryParse(Console.ReadLine(), out double x))
{
    Console.WriteLine("Некорректное значение х");
    return;
}
Console.Write("Введите степень (n): ");
if (!int.TryParse(Console.ReadLine(), out int n))
{
    Console.WriteLine("Некорректное значение n");
    return;
}
double result = Power(x, n);
Console.WriteLine($"{x}^{n} = {result}");

static double Power(double x, int n)
{
    if (n == 0)
        return 1;
    if (n < 0)
        return 1 / Power(x, -n);
    return x * Power(x, n - 1);
}
