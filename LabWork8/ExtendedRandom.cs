class ExtendedRandom : Random
{
    public bool[,] RandomBoolMassive(int line, int colum, int percentF)
    {
        if (percentF < 0 || percentF > 100)
            Console.WriteLine("Процент False должен быть от 0 до 100");
        bool[,] arr = new bool[line, colum];
        for (int i = 0; i < line; i++)
        {
            for (int j = 0; j < colum; j++)
            {
                arr[i, j] = Next(100) >= percentF;
            }
        }
        return arr;
    }
}
