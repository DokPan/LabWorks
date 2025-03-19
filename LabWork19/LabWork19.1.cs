// Istrategy.cs
interface IStrategy
{
    public int DoOperation(int num1, int num2);
}
//

// Context.cs
class Context
{
    private IStrategy _strategy;

    public Context(IStrategy strategy) => _strategy = strategy;

    public int ExecuteStrategy(int num1, int num2) => _strategy.DoOperation(num1, num2);
}
//

// OperationAdd.cs
class OperationAdd : IStrategy
{
    public int DoOperation(int num1, int num2) => num1 + num2;
}
//

// OperationDivided.cs
class OperationDivided : IStrategy
{
    public int DoOperation(int num1, int num2) => num1 / num2;
}
//

// OperationMultiply.cs
class OperationMultiply : IStrategy
{
    public int DoOperation(int num1, int num2) => num1 * numr2;
}
//

// OperationSubstract.cs
class OperationSubstract : IStrategy
{
    public int DoOperation(int num1, int num2) => num1 - num2;
}
//

// Program.cs
Context context = new(new OperationAdd());
Console.WriteLine("10 + 5 = " + context.ExecuteStrategy(10, 5));

context = new(new OperationSubstract());
Console.WriteLine("10 - 5 = " + context.ExecuteStrategy(10, 5));

context = new(new OperationMultiply());
Console.WriteLine("10 * 5 = " + context.ExecuteStrategy(10, 5));

context = new(new OperationDivided());
Console.WriteLine("10 / 5 = " + context.ExecuteStrategy(10, 5));
//
