Product product1 = new();
Product product2 = new("Мыло", "Химия", 130);
product1.PrintFullInfo();
product2.PrintFullInfo();
Console.WriteLine();

Product product3 = new("", "", -1);
Product product4 = new("Шампунь", "Химия", 180);
product4.PrintFullInfo();
Console.WriteLine();

Product product5 = new("Слойка", "Выпечка", 80);
product5.PrintCategoryInfo();
Console.WriteLine();

Product[] products = {
    new Product("Тортик", "Еда", 110),
    new Product("Шаньга", "Еда", 60),
    new Product("Хачапури", "Еда", 60)
};
Console.WriteLine("Введите категорию для поиска: ");
if (Enum.TryParse(Console.ReadLine(), out Category searchCategory))
{
    Console.WriteLine($"Товары категории {searchCategory}: ");
    foreach (var product in products)
    {
        if (product.Category == searchCategory)
            product.PrintCategoryInfo();
    }
}
else
    Console.WriteLine("Ошибка. Некорректная категория.");
Console.WriteLine();

Patients patient1 = new("Гриш Григорий Григорьевич", 2023865123, 1999);
Patients patient2 = new("Гриш Григорий Григорьевич", 2023865123, 1999);
Patients patient3 = new("Гришева Григория Григорьевна", 292933528, 1995);
Console.WriteLine(patient1);
Console.WriteLine($"Пациент №1 = Пациент №2; {patient1.Equals(patient2)}");
Console.WriteLine($"Пациент №2 = Пациент №3; {patient2.Equals(patient3)}");
