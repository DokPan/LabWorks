int[] array = { 7, 0, -4, 3, 1, -2, 5 };
Console.WriteLine("Массив до сортировки методом Insertion Sort: ");
PrintArray(array);
InsertionSort(array);
Console.WriteLine("Отсортированный массив методом Insertion Sort: ");
PrintArray(array);

static void InsertionSort(int[] array) //O(n^2)
{
    for (int i = 1; i < array.Length; i++)
    {
        int key = array[i];
        int j = i - 1;
        while (j >= 0 && array[j] > key)
        {
            array[j + 1] = array[j];
            j--;
        }
        array[j + 1] = key;
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
