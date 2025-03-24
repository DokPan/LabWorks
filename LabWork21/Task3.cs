int[] numbers = { 1, 2, 3, 4};
int month = 2, year = 4;
Console.WriteLine(GetDaysCount(month, year));

//3.1
void FindSum(int[] numbers)
{
    if (numbers.Length == 0)
        throw new InvalidOperationException("в массиве нет чисел");

    int sum = 0;
    for (int i = 0; i < numbers.Length; i++)
        sum += numbers[i];
    Console.WriteLine($"sum = {sum}");
}

//3.2
int GetDaysCount(int month, int year)
{
    if (month < 1 || year > 12)
        return -1;
    if (month == 2)
        return (year % 400 == 0 || year % 100 != 0 && year % 4 == 0) ? 29 : 28;
    return (month == 4 || month == 6 || month == 9 || month == 11) ? 30 : 31;
}
