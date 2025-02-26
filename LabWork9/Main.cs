Product product1 = new("Химия", "Антисептик", 150);
product1.Print();
Console.WriteLine();

Rectangle figura = new(5, 5,"");
figura.Print();
Console.WriteLine();

IPrinter printer;
printer = new Product("Химия", "Поршок", 80);
printer.Print();
Console.WriteLine();
printer = new Rectangle(4, 2,"Прямоугольник");
printer.Print();
Console.WriteLine();

IPrinter[] printers = {
    new Product("Лекарства", "Парацетамол",110),
    new Product("Лекарства", "Нурофен", 60),
    new Rectangle(6, 2,""),
    new Rectangle(4, 8,"")
};
foreach (var item in printers)
{
    item.Print();

    if (item is IFigure figure)
    {
        Console.WriteLine($"Это фигура:");
    }
    Console.WriteLine();
}
