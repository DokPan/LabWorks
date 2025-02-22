Console.WriteLine("Введите элементы массива через пробел: ");
string input = Console.ReadLine();
int[] array = ParseArray(input);
if (array.Length < 3)
{
    Console.WriteLine("Недостаточно элементов в массиве");
    return;
}
int localMaxElement = FindFirstLocalMax(array);
if (localMaxElement != -1)
    Console.WriteLine($"Первый максимум {array[localMaxElement]} (индекс {localMaxElement})");
else
    Console.WriteLine("Максимум не найден");
static int FindFirstLocalMax(int[] array)
{
    for (int i = 1; i < array.Length - 1; i++)
    {
        if (array[i] > array[i - 1] && array[i] > array[i + 1])
            return i;
    }
    return -1;
}

static int[] ParseArray(string input)
{
    string[] parts = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
    int[] array = new int[parts.Length];
    for (int i = 0; i < parts.Length; i++)
    {
        if (int.TryParse(parts[i], out int value))
            array[i] = value;
        else
        {
            Console.WriteLine("Некорректное значение в массиве");
            return new int[0];
        }
    }
    return array;
}
