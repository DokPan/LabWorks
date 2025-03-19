// Observer.cs
abstract class Observer
{
    protected Subject? _subject;
    public abstract void Update();
}
//

// Subject.cs
class Subject
{
    private List<Observer> observers = new();
    private int _state;

    public int GetState() => _state;

    public void SetState(int state)
    {
        _state = state;
        NotifyAllObservers();
    }

    public void Attach(Observer observer) => observers.Add(observer);

    public void NotifyAllObservers()
    {
        foreach (Observer observer in observers)
        {
            observer.Update();
        }
    }
}
//

// BinaryObserver.cs
class BinaryObserver : Observer
{
    public BinaryObserver(Subject subject)
    {
        _subject = subject;
        _subject.Attach(this);
    }
    public override void Update()
    {
        Console.WriteLine("Binary String: " + Convert.ToString(_subject.GetState(), 2));
    }
}
//

// OctalObserver.cs
class OctalObserver : Observer
{
    public OctalObserver(Subject subject)
    {
        _subject = subject;
        _subject.Attach(this);
    }
    public override void Update()
    {
        Console.WriteLine("Octal String: " + Convert.ToString(_subject.GetState(), 8));
    }
}
//

// DemicalObserver.cs
class DemicalObserver : Observer
{
    public DemicalObserver(Subject subject)
    {
        _subject = subject;
        _subject.Attach(this);
    }
    public override void Update() => Console.WriteLine("Demical String: " + Convert.ToString(_subject.GetState(), 10).ToUpper());
}
//

// HexaObserver.cs
class HexaObserver : Observer
{
    public HexaObserver(Subject subject)
    {
        _subject = subject;
        _subject.Attach(this);
    }
    public override void Update() => Console.WriteLine("Hex String: " + Convert.ToString(_subject.GetState(),16).ToUpper());
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
