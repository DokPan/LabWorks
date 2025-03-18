//отдельный файл
delegate void MathOperations(int x,int y);
//
MathOperation mathOperations = (a, b) => Console.WriteLine($"Сумма: {a + b}");
mathOperations += (a, b) => Console.WriteLine($"Разность: {a - b}");
mathOperations += (a, b) => Console.WriteLine($"Произведение: {a * b}");
mathOperations += (a, b) =>
{
    if (b != 0)
        Console.WriteLine($"Частное: {a / (double)b}");
    else
        Console.WriteLine("Деление на 0 невозможно");
};

Console.WriteLine("Введите два числа: ");
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());

mathOperations(a, b);
