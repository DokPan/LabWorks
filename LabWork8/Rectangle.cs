class Rectangle : Figure
{
    public int Length { get; set; }
    public int Width { get; set; }

    public Rectangle() : this(1, 1) { }

    public Rectangle(int length, int width)
    {
        this.Length = length;
        this.Width = width;
    }

    public sealed override string Name
        => "Прямоугольник";

    public override int GetSquare() { return Length * Width; }

    public override int GetPerimetr() { return 2 * (Width + Length); }

    public override void Print()
    {
        Console.WriteLine($"Название: {Name}");
        Console.WriteLine($"Длина: {Length}");
        Console.WriteLine($"Ширина: {Width}");
        Console.WriteLine($"Площадь: {GetSquare()}");
        Console.WriteLine($"Периметр: {GetPerimetr}");
    }
}
