// IShape.cs
interface IShape
{
    void Draw();
}
//

// Circle.cs
class Circle : IShape
{
    public void Draw() => Console.WriteLine("Shape: Circle");
}
//

// Rectangle.cs
class Rectangle : IShape
{
    public void Draw() => Console.WriteLine("Shape: Rectangle");
}
//

// ShapeDecorator.cs
abstract class ShapeDecorator : IShape
{
    protected IShape _decoratedShape;

    public ShapeDecorator(IShape decoratedShape)
    {
        _decoratedShape = decoratedShape;
    }

    public void Draw() => _decoratedShape.Draw();
}
//

// RedShapeDecorator.cs
class RedShapeDecorator : ShapeDecorator
{

    public RedShapeDecorator(IShape decoratedShape) : base(decoratedShape) { }

    public void Draw()
    {
        _decoratedShape.Draw();
        SetRedBorder(_decoratedShape);
    }

    private void SetRedBorder(IShape decoratedShape) => Console.WriteLine("Border Color: Red");
}
//

// BlueShapeDecorator.cs
class BlueShapeDecorator : ShapeDecorator
{
    public BlueShapeDecorator(IShape decoratedShape) : base(decoratedShape) { }

    public void Draw()
    {
        _decoratedShape.Draw();
        SetBlueBorder(_decoratedShape);
    }

    private void SetBlueBorder(IShape decoratedShape) => Console.WriteLine("Border Color: Blue");
}
//

// Program.cs
Circle circle = new Circle();
RedShapeDecorator redCircle = new(new Circle());
RedShapeDecorator redRectangle = new(new Rectangle());
BlueShapeDecorator blueCircle = new(new Circle());
BlueShapeDecorator blueRectangle = new(new Rectangle());

Console.WriteLine("Circle with normal border");
circle.Draw();

Console.WriteLine("Circle of red border");
redCircle.Draw();

Console.WriteLine("Rectangle of red border");
redRectangle.Draw();

Console.WriteLine("Circle of blue border");
blueCircle.Draw();

Console.WriteLine();
Console.WriteLine("Rectangle of blue border");
blueRectangle.Draw();
//
