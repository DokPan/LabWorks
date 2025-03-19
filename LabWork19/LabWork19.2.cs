// IShape.cs
interface IShape
{
    void Draw();
}
//

// Circle.cs
class Circle : IShape
{
    public void Draw() => Console.WriteLine("Inside Circle::draw() method.");
}
//

// Square.cs
class Square : IShape
{
    public void Draw() => Console.WriteLine("Inside Square::draw() method.");
}
//

// Rectangle.cs
class Rectangle : IShape
{
    public void Draw() => Console.WriteLine("Inside Rectangle::draw() method.");
}
//

// Pentagon.cs
class Pentagon : IShape
{
    public void Draw() => Console.WriteLine("Inside Pentagon::draw() method.");
}
//

// ShapeFactory.cs
class ShapeFactory
{
    public IShape? PropertyShape(string shapeType)
    {
        if (shapeType == null)
            return null;

        if (shapeType.Equals("CIRCLE", StringComparison.OrdinalIgnoreCase))
            return new Circle();

        if (shapeType.Equals("RECTANGLE", StringComparison.OrdinalIgnoreCase))
            return new Rectangle();

        if (shapeType.Equals("SQUARE", StringComparison.OrdinalIgnoreCase))
            return new Square();

        if (shapeType.Equals("PENTAGON", StringComparison.OrdinalIgnoreCase))
            return new Pentagon();

        return null;
    }
}
//

// Program.cs
ShapeFactory shapeFactory = new();

IShape? shape1 = shapeFactory.PropertyShape("CIRCLE");
shape1?.Draw();

IShape? shape2 = shapeFactory.PropertyShape("RECTANGLE");
shape2?.Draw();

IShape? shape3 = shapeFactory.PropertyShape("SQUARE");
shape3?.Draw();

IShape? shape4 = shapeFactory.PropertyShape("PENTAGON");
shape4?.Draw();
//
