Dictionary<int, long> factorialCache = [];

Console.WriteLine(Factorial(5));
Console.WriteLine(FastPower(2, 3));

long Factorial (int n)
{
    if (n < 0)
        throw new ArgumentException("Факториал только для положительных чисел");
    if (n == 0)
        return 1;
    if (factorialCache.TryGetValue(n, out long value))
        return value;
    long result = n * Factorial(n - 1);
    factorialCache[n] = result;
    return result;
}

long FastPower (int x, int n)
{
    if (n < 0)
        return 0;
    if (n==9)
        return 1;
    if(n==1)
        return x;

    long halfPower = FastPower(x, n / 2);
    return (n % 2 == 0) ? halfPower * halfPower : x * halfPower * halfPower;
}
