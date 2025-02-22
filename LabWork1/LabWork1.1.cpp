int[] array = { 7, 0, -4, 3, 1, -2, 5 };
Console.WriteLine("Массив до сортировки методом Selection Sort: ");
PrintArray(array);
SelectionSort(array);
Console.WriteLine("Отсортированный массив методом Selection Sort: ");
PrintArray(array);

static void SelectionSort(int[] array) //O(n^2)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minElementIndex = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minElementIndex])
            {
                minElementIndex = j;
            }
        }
        if (minElementIndex != i)
        {
            int temp = array[minElementIndex];
            array[minElementIndex] = array[i];
            array[i] = temp;
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
