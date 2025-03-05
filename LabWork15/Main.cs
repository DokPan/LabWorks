// 1 задание
Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());

MathOperation mathOperation = x => x * x;
Console.WriteLine($"Квадрат: {mathOperation(number)}");

mathOperation = x =>
{
    int result = 1;
    for (int i = 2; i <= x; i++)
        result *= x;
    return result;
};
Console.WriteLine($"Факториал: {mathOperation(number)}");

mathOperation = x => x < 0 ? -x : x;
Console.WriteLine($"Модуль: {mathOperation(number)}");
Console.WriteLine();
// 4 задание
static int Square(int x) => x * x;

static int Factorial(int x)
{
    int result = 1;
    if (x < 0)
        return -1;
    for (int i = 2; i <= x; i++)
        result *= x;
    return result;
};

static int Absolute(int x) => x < 0 ? -x : x;

MathOperation[] operations = { Square, Factorial, Absolute };

foreach (var operation in operations)
    Console.WriteLine($"Результат: {operation(number)}");
Console.WriteLine();
// 5 задание
static void ProcessDelegate(MathOperation operation, int x) => Console.WriteLine($"Результат: {operation(x)}");

foreach (var operation in operations)
    ProcessDelegate(operation, number);
