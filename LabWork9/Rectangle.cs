// Отдельный файл
/*interface IFigure
{
    void PrintInfo();
    public double GetSquare();
    public double GetPerimeter();
    public string FigureName { get => "Фигура"; }
}*/
class Rectangle : IFigure, IPrinter
{
    public int Length { get; set; }
    public int Width { get; set; }
    private string Name { get; set; }
    public string FigureName => Name;

    public Rectangle(int length, int width, string name)
    {
        Length = length;
        Width = width;
        Name = name;
    }

    public int GetSquare() => Length * Width;

    public int GetPerimetr() => (Width + Length) * 2;

    public void Print()
    {
        Console.WriteLine($"Название: {Name}");
        Console.WriteLine($"Длина: {Length}");
        Console.WriteLine($"Ширина: {Width}");
    }

    public void PrintInfo()
    {
        Console.WriteLine($"Название: {Name}");
        Console.WriteLine($"Длина: {Length}");
        Console.WriteLine($"Ширина: {Width}");
        Console.WriteLine($"Площадь: {GetSquare()}");
        Console.WriteLine($"Периметр: {GetPerimetr}");
    }

    double IFigure.GetSquare()
    {
        throw new NotImplementedException();
    }

    public double GetPerimeter()
    {
        throw new NotImplementedException();
    }
}
