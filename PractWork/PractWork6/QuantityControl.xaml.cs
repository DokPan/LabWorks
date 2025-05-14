public partial class QuantityControl : UserControl
{
    public static readonly DependencyProperty ValueProperty = DependencyProperty.Register("Value", typeof(int), 
        typeof(QuantityControl),
        new FrameworkPropertyMetadata(0, FrameworkPropertyMetadataOptions.BindsTwoWayByDefault, OnValueChanged));
    public int MaxValue { get; set; } = 5;
    private int _value = 0;

    public int Value
    {
        get => (int)GetValue(ValueProperty);
        set => SetValue(ValueProperty, value);
        
    }
    public int ValueText
    {
        get { return Value; }
    }

    public event RoutedEventHandler ValueChanged;
    public QuantityControl()
    {
        InitializeComponent();
        UpdateButtonState();
    }

    private void MinusButton_Click(object sender, RoutedEventArgs e)
    {
        if (Value > 0)
            Value--;
    }

    private void PlusButton_Click(object sender, RoutedEventArgs e)
    {
        if (Value < MaxValue)
            Value++;
    }
    private void UpdateButtonState()
    {
        PlusButton.IsEnabled = Value < MaxValue;
        MinusButton.IsEnabled = Value > 0;
    }

    private static void OnValueChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
    {
        var control = (QuantityControl)d;
        control.ValueTextBox.Text = control.Value.ToString();
        control.ValueChanged?.Invoke(control, new RoutedEventArgs());
        control.UpdateButtonState();
    }
}
/*
public int Value
{
    get => _value;
    set
    {
        _value = value;
        ValueTextBox.Text = _value.ToString();
        ValueChanged?.Invoke(this, new RoutedEventArgs());
        UpdateButtonState();
    }
}*/
