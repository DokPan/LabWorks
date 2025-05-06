public partial class ColorDialogWindow : Window
{
    public Color SelectedColor => Color.FromRgb(
        (byte)RedSlider.Value,
        (byte)GreenSlider.Value,
        (byte)BlueSlider.Value);

    public ColorDialogWindow()
    {
        InitializeComponent();
        RedSlider.ValueChanged += UpdateColor;
        GreenSlider.ValueChanged += UpdateColor;
        BlueSlider.ValueChanged += UpdateColor;
    }

    private void UpdateColor(object sender, RoutedPropertyChangedEventArgs<double> e)
    {
        ColorPreview.Fill = new SolidColorBrush(SelectedColor);
    }

    private void OkButton_Click(object sender, RoutedEventArgs e)
    {
        DialogResult = true;
    }

    private void CancelButton_Click(object sender, RoutedEventArgs e)
    {
        DialogResult = false;
    }

    private void Window_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.Key == Key.Escape)
        {
            DialogResult = false;
        }
        else if (e.Key == Key.Enter)
        {
            DialogResult = true;
        }
    }
}
