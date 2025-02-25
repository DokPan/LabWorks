Product product1 = new("Химия", "Антисептик", 150);
Console.WriteLine(product1);
Console.WriteLine();

Product product2 = new("Химия", "Антисептик", 150);
Product product3 = new("Химия", "Порошок", 150);
Console.WriteLine(product1.Equals(product2));
Console.WriteLine(product1.Equals(product3));
Console.WriteLine();

Rectangle rectangle = new(5, 5);
rectangle.Print();
Console.WriteLine();

ExtendedRandom random = new();
ExtendedRandom random1 = new();
bool[,] arr = random.RandomBoolMassive(2, 3, 20);
Console.WriteLine("Вывод случайного булевого массива");
for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
        Console.WriteLine(arr[i, j] ? "True" : "False");
    Console.WriteLine();
}
