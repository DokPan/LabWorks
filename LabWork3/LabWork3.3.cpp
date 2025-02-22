Console.Write("Введите основание (х): ");
if (!double.TryParse(Console.ReadLine(), out double x))
{
    Console.WriteLine("Некорректное значение х");
    return;
}
Console.Write("Введите степень (n): ");
if (!int.TryParse(Console.ReadLine(), out int n) || n < 0)
{
    Console.WriteLine("Некорректное значение n");
    return;
}
double result = FastPower(x, n);
Console.WriteLine($"{x}^{n} = {result}");

static double FastPower(double x, int n)
{
    if (n == 0)
        return 1;
    if (n < 0)
        return -1;
    if (n == 1)
        return x;

    double half = FastPower(x, n / 2);
    if (n % 2 == 0)
        return half * half;
    else
    {
        half = FastPower(x, n - 1);
        return half * x;
    }
}
