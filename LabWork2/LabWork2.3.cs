int[] array = { 0, 10, 20, 300, 400, 500, 6000, 7000, 8000, 90000 };
int result = JumpPointSearch(array, 90000);
if (result != -1)
    Console.WriteLine($"Номер элемента, найденного алгоритмом поиска прыжками: {result}");
else
    Console.WriteLine($"Элемент не найден");

static int JumpPointSearch(int[] array, int elementToSearch)
{
    int jumpStep = (int)Math.Floor(Math.Sqrt(array.Length));
    int previousStep = 0;
    //int nextStep = jumpStep;

    while (array[Math.Min(jumpStep, array.Length) - 1] < elementToSearch)
    {
        previousStep = jumpStep;
        jumpStep += jumpStep;
        if (array[previousStep] > elementToSearch)
            return -1;
    }

    while (array[previousStep] < elementToSearch)
    {
        previousStep++;
        if (previousStep == Math.Min(jumpStep, array.Length))
            return -1;
    }

    if (array[previousStep] == elementToSearch)
        return previousStep;
    return -1;
}
