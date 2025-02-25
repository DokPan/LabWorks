int[] array = { 0,1, 2, 3, 4, 5, 6, 7, 8};
int result = BinarySearch(array, 8);
if (result != -1)
    Console.WriteLine($"Номер элемента массива отталкиваясь от среднего элемента: {result}");
else
    Console.WriteLine($"Элемент не найден");

static int BinarySearch(int[] array, int value)
{
    int left = 0;
    int right = array.Length;
    while (left < right)
    {
        int middle = (left + right) / 2;

        if (array[middle] == value)
            return middle;
        if (array[middle] > value)
            right = middle;
        else
            left = middle + 1;
    }
    return -1;
}
