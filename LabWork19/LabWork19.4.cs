// Observer.cs
class Observer
{
    protected Subject _subject;
    public Observer(Subject subject)
    {
        _subject = subject;
        _subject.StateChanged += Update;
    }
    public virtual void Update(int state) { }
    
}
//

// Subject.cs
class Subject
{
    private int _state;
    public event Action<int>? StateChanged;

    public int GetState() => _state;

    public void SetState(int state)
    {
        _state = state;
        StateChanged?.Invoke(_state);
    }
}
//

// BinaryObserver.cs
class BinaryObserver : Observer
{
    public BinaryObserver(Subject subject) : base(subject) { }
    public override void Update(int state)
    {
        Console.WriteLine("Binary String: " + Convert.ToString(_subject.GetState(), 2));
    }
}
//

// OctalObserver.cs
class OctalObserver : Observer
{
    public OctalObserver(Subject subject) : base(subject) { }
    public override void Update(int state)
    {
        Console.WriteLine("Octal String: " + Convert.ToString(_subject.GetState(), 8));
    }
}
//

// DemicalObserver.cs
class DemicalObserver : Observer
{
    public DecimalObserver(Subject subject) : base(subject) { }
    public override void Update(int state) => Console.WriteLine("Demical String: " + Convert.ToString(_subject.GetState(), 10).ToUpper());
}
//

// HexaObserver.cs
class HexaObserver : Observer
{
    public HexaObserver(Subject subject) : base(subject) { }
    public override void Update(int state) => Console.WriteLine("Hex String: " + Convert.ToString(_subject.GetState(),16).ToUpper());
}
//

// Program.cs
Subject subject = new();

new HexaObserver(subject);
new OctalObserver(subject);
new BinaryObserver(subject);
new DemicalObserver(subject);

Console.WriteLine("First state change: 15");
subject.SetState(15);
Console.WriteLine();
Console.WriteLine("Second state change: 10");
subject.SetState(10);
//
