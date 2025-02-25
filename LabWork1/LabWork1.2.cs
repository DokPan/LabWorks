int[] array = { 7, 0, -4, 3, 1, -2, 5 };
Console.WriteLine("Массив до сортировки методом Bubble Sort: ");
PrintArray(array);
BubbleSort(array);
Console.WriteLine("Отсортированный массив методом Bubble Sort: ");
PrintArray(array);

static void BubbleSort(int[] array) //O(n^2)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        for (int j = array.Length - 1; j >= 1; j--)
        {
            if (array[j] < array[j - 1])
            {
                int temp = array[j];
                array[j] = array[j - 1];
                array[j - 1] = temp;
            }
        }
        PrintArray(array);
    }
}

static void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}\t");
    }
    Console.WriteLine();
}
