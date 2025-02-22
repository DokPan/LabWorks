Console.Write("Введите число для вычисления факториала: ");
string input = Console.ReadLine();
if (int.TryParse(input, out int number))
{
    int result = Factorial(number);
    Console.WriteLine($"Факториал числа {number} равен {result}");
}
else
    Console.WriteLine("Некорректное значение, результат = 0");

static int Factorial(int number)
{
    if (number < 0)
        return 0;
    if (number == 0 || number == 1)
        return 1;
    return number * Factorial(number - 1);
}
/*Debug.Assert(Factorial(4) == 24);
Debug.Assert(Factorial(-1) == -1);
Debug.Assert(Factorial(1) == 1);
Debug.Assert(Factorial(0) == 1);*/
