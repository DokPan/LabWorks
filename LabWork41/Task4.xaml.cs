public partial class Task4 : Window
{
    public Task4()
    {
        InitializeComponent();
        ApplyHoverStyle();
    }

    private void ApplyHoverStyle()
    {
        foreach (var child in ButtonPanel.Children)
        {
            if (child is Button button)
            {
                var style = new Style(typeof(Button));
                var trigger = new Trigger { Property = IsMouseOverProperty, Value = true };

                var colorAnim = new ColorAnimation
                {
                    To = Colors.LightBlue,
                    Duration = new Duration(TimeSpan.FromSeconds(30))
                };

                var originalColor = new SolidColorBrush(Colors.White);
                var hoverColor = new SolidColorBrush(Colors.LightBlue);
                button.Background = originalColor;

                style.Setters.Add(new Setter(Button.BackgroundProperty, originalColor));
                trigger.Setters.Add(new Setter(Button.BackgroundProperty, hoverColor));
                style.Triggers.Add(trigger);

                button.Style = style;
            }
        }
    }
}

# XAML
/*<StackPanel x:Name="ButtonPanel">
    <Button Content="Кнопка 1" Margin="10"/>
    <Button Content="Кнопка 2" Margin="10"/>
    <Button Content="Кнопка 3" Margin="10"/>
</StackPanel>*/
