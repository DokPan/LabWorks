int[] array = { 100, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
int result = LinearSearch(array, 100);
if (result != -1)
    Console.WriteLine($"Элемент по индексу i: {result}");
else
    Console.WriteLine($"Элемент не найден");

static int LinearSearch(int[] array, int value)
{
    for (int i = 0; i < array.Length; i++)
        if (array[i] == value)
            return i;
    return -1;
}
